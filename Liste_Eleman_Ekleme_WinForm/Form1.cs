namespace Liste_Eleman_Ekleme_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //    lsbAd.Items.Add(i);
            //    cmbAd.Items.Add(i+10);
            //}
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lsbAd.Items.Add(txtAd.Text);
            cmbAd.Items.Add(txtAd.Text);
        }

        private void btnSecme_Click(object sender, EventArgs e)
        {
            cmbAd.SelectedIndex = -1;
            lsbAd.SelectedIndex = -1;
        }

        private void lsbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbAd.SelectedIndex != -1)
                MessageBox.Show("Listboxtan secilen eleman: " + lsbAd.Text + " Secili indexi: " + lsbAd.SelectedIndex);
        }

        private void cmbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAd.SelectedIndex != -1)
                MessageBox.Show("Comboboxtan secilen eleman: " + cmbAd.Text + " Secili indexi: " + cmbAd.SelectedIndex);
        }
    }
}