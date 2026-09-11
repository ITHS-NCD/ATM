using WestCoastBank;

namespace ATM;

class Program
{
    // Används vid constructors
    // static Account account = new Account("1234-5678");

    //Använd vid objekt initiering 
    // static Account account = new(){accountNumber = "1234-5678"};
    static Account account = new("1234-5678"){};
    


    static void Main()
    {
        account.FirstName = "Alfred";
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("För att sätta in pengar, tryck på tangenten 'd'");
        Console.WriteLine("För att ta ut pengar, tryck på tangenten 'w'");
        Console.WriteLine("För att se saldo, tryck på tangenten 'b'");
        Console.WriteLine("För att se transaktionerna, tryck på tangenten 't'");
        Console.WriteLine("För att avsluta, tryck på tangenten 'x'");
        Console.WriteLine("-----------------------------------------------------");

        App();
    }
    
    
    static void App()
    {
        try
        {
            
            while (true)
            {
                var key = Console.ReadLine();
                // Console.WriteLine($"Användaren tryckte på tangenten {key}");

            if (string.IsNullOrWhiteSpace(key))
            {
                continue;
                throw new Exception("Du måste välja en knapp för de olika menyerna");
            }

            if (key == "x")
                {
                    Console.WriteLine("Välkommen åter! Stänger ner bankomaten");
                    Environment.Exit(0);        
                }
            

            switch (key)
            {
                case "b":
                    DisplayBalance();
                    break;
                
                case "t":
                    DisplayTransactions();
                    break;
                
                case "d":
                    Console.WriteLine("Hur mycket vill du sätta in?");
                    var amount = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(amount))
                    {
                        throw new Exception("Du måste ange ett heltalsvärde");
                    }
                    if (!int.TryParse(amount, out int result))
                    {
                        throw new Exception("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                    }
                    Deposit(result);
                    break;
                
                case "w":
                    Console.WriteLine("Hur mycket vill du ta ut?");
                    amount = Console.ReadLine();
                
                    if (string.IsNullOrWhiteSpace(amount))
                    {
                        throw new Exception("Du måste ange ett heltalsvärde");
                        
                    }
                    if(!int.TryParse(amount, out int value))
                    {
                        throw new Exception("Du måste ange ett heltalsvärde för att jag ska kunna förstå!");
                    }
                    Withdraw(value);
                    break;

                default:
                    continue;
                    throw new Exception($"Du måste välja en knapp för de olika menyerna");  
                    
            }
                Console.WriteLine("Klicka på en knapp från menyn för att fortsätta");
            }
                
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
                    
        }
        finally
        {
            Console.WriteLine("Stänger ner bankomaten");
        }
    }
   

    // static void transactionsAdd(List<string> transactions = new List<string>())
    // {
    //     transactions.Add();
    // }



    static void Deposit(int amount)
    {
        
        account.Deposit(amount);
    }

    static void Withdraw(int amount)
    {
            account.Withdraw(amount);
    }
    
    static void DisplayBalance()
    {
        Console.WriteLine($"Ditt nuvarande saldo: {account.Balance}");
    }
    static void DisplayTransactions()
    {
        Console.WriteLine("Dina transaktioner:");
        foreach(var transaction in account.Transactions)
        {
            Console.WriteLine(transaction.ToString());
        }
    }


}
