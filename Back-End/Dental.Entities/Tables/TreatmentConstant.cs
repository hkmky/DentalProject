﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class TreatmentConstant : EntityBase
    {
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public byte[] Image { get; set; }
    }
}
