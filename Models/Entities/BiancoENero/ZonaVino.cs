using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities.BiancoENero
{
    public class ZonaVino
    {
        [DisplayName("Vino")]
        [ForeignKey("NomeVino")]
        public string NomeVino { get; set; }
        [DisplayName("Zona")]
        [ForeignKey("NomeZona")]
        public string NomeZona { get; set; }
        public Vino Vino { get; set; }
        public Zona Zona { get; set; }

        public ZonaVino() { }

        public ZonaVino(Zona zona, Vino vino)
        {
            this.Zona = zona;
            this.NomeZona = zona.NomeZona;

            this.Vino = vino;
            this.NomeVino = vino.NomeVino;
        }
    }
}
