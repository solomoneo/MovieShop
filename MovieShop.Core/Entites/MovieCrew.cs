﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.Entites
{
    public class MovieCrew
    {
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public Crew Crew { get; set; }
        public Movie Movie { get; set; }
    }
}