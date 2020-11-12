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
        }
        [Key] public long OperaId { get; set; }
        public long AutoreId { get; set; }
        public string Titolo { get; set; }
        public string Trama { get; set; }
        public string Contesto { get; set; }
        public float Prezzo { get; set; }
        public string VideoOpera { get; set; }
        public string FotoOpera { get; set; }
        public virtual ICollection<Personaggio> Personaggi { get; set; }
        public virtual ICollection<Recensione> Recensioni { get; set; }
        public virtual Autore Autore { get; set; }

    }
}
