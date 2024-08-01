//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
static string IsDivisible(int n)
{
    if (n%3==0 && n%7 ==0)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}

Console.WriteLine(IsDivisible(15)); 


//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

static int EvenNumberSum(int n,int m)
{
    if (n%2==0 && m%2==0)
    {
        return n + m;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(EvenNumberSum(10, 12)); 

//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
static int OddNumberCount(int n, int b)
{
    int count =0;
    for (int i = n; i < b; i++)
    {
        if (i%2==1)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(OddNumberCount(1, 12));

//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
static int OddNumberSum(int n, int b)
{
    int sum = 0;
    for (int i = n; i < b; i++)
    {
        if (i % 2 == 1)
        {
            sum+=i;
        }
    }
    return sum;
}
Console.WriteLine(OddNumberSum(1, 12));

//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.


static int ArrayOddNumberSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = { 1, 2, 3, 4, 5, 7, 89, 12 };
Console.WriteLine(ArrayOddNumberSum(array));


//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

static int ArrayEvenNumberCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine(ArrayEvenNumberCount(array));


//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

static string SimpleNumber(int n)
{
    if (n<=1)
    {
        return "Neither simple nor complex!";
    }
    else
    {
        int count = 0;
        for (int i = 1; i < n; i++)
        {
            if (n%i==0)
            {
                count++;
            }
        }
        if (count==1)
        {
            return $"{n} is simple number";
        }
        else
        {
            return $"{n} is't simple number";
        }
    }
}
Console.WriteLine(SimpleNumber(121)) ;


//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.
static string TwoPower(int n)
{
    int count = 0;
    int num = n;
    while (n>1)
    {
        if (n%2==0)
        {
            count++;
            n /= 2;
        }
        else
        {
            return "No";
        }
    }
    return $"{num} is 2 to the power of {count}";
}

Console.WriteLine(TwoPower(64));

//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18).
static int ArrayNUmberMultiply(int[] array)
{
    int multiply = 1;
    foreach (var item in array)
    {
        if (item>1 && item<20)
        {
            multiply *= item;
        }
    }
    return multiply;
}

int[] array1 = { 1, 2, 3, 4, 5, 7, 89, 12 };
Console.WriteLine(ArrayNUmberMultiply(array1));


//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

static int ArrayEvenNumbersSquareSum(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item%2==0)
        {
            sum += item;
        }
    }
    return sum * sum;
}
int[] array2 = { 1, 2, 3, 4, 5, 7, 89, 12 };
Console.WriteLine(ArrayEvenNumbersSquareSum(array2));

//11) Stringlerden ibaret arrayin icerisindeki charlarin sayini tapan method yazin. (Mes: ["Cavid","Teymur"] - cavab: 11).
static int ArrayCharsSum(string[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        sum += item.Length;
    }
    return sum;
}

string[] names = { "Nihat", "Hemid", "Fadile", "Elshad", "Valeh", "Nergiz", "Samir", "Terxan", "Aqil", "Ramil", "Eldar", "Ferdi" };
Console.WriteLine(ArrayCharsSum(names));