﻿Console.Write ("Введите имя пользователя: "); 
string username = Console.ReadLine (); 

if (username.ToLower() == "tom")
{
Console.WriteLine ("Салют!");
    }
else 
{
    Console.Write("Привет, ");
    Console.WriteLine (username);

}