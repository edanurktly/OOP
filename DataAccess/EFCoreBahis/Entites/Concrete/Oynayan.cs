﻿using EFCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBahis.Entites.Concrete
{
    public class Oynayan:BaseEntity
    {
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public double? Bakiye { get; set; }

    }
}
