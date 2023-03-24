namespace _13_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /* comparsion        --               class     struct
     * user defined type                  true      true
     * 
     * constructor                        true      true
     * 
     * paramelteless constructor          true      false
     * --notice: in struct there is empty constructor but you can write it by code
     * if you do not want parameter in constructor, just do not write constructor
     * 
     * has fields                         true      true
     * -- but in construct you can not say //private string name = 'amr';
     * -- you can only say //string name = 'amr';
     * -- so there is no initialization unless you have a constructor
     * 
     * support event                      true      true
     * 
     * support method                     true      true
     * 
     * finializer                         true      false
     * 
     * support(protected and virtual)     true      false
     * 
     * support inheritance                true      false
     * 
     * impliciltly inherit object class   true      true
     * 
     * value semantic(value type)                    false     true
     * -- value type is stored in stack in memory (faster access)
     * -- so that it should be small (not more than 16bytes)
     *
     * new() is mandatory (to craete new) true      false
     * -- in struct => you can make
     */


    /*
     * if you wrote this code
     * Student std = new Student();
     * Console.WriteLine(std.GetId());
     * will print (0) because it is the default value of int
     
     */
    struct Student {
        private int id = 0;

        public int GetId() { return id; }

        public Student(int id) {
            this.id = id;
        }
    }

    /* you can have readonly struct */
    // then compiler will force you to declare all fields as readonly
    // you still can set fields by constructor (only way)
    readonly struct User {
        readonly int id;

        public User(int id) {
            this.id = id;
        }
    }

    /** --notice: if you set fields in constructor you can chnage it in another method **/
    struct Bank {
        int id;
        Bank(int id) {
            this.id = id;
        }
        
    }

    // notice that struct is value type so when you edit it, you have new value

    // c# has built in struct called DateTime() you can use it to build date

    // all primitive types except string in c# is a struct 
    // string is class

}