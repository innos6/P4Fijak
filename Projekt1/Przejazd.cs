namespace Projekt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Przejazd")]
    public partial class Przejazd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Przejazd()
        {
            Miesięczna_Karta_Drogowa = new HashSet<Miesięczna_Karta_Drogowa>();
        }

        [Key]
        [Column("Id przejazdu")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_przejazdu { get; set; }

        [Column("Dzień Miesiąca")]
        public DateTime Dzień_Miesiąca { get; set; }

        [Column("Cel wyjazdu")]
        [Required]
        [StringLength(50)]
        public string Cel_wyjazdu { get; set; }

        [Required]
        [StringLength(50)]
        public string Trasa { get; set; }

        [Column("Stan licznika przy wyjeździe")]
        public int Stan_licznika_przy_wyjeździe { get; set; }

        [Column("Stan licznika po powrocie")]
        public int Stan_licznika_po_powrocie { get; set; }

        [Column("Ilość przejechanych km.")]
        public int Ilość_przejechanych_km_ { get; set; }

        [Column("Podpis użytkownika")]
        [Required]
        [MaxLength(50)]
        public byte[] Podpis_użytkownika { get; set; }

        [Column("Id pracownika")]
        public int Id_pracownika { get; set; }

        [Column("Id faktury")]
        public int? Id_faktury { get; set; }

        public virtual Faktura Faktura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miesięczna_Karta_Drogowa> Miesięczna_Karta_Drogowa { get; set; }

        public virtual Użytkownicy Użytkownicy { get; set; }
    }
}
