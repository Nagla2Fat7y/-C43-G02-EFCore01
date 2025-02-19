using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Assignment.Models
{
   

    internal class Instractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public string Address { get; set; }
        public double HoursRate { get; set; }
        public int DepartmentId { get; set; }
       
        
    }

    

 
}
