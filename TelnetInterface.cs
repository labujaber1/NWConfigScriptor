// minimalistic telnet implementation
// conceived by Tom Janssens on 2007/06/06  for codeproject
// ammended by jonsagara to include IDisposable
// h ttp://www.corebvba.be
// used by SID2018481
// Greatly appreciated for use in this project
//##########################################//
//                                          //
// Project: Network Config Scriptor Creater //
// Author:  L. Abu-Jaber                    //
// Date:    09/05/2022                      //
// Control System: Github                   //
//                                          //
//##########################################//
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace NWConfigScriptor
{
    
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

        public string Login(string username, string password, int loginTimeOutMs)
        {
            int oldTimeOutMs = TimeOutMs;
            TimeOutMs = loginTimeOutMs;
            string s = Read();
            if (!s.TrimEnd().EndsWith(":"))
            {
                throw new Exception("Failed to connect : no login prompt");
            }
            WriteLine(username);
            s += Read();

            if (!s.TrimEnd().EndsWith(":"))
            {
                throw new Exception("Failed to connect : no password prompt");
            }
            WriteLine(password);
            s += Read();

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
            //byte[] buf = Encoding.UTF8.GetBytes(cmd);
            byte[] buf = Encoding.ASCII.GetBytes(cmd.Replace("\0xFF", "\0xFF\0xFF"));
            tcpSocket.GetStream().Write(buf, 0, buf.Length);
        }

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
                                // reply to all commands with "WONT", unless it is SGA (suppres go ahead)
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
