namespace quartzz
{
	// Token: 0x02000002 RID: 2
	public partial class scripts : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002085 File Offset: 0x00000285
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::quartzz.scripts));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneButton4 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneLabel1 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneButton2 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton1 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton3 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneLabel2 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel3 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneElipse1 = new global::Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse2 = new global::Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse3 = new global::Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.siticoneButton4);
			this.panel1.Controls.Add(this.siticoneLabel1);
			this.panel1.Controls.Add(this.siticoneButton2);
			this.panel1.Controls.Add(this.siticoneButton1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(584, 42);
			this.panel1.TabIndex = 8;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::quartzz.Properties.Resources.Untitled_design_1__removebg_preview;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(23, 19);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.siticoneButton4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.siticoneButton4.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
			this.siticoneButton4.Location = new global::System.Drawing.Point(542, 3);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.PressedColor = global::System.Drawing.Color.DimGray;
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneButton4.TabIndex = 3;
			this.siticoneButton4.Text = "X";
			this.siticoneButton4.UseTransparentBackground = true;
			this.siticoneButton4.Click += new global::System.EventHandler(this.siticoneButton4_Click);
			this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel1.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneLabel1.Location = new global::System.Drawing.Point(41, 19);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new global::System.Drawing.Size(122, 14);
			this.siticoneLabel1.TabIndex = 2;
			this.siticoneLabel1.Text = "quartzz (scripts)";
			this.siticoneButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = global::System.Drawing.Color.FromArgb(64, 0, 0);
			this.siticoneButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new global::System.Drawing.Point(648, 3);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new global::System.Drawing.Size(66, 30);
			this.siticoneButton2.TabIndex = 1;
			this.siticoneButton2.Text = "_____";
			this.siticoneButton2.UseTransparentBackground = true;
			this.siticoneButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = global::System.Drawing.Color.FromArgb(64, 0, 0);
			this.siticoneButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new global::System.Drawing.Point(720, 3);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneButton1.TabIndex = 0;
			this.siticoneButton1.Text = "X";
			this.siticoneButton1.UseTransparentBackground = true;
			this.siticoneButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
			this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
			this.siticoneButton3.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.siticoneButton3.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
			this.siticoneButton3.Location = new global::System.Drawing.Point(12, 73);
			this.siticoneButton3.Name = "siticoneButton3";
			this.siticoneButton3.PressedColor = global::System.Drawing.Color.DimGray;
			this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
			this.siticoneButton3.Size = new global::System.Drawing.Size(110, 30);
			this.siticoneButton3.TabIndex = 4;
			this.siticoneButton3.Text = "inf yield";
			this.siticoneButton3.UseTransparentBackground = true;
			this.siticoneButton3.Click += new global::System.EventHandler(this.siticoneButton3_Click);
			this.siticoneLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel2.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneLabel2.Location = new global::System.Drawing.Point(5, 53);
			this.siticoneLabel2.Name = "siticoneLabel2";
			this.siticoneLabel2.Size = new global::System.Drawing.Size(129, 14);
			this.siticoneLabel2.TabIndex = 4;
			this.siticoneLabel2.Text = "admin / cool tools";
			this.siticoneLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel3.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.siticoneLabel3.Location = new global::System.Drawing.Point(12, 323);
			this.siticoneLabel3.Name = "siticoneLabel3";
			this.siticoneLabel3.Size = new global::System.Drawing.Size(122, 14);
			this.siticoneLabel3.TabIndex = 9;
			this.siticoneLabel3.Text = "more coming soon!";
			this.siticoneElipse1.BorderRadius = 10;
			this.siticoneElipse1.TargetControl = this;
			this.siticoneElipse2.TargetControl = this.siticoneButton3;
			this.siticoneElipse3.TargetControl = this.siticoneButton4;
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(584, 349);
			base.Controls.Add(this.siticoneLabel3);
			base.Controls.Add(this.siticoneLabel2);
			base.Controls.Add(this.siticoneButton3);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "scripts";
			this.Text = "scripts";
			base.Load += new global::System.EventHandler(this.scripts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000004 RID: 4
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton4;

		// Token: 0x04000005 RID: 5
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;

		// Token: 0x04000006 RID: 6
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton2;

		// Token: 0x04000007 RID: 7
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000008 RID: 8
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton3;

		// Token: 0x04000009 RID: 9
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;

		// Token: 0x0400000A RID: 10
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;

		// Token: 0x0400000B RID: 11
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;

		// Token: 0x0400000C RID: 12
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;

		// Token: 0x0400000D RID: 13
		private global::Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;

		// Token: 0x0400000E RID: 14
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
