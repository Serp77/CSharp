//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5   782 -> 8   918 -> 1

// void SecondNum(int num){
//     if(num<100 || num>999){
//         Console.WriteLine("Error");
//     }
//     else{
//         int second_num = (num/10)%10;
//         Console.WriteLine($"New num is {second_num}");
//     }
// }
// Console.WriteLine("Inter number 100-999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number<0)
//      number = number * (-1);
// SecondNum(number);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5      78 -> третьей цифры нет     32679 -> 6

// void Third(int number){
//     if (number>99){
//         while(number>999){
//         number = number/10; 
//         }
//         int third_num = number%10;
//         Console.WriteLine($"Third {third_num}");
//     }
//     else
//          Console.WriteLine("Third digit no");
// }

// Console.WriteLine("Enter tne num:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num<0)
//     num = num * (-1);
// Third(num);





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да     7 -> да      1 -> нет

// Console.WriteLine("Input number day of week. It is weekend?: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>0 && num<8){
//     bool weekend = Week(num);
//     Console.WriteLine(weekend);
// }
// else
//     Console.WriteLine("This no day of week");

// bool Week(int num){
//     if (num==6 || num==7)
//          return true;
//     else
//          return false;
// }
