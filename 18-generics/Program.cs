namespace _18_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // notice that the next three methods, what if i want to make the color of printing all of
        // them are red

        //static void Print(int value) 
        //{
        //    Console.WriteLine(value);
        //}
        //static void Print(string value) 
        //{
        //    Console.WriteLine(value);
        //}
        //static void Print(char value) 
        //{
        //    Console.WriteLine(value);
        //}

        // instea you can pass object in the parameter, so you can enter anything
        static void Print(object value)
        {
            Console.WriteLine(value);
        }

        // but passing object is not good, not good for performance 
        // because you pass refernce not value which take additional resources to gte the object
        // also you might chnage the satte of the object
        // also type safety problem, you can pass ANYTHING now
        

        // SO we need GENRICS
        // solve three problems 
        // 1-reusability
        // 2-type safety
        // 3-efficency

        // check chat gpt folder to know what is generics

        /*
         * static void Print<T>(T value)
         * {
         *  Console.WriteLine();
         * }
         * 
         * now if you passed integer the type will be integer , T refers to whatever the type you will
         * send to the method

         */
    }
}