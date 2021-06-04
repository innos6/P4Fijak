namespace Projekt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Faktura")]
    public partial class Faktura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faktura()
        {
            Przejazd = new HashSet<Przejazd>();
            Pozycje_faktury = new HashSet<Pozycje_faktury>();
        }

        [Key]
        [Column("Id faktury")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_faktury { get; set; }

        public DateTime Data { get; set; }

        [Required]
        [StringLength(50)]
        public string Sprzedawca { get; set; }

        [Required]
        [StringLength(50)]
        public string Nabywca { get; set; }

        [Column(TypeName = "money")]
        public decimal Suma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przejazd> Przejazd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pozycje_faktury> Pozycje_faktury { get; set; }
    }
}
