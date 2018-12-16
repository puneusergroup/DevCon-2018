using System;
using System.Collections.Generic;
using System.Text;

namespace DevCon2018.SOLIDDemo
{
    class Startup
    {
        IMessageReader _reader;
        IMessageWriter _writer;
        public Startup(IMessageReader reader, IMessageWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void Run()
        {
            _writer.WriteMessage(_reader.ReadMessage());
        }
    }
}
