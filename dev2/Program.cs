/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. +
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

    возрастания
    элементы, больше 8
    знакочередования*/


//ввожу методы для дальнейшей работы

void FillArray(int[] array) 
{
  int length = array.Length; 
  int index = 0;
  while (index<length)
   {
    array[index] = new Random().Next(-50,50);
    index ++;
    
   }
}
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
Console.Write("min number ");
Console.WriteLine(minValue); // отобрадаю числа на консоли
Console.Write("max number ");
Console.WriteLine(maxValue);
Console.WriteLine("array А");

int index = 0;
while (index < 10)
    {
    arrayA[index] = new Random().Next (minValue, maxValue); //заполняю рандом числами в диапазоне от рандом мин до рандом макс
    Console.Write($"{arrayA[index]} ") ;
    index++;
    }
    
Console.WriteLine();
int [] arrayAB = new int [10];
FillArray(arrayAB); 
//Console.WriteLine("array AB");
//PrintArray(arrayAB);
int current = arrayA[0];  //текущий массив
for (int i = 0; i > current; i++)
{
    Console.WriteLine();
}
int [] arrayB = new int [current];// ввод массива В, заполненным числами current
for (int i = 0; i < arrayAB.Length; i++)
{
    Console.WriteLine();
}
Console.WriteLine("array B:");
PrintArray(arrayB);