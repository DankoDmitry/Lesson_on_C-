string[,] table = new string[2, 5];
table[1,2] = "Слово";


for (int rows = 0; rows < 2; rows++) {
    for (int columns = 0; columns < 5; columns++) {
        Console.Write($"{table[rows,columns]} ");
    }
}