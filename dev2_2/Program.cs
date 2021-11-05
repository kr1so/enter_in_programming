/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. +
Создать на его основе масив B, отбрасывая те, которые не
элементы, больше 8

//ввожу методы для дальнейшей работы*/

/*void FillArray(int[] array) 
{
  int length = array.Length; 
  int index = 0;
  while (index<length)
   {
    array[index] = new Random().Next(-50,50);
    index ++;
    
   }
}*/
void PrintArray(int[] array) 
{
   int count = array.Length;
   int position = 0;
   while (position<count)
   {
        Console.Write($"{array[position]} ");
        position ++;
   }

}
//создаю массив А со случайными числами
int [] arrayA = new int [10];
int minValue = -50;
int maxValue = 50;
/*Console.Write("min number ");
Console.WriteLine(minValue); // отобрадаю числа на консоли
Console.Write("max number ");
Console.WriteLine(maxValue);
Console.WriteLine("array А");*/
for (int index = 0; index < 10; index++)
{
    
    arrayA[index] = new Random().Next (minValue, maxValue);
    Console.Write($"{arrayA[index]} ") ;
}
int [] arrayAB = new int [10];
int current = arrayA[0];
int counter = 0;
for (int index = 0; index<arrayA.Length; index++)
{
    if (index == 0)
    {
        arrayA[counter]=current;
        current = arrayA[index];
        counter++;
    }
    if (current < arrayA.Length)
    {
        arrayAB[counter]=arrayA[index];
        current = arrayA[index];
        counter++;
    }
}
int[] arrayB= new int[counter];
for (int index = 0; index < counter; index++)
{
    arrayB[index] = arrayAB[index];
    Console.WriteLine("массив B");
    PrintArray(arrayB);
}


