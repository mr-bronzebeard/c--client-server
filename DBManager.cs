using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace server
{
    class DBManager
    {
        private static DBManager mInst;

        string fileName = "DataBase.xml";

        public Dictionary<uint, Houseroom> Houserooms;
        public Dictionary<uint, User> Users;
        
        uint NextHouseroomId = 0;
        uint NextUserId;
        
        private DBManager()
        {
            Houserooms = new Dictionary<uint, Houseroom>();
            
            NextHouseroomId = 0;
        }

        ~DBManager()
        {

        }

        public static void Init()
        {
            mInst = new DBManager();
        }

        public static DBManager Inst()
        {
            if (mInst == null)
                mInst = new DBManager();

            return mInst;
        }

        public bool OpenFile()
        {
            Houserooms.Clear();

            XmlDocument document = new XmlDocument();

            try
            {
                document.Load(fileName);

                XmlNodeList UsersNodes = document.SelectNodes("/DataBase/Users/User");

                //foreach (XmlNode UserNode in UsersNodes)
                //{
                //    //читаем атрибуты
                //    uint id = uint.Parse(UserNode.SelectSingleNode("ID").InnerText);
                //    string login = UserNode.SelectSingleNode("LOGIN").InnerText;
                //    string passHash = UserNode.SelectSingleNode("PASS_HASH").InnerText;

                //    User item = new User(id, login, passHash);
                //    Users.Add(item.Id, item);

                //    if (item.Id > NextUserId)
                //        NextUserId = item.Id++;
                //}
                //NextUserId++;

                XmlNodeList HouseroomsNodes = document.SelectNodes("/DataBase/Houserooms/Houseroom");

                foreach(XmlNode HouseroomNode in HouseroomsNodes)
                {
                    //считываем атрибуты
                    uint id = uint.Parse(HouseroomNode.SelectSingleNode("ID").InnerText);
                    string city = HouseroomNode.SelectSingleNode("CITY").InnerText;
                    string street = HouseroomNode.SelectSingleNode("STREET").InnerText;
                    decimal price = decimal.Parse(HouseroomNode.SelectSingleNode("PRICE").InnerText);
                    string description = HouseroomNode.SelectSingleNode("DESCRIPTION").InnerText;
                    //uint numberOfRooms = uint.Parse(HouseroomNode.SelectSingleNode("NUMBER_OF_ROOMS").InnerText);

                    Houseroom item = new Houseroom(id, city,street,price,description);
                    Houserooms.Add(item.Id, item);

                    if (item.Id > NextHouseroomId)
                        NextHouseroomId = item.Id;
                }
                NextHouseroomId++;
            }
            catch
            {
                //не открылся файл
                return false;
            }

            return true;
        }

        public bool SaveFile()
        {
            XmlDocument document = new XmlDocument();

            XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "UTF-8", "yes");

            XmlElement root = document.CreateElement("DataBase");
            document.AppendChild(root);
            document.InsertBefore(xmlDeclaration, root);

            //XmlElement UsersNodes = document.CreateElement("Users");

            //root.AppendChild(UsersNodes);

            //foreach (var item in Users)
            //{
            //    XmlElement UserNode = document.CreateElement("User");

            //    XmlElement XML_ID = document.CreateElement("ID");
            //    XML_ID.InnerText = item.Value.Id.ToString();
            //    UserNode.AppendChild(XML_ID);

            //    XmlElement XML_Login = document.CreateElement("LOGIN");
            //    XML_Login.InnerText = item.Value.Login;
            //    UserNode.AppendChild(XML_Login);

            //    XmlElement XML_Password = document.CreateElement("PASS_HASH");
            //    XML_Password.InnerText = item.Value.Password;
            //    UserNode.AppendChild(XML_Password);

            //    UsersNodes.AppendChild(UserNode);
            //}

            XmlElement HouseroomsNodes = document.CreateElement("Houserooms");

            root.AppendChild(HouseroomsNodes);

            foreach(var item in Houserooms)
            {
                XmlElement HouseroomNode = document.CreateElement("Houseroom");

                XmlElement XML_ID = document.CreateElement("ID");
                XML_ID.InnerText = item.Value.Id.ToString();
                HouseroomNode.AppendChild(XML_ID);

                XmlElement XML_CITY = document.CreateElement("CITY");
                XML_CITY.InnerText = item.Value.City;
                HouseroomNode.AppendChild(XML_CITY);

                XmlElement XML_STREET = document.CreateElement("STREET");
                XML_STREET.InnerText = item.Value.Street;
                HouseroomNode.AppendChild(XML_STREET);

                XmlElement XML_PRICE = document.CreateElement("PRICE");
                XML_PRICE.InnerText = item.Value.Price.ToString();
                HouseroomNode.AppendChild(XML_PRICE);

                XmlElement XML_DESCRIPTION = document.CreateElement("DESCRIPTION");
                XML_DESCRIPTION.InnerText = item.Value.Description.ToString();
                HouseroomNode.AppendChild(XML_DESCRIPTION);

                //XmlElement XML_NumberOfRooms = document.CreateElement("NUMBER_OF_ROOMS");
                //XML_NumberOfRooms.InnerText = item.Value.NumberOfRooms.ToString();
                //HouseroomNode.AppendChild(XML_NumberOfRooms);

                HouseroomsNodes.AppendChild(HouseroomNode);
            }

            document.Save(fileName);

            return true;
        }

        public uint AddUser(User user)
        {
            user.Id = NextUserId;
            Users.Add(NextUserId, user);
            return NextUserId++;
        }

        public uint AddHouseroom(Houseroom houseroom)
        {
            houseroom.Id = NextHouseroomId;
            Houserooms.Add(NextHouseroomId, houseroom);

            return NextHouseroomId++;
        }

        public bool FindUser(string login)
        {
            foreach (var it in Users)
                if (it.Value.Login == login) return true;
            return false;
        }

        public int FindUser(string login, string password)
        {
            foreach (var it in Users)
                if (it.Value.Login == login && it.Value.Password == password)
                    return (int)it.Key;
            return -1;
        }

        public int[] FindHouseroom(string city, string street, decimal price)
        {
            int count = 0;
            foreach (var it in Houserooms)
                if (it.Value.City == city && it.Value.Street == street && it.Value.Price == price) count++;

            int[] ids = new int[count];

            int next = 0;

            foreach (var it in Houserooms)
                if (it.Value.City == city && it.Value.Street == street && it.Value.Price == price) ids[next++] = (int)it.Key;

            return ids;
        }
    }
}
