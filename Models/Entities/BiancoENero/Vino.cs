using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities.BiancoENero
{
    public class Vino
    { 
        
        [Key]
        [Display(Name = "Denominazione")]
        public string NomeVino { get; set; }

        [Display(Name = "Descrizione")]
        public string DescrizioneVino { get; set; }

        [Display(Name = "Tipologia")]
        public string TipoVino { get; set; }

        public virtual ICollection<Provenienza> Provenienze { get; set; }
    }
}
