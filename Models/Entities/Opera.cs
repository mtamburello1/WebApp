using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Opera
    {
        public Opera()
        {
            Personaggi = new HashSet<Personaggio>();
            Recensioni = new HashSet<Recensione>();
            Voto = 0;
            NumeroVoti = 0;
            FiveStars = 0;
            FourStars = 0;
            ThreeStars = 0;
            TwoStars = 0;
            OneStars = 0;
        }

        [Display(Name = "Opera")]
        [Key] public long OperaId { get; set; }

        [Display(Name = "Autore")]
        [ForeignKey("AutoreId")]
        public long AutoreId { get; set; }

        [Required]
        public string Titolo { get; set; }

        [Required]
        public string Trama { get; set; }

        public string Contesto { get; set; }

        public float Prezzo { get; set; }

        [Display(Name = "Path video")]
        public string VideoOpera { get; set; }

        [Display(Name = "Path foto")]
        public string FotoOpera { get; set; }

        [Range(0, 5)]
        public float? Voto { get; set; }

        public int NumeroVoti { get; set; }

        public int FiveStars { get; set; }
        public int FourStars { get; set; }
        public int ThreeStars { get; set; }
        public int TwoStars { get; set; }
        public int OneStars { get; set; }

        public ICollection<Personaggio> Personaggi { get; set; }

        public ICollection<Recensione> Recensioni { get; set; }

        public virtual Autore Autore { get; set; }

    }
}
