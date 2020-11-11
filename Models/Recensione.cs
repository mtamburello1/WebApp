using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Recensione
    {
        [Key] public long RecensioneId { get; set; }
        public float ValoreRecensione { get; set; }
        public string TestoRecensione { get; set; }
        public long OperaId { get; set; }
        public virtual Opera Opera { get; set; }
    }
}
