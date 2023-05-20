using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Model.Entity
{
    internal class Picture
    {
        [Key]
        public int Id_p { get; set; }
        public string Name_p { get; set; } = "";
        public int Year_p { get; set; }
        public override string ToString()
        {
            return $"{Id_p} - {Name_p} - {Year_p}";
        }
    }
}
