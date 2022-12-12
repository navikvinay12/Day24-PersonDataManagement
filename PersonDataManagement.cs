using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo222Batch
{
    public class PersonDataManagement
    {
        public static void RetrieveTop2RecordsBasedOnAge(List<Person> list)
        {
            //List<Person> sortedData=list.OrderBy(p => p.Age).ToList();  //OrderBy=Sorting in Ascending,ToList=Converts given data in to List. 
            //Console.WriteLine("Sorted in Ascending order");
            //Program.DisplayPersonDetails(sortedData);
            //List<Person> top2Records = sortedData.Take(2).ToList();
            //Console.WriteLine("Top 2 records are : ");
            //Program.DisplayPersonDetails(top2Records);
            Console.WriteLine("Retrieve Top 2 Records Based On Age");
            List<Person> top2Records=list.OrderBy(p => p.Age).Take(2).ToList();
            Program.DisplayPersonDetails(top2Records);
        }
    }
}
