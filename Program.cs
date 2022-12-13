namespace LambdaDemo222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddingPersonDetailsIntoList(list);
            PersonDataManagement.RetrieveTop2RecordsBasedOnAge(list);    //UC2
            PersonDataManagement.GetTeenageRecords13To18Only(list);     //UC3 
            PersonDataManagement.FindAverageAge(list);     //UC4
            PersonDataManagement.SearchPerson(list,"Aruna");     //UC5

            //List<Person> result = PersonDataManagement.SearchPerson(list, "Aruna");     //UC5
            //if(result!=null)
            //DisplayPersonDetails(result);         //UC5 (to view the list of names found as per the given name)
        }
        public static void AddingPersonDetailsIntoList(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kavya", Address = "bnglr", Age = 12, });
            list.Add(new Person() { SSN = 2, Name = "UV", Address = "Karnataka", Age = 70, });
            list.Add(new Person() { SSN = 3, Name = "Arun", Address = "Mumbai", Age = 32, });
            list.Add(new Person() { SSN = 4, Name = "Kalpan", Address = "Bangluru", Age = 16, });
            list.Add(new Person() { SSN = 5, Name = "Sachin", Address = "Bangluru", Age = 63, });
            list.Add(new Person() { SSN = 6, Name = "Arun", Address = "Chennai", Age = 36, });
            list.Add(new Person() { SSN = 7, Name = "Shrikanth", Address = "India", Age = 14, });
            DisplayPersonDetails(list);
        }
        public static void DisplayPersonDetails(List<Person> list)
        {
            foreach(Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}