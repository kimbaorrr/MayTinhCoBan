namespace BaiThucHanh_1;
internal class MayTinh
{
    public double a { get; set; }
    public double b { get; set; }
    /*
     * Clear Contructor
     */
    public MayTinh()
    {
        this.a = 0;
        this.b = 0;
    }
    /*
     * Default Constructor
     */
    public MayTinh(MayTinh mt)
    {
        this.a = mt.a;
        this.b = mt.b;
    }
    /**
     * Truyền tham số cho Constructor
     */
    public MayTinh(double s1, double s2)
    {
        this.a = s1;
        this.b = s2;
    }
    /**
     * Tính tổng 2 số
     */
    public double tinh_Tong()
    {
        return this.a + this.b;
    }
    /**
     * Tính hiệu 2 số
     */
    public double tinh_Hieu()
    {
        return this.a - this.b;
    }
    /**
     * Tính tích 2 số
     */
    public double tinh_Tich()
    {
        return this.a * this.b;
    }
    /**
     * Tính thương 2 số 
     */
    public double tinh_Thuong()
    {
        return this.a / this.b;
    }

}
