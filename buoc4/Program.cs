using System;
class Product
{
    private string name="";
    private double price;
    public string Name
    {
        get {return name;}
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            name ="";
            else
            {
                string s= value.Trim();
                name= char.ToUpper(s[0]) +s.Substring(1);
            }
        }
    }
    public double Price
    {
        get {return price;}
        set
        {
            if(value<0)
            {
                price=0;
                Console.WriteLine("Gia khong hop le, dat ve 0");
            }
            else price = value;
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Ten san pham: "+Name);
        Console.WriteLine("Gia san pham: "+Price);
    }
}
class Program
{
    static void Main()
    {
        Product p= new Product();
        p.Name="Laptop";
        p.Price=20000000;
        
        p.DisplayInfo();
        p.Price= -100000;
        p.DisplayInfo();
    }
}
