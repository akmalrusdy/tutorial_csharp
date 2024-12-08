using System;
using System.Linq;


class Mahasiswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }

    public Mahasiswa(string nama, int nilai)
    {
        Nama = nama;
        Nilai = nilai;
    }
}


class Program()
{
    public static void Main(String[] args)
    {
        Mahasiswa[] mahasiswaArray = new Mahasiswa[5];

        mahasiswaArray[0] = new Mahasiswa("Alice", 85);
        mahasiswaArray[1] = new Mahasiswa("Bob", 90);
        mahasiswaArray[2] = new Mahasiswa("Charlie", 78);
        mahasiswaArray[3] = new Mahasiswa("Andi", 65);
        mahasiswaArray[4] = new Mahasiswa("Pal", 100);

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("==== Program Statisik Jaya ====");
            Console.WriteLine("Pilih tindakan");
            Console.WriteLine("1. Tampilkan data mahasiswa");
            Console.WriteLine("2. Tampilkan Nilai");
            Console.WriteLine("3. Hitung Rata Rata Nilai");
            Console.WriteLine("4. Tampilkan data mahasiswa berdasarkan nilai (descending)");
            Console.WriteLine("5. Keluar");

            Console.Write("Pilihan: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("==== Data Mahasiswa ====");
                    TampilkanData(mahasiswaArray);
                    break;
                case 2:
                    Console.WriteLine("==== Data Mahasiswa ====");
                    TampilkanNilai(mahasiswaArray);
                    break;
                case 3:
                    Console.WriteLine("==== Data Mahasiswa ====");
                    RataRataNilai(mahasiswaArray);
                    break;
                case 4:
                    Console.WriteLine("==== Data Mahasiswa ====");
                    UrutkanData(mahasiswaArray);
                    break;
                case 5:
                    Console.WriteLine("Keluar...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Pilihan anda salah!");
                    break;
            }
        }


    }

    private static void TampilkanData(Mahasiswa[] mahasiswaArray)
    {
        foreach (Mahasiswa mhs in mahasiswaArray)
        {
            Console.WriteLine($"Nama: {mhs.Nama}, Nilai: {mhs.Nilai}");
        }
    }

    private static void TampilkanNilai(Mahasiswa[] mahasiswaArray)
    {
        var maxNilai = mahasiswaArray.Max(m => m.Nilai);
        var minNilai = mahasiswaArray.Min(m => m.Nilai);

        // Mencari mahasiswa dengan nilai maksimum dan minimum
        var mahasiswaMax = mahasiswaArray.First(m => m.Nilai == maxNilai);
        var mahasiswaMin = mahasiswaArray.First(m => m.Nilai == minNilai);

        Console.WriteLine($"Nilai Tertinggi: {maxNilai} ({mahasiswaMax.Nama})");
        Console.WriteLine($"Nilai Terendah: {minNilai} ({mahasiswaMin.Nama})");

    }

    private static void RataRataNilai(Mahasiswa[] mahasiswaArray)
    {
        var rataRataNilai = mahasiswaArray.Average(m => m.Nilai);
        Console.WriteLine($"Rata-rata Nilai: {rataRataNilai}");
    }


    private static void UrutkanData(Mahasiswa[] mahasiswaArray)
    {
        // Mengurutkan mahasiswa berdasarkan nilai secara ascending
        Array.Sort(mahasiswaArray, (m1, m2) => m2.Nilai.CompareTo(m1.Nilai));

        // Menampilkan mahasiswa setelah diurutkan
        foreach (var mhs in mahasiswaArray)
        {
            Console.WriteLine($"Nama: {mhs.Nama}, Nilai: {mhs.Nilai}");
        }
    }

}

