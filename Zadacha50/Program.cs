void Zadacha50()
{
    Random random= new Random();
    int rows=random.Next(4,10);
    int columns=random.Next(4,10);
    Console.WriteLine ($"Массив  размером - строчек {rows}, столбцов {columns}");
    int[,]numbers=new int[rows, columns];
    
    FillArray(numbers);
    PrintArray (numbers);
    Index(numbers);
}

void FillArray (int[,] numb)
{
    Random random= new Random();
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            numb[i,j]=random.Next(-10,11);
        }
    }
}

void PrintArray (int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
           Console.Write(numb[i,j]+"\t");
        }
        Console.WriteLine(); 
    }    
}
void Index(int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    Console.WriteLine ("Введите индексы элемента");
    int index=Convert.ToInt32(Console.ReadLine());
    
    if (index/10<=rows && index%10<=columns)
    {
        Console.WriteLine ($"Элемент массива равен {numb[index/10,index%10]}");
    }
    else
    {
        Console.WriteLine ("Такого элемента нет");
    }
}
Zadacha50();
