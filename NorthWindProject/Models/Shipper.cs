﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWindProject.Models
{
    public class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone
        { get; set; }
    }
}