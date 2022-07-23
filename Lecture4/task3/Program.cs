
void PrintArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i,j]} ");
        }

        System.Console.WriteLine();
    }
}

void FillArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 5];

matrix[1,2] = 5;

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);