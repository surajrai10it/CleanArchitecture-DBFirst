using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public string DirectorName { get; set; } = string.Empty;
        public DateTime createdDate { get; set; } = DateTime.Now;
    }
}
