using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Policlinic_.Net_Core_
{
    class Policlinic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Adress { get; set; }

    }
}
