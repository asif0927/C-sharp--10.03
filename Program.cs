/*Adlar strinqden uzunlugu 4olanlari capa verme*/
/*  1+n*(1+1)=O(2n+1)  */
string[] names = { "Asif", "Kenan", "Eli", "Arif" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i].Length == 4)
    {
        Console.WriteLine(names[i]);
    }
}

/*2 eded daxil edib ozleride daxil olmaqla cemleri*/
/*  1+1+1+1+1+1+n*1+1=O(7n)   */
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int cem = 0;
int boyukeded, kicikeded;
if (num1 < num2)
{
    kicikeded = num1;
    boyukeded = num2;
}
else
{
    kicikeded = num2;
    boyukeded = num1;
}
for (int i = kicikeded; i <= boyukeded; i++)
{
    cem += i;
}
Console.WriteLine(cem);

/*mertebe sayin tapmaq*/
/* 1+1+n*(1+1)+1=3+2n=O(2n+3)  */
int num = int.Parse(Console.ReadLine());
int reqem = 0;
while (num > 0)
{
    reqem += 1;
    num /= 10;
}
Console.WriteLine(reqem);

/* Quvvet Ustu */
/* 1+1+1+(n+1)+1=O(4n+1) */
Console.WriteLine("M ededini daxil edin");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("N ededini daxil edin");
int n = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= m;
}

Console.WriteLine(result);