using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krsch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(textBox1.Text);
                String[] sNums = textBox2.Text.Split(' ');

                int[] nums = new int[c];
                for (int i = 0; i < c; i++)
                {
                    nums[i] = int.Parse(sNums[i]);

                }
                

                Form2 form2 = new Form2(nums);
                form2.Show();

            }
            catch
            {
                MessageBox.Show("Ошибка!!!");
            }
            }
        

      
    }
}
