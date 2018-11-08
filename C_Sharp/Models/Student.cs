using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Models
{
    public class Student
    {
        [Key]
        public string Rollnumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
