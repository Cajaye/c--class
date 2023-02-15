using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal static class Program
{
    public static void Main(string[] args)
    {

    }

    public static void Question1()
    {
        Console.WriteLine("Enter your Salary");
        double salary = Convert.ToDouble(Console.ReadLine());
        double taxRate = 0, netIncome = 0;

        if (salary >= 0 && salary <= 800000)
        {
            taxRate = 0;
        }
        else if (salary >= 800000 && salary <= 6000000)
        {
            taxRate = 0.25;
        }
        else if (salary > 6000000)
        {
            taxRate = 0.3;
        }

        double incomeTax = taxRate * salary;
        netIncome = salary - incomeTax;

        Console.WriteLine("Your income tax is: {0} and net income is {1}", incomeTax, netIncome);
    }

    public static void Question2()
    {
        Console.WriteLine("Enter an integer");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 12 == 0)
        {
            Console.WriteLine("{0} is directly divisible by 3 and 4", num);
        }
        else
        {
            Console.WriteLine("{0} is not what you are looking for!", num);
        }
    }

    public static void Question3()
    {
        Console.WriteLine("Enter vacation type");
        char vacType = Convert.ToChar(Console.ReadLine());

        if (char.ToUpper(vacType) == 'C')
            Console.WriteLine("Cruise");
        else if (char.ToUpper(vacType) == 'H')
            Console.WriteLine("Hotel");
        else if (char.ToUpper(vacType) == 'F')
            Console.WriteLine("Flight");
        else
            Console.WriteLine("Invalid");

        switch (char.ToUpper(vacType))
        {
            case 'C':
                Console.WriteLine("Cruise");
                break;
            case 'H':
                Console.WriteLine("Hotel");
                break;
            case 'F':
                Console.WriteLine("Flight");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }

    public static void Question4()
    {
        Console.WriteLine("Enter height and width of vehicle in metres");
        double height = Convert.ToDouble(Console.ReadLine());
        double length = Convert.ToDouble(Console.ReadLine());
        string vehClass = "";

        if (height < 1.7)
        {
            vehClass = "Class 1";
        }
        else if (height >= 1.7 && length < 5.5)
        {
            vehClass = "Class 2";
        }
        else
        {
            vehClass = "Class 3";
        }

        Console.WriteLine("Vehicle class is: {0}",vehClass);
    }

    public static void Question5()
    {
        Console.WriteLine("Enter an integer");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an code for conversion");
        Console.WriteLine("Code A for Kilogram to Pounds");
        Console.WriteLine("Code B for Pounds to Kilogram");
        char code = Convert.ToChar(Console.ReadLine());
        double conversion = 0;

        if (char.ToUpper(code) == 'A')
        {
            conversion = num * 2.2;
            Console.WriteLine("{0} kg in lbs is {1}",num,conversion);
        }
        else if(char.ToUpper(code) == 'B')
        {
            conversion = num * 0.45359237;
            Console.WriteLine("{0} lbs in kg is {1}",num,conversion);
        }
        else
        {
            Console.WriteLine("Invalid code entered");
        }
    }

    public static void Question6()
    {
        Console.WriteLine("Enter a letter in the alphabet: ");
        char letter = Convert.ToChar(Console.ReadLine());

        switch (char.ToUpper(letter))
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("The letter {0} is a vowel", letter);
                break;
            default:
                Console.WriteLine("The letter {0} is not a vowel", letter);
                break;
        }
    }

    public static void Question7()
    {
        Console.WriteLine("Enter students grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade > 0 && grade <= 100)
        {
            if (grade >= 50)
                Console.WriteLine("Student passed");
            else
                Console.WriteLine("Student failed");
        }
        else
        {
            Console.WriteLine("Invalid grade entered");
        }
    }

    public static void Question8()
    {
        Console.WriteLine("Enter employee's name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter hours employee worked: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter employee's code P for part-time F for full-time or C for contract : ");
        char code = Convert.ToChar(Console.ReadLine());

        double pay = 0;

        switch (char.ToUpper(code))
        {
            case'P':
                pay = hours * 2000;
                break;
            case'F':
                pay = hours * 3000;
                break;
            case 'C' when(hours > 12):
                pay = hours * 4000;
                break;
            case 'C':
                pay = hours * 250;
                break;
            default:
                Console.WriteLine("Invalid code");
                break;
        }

        Console.WriteLine("{0} worked {1} hours and their pay is {2} ", name, hours, pay);
    }

    public static void Question9()
    {
        int answer = 17;
        Console.WriteLine("Guess a number from 1-20");
        int guess = Convert.ToInt32(Console.ReadLine());

        if (guess <= 0 || guess > 20)
        {
            Console.WriteLine("Game Over!");
        }
        else if(guess > answer)
        {
            Console.WriteLine("Too high!");
        } else if (guess < answer)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the number");
        }
    }
}