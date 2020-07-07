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
        public int Numero { get; set; }
        public Membro Membro { get; private set; }

        [Display(Name = "Membro")]
        public int MembroId { get; private set; }
    }
}
