﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteamAPI_Project.Interfaces
{
    interface IAchievement
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }

        
    }
}
