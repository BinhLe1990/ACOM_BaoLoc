using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class StateObject
    {
        // Client  socket.
        public Socket WorkSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 8192;
        // Receive buffer.
        public byte[] Buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder Sb = new StringBuilder();
    }
}
