/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
Создать на его основе масив B с числами, которые не нарушают порядок возрастания*/

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
int[]arrayA = new int [10];
int minValue = -50;
int maxValue = 50;
for (int var = 0; var < 10; var++)
{
    arrayA[var] = new Random().Next (minValue, maxValue);
    Console.Write($"{arrayA[var]} ") ;
}
int[]arrayAB = new int[10];
int current = arrayA[0]; 
int counter = 0; 
for (int var = 0; var<arrayA.Length; var++) 
    if (var == 0)
    {
        arrayAB[counter]=current;
        current = arrayA[var];
        counter++; 
    }
    if (current < arrayA.Length) 
    {
        arrayAB[counter]=arrayA[var]; 
        current = arrayA[var]; 
        counter++; 
}
int[]arrayB= new int[counter];
for (int var = 0; var < counter; var++)
{
    arrayB[var] = arrayAB[var];
    Console.WriteLine("массив B");
}
PrintArray(arrayB);

/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
Создать на его основе масив B, отбрасывая элементы, которые не больше 8*/
void PrintArray(int[]array) 
{
   int count = array.Length;
   int position = 0;
   while (position<count)
   {
        Console.Write($"{array[position]} ");
        position ++;
   }

}
int[]arrayA = new int[10];
int minValue = -50;
int maxValue = 50;
for (int var = 0; var < 10; var++) 
{
    arrayA[var] = new Random().Next (minValue, maxValue);
    //Console.Write($"{arrayA[index]} ") ;
}
int[]arrayAB = new int[10];
int currentValue = 8; 
int counter = 0; 
for (int var = 0; var<arrayA.Length; var++) 
{
    if (arrayA[var] <= 8)
    {
        arrayAB[counter]=currentValue;
        currentValue = arrayA[var]; 
        counter++; 
    }
}
int[]arrayB= new int[counter]; 
for (int var = 0; var < counter; var++)
{
    arrayB[var] = arrayAB[var];
}
 Console.WriteLine();
Console.WriteLine("массив B");
Console.WriteLine();
PrintArray(arrayB);

/*Задача
Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
Создать на его основе масив B, отбрасывая элементы, которые нарушают порядок знакочередования*/

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
int[]arrayA = new int [10];
int minValue = -50;
int maxValue = 50;
for (int i = 0; i < 10; i++) 
{
    arrayA[i] = new Random().Next (minValue, maxValue);
}
Console.Write("массив А ");
PrintArray(arrayA);
int[]arrayAB = new int[10];
int current = arrayA[0]; 
int counter = 0; 
for (int i=1; i >= arrayA.Length; i++) 
  {
    if (((current<=0) && arrayA[i]<=0))
    {
        arrayAB[counter]=arrayA[i];
        current = arrayAB[i];
        counter++; 
    }
    if ((current>=0 && arrayA[i]<=0))
    {
        arrayAB[counter]=arrayA[i];
        current = arrayAB[i];
        counter++;   
    }
int[]arrayB= new int[counter];
for (i = 0; i < counter; i++)
{
    arrayB[i] = arrayAB[counter];
    Console.WriteLine("массив B");
}
PrintArray(arrayB);
}