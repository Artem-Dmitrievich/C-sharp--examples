﻿// void - процедура
// int/string - функция(return)

void f(ref int n)
//ref n - передача значений по ссылки(где хранится данный элемент в памяти компа)
//если без ref (то не складывается,а указывается копия)
{
    n = n + 10;
}
int n = 10;
f(ref n);
Console.Write(n);


//return -(работает как брейк, завершает работу ф-ции)
string main(int n, int m)
{
    if (n > m)
        return "n > 2";
    return "1 <= 2";
}
string x;
x = main(37, 23);
Console.Write(x);
//если что то найти, или выполнить то -функция.
//Процедура, если надо изменить значения...
