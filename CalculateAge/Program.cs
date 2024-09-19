using System;

class Program
{
    static void CalculateAge(DateTime BirthDateInput, out int age)
    {
        //
        age = DateTime.Now.Year - BirthDateInput.Year;
        if (DateTime.Now < BirthDateInput.AddYears(age))
        {
            age--;
        }
    }

    static void Main(string[] args)
    {
        var date = new DateTime(1999, 10, 28);
        CalculateAge(date, out int age);
        Console.WriteLine($"Age: {age}");
    }
}