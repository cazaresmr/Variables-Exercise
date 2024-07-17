namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;
            char grade = 'A';
            bool isPass = true;
            double salary = 5000.50;
            decimal price = 459999.99m;

            Console.WriteLine($"{name}, who at the age of {age}, decided to study math at the local college. He took his first quiz and earned an {grade}, so it is {isPass} - he easily passed his first quiz. Although his current monthly salary is {salary}, he is hoping for a promotion that will allow him to afford a home that is currently listed at {price}");
        }
    }
}
