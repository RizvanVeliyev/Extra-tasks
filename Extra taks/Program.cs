using System.ComponentModel.DataAnnotations;

namespace Extra_taks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region task1
			//Console.Write("ededi daxil edin:");
			//int n = int.Parse(Console.ReadLine());

			//int count = 0, sonreqem;
			//while (n > 0)
			//{
			//	sonreqem = n % 10;
			//	n /= 10;
			//	count += 1;
			//}
			//Console.Write($"ededin reqemleri say={count}");
			#endregion
			#region task2
			//Console.Write("ededi daxil edin:");
			//int n = int.Parse(Console.ReadLine());

			//int sum=0, sonreqem;
			//while (n > 0)
			//{
			//	sonreqem = n % 10;
			//	n /= 10;
			//	sum += sonreqem;
			//}
			//Console.Write($"ededin reqemleri cemi={sum}");


			#endregion
			#region task3
			//Console.Write("massivin elementleri sayi:");
			//int n = int.Parse(Console.ReadLine());
			//int[] A = new int[n];
			//int[] B = new int[n];

			//for (int i = 0; i < A.Length; i++)
			//{
			//	Console.Write($"A[{i}]=");
			//	A[i] = int.Parse(Console.ReadLine());
				
			//}
			//int max = A[0],maxi=0;
			//int min = A[0],mini=0;
			//for (int j = 0; j < A.Length; j++)
			//{

			//	if (A[j] > max) { 

			//	max = A[j];
			//	maxi = j;
			//}

			//	if (A[j] < min) { 

			//	min = A[j];
			//	mini = j;
			//}
			//}

			

			//Console.WriteLine($"max=A[{maxi}]={max}");
			//Console.WriteLine($"min=A[{mini}]={min}");
			//A[maxi] = min;
			//A[mini] = max;
			//Console.WriteLine($"max-la minimumun yerinin deyisdirilmis veriyasi:");
			//foreach (var item in A)
			//{
			//	Console.Write(item + " ");
			//}


			#endregion
			#region task4
			//Console.Write("massivin elementleri sayi:");
			//int n = int.Parse(Console.ReadLine());
			//int[] A = new int[n];
			//int[] B = new int[n];
			//int j = 0;
			//for (int i = 0; i < A.Length; i++)
			//{
			//	Console.Write($"A[{i}]=");
			//	A[i] = int.Parse(Console.ReadLine());
			//	if (A[i] % 2 == 1)
			//	{
			//		A[i] = A[i] * -1;
			//		B[j] = A[i];
			//		j++;

			//	}

			//}
			//Console.WriteLine($"A massivindeki tek ededlerin eksi:");
			//foreach (var item in B)
			//{
			//	Console.Write(item + " ");
			//}
			#endregion
			#region task5
			//Console.Write("eded:");
			//int n = int.Parse(Console.ReadLine());
			//int teklik = n % 10;
			//int onluq = (n / 10) % 10;
			//if (teklik > onluq)
			//{
			//	Console.Write($"teklik onluqdan boyukdur\n{teklik}>{onluq}");

			//}
			//else if (teklik == onluq)
			//{
			//	Console.Write($"teklik onluga beraberdir\n{teklik}={onluq}");

			//}
			//else
			//{
			//	Console.Write($"teklik onluqdan kicikdir\n{teklik}<{onluq}");

			//}
			#endregion
			#region task6
			//Console.Write("eded:");
			//int n = int.Parse(Console.ReadLine());
			//int max = 0,sonreqem;
			//while (n > 0)
			//{
			//	sonreqem = n % 10;
			//	n /= 10;
			//	if (sonreqem > max)
			//	{
			//		max = sonreqem;
			//	}
			//}
			//Console.Write($"ededdeki max reqem={max}");

			#endregion

		}
	}
}