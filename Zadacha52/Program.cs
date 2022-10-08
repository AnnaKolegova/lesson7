void Zadacha52()
{
    Random random= new Random();
    int rows=random.Next(1,4);
    int columns=random.Next(1,3);
    Console.WriteLine ($"Массив  размером - строчек {rows}, столбцов {columns}");
    int[,]numbers=new int[rows, columns];
    
    FillArray(numbers);
    PrintArray (numbers);
    Average(numbers);
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
            numb[i,j]=random.Next(1,3);
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
void Average(int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    Console.Write ("Среднее арифметическое каждого столбца:");
       
    for (int j=0; j<columns; j++)
    {
        int sum=0; 
        for (int i=0; i<rows; i++)
        {
            sum=sum+numb[i,j];
        }
        Console.Write($"{Math.Round((double) sum/rows,1)}; "); 
    }
}
Zadacha52();

