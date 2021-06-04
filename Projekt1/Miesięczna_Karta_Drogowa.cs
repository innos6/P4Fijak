namespace Projekt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Miesięczna Karta Drogowa")]
    public partial class Miesięczna_Karta_Drogowa
    {
        [Key]
        [Column("Id karty")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_karty { get; set; }

        public int Miesiąc { get; set; }

        public int Rok { get; set; }

        [Column("Nr rejestracyjny")]
        [Required]
        [StringLength(50)]
        public string Nr_rejestracyjny { get; set; }

        [Column("Id przejazdu")]
        public int? Id_przejazdu { get; set; }

        public virtual Przejazd Przejazd { get; set; }

        public virtual Samochody Samochody { get; set; }
    }
}
