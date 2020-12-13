using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Recensione
    {
        [Key] public long RecensioneId { get; set; }

        [Display(Name = "Recensore")]
        public string NomeRecensore { get; set; }

        [Range(1, 5)]
        [Required]
        [Display(Name = "Voto")]
        public float ValoreRecensione { get; set; }

        [Required]
        public string Titolo { get; set; }

        [Display(Name = "Descrizione")]
        [Required]
        public string TestoRecensione { get; set; }

        [ForeignKey("OperaId")]
        [Display(Name = "Opera")]
        public long OperaId { get; set; }

        public virtual Opera Opera { get; set; }
    }
}
