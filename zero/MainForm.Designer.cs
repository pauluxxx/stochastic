/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 10.09.2016
 * Time: 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace zero
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ProgressBar wProgers;
		private System.ComponentModel.BackgroundWorker bWorkerRand;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.wProgers = new System.Windows.Forms.ProgressBar();
			this.bWorkerRand = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(60, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 35);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.AutoEllipsis = true;
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(127, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 35);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(193, 65);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(41, 35);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// wProgers
			// 
			this.wProgers.Location = new System.Drawing.Point(60, 30);
			this.wProgers.Name = "wProgers";
			this.wProgers.Size = new System.Drawing.Size(174, 23);
			this.wProgers.TabIndex = 3;
			// 
			// bWorkerRand
			// 
			this.bWorkerRand.WorkerReportsProgress = true;
			this.bWorkerRand.WorkerSupportsCancellation = true;
			this.bWorkerRand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWorkerRandDoWork);
			this.bWorkerRand.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWorkerRandProgressChanged);
			this.bWorkerRand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWorkerRandRunWorkerCompleted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(284, 146);
			this.Controls.Add(this.wProgers);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "zero";
			this.ResumeLayout(false);

		}
	}
}
