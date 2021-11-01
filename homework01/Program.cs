// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 
// Задать массив
int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}


//больше среднего арифметического элементов A


// сперва сделать среднее арифметическое элементов А
//затем сделать отсеивание-сравнение


//int[] ascending = new int[10];
//while (index < ascending)
//{
   // array[index] = ascending (10, 100); // [10, 99]
  //  index++;
//}

//index = 0;


int ascending = array[0];
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}
