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
        public static void FindAverageAge(List<Person> list) //UC3
        {
            Console.WriteLine("\nFinding Average Age");
            double age = list.Average(p => p.Age);
            Console.WriteLine("Average Age is : "+age);
        }
        public static List<Person> SearchPerson(List<Person> list,string name)
        {
            //LastOrDefault() or FirstOrDefault() we can use instead of ToList() in below .
            var result = list.Where(p => p.Name == name).ToList();  
            if(result.Count!=0)        //or result!=null ; if you want to fetch only single person.
            {
                Console.WriteLine($"\n{name} is Present in the List");
                return result;
            }
            else
            {
                Console.WriteLine($"\n{name} is Not present in the List");
                return default;
            }
        }
        public static void SkipPersonLessThanAge60(List<Person> list)       //UC6
        {
            Console.WriteLine("\nSkipping the records whose age is less than 60");
            //Note-Sorting is imp here else iteration will stop once condition will fail
            List<Person> data=list.OrderBy(p => p.Age).SkipWhile(p => p.Age < 60).ToList();
            Program.DisplayPersonDetails(data);
        }
        public static void RemoveGivenPerson(List<Person> list, string name)       //UC7
        {
            list.RemoveAll(p=>(p.Name==name));
            if(list.TrueForAll(e=>e.Name!=name))
            {
                Console.WriteLine($"\nAll records with the name=\"{name}\" has been removed from the list.");
            }
        }
    }
}
