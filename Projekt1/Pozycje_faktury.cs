namespace Projekt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pozycje faktury")]
    public partial class Pozycje_faktury
    {
        [Key]
        [Column("Id pozycji")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_pozycji { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwa { get; set; }

        public int Ilość { get; set; }

        [Column("Cena jednostkowa brutto", TypeName = "money")]
        public decimal Cena_jednostkowa_brutto { get; set; }

        [Column("Wartość netto", TypeName = "money")]
        public decimal Wartość_netto { get; set; }

        public int Stawka { get; set; }

        [Column(TypeName = "money")]
        public decimal Podatek { get; set; }

        [Column("Wartość brutto", TypeName = "money")]
        public decimal Wartość_brutto { get; set; }

        [Column(TypeName = "money")]
        public decimal Suma { get; set; }

        [Column("Id faktury")]
        public int Id_faktury { get; set; }

        public virtual Faktura Faktura { get; set; }
    }
}
