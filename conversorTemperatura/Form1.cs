namespace conversorTemperatura
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal temperaturaCelcius = Convert.ToDecimal(textBox1.Text);

            decimal temperaturaFahrenheit = (temperaturaCelcius * 5 / 9) + 32;
            temperaturaFahrenheit = decimal.Round(temperaturaFahrenheit, 2);
            label2.Text = $"Resultado: {temperaturaFahrenheit} F";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal temperaturaCelsius = Convert.ToDecimal(textBox1.Text);
            decimal temperaturaKelvin = temperaturaCelsius + Convert.ToDecimal(273.15);
            temperaturaKelvin = decimal.Round(temperaturaKelvin, 2);

            label2.Text = $"Resultado: {temperaturaKelvin} K";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Resultado: ";
        }
    }
}