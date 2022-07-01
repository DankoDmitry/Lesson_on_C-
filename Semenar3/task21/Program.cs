//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



namespace task19 {
    class Program {
        static void Main(string[] args) {
            float[] A = new float[3];
            float[] B = new float[3];

            Console.WriteLine("Введите координаты А через Entr:");
            for (int i = 0; i < 3; i++) {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }     
            Console.WriteLine("Введите координаты B через Entr:");
            for (int i = 0; i < 3; i++) {
                B[i] = Convert.ToInt32(Console.ReadLine());
            }       

            float S = 0;

            for (int i = 0; i < 3; i++) {
                S += (A[i] - B[i]) * (A[i] - B[i]);
            }

            Console.WriteLine("Растояние между А и В: " + MathF.Sqrt(S));
        }
    }
}