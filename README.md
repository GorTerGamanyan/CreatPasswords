CreatPasswords

This code generates several types of passwords, there is a possibility to specify how many characters should be, so you can choose from several methods you more convenient it is: CrearPassByDigitsLetterSymbol, CreatePassByLetter, CreatePassByDigits, CreatePassByDigitsAndLetter - the names speak for themselves. Everything is very simple.

Example:
```C#
using System;

using System.Text;

using CreatPasswords;

namespace XXXXXX

{

class Program

    {

    static void Main(string[] args)

        {

        var pass = PasswordGenerate.CrearPassByDigitsLetterSymbol(5);  // it will be a 5-digit code with the letters numbers and symbols

        }

    }

}

```
