using System;
using System.ComponentModel.DataAnnotations;

namespace AzureProjectDB.Models
{
    public class ErrorViewModel
    {
        [Key]
        public string RequestId { get; set; }
        public int IdProVip { get; set; }
    }
}
