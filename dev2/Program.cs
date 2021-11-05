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
int minValue = new Random().Next(-50,10);
int maxValue = new Random().Next(10,50);
Console.Write("min number ");
Console.WriteLine(minValue);
Console.Write("max number ");
Console.WriteLine(maxValue);
Console.WriteLine("array А");
int index = 0;
while (index < 10)
    {
    arrayA[index] = new Random().Next (minValue, maxValue);
    Console.Write($"{arrayA[index]} ") ;
    index++;
    }
// создаю на его основе массив B, в котором исключены числа, нарушающие восрастание
Console.WriteLine();
int [] arrayAB = new int [10];
FillArray(arrayAB); 
Console.WriteLine("array AB");
PrintArray(arrayAB);

int current = arrayA[0]; //ввод элементов, не нарушающих порядка возрастания
int counter = 0;
for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA.Length>=current)
    {
     current = arrayA[i];
     counter++;
    }
}
int [] arrayB = new int [counter];
Console.WriteLine("array B:");
for (int cnt = 0;cnt < counter;cnt++)
{
    arrayB.Length = counter;
}
PrintArray(arrayB);