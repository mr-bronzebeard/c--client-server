using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public class Client
    {
        IPAddress ipAddr;
        IPEndPoint ipEndPoint;
        Socket sock;

        byte[] recvBytes = new byte[1024];
        bool isConnected;

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

        public Client()
        {
            isConnected = false;

            ipAddr = IPAddress.Parse("127.0.0.1");
            ipEndPoint = new IPEndPoint(ipAddr, 28);
        }

        public bool Connect()
        {
            ipAddr = IPAddress.Parse("127.0.0.1");
            ipEndPoint = new IPEndPoint(ipAddr, 28);

            return connecthandle();
        }

        private bool connecthandle()
        {
            if (isConnected)
                return true;

            sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sock.Connect(ipEndPoint);
            }
            catch
            {
                return false;
            }

            isConnected = true;
            return true;
        }

        public void Disconnect()
        {
            if(isConnected)
            {
                sock.Shutdown(SocketShutdown.Both);
                sock.Close();
                isConnected = false;
            }
        }

        //отправляем команду и получаем ответ
        public int recvDigit32()
        {
            if (isConnected)
            {
                byte[] bytes = new byte[4];
                int bytesRecv = sock.Receive(bytes);
                return (int)BitConverter.ToInt32(bytes, 0);
            }
            return 0;
        }

        public int recvDigit16()
        {
            if (isConnected)
            {
                byte[] bytes = new byte[2];
                int bytesRecv = sock.Receive(bytes);
                return (int)BitConverter.ToInt16(bytes, 0);
            }
            return 0;
        }

        public void sendDigit32(int value)
        {
            sock.Send(BitConverter.GetBytes((Int32)value));
        }

        public void sendDigit16(short value)
        {
            sock.Send(BitConverter.GetBytes((Int16)value));
        }

        //отправляем команду и получаем ответ
        public string recvString()
        {
            if (isConnected)
            {
                int lenght = recvDigit32();
                byte[] bytes = new byte[lenght];
                int bytesSent = sock.Receive(bytes);
                return Encoding.UTF8.GetString(bytes, 0, lenght);
            }
            return "";
        }

        public void SendString(string str)
        {
            if (isConnected)
            {
                sock.Send(BitConverter.GetBytes((Int32)str.Length));
                sock.Send(Encoding.UTF8.GetBytes(str));
            }
        }

        public int getHouseroom(string city, string street, string price, ref string[][] fields)
        {
            sendDigit16((short)Commands.LIST_HOUSEROOM);

            int answer = recvDigit16();

            switch(answer)
            {
                case (int)Answers.USER_NOT_LOGIN:
                    {
                        break;
                    }

                case (int)Answers.COMMAND_OK:
                    {
                        SendString(city);
                        SendString(street);
                        SendString(Convert.ToString(price));

                        answer = recvDigit16();

                        switch (answer)
                        {
                            case (int)Answers.USER_NOT_LOGIN:
                                {
                                    break;
                                }
                            case (int)Answers.COMMAND_OK:
                                {
                                    int countRows = recvDigit32();

                                    fields = new string[countRows][];

                                    for (int i = 0; i < countRows; i++)
                                    {
                                        fields[i] = new string[3];
                                        fields[i][0] = recvDigit32().ToString();
                                    }

                                    for (int i = 0; i < countRows; i++)
                                    {
                                        sendDigit16((short)Commands.SELECT_HOUSEROOM);

                                        sendDigit16(short.Parse(fields[i][0]));

                                        answer = recvDigit16();

                                        switch (answer)
                                        {
                                            case (int)Answers.USER_NOT_LOGIN:
                                                {
                                                    break;
                                                }

                                            case (int)Answers.COMMAND_OK:
                                                {
                                                    fields[i][1] = recvString();
                                                    fields[i][2] = recvString();

                                                    break;
                                                }
                                        }
                                    }

                                    break;
                                }
                        }
                        
                        break;
                    }
            }

            return answer;
        }

        public int addHouseroom(string City, string Street, string Price, string Description)
        {
            sendDigit16((short)Commands.ADD_HOUSEROOM);

            SendString(City);
            SendString(Street);
            SendString(Price);
            SendString(Description);

            int answer = recvDigit16();

            return answer;
        }

    }
}
