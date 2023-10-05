// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateRandomArrayXXX(int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void ShowEven(int[] array){
//     int sumEven = 0;
//     for(int i=0; i<array.Length; i++){
//         if(array[i] %2 == 0){
//             sumEven = sumEven + 1;
//         }
//     }
//     Console.WriteLine($"Number of even numbers is {sumEven}");
// }

// Console.WriteLine("Enter size of array of three-digit numbers:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArrayXXX(size);
// ShowArray(newArray);
// ShowEven(newArray);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int min, int max, int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SumOdd(int[] array){
//     int sumOdd = 0;
//     for(int i=1; i<array.Length; i+=2){
//           sumOdd = sumOdd + array[i];
//         }
//     Console.WriteLine($"Sum odd is {sumOdd}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// SumOdd(newArray);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// void FillArrayRandomNumbers(double[] numbers){
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,10000)) / 100;
//         }
// }
// void PrintArray(double[] numbers){
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void MaxMin(double[] numbers){
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)        
//             max = numbers[i];
   
//     if (numbers[i] < min)        
//             min = numbers[i];
// }
// Console.WriteLine($"Max = {max}, Min = {min}");
// Console.WriteLine($"The difference between Max&Min = {max-min}");
// }

// Console.WriteLine("Enter size of array:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// MaxMin(numbers);
