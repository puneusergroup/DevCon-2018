using System;
using System.Collections.Generic;
using System.Text;

namespace DevCon2018.SOLIDDemo
{
    public class MessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
