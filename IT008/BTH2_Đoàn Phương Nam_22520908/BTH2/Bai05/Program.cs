using System;

abstract class diaOC
{
    public string diadiem { get; set; }
    public int giaban { get; set; }
    public int dientich { get; set; }

    public abstract int Type();
    public virtual void NhapThongTin()
    {
        Console.WriteLine("Nhập địa điểm:");
        diadiem = Console.ReadLine();

        Console.WriteLine("Nhập giá bán:");
        if (int.TryParse(Console.ReadLine(), out int giabanValue))
        {
            giaban = giabanValue;
        }
        else
        {
            Console.WriteLine("Giá bán không hợp lệ.");
        }

        Console.WriteLine("Nhập diện tích:");
        if (int.TryParse(Console.ReadLine(), out int dientichValue))
        {
            dientich = dientichValue;
        }
        else
        {
            Console.WriteLine("Diện tích không hợp lệ.");
        }
    }
    public virtual void Print()
    {
        Console.WriteLine($"Loại: Khu Đất");
        Console.WriteLine($"Địa điểm: {diadiem}");
        Console.WriteLine($"Giá bán: {giaban}");
        Console.WriteLine($"Diện tích: {dientich}");
    }

    public bool ContainsDiadiem(string s)
    {
        return diadiem.Contains(s);
    }

    public bool IsGiabanLessThanOrEqualTo(int gia)
    {
        return giaban <= gia;
    }

    public bool IsDientichGreaterThanOrEqualTo(int dien)
    {
        return dientich >= dien;
    }
}

class khuDat : diaOC
{
    public override int Type() => 1;
}

class chungCu : diaOC
{
    private int yearbuild { get; set; }
    private int flors { get; set; }

    public override int Type() => 2;
    public int GetYear()
    {
        return yearbuild;
    }
    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.WriteLine("Nhập năm xây dựng:");
        if (int.TryParse(Console.ReadLine(), out int NamXayDung))
        {
            yearbuild = NamXayDung;
        }
        else
        {
            Console.WriteLine("Năm xây dựng không hợp lệ.");
        }
        Console.WriteLine("Nhập số tầng:");
        if (int.TryParse(Console.ReadLine(), out int SoTang))
        {
            flors = SoTang;
        }
        else
        {
            Console.WriteLine("Số tầng không hợp lệ.");
        }
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Năm xây dựng: {yearbuild}");
        Console.WriteLine($"Số tầng: {flors}");
    }
}

class nhaPho : diaOC
{
    private int flors { get; set; }

    public override int Type() => 3;
    
    public override void NhapThongTin()
    {
        base.NhapThongTin();

        Console.WriteLine("Nhập số tầng:");
        if (int.TryParse(Console.ReadLine(), out int SoTang))
        {
            flors = SoTang;
        }
        else
        {
            Console.WriteLine("Số tầng không hợp lệ.");
        }
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Số tầng: {flors}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        diaOC[] a = new diaOC[n];

        long sum_kd = 0;
        long sum_cc = 0;
        long sum_np = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Choose your choice: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    a[i] = new khuDat();
                    break;

                case 2:
                    a[i] = new chungCu();
                    break;
                case 3:
                    a[i] = new nhaPho();
                    break;
            }

            a[i].NhapThongTin();

            if (a[i].Type() == 1)
            {
                sum_kd += a[i].giaban;
            }
            else if (a[i].Type() == 2)
            {
                sum_cc += a[i].giaban;
            }
            else
            {
                sum_np += a[i].giaban;
            }
        }

        // Print properties based on conditions
        foreach (diaOC x in a)
        {
            if ((x.Type() == 1 && x.dientich >= 60) || (x.Type() == 2 && x is chungCu cc && cc.GetYear() >= 2019)
)
            {
                x.Print();
            }
        }

        // Search and print properties
        string s = Console.ReadLine();
        int pri = Convert.ToInt32(Console.ReadLine());
        int area = Convert.ToInt32(Console.ReadLine());

        foreach (diaOC x in a)
        {
            if (x.ContainsDiadiem(s) && x.IsGiabanLessThanOrEqualTo(pri) && x.IsDientichGreaterThanOrEqualTo(area))
            {
                x.Print();
            }
        }
    }
}
