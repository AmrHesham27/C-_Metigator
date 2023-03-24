namespace _17_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Vehicle 
    {
        public int Id { get; set; }
    }

    // best practices that name of interface starts with I
    interface ILoader 
    {
        const int Price = 1000;
        void Load();
        void Unload();
    }

    interface IMachine 
    {
        void ConsumeOil();
    }

    // notice tat you inhrited form one abstract class , you can inherit from many
    // class can inherit from only one class and many interfaces
    class Honda : Vehicle, ILoader, IMachine 
    {
        public void Load() 
        {
            Console.WriteLine("Load");
        }

        public void Unload()
        {
            Console.WriteLine("UnLoad");
        }

        public void ConsumeOil()
        {
            Console.WriteLine("oil...");
        }


        // there are two ways to apply interface, implicit and explicit
        // Implicit is like we already saw
        // explicit is like what you will see
        interface IX 
        {
            void Letter();
        }

        interface IY
        {
            void Letter();
        }

        // here is explicit ,we have the same method in the two interfaces
        // so we needed explicit, and we needed the two methods IX.Letter, IY.Letter

        class XY : IY, IX 
        {
            void IX.Letter() { Console.WriteLine("xxxxx"); }
            void IY.Letter() { Console.WriteLine("xxxx"); }
        }


        // Tight coupling vs Loose coupling 
        /*
        tight coupling when you depened on certain class 
        while loose coupling is when you depend on interface 
        so you can use any class that use the methods in the interface
        .. in the constructor 
        public Constructor (Interface class)
        so you tell the constructor you will accept any class that follow the interface
         
         */
    }
}