Console.Clear();
Console.WriteLine("Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Нажмите Enter для вывода массива.");
Console.ReadLine();

Random random = new Random();

int[] array = new int[random.Next(3,10)];

Console.Write("[");

int result=0;

for (int i=0;i<array.Length;i++){
    array[i]=random.Next(100,999); 

    if ((array[i]%2)==0){result=result+1;}

    Console.Write(array[i]);
    if (i<array.Length-1){
        Console.Write(", ");
    } else {
        Console.Write("]");}

}

Console.Write($" -> {result}");