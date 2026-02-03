using System;

namespace CsharpDay04Assignment
{

     class Program
     {
         static void Main()
         {
             #region Problem 1
             //int[] arr1 = new int[3];
             //arr1[0] = 10;
             //arr1[1] = 20;
             //arr1[2] = 30;
     
             //int[] arr2 = { 40, 50, 60 };
             //int[] arr3 = new int[] { 70, 80, 90 };
     
             //Console.WriteLine("Problem 1 Output:");
             //foreach (int value in arr1) Console.WriteLine(value);
             //foreach (int value in arr2) Console.WriteLine(value);
             //foreach (int value in arr3) Console.WriteLine(value);
             #endregion
     
             #region Problem 2
             //int[] original = { 1, 2, 3 };
             //int[] shallowCopy = original;
             //shallowCopy[0] = 100;
     
             //Console.WriteLine("Problem 2 Output:");
             //Console.WriteLine("Shallow copy changes original: " + original[0]);
     
             //int[] deepCopy = (int[])original.Clone();
             //deepCopy[1] = 200;
     
             //Console.WriteLine("Deep copy does not affect original: " + original[1]);
             //Console.WriteLine("Deep copy value: " + deepCopy[1]);
             #endregion
     
             #region Problem 3
             //int[,] grades = new int[3, 3];
     
             //for (int student = 0; student < 3; student++)
             //{
             //    Console.WriteLine($"Enter grades for student {student + 1}:");
             //    for (int subject = 0; subject < 3; subject++)
             //    {
             //        grades[student, subject] = int.Parse(Console.ReadLine());
             //    }
             //}
     
             //Console.WriteLine("Problem 3 Output:");
             //for (int student = 0; student < 3; student++)
             //{
             //    Console.Write("Student " + (student + 1) + ": ");
             //    for (int subject = 0; subject < 3; subject++)
             //    {
             //        Console.Write(grades[student, subject] + " ");
             //    }
             //    Console.WriteLine();
             //}
             #endregion
     
             #region Problem 4
             //int[] numbers = { 5, 3, 9, 1 };
     
             //Array.Sort(numbers);
             //Array.Reverse(numbers);
     
             //int index = Array.IndexOf(numbers, 3);
     
             //int[] copiedNumbers = new int[numbers.Length];
             //Array.Copy(numbers, copiedNumbers, numbers.Length);
     
             //Array.Clear(numbers, 0, 2);
     
             //Console.WriteLine("Problem 4 Output:");
             //foreach (int value in numbers) Console.WriteLine(value);
             #endregion
     
             #region Problem 5
             //int[] loopArray = { 1, 2, 3, 4 };
     
             //Console.WriteLine("Problem 5 Output - For Loop:");
             //for (int i = 0; i < loopArray.Length; i++)
             //    Console.WriteLine(loopArray[i]);
     
             //Console.WriteLine("Problem 5 Output - Foreach Loop:");
             //foreach (int value in loopArray)
             //    Console.WriteLine(value);
     
             //Console.WriteLine("Problem 5 Output - While Loop Reverse:");
             //int counter = loopArray.Length - 1;
             //while (counter >= 0)
             //{
             //    Console.WriteLine(loopArray[counter]);
             //    counter--;
             //}
             #endregion
     
             #region Problem 6
             //int number;
             //do
             //{
             //    Console.WriteLine("Enter a positive odd number:");
             //}
             //while (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number % 2 == 0);
     
             //Console.WriteLine("Problem 6 Output: " + number);
             #endregion
     
             #region Problem 7
             //int[,] matrix =
             //{
             //    {1,2,3},
             //    {4,5,6},
             //    {7,8,9}
             //};
     
             //Console.WriteLine("Problem 7 Output:");
             //for (int i = 0; i < matrix.GetLength(0); i++)
             //{
             //    for (int j = 0; j < matrix.GetLength(1); j++)
             //    {
             //        Console.Write(matrix[i, j] + "\t");
             //    }
             //    Console.WriteLine();
             //}
             #endregion
     
             #region Problem 8
             //Console.WriteLine("Enter a month number:");
             //int month = int.Parse(Console.ReadLine());
     
             //if (month == 1)
             //    Console.WriteLine("January");
             //else if (month == 2)
             //    Console.WriteLine("February");
             //else
             //    Console.WriteLine("Other");
     
             //switch (month)
             //{
             //    case 1: Console.WriteLine("January"); break;
             //    case 2: Console.WriteLine("February"); break;
             //    default: Console.WriteLine("Other"); break;
             //}
             #endregion
     
             #region Problem 9
             //int[] searchArray = { 4, 1, 7, 1, 9 };
     
             //Array.Sort(searchArray);
     
             //int firstIndex = Array.IndexOf(searchArray, 1);
             //int lastIndex = Array.LastIndexOf(searchArray, 1);
     
             //Console.WriteLine("Problem 9 Output:");
             //Console.WriteLine("First Index: " + firstIndex);
             //Console.WriteLine("Last Index: " + lastIndex);
             #endregion
     
             #region Problem 10
             //int[] sumArray = { 1, 2, 3, 4 };
             //int sumFor = 0;
             //int sumForeach = 0;
     
             //for (int i = 0; i < sumArray.Length; i++)
             //    sumFor += sumArray[i];
     
             //foreach (int value in sumArray)
             //    sumForeach += value;
     
             //Console.WriteLine("Problem 10 Output:");
             //Console.WriteLine("Sum using for: " + sumFor);
             //Console.WriteLine("Sum using foreach: " + sumForeach);
             #endregion
         }
     }
}
