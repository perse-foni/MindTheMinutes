﻿using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class ListType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
