namespace Knowledge_Check_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());
            var recordList = new List<GroceryStore>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new GroceryStore();
                Console.WriteLine("Enter the name of this store");
                myClass.StoreName = Console.ReadLine();
                Console.WriteLine("Enter the number of employees at " + myClass.StoreName);
                myClass.NumberOfEmployees = int.Parse(Console.ReadLine());
                recordList.Add(myClass);
            }
            
            foreach (var record in recordList)
            {
                Console.WriteLine(record.StoreName);
                Console.WriteLine("The number of employees at this store is: " + record.NumberOfEmployees);
            }
            // Print out the list of records using Console.WriteLine()
        }
    }
}