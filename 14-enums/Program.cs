Console.WriteLine(Month.January); // January
Console.WriteLine((int) Month.January); // 0

Console.WriteLine((int)Month2.FEB); // 11
Console.WriteLine(Month2.FEB.ToString()); // FEB

var d = (DAY.SATURDAY | DAY.SUNDAY);
Console.WriteLine(d.HasFlag(DAY.WEEKEND));

var theDay = "FEB";
Console.WriteLine((int) Enum.Parse(typeof(Month2), theDay)); // 11

var dayNumber = 11;
Console.WriteLine((Month2)dayNumber);

foreach ( var month in Enum.GetNames(typeof(Month2)) )
{
    Console.WriteLine($"{month} = {(int) Enum.Parse(typeof(Month2), month)}");
};


// Enum is value type
// it is good for readability and code calrity
enum Month
{
    January, // 0
    February, // 1
    March //1
};


// OR 
enum Month2
{
    JAN = 10,
    FEB,   // 11
    MAR,  // 12
}

// you can set the type of the enum 
enum Month3 : long
{
    JAN = 1234566,
}

// the last enums were simple enums

// the next enums ar flags enums
// the values are the binary numbers in c#
[Flags]
enum DAY 
{ 
    NONE        = 0b_0000_0000, // 0
    MONDAY      = 0b_0000_0001, // 1
    TUESDAY     = 0b_0000_0010, // 2
    WEDNESDAY   = 0b_0000_0100, // 4
    THURSDAY    = 0b_0000_1000, // 8
    FRIDAY      = 0b_0001_0000, // 16
    SATURDAY    = 0b_0010_0000, // 32
    SUNDAY      = 0b_0100_0000, // 64
    WEEKEND     = SATURDAY | SUNDAY, // 0b_0110_0000
    BUSINESSDAY = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,

}

// another example of enum
public enum AccessRights
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    ReadWrite = Read | Write,
    All = Read | Write | Execute
}

// why we did not use 3 in the last exmaple
/*
    The reason why 3 is not used as an individual value in this case is because it is not a 
    power of 2. 
    If you were to use 3 as an individual value and then try to combine it with other 
    values using bitwise OR, the resulting value might not be unique, 
    because it could be represented by the same bits as some other combination of values.
 */