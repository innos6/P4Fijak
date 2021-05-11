using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie_4
{
    [Table("Klient")]
    public class KlientTPT : OsobaTPT
    {
        public string NumerTelefonu { get; set; }
        public string NumerRejestracyjny { get; set; }
    }
}
