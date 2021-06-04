namespace RozliczenieSamochodów.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Przejazd")]
    public partial class Przejazd
    {
        [Key]
        [Column("Id przejazdu")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_przejazdu { get; set; }

        [Column("Dzień Miesiąca")]
        public int Dzień_Miesiąca { get; set; }

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

        [Column("Id pracownika")]
        public int Id_pracownika { get; set; }

        [Column("Id faktury")]
        public int? Id_faktury { get; set; }

        public int Miesiąc { get; set; }

        public int Rok { get; set; }

        [Column("Nr rejestracyjny")]
        [Required]
        [StringLength(8)]
        public string Nr_rejestracyjny { get; set; }

        public virtual Faktura Faktura { get; set; }

        public virtual Miesięczna_Karta_Drogowa Miesięczna_Karta_Drogowa { get; set; }

        public virtual Użytkownicy Użytkownicy { get; set; }
    }
}
