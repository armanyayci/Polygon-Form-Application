using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme
{
    public partial class Form1 : Form
    {
        Bitmap poli_draw;
        Point2D class1 = new Point2D();   //class 1 contains point2D datas

        Polygon class2 = new Polygon();     //class 2 contains polygon datas
        public Form1()
        {
            InitializeComponent();
            poli_draw = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height); //declaring a bitmap to draw the polygon
            pictureBox1.Image = poli_draw;      //equalizing the picturebox image to polidraw bitmap
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //getting x and y cordinates if it is empty random values will be apply to
            if (cordinate_X.Text == "" || cordinate_Y.Text == "")
            {
                cordinate_total.Text = Convert.ToString("(" + class1.x + "," + class1.y + ")");
                cordinate_X.Text = Convert.ToString(class1.x);
                cordinate_Y.Text = Convert.ToString(class1.y);
            }
            else
            {
                cordinate_total.Text = ("C(" + cordinate_X.Text + "," + cordinate_Y.Text + ")");
                class1.x = Convert.ToInt32(cordinate_X.Text);
                class1.y = Convert.ToInt32(cordinate_Y.Text);
            }
            //gets the length if it is empty random values will be apply to
            if (input_length.Text == "")
            {
                length_total.Text = Convert.ToString(class2.length);
                input_length.Text = Convert.ToString(class2.length);
            }
            else
            {
                length_total.Text = (input_length.Text);
                class2.length = Convert.ToInt32(input_length.Text);
            }
            //gets the edge number at least 3 if it is empty random values will be apply to
            if (input_edge.Text == "")
            {
                input_edge.Text = Convert.ToString(class2.edges);
                edge_total.Text = Convert.ToString(class2.edges);
            }
            else
            {
                edge_total.Text = (input_edge.Text);
                class2.edges = Convert.ToInt32(input_edge.Text);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)  // this button is for drawing the polygon
        {
            Polygon class3 = new Polygon();     //declaring new polygon class 
            poli_draw = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);        
            pictureBox1.Image = poli_draw;

            class3.length = Convert.ToInt32(input_length.Text);         //equalizing the textboxs to data 
            class3.edges = Convert.ToInt32(input_edge.Text);
            class3.center.x = Convert.ToInt32(cordinate_X.Text);
            class3.center.y = Convert.ToInt32(cordinate_Y.Text);

            Pen pen = new Pen(Color.Black, 3);          //declaring pen and its color
            Graphics g = Graphics.FromImage(poli_draw);         //declaring grapichs for drawing the polygon
            g.DrawLines(pen, class3.calculateEdgeCordinate());
            g.DrawLine(pen, class3.calculateEdgeCordinate()[0], class3.calculateEdgeCordinate()[class3.edges - 1]);
            pictureBox1.Image = poli_draw;
            g.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)      //this button is for clear the form
        {
            cordinate_X.Text = "";
            cordinate_Y.Text = "";
            cordinate_total.Text = "";
            input_length.Text = "";
            input_edge.Text = "";
            length_total.Text = "";
            edge_total.Text = "";
            pictureBox1.Image = null;

        }
    }
}
