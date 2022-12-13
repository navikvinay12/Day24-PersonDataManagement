using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo222Batch
{
    public class PersonDataManagement
    {
        public static void RetrieveTop2RecordsBasedOnAge(List<Person> list) //UC2
        {
            //List<Person> sortedData=list.OrderBy(p => p.Age).ToList();  //OrderBy=Sorting in Ascending,ToList=Converts given data in to List. 
            //Console.WriteLine("Sorted in Ascending order");
            //Program.DisplayPersonDetails(sortedData);
            //List<Person> top2Records = sortedData.Take(2).ToList();
            //Console.WriteLine("Top 2 records are : ");
            //Program.DisplayPersonDetails(top2Records);
            Console.WriteLine("\nRetrieve Top 2 Records Based On Age");
            List<Person> top2Records = list.OrderBy(p => p.Age).Take(2).ToList();
            Program.DisplayPersonDetails(top2Records);
        }
        public static void GetTeenageRecords13To18Only(List<Person> list) //UC2
        {
            Console.WriteLine("\nGet Teenage Records 13 To 18 Only ");
            List<Person> teenageRecords=list.Where(p=>p.Age>13 && p.Age<18).ToList();
            Program.DisplayPersonDetails(teenageRecords);
        }
    }
}
