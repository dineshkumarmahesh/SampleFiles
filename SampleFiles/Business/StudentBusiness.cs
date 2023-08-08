//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Dapper;
//using System.Data.SqlClient;
//using SampleFiles.Repository;
//using SampleFiles.Model;

//namespace SampleFiles.Business
//{
//    class StudentBusiness
//    {


//        public void CRUD_Operation()
//        {

//            int b;

//            StudentDetailMenu obj1 = new StudentDetailMenu();
//            StudentInformation obj = new StudentInformation(); 
//            {
//                Console.WriteLine("Choose the option");
//                Console.WriteLine("0.Exit");
//                Console.WriteLine("1.Insert");
//                Console.WriteLine("2.select");



//                b = Convert.ToInt32(Console.ReadLine());
               

//                switch (b)
//                {
//                    case 1:
//                        var Add = obj1.modelInfo();
//                        obj1.Insert(Add);

//                        break;
//                    case 2:

//                        obj1.Select();

//                        break;

//                    default:
//                        Console.WriteLine("Please give a valid OPtion");
//                        break;

//                }

//            } while (b != 0);
//            Console.ReadLine();






//        }
//    }
//}
