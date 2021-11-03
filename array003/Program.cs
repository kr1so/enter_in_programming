Console.Clear();

/* создание методов
заполнения массива
печати массива на экран*/


/*создать массив с методом void
void-метод ничего не возвращает. в нём не используем оператор return
 создание своего метода
наименование метода - FillArray
наименование аргумента - collection*/
void FillArray(int[] collection) // метод, который заполняет массив. не используем запятую
{
  int length = collection.Length; // получить длину массива
  int index = 0;
  while (index<length)
   {
    collection[index] = new Random().Next(1,10);
     index ++;
   }
}

void PrintArray(int[] col) //метод, который печатает массив
{
   int count = col.Length;
   int position = 0;
   while (position<count)
   {
        Console.WriteLine(col[position]);
        position ++;
   }

}
int [] array = new int [10]; // создать новый массив, в котором будет n элементов
FillArray(array); // метод, заполняющий массив
PrintArray(array); // метод, выводящий массив

