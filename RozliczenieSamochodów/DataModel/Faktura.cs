namespace RozliczenieSamochodów.DataModel
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
            Przejazds = new HashSet<Przejazd>();
            Pozycje_faktury = new HashSet<Pozycje_faktury>();
        }

        [Key]
        [Column("Id faktury")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_faktury { get; set; }

        [Required]
        [StringLength(50)]
        public string Sprzedawca { get; set; }

        [Required]
        [StringLength(50)]
        public string Nabywca { get; set; }

        [Column(TypeName = "money")]
        public decimal Suma { get; set; }

        [Column("Dzień wystawienia")]
        public int Dzień_wystawienia { get; set; }

        [Column("Miesiąc wystawienia")]
        public int Miesiąc_wystawienia { get; set; }

        [Column("Rok wystawienia")]
        public int Rok_wystawienia { get; set; }

        [Column("Dzień Sprzedaży")]
        public int Dzień_Sprzedaży { get; set; }

        [Column("Miesiąc Sprzedaży")]
        public int Miesiąc_Sprzedaży { get; set; }

        [Column("Rok Sprzedaży")]
        public int Rok_Sprzedaży { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przejazd> Przejazds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pozycje_faktury> Pozycje_faktury { get; set; }
    }
}
