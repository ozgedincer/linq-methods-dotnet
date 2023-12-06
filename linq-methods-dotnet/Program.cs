using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Schema;
using linq_methods_dotnet;


int[] num1 = { 1, 2, 3, 4, 5, 6 };

int[] num2 = { 7, 8, 9, 1, 2, 3 };

//Concat: iki dizeyi birleştirir
var combinedNumbers = num1.Concat(num2);

//Distinct: tekrar eden değerleri kaldırır
var distinctNumbers = combinedNumbers.Distinct();

//Skip: belirli bir sayı kadar elemanı atlayarak alır
var skippedNumbers = distinctNumbers.Skip(2);

//Take: belirli bir sayıda elemanı alır
var takenNumbers = skippedNumbers.Take(3);

//Average: ortalamasını hesaplar
double average = takenNumbers.Average();

Console.WriteLine("Birleştirilmiş ve benzersiz değerler: " + string.Join(", ", distinctNumbers));
Console.WriteLine("İlk 2 benzersiz değer atlandı: " + string.Join(", ", skippedNumbers));
Console.WriteLine("Son 3 değer alındı: " + string.Join(", ", takenNumbers));
Console.WriteLine("Alınan değerlerin ortalama: " + average);

List<Student> student = new List<Student>
{
    new Student { Name = "Ahmet", Age = 22 },
    new Student { Name = "Ayşe", Age = 27 },
    new Student { Name = "Mehmet", Age = 32 },
    new Student { Name = "Zeynep", Age = 37 },
    new Student { Name = "Can", Age = 42 }
};

var personAtIndex = student.ElementAt(2); 

var groupedByAge = student.GroupBy(student => student.Age);

var lastPerson = student.OrderBy(student => student.Age).Last(); 

var maxAge = student.Max(student => student.Age);

