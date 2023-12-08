public class BankAccount
{
    private string acc_number;
    private decimal balance = 0;

    public BankAccount(string account_Number, decimal balance)
    {
        this.acc_number = account_Number;
        this.balance = balance;

        Console.Write( account_Number + " is your Account Number and" +balance+ "is your  current balance");
    }

    public decimal Deposite(decimal amt)
    {
        Console.WriteLine("Rs" + amt + "has been deposited in your account");
        return balance += amt;
    }

    public decimal Withdraw(decimal amt)
    {
        Console.WriteLine("Rs" + "has been withdraw from your account");
        return balance += amt;
    }

    public decimal Total_Balance()
    {
        Console.WriteLine(balance+ " is your final balance.");
        return balance;
    }
}