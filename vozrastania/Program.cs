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


