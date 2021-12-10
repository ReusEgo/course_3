using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Policlinic_.Net_Core_
{
    class Program
    {

        static void Main(string[] args)
        {
            using (AppContext db = new AppContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Console.WriteLine("Adding policlinic 1...");
                Policlinic Policlinic1 = new Policlinic
                {
                    Name = "KMDP#1",
                    Adress = "Tests street"
                };
                db.Policlinics.Add(Policlinic1);
                Doctor Doctor1 = new Doctor
                {
                    Passport_Id = 178519374,
                    Full_Name = "Lisa Kavun",
                    Birthday = "21.11.1998",
                    Sex = "Female",
                    Policlinic = Policlinic1
                };
                db.Doctors.Add(Doctor1);
                Procedure Procedure1 = new Procedure
                {
                    Name = "Vaccination",
                    Doctor = Doctor1
                };

            }
        }
    }

}
