// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
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
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
PrintMatrix(matrix);
