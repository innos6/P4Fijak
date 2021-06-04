namespace RozliczenieSamochodów.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Samochody")]
    public partial class Samochody
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Samochody()
        {
            Miesięczna_Karta_Drogowa = new HashSet<Miesięczna_Karta_Drogowa>();
        }

        [Key]
        [Column("Nr rejestracyjny")]
        [StringLength(8)]
        public string Nr_rejestracyjny { get; set; }

        [Required]
        [StringLength(50)]
        public string Typ { get; set; }

        [Required]
        [StringLength(50)]
        public string Marka { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Własność { get; set; }

        [Required]
        [StringLength(50)]
        public string Paliwo { get; set; }

        [Column(TypeName = "money")]
        public decimal Pojemność { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miesięczna_Karta_Drogowa> Miesięczna_Karta_Drogowa { get; set; }
    }
}
