﻿using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter birth date (dd-MM-yyyy):");
        String userInput = Console.ReadLine();

        DateTime birthDate = DateTime.ParseExact(userInput, "dd-MM-yyyy", null);
        DateTime userDate = birthDate.AddDays(999);
        string d = userDate.ToString("dd-MM-yyyy",
             System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine(d);
        // трябва да съм в новия клон /branch
        //отново добавям в /feature/new-branch
        //Правя изменения в главния клон /master = origin
//след конфликт
    }
}

