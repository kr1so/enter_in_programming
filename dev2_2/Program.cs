/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
Создать на его основе масив B с числами, которые не нарушают порядок возрастания*/

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
Console.WriteLine(minValue); // отображаю числа на консоли
Console.Write("max number ");
Console.WriteLine(maxValue);
Console.WriteLine("array А");*/
for (int index = 0; index < 10; index++) //цикл для заполнения мин и макс
{
    arrayA[index] = new Random().Next (minValue, maxValue);
    Console.Write($"{arrayA[index]} ") ;
}
int [] arrayAB = new int [10];//ввожу массив AB, чтоб заполнить нужными числами
int current = arrayA[0]; //обожражаю нулевой элемент массива (в current)
int counter = 0; //куда записываются все числа 
for (int index = 0; index<arrayA.Length; index++) //индекс изменяется от 0 до значения размера массива А
{
    if (index == 0)//если индекс = 0
    {
        arrayAB[counter]=current;//текущий 0 элемент второго массива = элементу массива А
        current = arrayA[index]; //текущий элемент
        counter++; //увеличиваю счетчик counter на 1
    }
    if (current < arrayA.Length) //если 0 элемент < первого 
    {
        arrayAB[counter]=arrayA[index]; // текущее значение = текущему индексу
        current = arrayA[index]; //текущий элемент соответствует новому значению
        counter++; //увеличиваю счетчик counter на 1
    }
}
int[] arrayB= new int[counter]; //ввожу новый массив В с новыми числами, состоящими из счетчика
for (int index = 0; index < counter; index++)
{
    arrayB[index] = arrayAB[index];
    Console.WriteLine("массив B");
}
PrintArray(arrayB);


