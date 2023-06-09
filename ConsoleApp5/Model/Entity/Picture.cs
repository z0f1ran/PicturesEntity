﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Model.Entity
{
    internal class Picture
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id_p { get; set; }
        public string Name_p { get; set; } = "";
        public int Year_p { get; set; }
        public Author? Author { get; set; }
        public int? AuthorId { get; set; }
        public override string ToString()
        {
            return $"{Id_p} - {Name_p} - {Year_p} - {Author}";
        }
    }
}
