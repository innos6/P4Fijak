namespace RozliczenieSamochodów.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Użytkownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Użytkownicy()
        {
            Przejazds = new HashSet<Przejazd>();
        }

        [Key]
        [Column("Id pracownika")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_pracownika { get; set; }

        [Required]
        [StringLength(50)]
        public string Imie { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwisko { get; set; }

        [Column("Dzień urodzenia")]
        public int Dzień_urodzenia { get; set; }

        [Column("Miesiac urodzenia")]
        public int Miesiac_urodzenia { get; set; }

        [Column("Rok urodzenia")]
        public int Rok_urodzenia { get; set; }

        [StringLength(50)]
        public string Stanowisko { get; set; }

        [Column("Rodzaj uprawnień")]
        [Required]
        [StringLength(50)]
        public string Rodzaj_uprawnień { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przejazd> Przejazds { get; set; }
    }
}
