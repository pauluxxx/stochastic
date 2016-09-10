/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 10.09.2016
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace zero
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//this form for chart 
		}
		public Form1(int[] rand):this()
		{
			for (int i = 0; i < rand.Length; i++) {
				this.chart1.Series["rands"].Points.AddY(rand[i]);
			}
		}
		void Form1Deactivate(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
