namespace _15_inheritance
{
    // why inheritance
    // 1- Resuablitiy
    // 2- Maintanablitiy
    // 3- Extensiability
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class Animal 
        { 
        }

        // class eagle can access (public and protected) in Animal class
        class Eagle : Animal 
        {
        }

        // limitations : class can inherit only one class

        // in C#
        // there is upcasting and downcasting
        // upcasting to the parent class, downcasting to the subclass
        // upcasting when you 
        /*
            class Animal { }
            class Dog : Animal { }

            Dog dog = new Dog();
            Animal animal = dog; // upcasting (creatting new Animal instance and upcasting it)
        // upcatsed because we put (subclass instance) in parent class
         */

        /*
            class Animal { }
            class Dog : Animal { }

            Animal animal = new Dog();
            Dog dog = (Dog)animal; // downcasting
                // creating new Dog class instance and downcasting it
         */

        // Falcon f = a as Falcon;
        /*
         In C#, the line "Falcon f = a as Falcon;" is attempting to perform an "as" type 
           conversion on an object "a" and assign it to a variable of type "Falcon" named "f".

         The "as" keyword is used for safe type casting in C#. 
        It checks if the object on the left-hand side of the "as" keyword is compatible with 
        the type on the right-hand side, and if so, it returns the object cast as that type. 
        If the object is not compatible with the type, it returns null.

         So, in this specific line of code, if "a" is already an instance of the "Falcon" class 
        or a subclass of "Falcon", then "f" will be assigned the value of "a" cast as "Falcon". 
        If "a" is not a "Falcon" object or a subclass of "Falcon", then "f" will be assigned 
        the value of null.

         Overall, this line of code is trying to assign a variable of type "Falcon" to an 
        object "a", but it is performing a safe type casting to ensure that the conversion is 
        possible and does not result in any errors.
         */

        // check type
        // if (a is Falcon) 
        // The is operator is used to determine if a is an instance of
        // the Falcon class or a class derived from it.

        // abstract class
        // to inherit from , but you can not instance objects from it 

        // sealed class
        // class you can not inherit from 
        /*
         * sealed class SealedClass {}
         
         */

        /*
         * to be able to override methods in inheritance you have to use virtual
         * public virtual void Move(){ Console.WriteLine('1')}
         * 
         * and in subclass
         * public overrid Move(){
         *  base.Move();
         *  Console.WriteLine('a')
         * }
         * 
         * Move() //
         * -- 1
         * -- a
         * 
         * In C#, the keyword "base" is used to refer to the base class of a derived class.
         * 
         * notice that you may need to use "virtual" instaed of override in case if you want to
         * the subclass of the subclass to also override the method
         */

        // abstract method has no body
        // like that public void move()

        // sealed Member
        // public sealed override void move()
        // no one can inherit this method

        // if object has no parent 
        // then his parent Object class
        // class Animal {} = class Animal: Object {}
        // Object  has its own methods like ToString() and you can override it if you want

        // constructor is not automatically inherited

        // public SubClass(int scValue) : base(scValue)
        // this code is passing value to the constructo of the class and the constructor '
        // of the parent
        // the parent fisrt
    }
}