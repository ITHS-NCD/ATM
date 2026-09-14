namespace WestcoastBank;

public class SavingsAccount(string accountNo, string fName, string lName) : Account(accountNo, fName, lName)
{
    // // Det gamla sättet att överföra information till basklassen (Account)
    // public SavingsAccount(string accountNo) : base(accountNo)
    // {

    // }

    public override int Balance => base.Balance + 10;
    // public override int Balance
    // {
    //     get
    //     {
    //         return base.Balance + 100;    
    //     }
    // }
    public double InterestRate { get; set; }

    // public override void Deposit(int amount)
    // {
    //     AddTransaction(amount, TransactionTypeEnum.Insättning);
    // }
    public void CalculateInterest()
    {
        
    }
}
