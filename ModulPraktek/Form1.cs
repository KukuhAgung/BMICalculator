namespace ModulPraktek
{
    public partial class Form1 : Form
    {
        double bmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            double berat = 0;
            int usia = 0;
            double tinggi = 0;

            bool isberat = double.TryParse(txtberat.Text, out berat);
            bool isusia = int.TryParse(txtusia.Text, out usia);
            bool istinggi = double.TryParse(txttinggi.Text, out tinggi);

            if (isberat && isusia && istinggi)
            {
                bmi = berat * 10000 / (tinggi * tinggi);
                txthasil.Text = bmi.ToString("0.00");
                if (bmi < 18.5)
                {
                    lblket1.Text = "Hasil BMI < 18,5: Berat badan kurang.";
                }
                else if (bmi >= 18.5 && bmi < 22.9)
                {
                    lblket1.Text = "Hasil BMI Normal: Berat badan sehat.";
                }
                else if (bmi >= 23 && bmi < 27.5)
                {
                    lblket1.Text = "Hasil BMI Overweight: Berat badan berlebih.";
                    MessageBox.Show("Anda berada dalam kategori overweight. Pertimbangkan untuk mengadopsi pola makan sehat dan meningkatkan aktivitas fisik untuk menjaga berat badan Anda.");
                }
                else
                {
                    lblket1.Text = "Hasil BMI Obesitas: Berat badan berlebih tinggi.";
                    MessageBox.Show("Anda berada dalam kategori obesitas. Konsultasikan dengan profesional kesehatan untuk panduan lebih lanjut mengenai manajemen berat badan.");
                }
            }
            else
            {
                MessageBox.Show("Masukan Nilai yang Diperlukan");
            }
        }

        private void txtberat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttinggi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtberat.Text = "";
            txttinggi.Text = "";
            txtusia.Text = "";
            txthasil.Text = "";
            lblket1.Text = "";
        }
    }
}
