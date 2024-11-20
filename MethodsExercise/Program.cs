namespace MethodsExercise
{
    public class Program
    {
        public static void MadLibInteraction()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, where are you from?");
            string location = Console.ReadLine();
            Console.WriteLine($"Does living in {location} affect your coding ability, {name}?");
            string codingAbility = Console.ReadLine();
            Console.WriteLine($"I see. Do you need any assistance?");
            string assistance = Console.ReadLine();
            Console.WriteLine($"Goodbye, {name}");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        
        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        
        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        static void Main(string[] args)
        {
            MadLibInteraction();
            Console.WriteLine(Add(8, 2));
            Console.WriteLine(Subtract(8, 2));
            Console.WriteLine(Multiply(8, 2));
            Console.WriteLine(Divide(8, 2));
        }
        
        
    }
    
}
    

