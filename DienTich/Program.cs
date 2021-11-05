using System;

namespace DienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai vs chieu rong");
            double dai = Convert.ToDouble(Console.ReadLine());
            double rong = Convert.ToDouble(Console.ReadLine());
            Shape cn = new ChuNhat(dai,rong);
            //ChuNhat cn1 = new ChuNhat(dai,rong);
            Console.WriteLine("Dien tich: {0}",cn.DienTich());
            Console.WriteLine("Chu vi: {0}",cn.Chuvi());
            Console.WriteLine("----------------");
            Console.WriteLine("Nhap 3 canh");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double c3 = Convert.ToDouble(Console.ReadLine());
            Shape tamgiac = new Tamgiac(c1,c2,c3);
            //ChuNhat cn1 = new ChuNhat(dai,rong);
            Console.WriteLine("Dien tich: {0}",tamgiac.DienTich());
            Console.WriteLine("Chu vi: {0}",tamgiac.Chuvi());
        }
    }

    public abstract class Shape
    {
        //public abstract double Canh { get; set; }
        public abstract double DienTich();
        public abstract double Chuvi();
    }

    public class ChuNhat : Shape
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public ChuNhat(double dai,double rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }

        public override double Chuvi()
        {
            return 2 * (Dai + Rong);
        }

        public override double DienTich()
        {
            return Dai * Rong;
        }
    }


    public partial class Tamgiac : Shape
    {
        public double C1 { get; set; }
        public double C2 { get; set; }
        public double C3 { get; set; }

        public Tamgiac(double c1,double c2,double c3)
        {
            this.C1 = c1;
            this.C2 = c2;
            this.C3 = c3;

        }

        public override double Chuvi()
        {
            return C1 + C2 + C3;
        }

        public override double DienTich()
        {
            double p = (C1 + C2 + C3) / 2;
            double S = Math.Sqrt(p * (p - C1) * (p - C2) * (p - C3));
            return S;
        }
    }
    public partial class Tron : Shape
    {
        public double R { get; set; }

        public Tron(double r)
        {
            R = r;
        }

        public override double Chuvi()
        {
            return Math.PI * 2 * R;
        }

        public override double DienTich()
        {
            return (Math.PI) * R * R;
        }
    }

}
