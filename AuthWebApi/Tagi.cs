//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tagi
    {
        public long id_tagu { get; set; }
        public System.Guid id_przejazdu { get; set; }
        public string skrot { get; set; }
        public string komentarz { get; set; }
    
        public virtual Przejazdy_fs Przejazdy_fs { get; set; }
    }
}
