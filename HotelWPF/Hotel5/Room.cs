namespace Hotel5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomNumber { get; set; }

        public int Capacity { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public bool ForSmokers { get; set; }

        public bool Available { get; set; }

    }
}
