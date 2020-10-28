using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server
{
    /// <summary>
    /// Реализует создание соединений с клиентом обработку команд
    /// </summary>
    class Server
    {
        IPEndPoint ServerEndPoint;
        Thread ListenThread;

        int serverPort;
        int sizeOfPacket = 1024;

        public object DBEntites { get; private set; }

        enum Commands
        {
            ADD_USER,           // Добавление нового пользователя
            LOGIN_USER,         // Авторизация пользователя
            ADD_HOUSEROOM,      // Добавление жилья
            LIST_HOUSEROOM,     // Просмотр жилья по критерям
            SELECT_HOUSEROOM,   // Просмотр данных для конкретного жилья
        };

        enum Answers
        {
            USER_NAME_ALREADY_USED, // Имя пользовател уже используется
            USER_NAME_OK, // Имя пользователя подходит
            REGISTRATION_OK, // Регистрация завершена
            USER_NOT_EXIST,
            USER_LOGIN_OK,
            USER_LOGIN_BREAK,
            USER_NOT_LOGIN,
            COMMAND_OK,
        }

        public Server (int Port)
        {
            serverPort = Port;

            ListenThread = new Thread(new ThreadStart(ListenForClients));
            ListenThread.Start();
        }

        public void ListenForClients()
        {
            ServerEndPoint = new IPEndPoint(IPAddress.Any, serverPort);

            Socket ListenSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            ListenSocket.Bind(ServerEndPoint);
            ListenSocket.Listen(10);

            Console.WriteLine("Сервер - аренда жилья (многопоточный)");
            Console.WriteLine("Ожидаем подключения клиента...");

            while (true)
            {
                //блокируется пока клиент не запросит соединение с сервером
                Socket client = ListenSocket.Accept();
                Thread clientThread = new Thread(new ParameterizedThreadStart(ClientHandle));
                clientThread.Start(client);
            }
        }

        public string recvString(Socket sock)
        {
            int lenght = recvDigit32(sock);
            byte[] bytes = new byte[lenght];
            int bytesSent = sock.Receive(bytes);
            return Encoding.UTF8.GetString(bytes, 0, lenght);
        }

        public void sendString(string str, Socket sock)
        {
            sock.Send(BitConverter.GetBytes(str.Length));
            sock.Send(Encoding.UTF8.GetBytes(str));
        }

        public int recvDigit32(Socket sock)
        {
            byte[] bytes_ = new byte[4];
            int bytesSent = sock.Receive(bytes_);
            return (int)BitConverter.ToInt32(bytes_, 0);
        }

        public int recvDigit16(Socket sock)
        {
            byte[] bytes_ = new byte[2];
            int bytesSent = sock.Receive(bytes_);
            return (int)BitConverter.ToInt16(bytes_, 0);
        }

        public void sendDigit32(int value, Socket sock)
        {
            sock.Send(BitConverter.GetBytes((Int32)value));
        }

        public void sendDigit16(short value, Socket sock)
        {
            sock.Send(BitConverter.GetBytes((Int16)value));
        }

        private void ClientHandle(object client)
        {
            byte[] bytes = new byte[sizeOfPacket];
            int bytesRead;

            int cUserId = -1;

            Socket Client = (Socket)client;
            IPEndPoint ClientEndPoint = (IPEndPoint)Client.RemoteEndPoint;

            Console.WriteLine("Открыли соединение с {0} на порту {1}",
                ClientEndPoint.Address, ClientEndPoint.Port);

            while(true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = Client.Receive(bytes);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    //Клиент был отсоединен от сервера
                    Console.WriteLine("Закрыли соединение с {0}", ClientEndPoint.Address);
                    break;
                }

                if(bytesRead == 2)
                {
                    short Command = BitConverter.ToInt16(bytes, 0);

                    DBManager.Inst().SaveFile();

                    switch (Command)
                    {
                        case (int)Commands.ADD_USER:
                            {
                                Console.WriteLine("\tКом. 1 - Добавление нового пользователя");

                                string Login = recvString(Client);
                                string Password = recvString(Client);

                                bool isUsed = DBManager.Inst().FindUser(Login);

                                if (isUsed)
                                    sendDigit16((short)Answers.USER_NAME_ALREADY_USED, Client);
                                else
                                {
                                    sendDigit16((short)Answers.USER_NAME_OK, Client);

                                    User user = new User(0, Login, Password);
                                    DBManager.Inst().AddUser(user);
                                }

                                break;
                            }

                        case (int)Commands.LOGIN_USER:
                            {
                                Console.WriteLine("\tКом. 2 - Авторизация пользователя");

                                string Login = recvString(Client);
                                string Password = recvString(Client);

                                bool isExist = DBManager.Inst().FindUser(Login);

                                if (!isExist)
                                    sendDigit16((short)Answers.USER_NOT_EXIST, Client);
                                else
                                {
                                    cUserId = -1;

                                    int id = DBManager.Inst().FindUser(Login, Password);
                                    if (id >= 0)
                                    {
                                        sendDigit16((short)Answers.USER_LOGIN_OK, Client);
                                        cUserId = id;
                                    }
                                    else
                                        sendDigit16((short)Answers.USER_LOGIN_BREAK, Client);
                                }

                                break;
                            }

                        case (int)Commands.ADD_HOUSEROOM:
                            {
                                Console.WriteLine("\tКом. 3 - Добавление жилплощади");

                                string City = recvString(Client);
                                string Street = recvString(Client);
                                decimal Price = Convert.ToDecimal(recvString(Client));
                                string Description = recvString(Client);

                                sendDigit16((short)Answers.COMMAND_OK, Client);

                                Houseroom houseroom = new Houseroom(0, City, Street, Price, Description);
                                DBManager.Inst().AddHouseroom(houseroom);

                                break;
                            }

                        case (int)Commands.LIST_HOUSEROOM:
                            {
                                Console.WriteLine("\tКом. 4 - Вывести список жилья");

                                sendDigit16((short)Answers.COMMAND_OK, Client);

                                //Console.WriteLine("отправил ОК");

                                string City = recvString(Client);
                                //Console.WriteLine(City);
                                string Street = recvString(Client);
                                //Console.WriteLine(Street);
                                decimal Price = Convert.ToDecimal(recvString(Client));
                                //Console.WriteLine("Принял цену");

                                int[] Rows = DBManager.Inst().FindHouseroom(City, Street, Price);

                                if (Rows.Count() == 0)
                                    sendDigit16((short)Answers.USER_NOT_LOGIN, Client);
                                else
                                {
                                    sendDigit16((short)Answers.COMMAND_OK, Client);
                                    sendDigit32(Rows.Length, Client);
                                    //Console.WriteLine("Отправил rows");

                                    for (int i = 0; i < Rows.Length; i++)
                                        sendDigit32(Rows[i], Client);
                                }

                                break;
                            }

                        case (int)Commands.SELECT_HOUSEROOM:
                            {
                                Console.WriteLine("\tКом. 5 - Получить данные для жилья");

                                sendDigit16((short)Answers.COMMAND_OK, Client);

                                int houseId = recvDigit16(Client);
                                
                                sendString(DBManager.Inst().Houserooms[(uint)houseId].Description, Client);
                                sendString(Convert.ToString(DBManager.Inst().Houserooms[(uint)houseId].Price), Client);

                                break;
                            }
                    }

                }
            }
        }
    }
}
