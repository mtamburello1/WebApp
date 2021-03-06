﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Personaggio
    {
        
        [Key] public long PersonaggioId { get; set; }

        [Display(Name = "Nome")]
        public string NomePersonaggio { get; set; }

        [Display(Name = "Opera")]
        [ForeignKey("OperaId")]
        public long OperaId { get; set; }

        [Display(Name = "Path video")]
        public string VideoPersonaggio { get; set; }

        [Display(Name = "Descrizione")]
        public string TestoPersonaggio { get; set; }

        public virtual Opera Opera { get; set; }
    }
}
