
using System;

class Person
{
    private string name = "Nguyen Van Bao";
    protected int age = 19;
    internal string address = "Da Nang";

    public void ShowInfo()
    {
        Console.WriteLine("Ho ten: " + name);
        Console.WriteLine("Tuoi: " + age);
        Console.WriteLine("Dia chi: " + address);
    }
}

class Student : Person
{
    public void TestAccess()
    {
        Console.WriteLine("Tuoi: " + age);
        Console.WriteLine("Dia chi: " + address);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.ShowInfo();
        Console.WriteLine("\n");
        Student st = new Student();
        st.TestAccess();
    }
}
