﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;
using _4team_project;
namespace Timer_TCPServer
{
    class TCPServer
    {

        public const string STATE_SUCCESS = "SUCCESS";
        public const string STATE_FAIL = "FAIL";
        public const string STATE_SUCCESS_INSERT = "SUCCESS_INSERT";
        public const string STATE_FAIL_INSERT = "FAIL_INSERT";
        public const string STATE_EMPTY = "EMPTY";
        public const string STATE_FAIL_PASSWORD = "FAIL_PASSWORD";
        public const string STATE_NOEXIT_ID = "NOEXIST_ID";
        public const string STATE_CLIENT_ON = "on";
        public const string STATE_CLIENT_OFF = "OFF";



        #region serverConnect
        private Socket server;               //서버 연결용 TCP클라이언트 

        private NetworkStream stream;    // 네트워크 스트림 
        private StreamReader read;       // 데이터 읽어오기
        private StreamWriter write;      // 데이터 보내기
        private Thread Reader;          // 읽기 쓰레드
        private Thread Accepter;          // 읽기 쓰레드
        // TCP 서버 구동 리스너 선언
        private TcpListener listener = null;

        public const char PACKET_SEPARATOR = ',';
        public const char TYPE_ASSIGNMENT = '=';
        public const char VALUE_ASSIGNMENT = ':';

        public const int PortNumber = 3342;        //서버 포트 번호

        private string ipAddress;     //서버쪽 ip주소

        public string IpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        private bool IsConnect = false;  // 서버 접속 플래그

        private main testerForm = null;

        public TCPServer()
        {

        }

        public TCPServer(main obj)
        {
            testerForm = obj;
        }


        public static string ClientIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string clientIP = string.Empty;
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    clientIP = host.AddressList[i].ToString();
                }
            }
            return clientIP;
        }




        /// <summary>
        /// 입력받은 ip(서버)로 연결
        /// </summary>
        /// <param name="ip">ip주소</param>
        ///<param name="portNum">port번호</param>
        public bool Connent(string ip, int portNum)
        {
            
            ipAddress = ip;
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint E_IP = new IPEndPoint(IPAddress.Parse(ipAddress), portNum);

            try
            {
                server.Connect(E_IP);  // 연결 시도

            }
            catch    // 연결이 실패하면
            {
               // return false;
            }

            IsConnect = true;  // 메인 서버에 접속 됨!
            
            stream = new NetworkStream(server);    // 서버와 입출력 스트림 연결

            read = new StreamReader(stream);  // 읽어오기 스트림..
            write = new StreamWriter(stream); // 출력하기 스트림..
            
            Reader = new Thread(new ThreadStart(Receive)); //  클라이언트 쓰레드 시작
            Reader.IsBackground = true;
            Reader.Start();
            return true;
        }

        /// <summary>
        ///  서버 시작
        /// </summary>
        public void Start()
        {
            // Accep 메서드 쓰레드 처리
            Accepter = new Thread(new ThreadStart(Accept));
            Accepter.IsBackground = true;  // Background 스레드 처리
            // 쓰레드 시작
            Accepter.Start();
        }

   


        /// <summary>
        ///  메인 서버 연결 끊기
        /// </summary>
        public void Disconnect()
        {
            try
            {
                read.Close();      // 읽기 해제
                write.Close();	   // 쓰기 해제			 					
                stream.Close();    // 스트림 해제
                listener.Stop();
                Reader.Abort();    // 쓰레드 종료
                Accepter.Abort();
                server.Close();    // 서버 연결 종료
            }
            catch
            {

            }
        }
        /// <summary>
        /// 클라이언트 요청을 기다림
        /// </summary>
        public void Accept()
        {

            try
            {  // TCP리스너 처리는 예외처리가 필요함

                // TCP 리스너 생성
                listener = new TcpListener(IPAddress.Any, PortNumber);
                // TCP 리스너 작동 시작
                listener.Start();

            }
            catch
            { // 예외 발생할 경우 Accept 메서드 반환
                return;
            }

            // 데몬상태 시작( 클라이언트 접속을 기다림 )
            while (true)
            {
                Socket socket = null;
                try
                {
                    // 클라이언트  접속 대기중
                    socket = listener.AcceptSocket();
                }
                catch 
                {
                   
                }
                if (socket != null && socket.Connected)
                { // 클라이언트가 접속하면...
                    stream = new NetworkStream(socket);    // 클라이언트와 입출력 스트림 연결

                    read = new StreamReader(stream);  // 읽어오기 스트림..
                    write = new StreamWriter(stream); // 출력하기 스트림..

                    Reader = new Thread(new ThreadStart(Receive)); //  클라이언트 쓰레드 시작
                    Reader.IsBackground = true;
                    Reader.Start();

                    IsConnect = true;
                }
            }
        }



        /// <summary>
        /// 서버에서 오는 메세지 처리
        /// </summary>
        public void Receive()
        {
            try
            {
                while (IsConnect)
                {
                    // 서버와 접속되면 while 시작
                    // 서버에서 수신한 메시지를 줄단위로 읽어옴
                    string message = read.ReadLine().Trim();

                    // 읽어온 메시지가 있다면
                    if (message != null)
                    {

                        if (testerForm != null) {
                            testerForm.Sendmessage(message);
                        }
                        
                    }
                }
            }
            catch//(Exception e) // 메인서버와 통신에서 예외 발생할 경우
            {

            }
            finally
            {
                Disconnect();  // 서버 연결 종료...				
            }
        }

        /// <summary>
        /// 서버에 메세지 전달
        /// </summary>
        /// <param name="messageStr">보낼 메세지 스트링</param>
        public void Send(string messageStr)
        {
            try
            {
                write.WriteLine(messageStr);  // 서버에 데이터 전송
                write.Flush();
            }
            catch
            {

            }

        }
        #endregion
    }
}
