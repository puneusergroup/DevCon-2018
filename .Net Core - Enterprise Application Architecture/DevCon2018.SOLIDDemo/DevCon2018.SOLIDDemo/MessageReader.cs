using System;
using System.Collections.Generic;
using System.Text;

namespace DevCon2018.SOLIDDemo
{
    public class MessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "Hello, world";
        }
    }
}
