﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace c_entidades
{
    public partial class DiscoDuro
    {
        public DiscoDuro()
        {
            CantDisc = new HashSet<CantDisc>();
        }

        public int IdDisco { get; set; }
        public string TipoDisco { get; set; }
        public string Conector { get; set; }
        public string Capacidad { get; set; }
        public int FMarcaDisco { get; set; }
        public string Extra { get; set; }

        public virtual Marca FMarcaDiscoNavigation { get; set; }
        public virtual ICollection<CantDisc> CantDisc { get; set; }
    }
}