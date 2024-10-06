//using System;
//using System.IO;
//using System.Net;
//using System.Net.NetworkInformation;
//using System.Net.Sockets;
//using System.Text;
//using System.Text.Json;
//using System.Threading;

//namespace project_Game_Caro
//{
//    class SocketManager
//    {
//        #region Client
//        Socket client;
//        public bool ConnectServer()
//        {
//            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
//            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            try
//            {
//                client.Connect(iep);
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        #endregion

//        #region Server
//        Socket server;

//        public bool isServer { get; set; }
//        public void CreateServer()
//        {
//            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
//            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            server.Bind(iep);
//            server.Listen(10);

//            Thread AcceptClient = new Thread(() => { try { client = server.Accept(); } catch { } });
//            AcceptClient.IsBackground = true;
//            AcceptClient.Start();
//        }
//        #endregion

//        #region Both
//        public string IP = "127.0.0.1";
//        public int Port = 9999;
//        public bool IsServer = true;
//        public const int BUFFER = 1024;

//        private bool SendData(Socket target, byte[] data)
//        {
//            return target.Send(data) == 1;
//        }

//        private bool ReceiveData(Socket target, byte[] data)
//        {
            
//            return target.Receive(data) == 1;
//        }


//        public bool Send(object data)
//        {
//            byte[] sendedData = SerializeData(data);
//            return SendData(client, sendedData);
//        }

//        public object Receive()
//        {
//            byte[] receivedData = new byte[BUFFER];
//            bool IsOk = ReceiveData(client, receivedData);
//            return DeserializeData(receivedData);
//        }

//        public byte[] SerializeData(Object o)
//        {
//            string jsonData = JsonSerializer.Serialize(o);
//            return Encoding.UTF8.GetBytes(jsonData);
//        }

//        public object DeserializeData(byte[] theByteArray)
//        {
//            string jsonData = Encoding.UTF8.GetString(theByteArray);
//            return JsonSerializer.Deserialize<object>(jsonData);
//        }

//        public string GetLocalIPv4(NetworkInterfaceType _type)
//        {
//            string output = "";
//            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
//            {
//                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
//                {
//                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
//                    {
//                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
//                        {
//                            output = ip.Address.ToString();
//                        }
//                    }
//                }
//            }
//            return output;
//        }

//        public void CloseConnect()
//        {
//            try
//            {
//                server.Close();
//                client.Close();
//            }
//            catch { }
//        }
//        #endregion
//    }
//}
