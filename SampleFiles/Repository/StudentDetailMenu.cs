using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFiles.Model;
using Dapper;
using System.Data.SqlClient;

namespace SampleFiles.Repository
{
    class StudentDetailMenu
    {

        public readonly string conectionstring;
        public StudentDetailMenu()
        {
            conectionstring = @"Data source=DESKTOP-18UQSSV;Initial catalog=SQL ;User Id=sa;Password=Anaiyaan@123";
        }

        public StudentInformation modelInfo()
        {

            StudentInformation S = new StudentInformation();


            Console.WriteLine("Enter  entername");
            S.entername = Console.ReadLine();

            Console.WriteLine("Enter fathername ");
            S.fathername = Console.ReadLine();

            Console.WriteLine("Enter  Email");
            S.Email = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            S.Gender = Console.ReadLine();
            return S;
        }

        public void Insert(StudentInformation a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec insertinfo '{a.entername}','{a.fathername}','{a.Email}','{a.Gender}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StudentInformation> Select()

        {

            try

            {

                List<StudentInformation> c = new List<StudentInformation>();
                var connection = new SqlConnection(conectionstring);
                connection.Open();
                c = connection.Query<StudentInformation>("select * from StudentInformation", conectionstring).ToList();

                connection.Close();
                foreach (var a in c)
                {
                    Console.WriteLine($" Empid-{ a.empid} Entername-{ a.entername} FatherName-{ a.fathername} email-{a.Email},Gender{a.Gender}");
                }
                //{a.Empid}','{a.Firstname}','{a.Lastname}','{a.Email}'
                return c;
            }

            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } 
    }
} 

   





      