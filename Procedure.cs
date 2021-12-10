using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Policlinic_.Net_Core_
{
    class Procedure
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Doctor_Id")]
        public Doctor Doctor { get; set; }
    }
}
