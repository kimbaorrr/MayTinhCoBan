namespace BaiThucHanh_1
{
    public partial class Form1 : Form
    {
        private string phepToan = "+";
        private double sta = 0, stb = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
            this.lbl_KetQua.Text = "0";
            this.txt_SoThuNhat.Focus();
        }
        private void checkVal()
        {
            
            // Kiểm tra kiểu dữ liệu các trường
            try
            {
                sta = Convert.ToDouble(this.txt_SoThuNhat.Text);
                stb = Convert.ToDouble(this.txt_SoThuHai.Text);
            } catch
            {
                MessageBox.Show("Giá trị không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Kiểm tra giá trị ST 1 & ST2 khi tính thương
            
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkVal();
            switch (this.phepToan)
            {
                case "+":
                    this.lbl_KetQua.Text = string.Format("{0:#,##0}", this.thiHanh_TinhToan().tinh_Tong());
                    break;
                case "-":
                    this.lbl_KetQua.Text = string.Format("{0:#,##0}", this.thiHanh_TinhToan().tinh_Hieu());
                    break;
                case "*":
                    this.lbl_KetQua.Text = string.Format("{0:#,##0}", this.thiHanh_TinhToan().tinh_Tich());
                    break;
                case "/":
                    if (sta < stb && this.phepToan.Equals("/"))
                        MessageBox.Show("Số thứ nhất không được bé hơn số thứ hai khi tính thương !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        this.lbl_KetQua.Text = string.Format("{0:#,##0}", this.thiHanh_TinhToan().tinh_Thuong());
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
                Application.Exit();
        }

        private MayTinh thiHanh_TinhToan()
        {
            return new MayTinh(double.Parse(this.txt_SoThuNhat.Text), double.Parse(this.txt_SoThuHai.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.phepToan = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.phepToan = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.phepToan = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.phepToan = "/";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}