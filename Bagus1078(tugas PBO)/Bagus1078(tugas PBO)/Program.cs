using System;

class Processor
{
    public string Merk;
    public string Tipe;

    public Processor(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel() : base("Intel", "") { }
}

class Corei3 : Intel
{
    public Corei3() : base() { Tipe = "Core i3"; }
}

class Corei5 : Intel
{
    public Corei5() : base() { Tipe = "Core i5"; }
}

class Corei7 : Intel
{
    public Corei7() : base() { Tipe = "Core i7"; }
}

class AMD : Processor
{
    public AMD() : base("AMD", "") { }
}

class Ryzen : AMD
{
    public Ryzen() : base() { Tipe = "RYZEN"; }
}

class Athlon : AMD
{
    public Athlon() : base() { Tipe = "ATHLON"; }
}

class Vga
{
    public string Merk;

    public Vga(string merk)
    {
        Merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia") { }
}

class AMD1 : Vga
{
    public AMD1() : base("AMD") { }
}

class Laptop
{
    public string Merk;
    public string Tipe;
    public Processor Processor;
    public Vga Vga;

    public Laptop(string merk, string tipe, Processor processor, Vga vga)
    {
        Merk = merk;
        Tipe = tipe;
        Processor = processor;
        Vga = vga;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, Processor processor, Vga vga) : base("ASUS", tipe, processor, vga) { }
}

class ROG : ASUS
{
    public ROG(Processor processor, Vga vga) : base("ROG", processor, vga) { }
}

class Vivobook : ASUS
{
    public Vivobook(Processor processor, Vga vga) : base("Vivobook", processor, vga) { }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Processor processor, Vga vga) : base("ACER", tipe, processor, vga) { }
}

class Swift : ACER
{
    public Swift(Processor processor, Vga vga) : base("Swift", processor, vga) { }
}

class Predator : ACER
{
    public Predator(Processor processor, Vga vga) : base("Predator", processor, vga) { }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, Processor processor, Vga vga) : base("Lenovo", tipe, processor, vga) { }
}

class IdeaPad : Lenovo
{
    public IdeaPad(Processor processor, Vga vga) : base("IdeaPad", processor, vga) { }
}

class Legion : Lenovo
{
    public Legion(Processor processor, Vga vga) : base("Legion", processor, vga) { }
}

class Program
{
    static void Main()
    {
        Processor corei5 = new Corei5();
        Processor ryzen = new Ryzen();
        Processor corei7 = new Corei7();
        Vga nvidia = new Nvidia();
        Vga amd = new AMD1();

        Laptop laptop1 = new Vivobook(corei5, nvidia);
        Laptop laptop2 = new IdeaPad(ryzen, amd);
        Predator predator = new Predator(corei7, amd);

        Console.WriteLine("--------------------JAWABAN SOAL 1--------------------");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("--------------------JAWABAN SOAL 2--------------------");
        //laptop1.Ngoding();//method ini eror

        Console.WriteLine("--------------------JAWABAN SOAL 3--------------------");
        Console.WriteLine($"Spesifikasi laptop1: Merk VGA = {laptop1.Vga.Merk}, Merk Processor = {laptop1.Processor.Merk}, Tipe Processor = {laptop1.Processor.Tipe}");

        Console.WriteLine("--------------------JAWABAN SOAL 4--------------------");
        predator.BermainGame();

        Console.WriteLine("--------------------JAWABAN SOAL 5--------------------");
        ACER acer = new Predator(corei7, amd);
        //acer.BermainGame(); method ini eror
    }
}
