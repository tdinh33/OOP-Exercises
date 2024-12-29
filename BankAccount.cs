namespace OOP; // A namespace to group related classes and avoid naming conflicts 

public class BankAccount
{
    // FIELDS (ENCAPSULATED DATA)
    // These fields are marked as private, meaning they cannt be accessed directly
    // from outside the class. This is a key principle of encapsulation. Other classes
    // must go through public methods to access these attributes 

    private string owner;   // Holds the name of the account owner 
    private double balance; // Holds the current balance of the bank account 


    // CONSTRUCTOR 
    // A constructor is a special method used to initialise new objects of this class 
    // It ensures that when a new BankAccount object is created, both the owner and
    // the balance fields are properly set.
    public BankAccount(string owner, int startingBalance)
    {
        // We assign the provided owner to the private owner field. 
        // For the balance, we use Math.Max to ensure the starting balance never goes below zero. 
        this.owner = owner;
        this.balance = Math.Max(startingBalance, 0);
    }


    // GETTER METHODS 
    // These methods provide controlled access to the private fields 
    // They return the values of the private fields without directly exposing them 
    // This allows other classes to read these values while maintaining encapsulation 
    public string GetOwner()
    {
        // Returns the name of the owner as a string 
        return owner;
    }

    public double GetBalance()
    {
        // Returns the current balance as a double 
        return balance;
    }


    // DEPOSIT METHODS
    // This method allows money to e added to the account. It accepts a positive amount
    // and increases the balance by that amount, then returns the amount deposited.
    // If the amount is not positive (e.g., negative or zero), it does nothing and returns 0
    public double Deposit(double amt)
    {
        if (amt > 0)
        {
            this.balance = this.balance + amt;
            return amt;
        }

        return 0;
    }

    // WITHDRAW METHOD
    // This method allows money to be withdrawn from the account. It checks if there is
    // enough balance to cover the withdrawal. If yes, it subtracts the amount from the
    // balance and returns the amount withdrawn. Otherwise, it returns 0.
    public double Withdraw(double amt)
    {
        if (amt <= this.balance)
        {
            this.balance = this.balance - amt;
            return amt;
        }

        return 0;
    }
}

/* 
CLASS: 
-  The 'BankAccount' class acts as a blueprint. It defines what data (owner, balance) and 
behaviours (Withdraw, Deposit) a bank account object should have.
 
OBJECT:
- When you create an instance of BankAccount, e.g.:
BankAccount account = new BankAccount("Alice", 1000); 
'account' is the object. It has a specific owner ("Alice") and a starting balance (1000).

PROPERTIES / FIELDS:
- owner and balance are fields (private data) that hold the state of the object. They are encapsulated, 
meaning no direct external access is allowed.

METHODS:
- GetOwner(), GetBalance(), Deposit(), Withdraw() are methods that define the object's behaviour. 
They give controlled acess to data (such as reading the balance) and define the logic for modifying the state 
(such as changing the balance during deposit or withdrawal).

ENCAPSULATION: 
- By marking the fields owner and balance as private, we prevent direct external manipulation. 
Instead, external code must use methods like Deposit() and Withdraw() to change the balance. 
This allows the class to maintain control over how its data is changed and ensure data integrity. 

ABSTRACTION:
- We provide a simple interface for interacting with the account: we can deposit, wwithdraw, and check the balance of the owner. 
We do not need to know the internal workings, like whether there's logic preventing negative balances. This complexity is hidden. 

STATIC vs NON-STATIC
- All members here are non-static. They belong to instances of BankAccount, not to the class itself.

 
*/