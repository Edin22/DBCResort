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
    
    public partial class Reservation
    {
        public int idReservation { get; set; }
        public int idRoom { get; set; }
        public int idGuest { get; set; }
        public int idEmpoyee { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ExtraOptions { get; set; }
        public Nullable<int> NumOfRooms { get; set; }
        public Nullable<int> NumOfGuests { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
    }
}
