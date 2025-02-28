﻿using LR1;
using System.Diagnostics;


Console.WriteLine("Первое задание: ");

Student people = new Student();
Console.WriteLine(people.ToShortString());
Console.WriteLine();

Console.WriteLine("Второе задание:");

Console.WriteLine(people[Education.Bachelor]);
Console.WriteLine(people[Education.SecondEducation]);
Console.WriteLine(people[Education.Specialist]);
Console.WriteLine();

Console.WriteLine("Третье задание: ");

people.Datastudent.Surname = "Горохов";
people.Datastudent.Name = "Андрей";
people.Datastudent.Datetime = new DateTime(2002, 7, 9);
people.Dataeducation = Education.Bachelor;
people.DataGroup = 31;
Console.WriteLine(people.ToString());

Exam[] e = new Exam[1];
e[0] = new Exam();
people.AddExams(e);
Console.WriteLine(people.ToString());


Console.WriteLine();
Console.WriteLine("Четвертое задание:");
Console.WriteLine();
Console.WriteLine();

Exam[] ex = new Exam[4];
ex[0] = new Exam();
ex[1] = new Exam("Физика", 4, new DateTime(2022, 6, 22));
ex[2] = new Exam("Английский Язык", 3, new DateTime(2022, 6, 24));
people.AddExams(ex);

for (int i = 0; i < people.Dataexams.Length; i++)
{
    Console.WriteLine(people.Dataexams[i]);
}

Console.WriteLine();

Console.WriteLine("Пятое задание:");
Console.WriteLine();
{
    Console.Write("Введите количество строк: ");
    int nrow = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int ncolumn = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Stopwatch stopwatch1 = new Stopwatch();
    Stopwatch stopwatch2 = new Stopwatch();
    Stopwatch stopwatch3 = new Stopwatch();

    Exam[] exams1 = new Exam[nrow * ncolumn]; // одномерный массив
    for (int i = 0; i < nrow * ncolumn; i++)
    {
        exams1[i] = new Exam();
    }

    stopwatch1.Start(); // засекаем время для одномерного массива
    for (int i = 0; i < nrow * ncolumn; i++)
    {
        exams1[i].Subject = "Русский язык";
    }
    stopwatch1.Stop();
    Console.WriteLine($"Время выполнения одномерного массива: {stopwatch1.Elapsed}");

    Exam[,] exams2 = new Exam[nrow, ncolumn]; // двумерный массив
    for (int i = 0; i < nrow; i++)
    {
        for (int j = 0; j < ncolumn; j++)
        {
            exams2[i, j] = new Exam();
        }
    }

    stopwatch2.Start(); // засекаем время для двумерного массива
    for (int i = 0; i < nrow; i++)
    {
        for (int j = 0; j < ncolumn; j++)
        {
            exams2[i, j].Subject = "Русский язык";
        }
    }
    stopwatch2.Stop();
    Console.WriteLine($"Время выполнения двумерного массива: {stopwatch2.Elapsed}");


    Exam[][] exams3 = new Exam[nrow][]; // зубчатый массив
    for (int i = 0; i < nrow; i++)
    {
        exams3[i] = new Exam[ncolumn];
    }

    for (int i = 0; i < nrow; i++)
    {
        for (int j = 0; j < ncolumn; j++)
        {
            exams3[i][j] = new Exam();
        }
    }

    stopwatch3.Start();
    for (int i = 0; i < nrow; i++)
    {
        for (int j = 0; j < ncolumn; j++)
        {
            exams3[i][j].Subject = "Русский язык";
        }
    }
    stopwatch3.Stop();
    Console.WriteLine($"Время выполнения зубчатого массива: {stopwatch3.Elapsed}");
    
}