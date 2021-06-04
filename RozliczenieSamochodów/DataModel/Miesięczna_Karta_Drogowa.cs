namespace RozliczenieSamochodów.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Miesięczna Karta Drogowa")]
    public partial class Miesięczna_Karta_Drogowa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Miesięczna_Karta_Drogowa()
        {
            Przejazds = new HashSet<Przejazd>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Miesiąc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rok { get; set; }

        [Key]
        [Column("Nr rejestracyjny", Order = 2)]
        [StringLength(8)]
        public string Nr_rejestracyjny { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przejazd> Przejazds { get; set; }

        public virtual Samochody Samochody { get; set; }
    }
}
