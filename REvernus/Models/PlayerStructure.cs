﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using EVEStandard.Models;

namespace REvernus.Models
{
    [Serializable]
    public class PlayerStructure
    {
        public long StructureId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Position Position { get; set; }
        public int SolarSystemId { get; set; }
        public int? TypeId { get; set; }
    }
}
