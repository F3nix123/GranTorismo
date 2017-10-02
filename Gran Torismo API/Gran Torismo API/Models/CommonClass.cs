﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gran_Torismo_API.Models
{
    public class Establecimiento
    {
        public string Name { get; set; }
        public int IdDistrict{ get; set; }
        public string Description{ get; set; }
        public string searchMap { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string fotos { get; set; }
    }
}