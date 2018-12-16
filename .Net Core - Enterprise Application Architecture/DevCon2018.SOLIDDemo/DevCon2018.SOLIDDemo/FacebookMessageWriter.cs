using System;
using System.Collections.Generic;
using System.Text;

namespace DevCon2018.SOLIDDemo
{
    public class FacebookMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine("Connected to facebook");
            Console.WriteLine(message);
        }
    }
}
