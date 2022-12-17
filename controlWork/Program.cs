﻿/*написать программу, которая из имеющегося масссива строк формирует массив из строк, длина которых меньше или равна 3 символа.*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

string[] InitArray(int n)
{
    string[] tempArray = new string[n];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = Console.ReadLine();
    }
    return tempArray;
}

int GetResultArrayLength(string[] tempArray)
{
    int resultArrayLength = 0;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        if (tempArray[i].Length <= 3) resultArrayLength++;
    }
    return resultArrayLength;
}

string[] InitResultArray(string[] inputArray, int n)
{
    string[] tempArray = new string[n];
    int k = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if(inputArray[i].Length <= 3)
        {
            tempArray[k] = inputArray[i];
            k++;
        }
    }
    return tempArray;
}

void PrintArray(string[] tempArray)
{
    Console.Write("[");
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        if (i < tempArray.GetLength(0) - 1) Console.Write($"\"{tempArray[i]}\", ");
        else Console.Write($"\"{tempArray[i]}\"");
    }
    Console.WriteLine("]");
}

int startArrayLength = GetNumber("Введите длину начального массива ");
string[] startArray = InitArray(startArrayLength);
int newArrayLength = GetResultArrayLength(startArray);
string[] resultArray = InitResultArray(startArray, newArrayLength);
PrintArray(resultArray);
