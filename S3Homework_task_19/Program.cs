// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
int n;  
int k;
int sum=0;
int m;
n = Convert.ToInt32(Console.ReadLine());
if(n > 9999 && n < 100000)
{
for(m= n; n != 0; n = n / 10)
{
k=n % 10;
sum=sum * 10 + k;
}
if(m == sum)
Console.Write($"{m} является палиндромом.");
else
Console.Write($"{m} не является палиндромом.");
} else
Console.Write("Введите пятизначное число! ");