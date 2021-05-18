using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice_game
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random random = new Random();
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1,7).ToString()));
		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1, 13).ToString()));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1, 19).ToString()));
		}
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1, 23).ToString()));
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1, 33).ToString()));
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show((random.Next(1, 101).ToString()));
		}
	}
}
