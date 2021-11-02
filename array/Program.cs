//программа нахождения максимального числа в массиве среди чисел с индексом, кратному делению на 9
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
//int - тип данных
// [] - скобки для обозначения массива и обозначения кол-ва чисел в нём
// massiv - имя массива. можно еще встретить array
// {} - значения массива    
//индесы массива: 0  1  2  3  4  5  6  7  8    
int [] massiv = {12,10,505,26,95,15,42,31,32};
//обращение к конкретному элементу массва:
//massiv - имя массива, 
//в квадратных скобках индекс обращаемого элемента. следовательно, на выходе будет число 55
// чтобы вывести в консоль нужное число из массива: Console.WriteLine(massiv[2]);

massiv[3] = 102; // заменить значение числа в нужном индексе 
Console.WriteLine(massiv[3]);

int max = Max(
          Max(massiv[0], massiv[1], massiv[2]),
          Max(massiv[3], massiv[4], massiv[5]),
          Max(massiv[6], massiv[7], massiv[8])
);
Console.WriteLine(max);