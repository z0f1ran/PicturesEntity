using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Model.Entity
{
    internal class Author
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int YearOfBorn { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name} - {YearOfBorn}";
        }
    }
}
