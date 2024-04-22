﻿using System;

namespace ExtentionOverloadingMethods
{
   internal class Program
   {
      static void Main(string[] args)
      {
         PersonModel person = new PersonModel();

         person.FirstName = "What is your first name: ".RequestString();

         person.LastName = "What is your last name: ".RequestString();

         person.Age = "What is your age: ".RequestInt(0, 120);
         // You can do
         //person.Age = ConsoleHelper.RequestInt("What is your age: ", 0, 120);

         Console.ReadLine();
      }
   }
}
