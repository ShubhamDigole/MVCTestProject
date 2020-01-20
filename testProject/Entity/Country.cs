using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testProject.Entity
{
    public class Country
    {  
        
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }
}
