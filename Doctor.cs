using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Policlinic_.Net_Core_
{
    class Doctor
    {
        [Key]
        public int Id { get; set; }
        public int Passport_Id { get; set; }
        public string Full_Name { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }

        [ForeignKey("Policlinic_Id")]
        public Policlinic Policlinic { get; set; }
    }
}
