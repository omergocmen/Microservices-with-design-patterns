﻿using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    [Owned]
    public class Address
    {
        public string Line { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }
}
