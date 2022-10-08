void Zadacha47()
{
    Random random= new Random();
    int rows=random.Next(4,10);
    int columns=random.Next(4,10);
    Console.WriteLine ($"Массив  размером - строчек {rows}, столбцов {columns}");
    double[,]numbers=new double[rows, columns];
    
    FillArray(numbers);
    
    PrintArray (numbers);
    
    
}

void FillArray (double[,] numb)
{
    Random random= new Random();
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            numb[i,j]=Convert.ToDouble(random.Next(-100,101)/10.0);
        }
    }

}

void PrintArray (double[,] numb)
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
Zadacha47();