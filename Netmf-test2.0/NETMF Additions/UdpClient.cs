using System;
using Microsoft.SPOT;

namespace System.Net.Sockets
{
    /// <summary>
    /// hand rolled UdpClient class.
    /// </summary>
    public class UdpClient : IDisposable
    {
        /// <summary>
        /// Create a UDP client not on any particular port
        /// </summary>
        public UdpClient()
        {
            
        }

        //public UdpClient(AddressFamily family);

        /// <summary>
        /// Create a UDP Client
        /// </summary>
        /// <param name="port">Port to create the client upon</param>
        public UdpClient(int port)
        {
            
        }

        //public UdpClient(int port, AddressFamily family);
        //public UdpClient(IPEndPoint localEP);
        //public UdpClient(string hostname, int port);
        //public Socket Client { get; set; }
        //protected bool Active { get; set; }
        //public int Available { get; }
        //public short Ttl { get; set; }
        //public bool DontFragment { get; set; }
        //public bool MulticastLoopback { get; set; }
        //public bool EnableBroadcast { get; set; }
        //public bool ExclusiveAddressUse { get; set; }

        #region IDisposable Members

        /// <summary>
        /// \todo Should probably flush and close on Disposal
        /// </summary>
        void IDisposable.Dispose()
        {
            
        }

        #endregion

        //public void Close();
        //protected virtual void Dispose(bool disposing);
        //public void Connect(string hostname, int port);
        //public void Connect(IPAddress addr, int port);
        //public void Connect(IPEndPoint endPoint);
        public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
        {
            return 0;
        }
        //public int Send(byte[] dgram, int bytes, string hostname, int port);
        //public int Send(byte[] dgram, int bytes);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, AsyncCallback requestCallback, object state);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state);

        //public int EndSend(IAsyncResult asyncResult);
        //public byte[] Receive(ref IPEndPoint remoteEP);

        //[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        //public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state);

        //public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP);
        //public void JoinMulticastGroup(IPAddress multicastAddr);
        //public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress);
        //public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr);
        //public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive);
        //public void DropMulticastGroup(IPAddress multicastAddr);
        //public void DropMulticastGroup(IPAddress multicastAddr, int ifindex);
    }
}

