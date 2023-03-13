using System;

namespace CalculatorString
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulang = "";
            do
            {
            Console.Write("\nMasukkan angka dan operator: ");
            string input = Console.ReadLine();

            if (input.EndsWith("="))
            {
                string hitung = input.Remove(input.Length - 1);
                char[] symbol = { '+', '-', '*', '/', ':' };
                int PosisiSymbol = input.IndexOfAny(symbol);
                char operasi = input[PosisiSymbol];

                switch (operasi)
                {
                    case '+':
                        pertambahan(hitung, operasi);
                        break;

                    case '-':
                        pengurangan(hitung, operasi);
                        break;

                    case '*':
                        pengurangan(hitung, operasi);
                        break;

                    case '/':
                    case ':':
                        pembagian(hitung, operasi);
                        break;

                    default:
                        Console.WriteLine("Masukkan tanda operasi yang sesuai (+, -, *, :, /");
                        break;
                }

            }
            else Console.WriteLine("Tambahkan symbol \"=\" di akhir");
            
                Console.Write("\nApakah anda ingin menghitung lagi? (Y / N): ");
                ulang = Console.ReadLine();
                string hr = String.Concat(Enumerable.Repeat("=", 45));
                Console.WriteLine(hr);

            } while(ulang == "y" || ulang == "Y");
            Console.WriteLine("!!SELESAI!!".PadLeft(28));
        }
        static void pertambahan(string hitung, char operasi)
        {
            string[] angka = hitung.Split(operasi);
            decimal pertama = decimal.Parse(angka[0]);
            decimal kedua = int.Parse(angka[1]);
            decimal hasil = pertama + kedua;
            Console.WriteLine($"{pertama} + {kedua} = {hasil}");
        }
        static void pengurangan(string hitung, char operasi)
        {
            string[] angka = hitung.Split(operasi);
            decimal pertama = decimal.Parse(angka[0]);
            decimal kedua = int.Parse(angka[1]);
            decimal hasil = pertama - kedua;
            Console.WriteLine($"{pertama} - {kedua} = {hasil}");
        }
        static void perkalian(string hitung, char operasi)
        {
            string[] angka = hitung.Split(operasi);
            decimal pertama = decimal.Parse(angka[0]);
            decimal kedua = int.Parse(angka[1]);
            decimal hasil = pertama * kedua;
            Console.WriteLine($"{pertama} * {kedua} = {hasil}");
        }
        static void pembagian(string hitung, char operasi)
        {
            string[] angka = hitung.Split(operasi);
            decimal pertama = decimal.Parse(angka[0]);
            decimal kedua = int.Parse(angka[1]);
            decimal hasil = pertama / kedua;
            Console.WriteLine($"{pertama} {operasi} {kedua} = {hasil}");
        }
    }
}