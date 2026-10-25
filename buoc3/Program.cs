using System;
class Student
{
    private string name="";
    private int age;
    
    public string Name
    {
        get {return name;}
        set{name= value;}
    }
    public int Age
    {
        get{return age;}
        set
        {
            if (value >=18)
                age = value;

            else 
            Console.WriteLine("Tuoi phai lon hon 18");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Ten: "+Name);
        Console.WriteLine("Tuoi: "+Age);
    }
}
class Program
{
    static void Main()
    {
        Student st = new Student();
        st.Name= "Nguyen Van Bao";
        st.Age=19;
        st.DisplayInfo();
          st.Age=17;
          st.DisplayInfo();
    }
}