//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace astronomy5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planetas
    {
        public int PlanetaID { get; set; }
        public string Nosaukums { get; set; }
        public string Izmers { get; set; }
        public string Masa { get; set; }
        public Nullable<double> Gravitacija { get; set; }
        public Nullable<double> MinT { get; set; }
        public Nullable<double> MaxT { get; set; }
        public string Apraksts { get; set; }
    }
}
