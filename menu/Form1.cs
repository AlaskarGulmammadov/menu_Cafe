using System.Diagnostics.Eventing.Reader;

namespace menu
{
    public partial class Form1 : Form
    {
        decimal price = 0;
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
            
        {
            string[] ickiler = { "Çay - 1.00azn", "Kola - 2.50azn", "Fanta - 3.00azn", "Su - 1.00azn", "Smoothie - 8.00azn", "Milkshake - 7.00azn" };
            listBox1.Items.Add("İçkilər");
            foreach (var item in ickiler)
            {
                listBox1.Items.Add(item);
            }
            //listBox1.Items.Add("Çay - 1.00azn");
            //listBox1.Items.Add("Kola - 2.50azn");
            //listBox1.Items.Add("Fanta - 3.00azn");
            //listBox1.Items.Add("Su - 1.00azn");
            //listBox1.Items.Add("Smoothie - 8.00azn");
            //listBox1.Items.Add("Milkshake - 7.00azn");

            listBox1.Items.Add("");


            listBox1.Items.Add("Şirniyyatlar");
            listBox1.Items.Add("magnolya - 5.00azn");
            listBox1.Items.Add("Napoleon - 4.50azn");
            listBox1.Items.Add("Paxlava (Az) - 3.00azn");
            listBox1.Items.Add("Paxlava (Tr) - 3.50azn");

            listBox1.Items.Add("");

            listBox1.Items.Add("Ana Yeməklər");
            listBox1.Items.Add("Dönər çörəkdə(50qr) - 3.50azn");
            listBox1.Items.Add("Dönər çörəkdə(100qr) - 4.50azn");
            listBox1.Items.Add("Dönər lavaşda(50qr) - 4.00azn");
            listBox1.Items.Add("Dönər Lavaşda(100qr) - 5.50azn");
            listBox1.Items.Add("Plov üstü Dönər(150qr) - 7.00azn");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cafeMoodcheck next = new cafeMoodcheck();
            next.label3.Text = comboBox1.Text;
            next.label4.Text = comboBox2.Text;
            next.label9.Text = comboBox3.Text;
            next.label22.Text = textBox2.Text;
            next.label6.Text = comboBox4.Text;
            next.label23.Text = textBox3.Text;
            next.label14.Text = comboBox8.Text;
            next.label16.Text = textBox1.Text;



            //ickiler

            if (comboBox3.Text == "Çay")
            {
                price = 1.00M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
                next.label10.Text = total.ToString();

            }

            else if (comboBox3.Text == "Kola")
            {
                price = 2.50M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
              

            }
            else if (comboBox3.Text == "Fanta")
            {
                price = 3.00M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
              

            }
            else if (comboBox3.Text == "Su")
            {
                price = 1.50M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
               

            }
            else if (comboBox3.Text == "Smoothie")
            {
                price = 8.00M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
             

            }
            else if (comboBox3.Text == "Milkshake")
            {
                price = 7.00M;
                int number = Convert.ToInt32(textBox2.Text);
                total = price * number;
              

            }

            //Sirniyatlar
            if (comboBox4.Text=="Magnolya") {
                price = 5.00M;
                int number = Convert.ToInt32(textBox3.Text);    
                total = total + price*number;
            }
          else  if (comboBox4.Text == "Napoleon")
            {
                price = 4.50M;
                int number = Convert.ToInt32(textBox3.Text);
                total = total + price * number;
            }
           else if (comboBox4.Text == "Paxlava (Az)")
            {
                price = 3.00M;
                int number = Convert.ToInt32(textBox3.Text);
                total = total + price * number;
            }
           else if (comboBox4.Text == "Paxlava (Tr)")
            {
                price = 3.50M;
                int number = Convert.ToInt32(textBox3.Text);
                total = total + price * number;
            }

            //Ana Yemekler
            if (comboBox8.Text=="Dönər çörəkdə(50qr)")
            {
                price = 3.50M;
                int number = Convert.ToInt32(textBox1.Text);
                total = total + price * number;
            }

            if (comboBox8.Text == "Dönər çörəkdə(100qr)")
            {
                price = 4.50M;
                int number = Convert.ToInt32(textBox1.Text);
                total = total + price * number;
            }

            if (comboBox8.Text == "Dönər lavaşda(50qr)")
            {
                price = 4.00M;
                int number = Convert.ToInt32(textBox1.Text);
                total = total + price * number;
            }

            if (comboBox8.Text == "Dönər lavaşda(100qr)")
            {
                price = 5.50M;
                int number = Convert.ToInt32(textBox1.Text);
                total = total + price * number;
            }

            if (comboBox8.Text == "Plov üstü Dönər(150qr)")
            {
                price = 7.00M;
                int number = Convert.ToInt32(textBox1.Text);
                total = total + price * number;
            }




            next.label10.Text = $"{total.ToString()} azn";
            next.Show();
        }
    }
}

