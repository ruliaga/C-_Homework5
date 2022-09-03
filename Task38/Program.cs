Console.Clear();

Console.WriteLine("Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("----------------------------------------");

Console.WriteLine("Нажмите Enter для вывода массива.");
Console.ReadLine();

Random random = new Random();

int[] array = new int[random.Next(4,7)];

Console.Write("[");

int min=100;
int max=0;

for (int i=0;i<array.Length;i++){
    array[i]=random.Next(0,100); 

    if (min>array[i]){min=array[i];}
    if (max<array[i]){max=array[i];}

    Console.Write(array[i]);
    if (i<array.Length-1){
        Console.Write(", ");
    } else {
        Console.Write("]");}

}

Console.Write($" -> {max-min}");