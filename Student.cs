class Student
{
  
    private int age;
    private string name;
    private double finalGrade;

    public Student(string name, int age, double finalGrade)
    {
        this.name = name;
        this.age = age;
        this.finalGrade = finalGrade;
    }

    public Student(string name, int age) :this(name, age,0)
    {
        //this is duplicating code and we can instead use a constructor initailizer
        //allows us to call another constructor from a constructor
        //this.name = name; 
        //this.age = age;
        //using the this keyword
    }

    
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and my final grade is {finalGrade}.");
    }
}