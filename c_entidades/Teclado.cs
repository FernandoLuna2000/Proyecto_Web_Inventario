﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace c_entidades
{
    public partial class Teclado
    {
        public int IdTeclado { get; set; }
        public int? FMarcat { get; set; }
        public string Conector { get; set; }

        public virtual Marca FMarcatNavigation { get; set; }
    }
}