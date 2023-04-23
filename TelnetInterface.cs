// minimalistic telnet implementation
// conceived by Tom Janssens on 2007/06/06  h ttps://github.com/rafinhaa/MinimalisticTelnett
// ammended by jonsagara to include IDisposable h ttps://github.com/jonsagara/MinimalisticTelnet/blob/master/src/MinimalisticTelnet/TelnetInterface.cs
// 
// used by SID2018481 and greatly appreciated for use in this project.
//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  2018481                         //
// Date:    24/04/2023                      //
// Control version: Github                  //
//                                          //
//##########################################//
using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;


namespace NWConfigScriptor
{

    // h ttps://www.codeproject.com/articles/19071/quick-tool-a-minimalistic-telnet-library
    public class TelnetConnection : IDisposable
    {
        private TcpClient tcpSocket;

        private int TimeOutMs = 100;

        public bool IsConnected
        {
            get { return tcpSocket.Connected; }
        }

        public TelnetConnection(string hostname, int port)
        {
            tcpSocket = new TcpClient(hostname, port);
        }
        ~TelnetConnection()
        {
            Dispose(false);
        }

        public string Login(string username, string password, int loginTimeOutMs, string secretPassword)
        {
            int oldTimeOutMs = TimeOutMs;
            TimeOutMs = loginTimeOutMs;
            string s = Read();
            Console.WriteLine(s); //########
           if (s.TrimEnd().EndsWith("Username:"))
            {
                WriteLine(username);
                s += Read();
                Debug.WriteLine(s); //########
            }
            if(s.TrimEnd().EndsWith("Password:"))
            {
                WriteLine(password);
                s += Read();
                Debug.WriteLine(s); //#########
            }
            if(s.TrimEnd().EndsWith(">"))
            {
                WriteLine("enable");
                s += Read();
                Debug.WriteLine(s);
                if (s.TrimEnd().EndsWith("Password:") && !s.TrimEnd().EndsWith(" set"))
                {
                    WriteLine(secretPassword);
                    s += Read();
                    Debug.WriteLine(s);
                }
                
            }
            else
            {
                throw new Exception("Failed to connect : " +
                    "no password/username prompt. Check these have been configured on the device.");
            }
            TimeOutMs = oldTimeOutMs;
            return s;
        }

        public void WriteLine(string cmd)
        {
            Write(cmd + "\n");
        }

        public void Write(string cmd)
        {
            if (!tcpSocket.Connected)
            {
                return;
            }
           byte[] buf = Encoding.ASCII.GetBytes(cmd.Replace("\0xFF", "\0xFF\0xFF"));
            tcpSocket.GetStream().Write(buf, 0, buf.Length);
        }

        // prepare CLI output as string 
        public string Read()
        {
            if (!tcpSocket.Connected)
            {
                return "no connected socket";
            }
            var sb = new StringBuilder();
            do
            {
                ParseTelnet(sb);
                Thread.Sleep(TimeOutMs);
            } while (tcpSocket.Available > 0);
            return sb.ToString();
        }
       
        /// <summary>
        /// CLI retreival: getting each byte from socket stream, translating to char and 
        /// append to string of chars. 
        /// Specifically checks if data contains telnet command sequences and handles echo
        /// to enable CLI retreival for the user to view. 
        /// IAC indicates stream should be handled as telnet command rather than just text.
        /// SGA suppress go ahead to client and reduce traffic which improves response time.
        /// </summary>
        /// <param name="sb"></param>
        
        private void ParseTelnet(StringBuilder sb)
        {
            while (tcpSocket.Available > 0)
            {
                int input = tcpSocket.GetStream().ReadByte();
                switch (input)
                {
                    case -1:
                        break;
                    case (int)Verbs.Iac:
                        // interpret as command
                        int inputverb = tcpSocket.GetStream().ReadByte();
                        if (inputverb == -1)
                        {
                            break;
                        }
                        switch (inputverb)
                        {
                            case (int)Verbs.Iac:
                                //literal IAC = 255 escaped, so append char 255 to string
                                sb.Append(inputverb);
                                break;
                            case (int)Verbs.Do:
                            case (int)Verbs.Dont:
                            case (int)Verbs.Will:
                            case (int)Verbs.Wont:
                                // reply to all commands with "WONT", unless it is SGA (suppress go ahead)
                                int inputoption = tcpSocket.GetStream().ReadByte();
                                if (inputoption == -1)
                                {
                                    break;
                                }
                                tcpSocket.GetStream().WriteByte((byte)Verbs.Iac);
                                if (inputoption == (int)Options.Sga)
                                {
                                    tcpSocket.GetStream().WriteByte(inputverb == (int)Verbs.Do ? (byte)Verbs.Will : (byte)Verbs.Do);
                                }
                                else
                                {
                                    tcpSocket.GetStream().WriteByte(inputverb == (int)Verbs.Do ? (byte)Verbs.Wont : (byte)Verbs.Dont);
                                }
                                tcpSocket.GetStream().WriteByte((byte)inputoption);
                                break;
                        }
                        break;
                    default:
                        sb.Append((char)input);
                        break;
                }
            }
        }

        // IDisposable included by:
        // h ttps://github.com/jonsagara/MinimalisticTelnet/blob/master/src/MinimalisticTelnet/TelnetInterface.cs
        public void Dispose()
        {
            Debug.WriteLine("Disposing connection");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (tcpSocket != null)
                {
                    ((IDisposable)tcpSocket).Dispose();
                    tcpSocket = null;
                }
            }
        }

        #region Private Enums

        enum Verbs
        {
            Will = 251,
            Wont = 252,
            Do = 253,
            Dont = 254,
            Iac = 255
        }

        enum Options
        {
            Sga = 3
        }

        #endregion

    }
}
