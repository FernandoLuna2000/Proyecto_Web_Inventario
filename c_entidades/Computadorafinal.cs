﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace c_entidades
{
    public partial class Computadorafinal
    {
        public Computadorafinal()
        {
            Actualizacion = new HashSet<Actualizacion>();
            CantDisc = new HashSet<CantDisc>();
            Evidencia = new HashSet<Evidencia>();
        }

        public string NumInv { get; set; }
        public string NumScpu { get; set; }
        public int? IdCpug { get; set; }
        public string NumSteclado { get; set; }
        public int? IdTecladog { get; set; }
        public string NumSmonitor { get; set; }
        public int? IdMong { get; set; }
        public string NumSmouse { get; set; }
        public int? IdMousg { get; set; }
        public string Estado { get; set; }
        public int IdEstatus { get; set; }

        public virtual Estatus IdEstatusNavigation { get; set; }
        public virtual ICollection<Actualizacion> Actualizacion { get; set; }
        public virtual ICollection<CantDisc> CantDisc { get; set; }
        public virtual ICollection<Evidencia> Evidencia { get; set; }
    }
}