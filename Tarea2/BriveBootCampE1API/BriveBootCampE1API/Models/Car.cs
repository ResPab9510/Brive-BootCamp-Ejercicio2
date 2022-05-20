using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BriveBootCampE1API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
        public DateTime CreateDate { get; set; } 
    }
}
