using C44_G03_OOP03.Company;
using C44_G03_OOP03.Inheritance;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C44_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 From 1 To 4
            ////Employee emp = new Employee(1, "Mohamed", SecurityLevel.Developer, 10000, new DateTime(2025, 8, 15), Gender.M);

            ////Console.WriteLine(emp);

            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Mahmoud", SecurityLevel.DBA, 6000, new HiringDate(day: 3, month: 5, year: 2025), Gender.M);
            //EmpArr[1] = new Employee(2, "Amr", SecurityLevel.Guest, 16000, new HiringDate(day: 20, month: 1, year: 2012), Gender.M);
            //EmpArr[2] = new Employee(3, "Amina", SecurityLevel.Secretary, 7000, new HiringDate(day: 12, month: 3, year: 2023), Gender.F);

            //foreach (var item in EmpArr)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = 0; j < EmpArr.Length - i - 1; j++)
            //    {
            //        if (EmpArr[j].HireDate.ToDateTime() > EmpArr[j + 1].HireDate.ToDateTime())
            //        {
            //            Employee temp = EmpArr[j];
            //            EmpArr[j] = EmpArr[j + 1];
            //            EmpArr[j + 1] = temp;
            //        }
            //    }
            //}



            //Console.WriteLine("\nSorted Array by Hire Date:");
            //foreach (var employee in EmpArr)
            //    Console.WriteLine(employee);
            #endregion

            #region Part01 Num 5
            //EBook eBook = new EBook("Mastering C#", "John Smith", "978-1-23456-789-0", 15.2);

            //PrintedBook printedBook = new PrintedBook("Object-Oriented Programming Basics", "Jane Doe", "978-0-98765-432-1", 350);

            //Console.WriteLine($"EBook Information: {eBook}\n \n PrintedBook Information: {printedBook} ");
            #endregion
        }
    }
}
