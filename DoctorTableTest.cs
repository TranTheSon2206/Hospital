using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DoctorTableTest
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating an object of the DoctorTable class
                DoctorTable objDoctorsTable = new DoctorTable();

                //Invoke the AcceptDetails method of the DoctorTable class
                //to display the details of the doctors
                objDoctorsTable.AcceptDetails();

                //Invoke the DisplayDetails method of the DoctorTable class
                //to display the details of the doctors
                objDoctorsTable.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options: ");
                    Console.WriteLine(" 1.Remove\n 2.Remove All\n 3.Search\n 4.Exit");
                    Console.WriteLine("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Removing the details of the doctor
                            if (objDoctorsTable.Remove())
                            {
                                Console.WriteLine("\n-----After Removing------");
                                objDoctorsTable.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Doctor with this name does not exist");
                            break;
                        case 2:
                            //Removing the names of all doctors using the built-in method Clear
                            objDoctorsTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n-----After removing all the doctors-----");
                            Console.WriteLine("Total number of doctors : " + objDoctorsTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            //Searching for the details of doctor
                            objDoctorsTable.Search();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx) {
                Console.WriteLine("Error : {0}", objEx.Message);   }
        }
    }
}
