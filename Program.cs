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
            /*using (AppContext db = new AppContext())
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
                db.SaveChanges();
                Doctor Doctor1 = new Doctor
                {
                    Passport_Id = 178519374,
                    Full_Name = "Lisa Kavun",
                    Birthday = "21.11.1998",
                    Sex = "Female",
                    Policlinic = Policlinic1
                };
                db.Doctors.Add(Doctor1);
                foreach (Doctor c in db.Doctors)
                    Console.WriteLine("{0}  {1}  {2}  {3} {5}", c.Passport_Id, c.Full_Name, c.Birthday, c.Sex, c.Policlinic);
                Console.WriteLine("--------------------------------------------------------------------");
                db.SaveChanges();
                Procedure Procedure1 = new Procedure
                {
                    Name = "Vaccination",
                    Doctor = Doctor1
                };
                db.Procedures.Add(Procedure1);
                db.SaveChanges();
                /*
                foreach (Doctor c in db.Doctors)
                    Console.WriteLine("{0}  {1}  {2}  {3} {5}", c.Passport_Id, c.Full_Name, c.Birthday, c.Sex, c.Policlinic);
                Console.WriteLine("--------------------------------------------------------------------");
            }*/
            Test();
            TestMethods();
        }

        public static void Test()
        {
            using (AppContext db = new AppContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Console.WriteLine("Adding Policlinic1");
                Policlinic Policlinic1 = new Policlinic
                {
                    Name = "KMDP#1",
                    Adress = "Tests street"
                };
                db.Policlinics.Add(Policlinic1);
                db.SaveChanges();
                Console.WriteLine("Adding Employee2");
                Doctor Doctor1 = new Doctor
                {
                    Passport_Id = 178519374,
                    Full_Name = "Lisa Kavun",
                    Birthday = "21.11.1998",
                    Sex = "Female",
                    Policlinic = Policlinic1
                };
                db.Doctors.Add(Doctor1);
                Console.WriteLine("Adding Employee3");
                Doctor Doctor2 = new Doctor
                {
                    Passport_Id = 346346346,
                    Full_Name = "Igor Ponomarchuk",
                    Birthday = "12.6.1973",
                    Sex = "Male",
                    Policlinic = Policlinic1
                };
                db.Doctors.Add(Doctor1);
                Console.WriteLine("Adding Employee4");
                Doctor Doctor3 = new Doctor
                {
                    Passport_Id = 806756678,
                    Full_Name = "Bogdan Rohluk",
                    Birthday = "19.8.1955",
                    Sex = "Male",
                    Policlinic = Policlinic1
                };
                db.Doctors.Add(Doctor1);
                db.Doctors.AddRange(Doctor1, Doctor2, Doctor3);
                db.SaveChanges();

            }
        }

        public static void TestMethods()
        {
            

            Console.WriteLine("\n Female doctors:");
            using (AppContext db = new AppContext())
            {
                var DoctorFem = db.Doctors.Where(p => p.Sex == "Female");

                foreach (var a in DoctorFem)
                {
                    Console.WriteLine($"{a.Full_Name} \t {a.Sex}");
                }
            }
            Console.Read();
        }
    }

}
