namespace Projekt1
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
            Przejazd = new HashSet<Przejazd>();
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

        [StringLength(50)]
        public string Adres { get; set; }

        [Column("Data urodzenia")]
        public DateTime? Data_urodzenia { get; set; }

        [StringLength(50)]
        public string Stanowisko { get; set; }

        [Column("Rodzaj uprawnień")]
        [Required]
        [StringLength(50)]
        public string Rodzaj_uprawnień { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przejazd> Przejazd { get; set; }
    }
}
