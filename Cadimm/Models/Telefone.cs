using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Telefone
    {
        [Key]
        [Display(Name = "Telefone")]
        public int Numero { get; set; }
        public int MembroId { get; set; }
    }
}
