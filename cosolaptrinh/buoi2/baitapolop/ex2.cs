using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.baitapolop
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so dung truoc: ");
            int soDungTruoc = int.Parse(Console.ReadLine());
            Console.Write( "Nhap vao so dung sau: ");
            int soDungSau = int.Parse(Console.ReadLine());
            Console.WriteLine($"{soDungTruoc} + {soDungSau} = {soDungTruoc + soDungSau}");
            Console.WriteLine($"{soDungTruoc} - {soDungSau} = {soDungTruoc - soDungSau}");
            Console.WriteLine($"{soDungTruoc} * {soDungSau} = {soDungTruoc * soDungSau}");
            Console.WriteLine($"{soDungTruoc} / {soDungSau} = {soDungTruoc / soDungSau}");
            Console.WriteLine($"{soDungTruoc} % {soDungSau} = {soDungTruoc % soDungSau}");

        }
    }
}
