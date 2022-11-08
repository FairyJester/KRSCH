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
    public partial class Form2 : Form
    {
        private int[] nums;
        public Form2(int[] nums)
        {
            InitializeComponent();
            this.nums = nums;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sort(nums);

            String str = "";
            for (int i = 0; i < nums.Length; i++)
            {
                str += nums[i] + " ";
            }
            textBox1.Text = str;


        }
        public static void sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int x = array[i];


                int j = Math.Abs(Array.BinarySearch(array, 0, i, x) + 1);


                System.Array.Copy(array, j, array, j + 1, i - j);


                array[j] = x;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
