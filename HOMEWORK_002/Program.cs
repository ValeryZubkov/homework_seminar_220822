// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void IplusJFillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}
void PrintMatrix(int[,] matr)
{
   for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    } 
}
Console.WriteLine("Введите количесво строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количесво столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
IplusJFillMatrix(matrix);
PrintMatrix(matrix);
