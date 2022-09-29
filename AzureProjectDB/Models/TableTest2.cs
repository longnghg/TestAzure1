using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureProjectDB.Models
{
    public class TableTest2
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string Menu { get; set; }
        [StringLength(15)]
        public string ProductName{ get; set; }
    }
}
