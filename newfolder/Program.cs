 int Max(int arg1, int arg2, int arg3) // функция max, типом int. цель: нахождение максимального из трёх чисел
// тело метода (ниже)
 {
    int result = arg1;
    if ( arg2 > result) result = arg2;
    if ( arg3 > result) result = arg3;
    return result;
 }

int a1 = 11, a2 = 112, a3 = 13;
int b1 = 21, b2 = 22, b3 = 2823;
int c1 = 331, c2 = 352, c3 = 3663;
//пример записи нахождения макса в коротком варианте
int max = Max(
        Max(a1,a2,a3),
         Max(b1,b2,b3),
         Max(c1,c2,c3));
Console.Write("max = ");
Console.WriteLine(max);

//другой пример записи нахождения макса
//int max1 = Max(a1,a2,a3);
//Console.Write("max 1 = ");
//Console.WriteLine(max1);
//int max2 = Max(b1,b2,b3);
//Console.Write("max 2 = ");
//Console.WriteLine(max2);
//int max3 = Max(c1,c2,c3);
//Console.Write("max 3 = ");
//Console.WriteLine(max3);
//int max = Max(max1, max2, max3);
//Console.Write("max = ");
//Console.WriteLine(max);
