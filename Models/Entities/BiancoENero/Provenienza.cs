using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities.BiancoENero
{
    public class Provenienza
    {
        [Display(Name = "Provenienza")]
        [Key]
        public long ProvenienzaId { get; set; }

        [Display(Name = "Zona")]
        [ForeignKey("NomeZona")]
        public string NomeZona { get; set; }

        [Display(Name = "Vino")]
        [ForeignKey("NomeVino")]
        public string NomeVino { get; set; }

        public virtual Vino Vino { get; set; }
        public virtual Zona Zona { get; set; }
    }
}
