using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class People
    {       
            public int Id { get; set; }
            [Required]
            public string Names { get; set; }
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; }
            public decimal Worth { get; set; }        
    }
}
