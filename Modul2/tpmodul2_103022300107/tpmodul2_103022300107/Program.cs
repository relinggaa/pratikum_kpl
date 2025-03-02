// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan huruf : ");
        string huruf = Console.ReadLine();
        if (huruf == "A" || huruf == "I" || huruf == "U" || huruf == "E" || huruf == "O" || huruf == "a" || huruf == "i" || huruf == "u" || huruf == "e" || huruf == "o")
        {
            Console.WriteLine("Huruf vokal");
        }
        else
        {
            Console.WriteLine("Huruf konsonan");
        }
        int[] angkaGenap = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine("Angka genap " + (i + 1) + " : " + angkaGenap[i]);
        }



    }
}

