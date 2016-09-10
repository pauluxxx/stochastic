/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 10.09.2016
 * Time: 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace zero
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int[] rand = new int[100];//for gistogramma
		private int place = 1;//from what we continue
		private bool pause = false;//pause btn
		private Random r = new Random();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			clearmas(rand);
		}
		void clearmas(int[] rand)
		{
			for (int i = 0; i < rand.Length; i++) {
				rand[i] = 0;
			}
		}
		void RandomEvent()
		{
			double ran = r.NextDouble() * 10;
			double ransqrt = Math.Pow(ran, 2);
			ransqrt = Math.Floor(ransqrt);
			int ranint = Int32.Parse(ransqrt.ToString());
			rand[ranint] = rand[ranint] + 1;//can put into one expression
		}
		void BWorkerRandDoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			//my comp do all this work on a 3 min
			for (int i = place; (i <= 100000); i++) {
				if ((worker.CancellationPending == true)) {
					e.Cancel = true;
					break;
				} else {
					if (!pause) {
						RandomEvent();
						// Perform a time consuming operation and report progress.
						System.Threading.Thread.Sleep(1);
						worker.ReportProgress((i / 1000));
					} else {
						place = i;
						worker.CancelAsync();
						//System.Threading.Thread.ResetAbort();
					}
				}
			}
		}
		void BWorkerRandProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.wProgers.Value = e.ProgressPercentage;
		}
		void BWorkerRandRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)//event when i stop or pause
		{
			if (!pause) {//check pause
				if ((e.Cancelled == true)) {
					this.wProgers.Text = "Canceled!";//for console but i am so lazy to print it to console
					place = 1;
				} else if (!(e.Error == null)) {
					this.wProgers.Text = ("Error: " + e.Error.Message);
				} else {
					MessageBox.Show("done");
					place = 1;
				}
			} else {
				this.wProgers.Text = "Pause...";
			}
		}

		void showStat()
		{
			Form f = new Form1(rand);
			f.Show();
		}

		void Button3Click(object sender, EventArgs e)
		{
			if (bWorkerRand.WorkerSupportsCancellation) {
				showStat();
				clearmas(rand);
				bWorkerRand.CancelAsync();
			}
		}
	
		void Button2Click(object sender, EventArgs e)
		{
			if (bWorkerRand.WorkerSupportsCancellation) {
				pause = true;	
				showStat();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (!bWorkerRand.IsBusy) {
				pause = false;				
				bWorkerRand.RunWorkerAsync();
			}
		}
	}
}
