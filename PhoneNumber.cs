using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

public class PhoneNumber
{
    private int countryCode;
    private string phoneNumber;

    public PhoneNumber(string phoneNumber)
    {
        if (phoneNumber.Length > 10)
        {
            this.countryCode = int.Parse(phoneNumber.Substring(0, phoneNumber.Length - 10));
            this.phoneNumber = phoneNumber.Substring(phoneNumber.Length - 10);
        }
        else
        {
            this.countryCode = 1;
            this.phoneNumber = phoneNumber;
        }
    }

    public PhoneNumber(int countryCode, string phoneNumber)
    {
        this.countryCode = countryCode;
        this.phoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"PhoneNumber{{countryCode={countryCode}, phoneNumber='{phoneNumber}'}}";
    }
}
