//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         Console.WriteLine($"Input the number with index {i}");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// int Check(int[] array)
// {
//     int s = 0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i] > 0) s++;
//     }
//     return s;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($"The amount of positive numbers in array is {Check(array)}");




//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//Значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double[] Check(double b1, double k1, double b2, double k2, int size = 2)
// {
//     double[] array = new double[size];
//     array[0] = (b2 - b1)/(k1 - k2);
//     array[1] = k1*array[0] + b1;
//     return array;
// }

// bool Check1(double k1, double k2)
// {
//     if((k1 - k2) == 0) return false;
//     else return true;
// }

// void ShowArray (double[] array, bool check)
// {
//     if(check == true)
//     {
//     Console.WriteLine ("Two lines cross in the point with coordinates:");
//     Console.Write ($"x:{array[0]}" + " ");
//     Console.Write ($"y:{array[1]}" + " ");
//     Console.WriteLine ();
//     }
//     else Console.WriteLine ("Two lines do not cross");
// }

// Console.WriteLine ("Input b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// double[] array = Check(b1, k1, b2, k2);
// bool check = Check1(k1,k2);
// ShowArray(array, check);
