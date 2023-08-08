using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFiles.Model;

using System.Data.SqlClient;
using Dapper;
using studentwebapi.Controllers;

namespace DataAccessLibrary.Repository
{

    public class StudentRepository

    {
        public readonly string conectionstring;
        public StudentRepository()
        {
            conectionstring = @"Data source=DESKTOP-18UQSSV;Initial catalog=SQL ;User Id=sa;Password=Anaiyaan@123";
        }

        public StudentInformation modelInfo()
        {

            StudentInformation S = new StudentInformation();

            Console.WriteLine("Enter  entername");
            S.entername = (Console.ReadLine());

            Console.WriteLine("Enter  fathername");
            S.fathername = Console.ReadLine();

            Console.WriteLine("Enter  email");
            S.email = Console.ReadLine();


            Console.WriteLine("Enter gender");
            S.gender = Console.ReadLine();
            return S;
        }
        public void InsertSP(StudentInformation a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec Insertstudentinformationcurd  '{a.entername}','{a.fathername}','{a.email}','{a.gender}'");



                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<StudentInformation> SelectSP()

        {
            try
            {
                List<StudentInformation> constrain = new List<StudentInformation>();

                var connection = new SqlConnection(conectionstring);
                connection.Open();
                constrain = connection.Query<StudentInformation>("  exec select_studentinformationcurd ", conectionstring).ToList();
                connection.Close();


                foreach (var constrai in constrain)
                {

                    Console.WriteLine($"Entername--{constrai.entername}   fathername--{constrai.fathername}  email --{constrai.email}   gender--{constrai.gender} ");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }




                /*Console.WriteLine(constrain);
                Console.ReadLine();*/

                return constrain;


            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void updateSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("Enter A Email to alter");
                string Email = Console.ReadLine();

                Console.WriteLine("Enter A entername to alter the Email");
                string Empid = Console.ReadLine();

                con.Open();
                con.Execute($"  exec Updatestudentinformationcurd '{Email}','{Empid}' ");

                // con.Execute($"  update studentinformationcurd set FirstName ='{f}' where LastName='{lastn}' ");


                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        public void deleteSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("enter a entername  to delete record");
                string del = Console.ReadLine();
                con.Open();
                con.Execute($"EXEC Deletestudentinformationcurd '{del}'");


                con.Close();
            }
            catch (SqlException e)
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