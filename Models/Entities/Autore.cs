using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Autore
    {

        [Display(Name = "Autore")]
        [Key] 
        public long AutoreId { get; set; }

        [Display(Name = "Nome")]
        public string NomeAutore { get; set; }

        [Display(Name = "Path foto")]
        public string FotoAutore { get; set; }

        [Display(Name = "Path video")]
        public string VideoAutore { get; set; }

        [Display(Name = "Storia")]
        public string StoriaAutore { get; set; }

        public virtual ICollection<Opera> Opere { get; set; }

    }
}
