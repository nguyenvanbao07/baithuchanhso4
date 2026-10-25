using System;
class BankAccount
{
    private string accountnumber;
    private double balance;
    public string AccountNumber
{
    get {return accountnumber;} 
}
public double Balance
{
    get{return balance;}
    set
    {
        if(value>=50000)
            balance= value;
        else Console.WriteLine("So du phai >= 50000 ");
    }
}
public BankAccount(string accountnumber, double balance)
{
    this.accountnumber= accountnumber;
    if(balance>=50000)
        this.balance= balance;
    else
    {
        this.balance=50000;
        Console.WriteLine("So du ban dau khong hop le da dat ve 50000");
    }
}
public void Deposit(double amount)
{
    if(amount<=0)
    {
        Console.WriteLine("SO tien gui phai lon hon 0");
        return;
    }
    Balance = balance + amount;
    Console.WriteLine("Gui tien thanh cong");
    Console.WriteLine("So du hien tai: "+ Balance);
}
public void Withdraw(double amount)
{
    if(amount<=0)
    {
        Console.WriteLine("So tien rut phai lon hon 0");
        return;
    }
    if (amount>balance)
    {
        Console.WriteLine("So du khong du de rut");
        return;
    }
    if (balance -amount< 50000)
    {
        Console.WriteLine("so du sau khi rut khong duoc duoi 50000");
        return;
    }
    Balance= balance- amount;
    Console.WriteLine("Rut tien thanh cong");
    Console.WriteLine("So du hien tai: "+ Balance);

}
}
class Program
{
    static void Main()
    {
        BankAccount acc= new BankAccount("123456", 100000);
        Console.WriteLine("So tai khoan: "+ acc.AccountNumber);
        Console.WriteLine("So du ban dau: "+ acc.Balance);
        Console.WriteLine("-GUI TIEN-");
        acc.Deposit(50000);
        Console.WriteLine("-Rut tien-");
        acc.Withdraw(20000);
        Console.WriteLine("-Rut qua so du-");
        acc.Withdraw( 600000);
        Console.WriteLine("So du cuoi cung: " + acc.Balance);
        
    }
}