using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.DAL
{
    public class Sach1
    {
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public float Giaban { get; set; }
        public string Mota { get; set; }
        public string Anhbia { get; set; }
        public DateTime Ngaycapnhat { get; set; }
        public int Soluongton { get; set; }

        public Sach1() { }
        public Sach1(string Masach, string Tensach, float Giaban,
     string Mota, string Anhbia, DateTime Ngaycapnhat, int Soluongton)
        {
            this.Masach = Masach;
            this.Tensach = Tensach;
            this.Giaban = Giaban;
            this.Mota = Mota;
            this.Anhbia = Anhbia;
            this.Ngaycapnhat = Ngaycapnhat;
            this.Soluongton = Soluongton;

        }

    }
}