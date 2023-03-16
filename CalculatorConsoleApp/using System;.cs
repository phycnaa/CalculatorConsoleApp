using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
	private double penambahan(double a, double b)
	{

		return (a + b);
	}

	private double pengurangan(double a, double b)
	{
		return (a - b);
	}

	private double perkalian(double a, double b)
	{
		return (a * b);
	}

	private double pembagian(double a, double b)
	{
		return (a / b);
	}

	public void Main()
	{
		Console.Title = "Aplikasi Calculator";

		double bil1, bil2;
		char pilihan;
		Console.WriteLine("Pilih menu calculator :");
		Console.WriteLine("\n");
		Console.WriteLine("1. Penambahan");
		Console.WriteLine("2. Pengurangan");
		Console.WriteLine("3. Perkalian");
		Console.WriteLine("4. Pembagian");
		Console.WriteLine("\n");
		Console.WriteLine("Input nomor menu [1..4] : ");
		pilihan = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\n");

		if (pilihan == '1')
		{
			Console.WriteLine("Inputkan nilai a = ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan nilai b = ");
			bil2 = Convert.ToDouble(Console.ReadLine()); ;
			Console.WriteLine("\n");
			Console.WriteLine("Hasil Penambahan = " + penambahan(bil1, bil2) + "			");
			Console.WriteLine("\n");
			Console.WriteLine("Tekan sembarang key untuk keluar");
		}

		else if (pilihan == '2')
		{
			Console.WriteLine("Inputkan nilai a = ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan nilai b = ");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\n");
			Console.WriteLine("Hasil Pengurangan = " + pengurangan(bil1, bil2) + "			");
			Console.WriteLine("\n");
			Console.WriteLine("Tekan sembarang key untuk keluar");
		}

		else if (pilihan == '3')
		{
			Console.WriteLine("Inputkan nilai a = ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan nilai b = ");
			bil2 = Convert.ToDouble(Console.ReadLine()); ;
			Console.WriteLine("\n");
			Console.WriteLine("Hasil Perkalian = " + perkalian(bil1, bil2) + "			");
			Console.WriteLine("\n");
			Console.WriteLine("Tekan sembarang key untuk keluar");

		}

		else if (pilihan == '4')
		{
			Console.WriteLine("Inputkan nilai a = ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan nilai b = ");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\n");
			Console.WriteLine("Hasil Pembagian = " + pembagian(bil1, bil2) + "			");
			Console.WriteLine("\n");
			Console.WriteLine("Tekan sembarang key untuk keluar");
		}

		else if (pilihan == '5')
		{
			Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
			Console.WriteLine("\n");
			Console.WriteLine("Tekan sembarang key untuk keluar");
		}
	}
}