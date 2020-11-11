using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Personaggio
    {
        [Key] public long PersonaggioId { get; set; }
        public long OperaId { get; set; }
        public string VideoPersonaggio { get; set; }
        public string TestoPersonaggio { get; set; }
        public virtual Opera Opera { get; set; }
    }
}
