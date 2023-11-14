//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
////float[] temperatures = { 0.5f, 1, 2, 1.5f, 3, 2, 0 };
////float[] temperatures = new float[] { 0.5f, 1, 2, 1.5f, 3, 2, 0 };
//float[] temperatures = new float[7] { 0.5f, 1, 2, 1.5f, 3, 2, 0 };
//foreach (float temperature in temperatures) {
//    Console.WriteLine(temperature);
//}
//Console.WriteLine();

////float[] temperatures = { 1.2f, 3.2f, 1.4f, 3.4f, 1.2f, 3.2f, 1.4f, 3.4f, 1.2f, 3.2f, 1.4f, 3.4f, 1.2f, 3.2f, 1.4f, 3.4f, 1.2f, 3.2f, 1.4f, 3.4f }; ;
////Console.WriteLine(temperatures);
//temperatures = new float[20];

//Console.WriteLine(temperatures);

//int[] abc;
//abc = new int[]{1,2,3};

//abc[1] = 5;

//string[] letters;

int[] A = new int [3] {0,3,6};
int sizeOfB = 2 * A.Length;
int[] B = new int[sizeOfB];
//int[] B = new int [6] {0,2,4,6,8,10};


for (int i = 0; i < B.Length; i++)
{
    if (i<A.Length)
    {
        B[i] = A[i];
    }
    else
    {
        B[i] =i*2;
    }
}


foreach (int num1 in A)
{
    Console.Write(num1);
}
Console.WriteLine();
foreach (int num2 in B)
{
    Console.Write(num2);
}

//Console.WriteLine();

//for(int i=0; i<B.Length; i++)
//{
//    A[i] = B[i];
//}
//A = B;

//foreach (int num1 in A)
//{
//    Console.Write(num1);
//}
//Console.WriteLine();
//foreach (int num2 in B)
//{
//    Console.Write(num2);
//}
//Console.WriteLine();

//for (int i= 0; i< A.Length; i++)
//{
//    A[i] = i;
//}

//foreach (int num1 in A)
//{
//    Console.Write(num1);
//}

//Console.WriteLine();

//foreach (int num2 in B)
//{
//    Console.Write(num2);
//}

//int[] C;
//bool[] D;
//C = D;