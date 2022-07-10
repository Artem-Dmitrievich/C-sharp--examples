//функции в C# -методы

//"механизм" ищущий максимум из 3-х чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;//Определяем внутренний "резалт",где будет храниться значение
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;//Чтобы наш метод возвращал "резалт"
}
//благодаря этому коду ошибку(в случае возникновения)нужно будет править в 1 месте
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;
//максимум из тройки переменных
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//Окончательный "финалист" из групп перем-х
//int max = Max(max1, max2, max3);
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(max);