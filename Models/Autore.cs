using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Autore
    {
        [Key] public long AutoreId { get; set; }

        public string FotoAutore { get; set; }

        public string VideoAutore { get; set; }

        public string StoriaAutore { get; set; }

        public string NomeAutore { get; set; }

        public virtual ICollection<Opera> Opere { get; set; }

    }
}
