using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities.BiancoENero
{
    public class Vino
    {
        public Vino() 
        {
            this.ZoneVini = new HashSet<ZonaVino>();
        }

        public Vino(String nome, String storia, string caratteristiche, string tipo) 
        {
            this.NomeVino = nome;
            this.StoriaVino = storia;
            this.CaratteristicheVino = caratteristiche;
            this.TipoVino = tipo;
            this.ZoneVini = new HashSet<ZonaVino>();
        }

        [Key]
        [Display(Name = "Denominazione")]
        public string NomeVino { get; set; }

        [Display(Name = "Storia")]
        public string StoriaVino { get; set; }

        [Display(Name = "Caratteristiche")]
        public string CaratteristicheVino { get; set; }

        [Display(Name = "Tipologia")]
        public string TipoVino { get; set; }

        public virtual ICollection<ZonaVino> ZoneVini { get; set; }
    }
}
