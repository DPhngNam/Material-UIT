namespace Bai04
{
    class phanSo
    {
        private int Tu;
        private int Mau;
        public phanSo(int v1, int v2)
        {
            this.Tu = v1;
            this.Mau = v2;
        }
        public void rut_gon()
        {
            int a = Tu, b = Mau;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            Tu /= a;
            Mau /= a;
        }
        public void Xuat()
        {
            if(Mau != 1) Console.WriteLine(Tu + "/" + Mau);
            else Console.WriteLine(Tu);
        }
        public phanSo Cong(phanSo other)
        {
            this.Tu = other.Tu*this.Mau + this.Tu*other.Mau;
            this.Mau = other.Mau*this.Mau;
            this.rut_gon();
            return this;
        }
        public phanSo Tru(phanSo other)
        {
            this.Tu = other.Tu * this.Mau - this.Tu * other.Mau;
            this.Mau = other.Mau * this.Mau;
            this.rut_gon();
            return this;
        }
        public phanSo Nhan(phanSo other)
        {
            this.Tu = other.Tu * this.Tu ;
            this.Mau = other.Mau * this.Mau;
            this.rut_gon();
            return this;
        }
        public phanSo Chia(phanSo other)
        {
            this.Tu = this.Tu * other.Mau;
            this.Mau = other.Tu * this.Mau;
            this.rut_gon();
            return this;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            phanSo a = new phanSo(2,4);
            //a.rut_gon();a.Xuat();

            phanSo b = new phanSo(3, 6);

            phanSo c = a.Cong(b); c.Xuat();
            phanSo d = a.Cong(b); d.Xuat();
            phanSo e = a.Cong(b); e.Xuat();
            phanSo f = a.Cong(b); f.Xuat();

        }
    }
}