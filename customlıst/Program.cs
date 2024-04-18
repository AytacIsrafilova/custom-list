using Core.Model;

namespace customlıst
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CustomList<int> customList = new CustomList<int>();

            
            customList.Add(10);
            customList.Add(20);
            customList.Add(30);
            customList.Add(40); 

            
            Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");
           
            int elementToFind = 20;
            int foundElement = customList.Find(x => x == elementToFind);
            Console.WriteLine($"Found element {elementToFind}: {foundElement}");

           
            var elementsGreaterThan20 = customList.FindAll(x => x > 20);
            Console.WriteLine("Elements greater than 20:");
            foreach (var item in elementsGreaterThan20)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");

            
            customList.RemoveAll(x => x > 20);

            
            Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");
        }
    }
}
 