//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBCResort.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public Room()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int idRoom { get; set; }
        public int idEmployee { get; set; }
        public int NumOfRoom { get; set; }
        public int NumOfBeds { get; set; }
        public string Status { get; set; }
        public string Info { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
