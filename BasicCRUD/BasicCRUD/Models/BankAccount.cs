using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCRUD.Models
{
    public class BankAccount
    {   
        [Key]
        public int BankAccountID { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string AccountHolder { get; set; }

        [Required]
        public int BankID { get; set; }

        [Required]
        public string IFSC { get; set; }




    }
}
