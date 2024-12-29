using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

public class Contact
{
    private string name;
    private PhoneNumber phoneNumber;
    private string emailAddress;

    public Contact(string name, PhoneNumber phoneNumber, string emailAddress)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.emailAddress = emailAddress;
    }

    public Contact(string name, PhoneNumber phoneNumber)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
    }

    public Contact(string name, string emailAddress)
    {
        this.name = name;
        this.emailAddress = emailAddress;
    }

    public override string ToString()
    {
        return $"Contact{{name='{name}', phoneNumber={phoneNumber}, emailAddress='{emailAddress}'}}";
    }
}