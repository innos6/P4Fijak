namespace Hotel5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime End { get; set; }

        public int RoomNumber { get; set; }

        public int GuestId { get; set; }
    }
}
