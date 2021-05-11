using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Zadanie_4
{
    [Table("Pracownik")]
    public class PracownikTPT : OsobaTPT
    {
        public DateTime DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
    }
}
