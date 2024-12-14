using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JQueryCrud.Models
{
    public class TransactionModel

    {
        [Key]
        public int Id { get; set; }

        [MaxLength(12)]
        [Required(ErrorMessage ="This Feild is Required")]
        [DisplayName("Account Number")]
        [Column(TypeName ="nvarchar(12)")]
        public string  AccountNumber { get; set; }

        [Required(ErrorMessage = "This Feild is Required")]
        [DisplayName(" Nominee")]
        [Column(TypeName = "nvarchar(12)")]
        public string Nominee { get; set; }

        [Required(ErrorMessage = "This Feild is Required")]
        [DisplayName("Bank Name ")]
        [Column(TypeName = "nvarchar(12)")] public string BankName { get; set; }


        [Required(ErrorMessage = "This Feild is Required")]
        [DisplayName(" IFSCCode")]
        [Column(TypeName = "nvarchar(12)")]
        public string IFSCCode { get; set; }

        [Required(ErrorMessage = "This Feild is Required")]
        [DisplayName("Amount")]
        public int Amount { get; set; }


        [DisplayFormat(DataFormatString ="{0:MM//dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
