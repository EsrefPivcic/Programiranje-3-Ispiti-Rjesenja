using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    [Table("GodineStudija")]
    public class GodinaStudija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivna { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
