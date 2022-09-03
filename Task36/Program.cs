Console.Clear();
Console.WriteLine("Нажмите Enter для вывода массива.");
Console.ReadLine();

Random random = new Random();

int[] array = new int[random.Next(4,7)];

Console.Write("[");

int sum=0;

for (int i=0;i<array.Length;i++){
    array[i]=random.Next(0,100); 

    if ((i%2)!=0){sum=sum+array[i];}

    Console.Write(array[i]);
    if (i<array.Length-1){
        Console.Write(", ");
    } else {
        Console.Write("]");}

}

Console.Write($" -> {sum}");