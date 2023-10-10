//тип имя_функции(тип аргумент, ... ) {
//     тело_функции;
//     оно же действия;
//     возврат;
// }

int Vozvedenie_v_kvadrat(int chislo, int stepen)
{
    int result = 1;


    for (int i = 1; i <= stepen; i++)
    {
        result *= chislo; // result = result * chislo
    }
    int result = 1;
}


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); //2
Console.Write("Введите степень числа: ");
int num2 = Convert.ToInt32(Console.ReadLine()); //5
//Ввод значений

Console.WriteLine(Vozvedenie_v_kvadrat(num1, num2) + num1 * num2);
//Вывод результата
