﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;
using ProtoBuf;

namespace Proto
{
    [ProtoContract]
    public class ProtoSoilMaps
    {
        [ProtoMember(1)]
        public KWSCellMap<SoilCell> liveMap;
        [ProtoMember(2)]
        public KWSCellMap<SoilCell> bufferMap;
    }
}
