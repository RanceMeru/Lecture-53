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

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and my final grade is {finalGrade}.");
    }
}