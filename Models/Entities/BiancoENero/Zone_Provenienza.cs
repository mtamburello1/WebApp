using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities.BiancoENero
{
    public class Zone_Provenienza
    {
        [Display(Name = "Zona")]
        [Key]
        public string NomeZona { get; set; }

        public virtual ICollection<Vino> Vini { get; set; }
    }
}
