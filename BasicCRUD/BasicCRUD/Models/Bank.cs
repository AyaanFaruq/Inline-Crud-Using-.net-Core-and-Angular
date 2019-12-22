using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCRUD.Models
{
    public class Bank
    {   
        [Key]
        public int BankID { get; set; }
        public string BankName { get; set; }
    }
}
