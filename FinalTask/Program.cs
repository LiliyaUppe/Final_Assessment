// написать программу которая из имеющегося массива строк 
//формирует массив из строк длина которых <= 3 символа.


// Метод считывания данных пользователя
string[] ReadData(string line)
{
    Console.WriteLine(line);
    string inputLine = Console.ReadLine() ?? "0";
    string[] array = inputLine.Split(",");
    return array;
}

// Печать результата
void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        Console.Write(newArray[i] + ",");
    }
    Console.WriteLine(newArray[newArray.Length - 1]);
}

//метод удаления пробелов 
string[] DeleteSpace(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i].Trim();
    return newArray;
}

// метод генерации и заполнения массива
string[] GenArray(string[] newArray)
{
    string[] newArray2 = new string[newArray.Length]; //создаем новый массив
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)  //заполняем массив
    {
        if (newArray[i].Length <= 3) //условие включения элемента в новый массив
        {
            newArray2[count] = newArray[i];
            count++;
        }
    }
    return newArray2;
}


string[] array = ReadData("Input word, numbers or symbols with tail");
string[] newArray = DeleteSpace(array); 
string[] newArray2 = GenArray(newArray);
PrintArray(newArray2);
