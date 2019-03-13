﻿using System.Collections.Generic;

namespace ANP.Core
{
    public class EventPacket
    {
        public EventPacket(byte code, Dictionary<byte, object> parameters)
        {
            Code = code;
            Parameters = parameters;
        }

        public byte Code { get; }
        public Dictionary<byte, object> Parameters { get; }
    }
}
