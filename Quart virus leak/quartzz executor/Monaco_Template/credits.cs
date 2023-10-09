using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FluxAPI;
using quartzz;
using quartzz.Properties;
using Siticone.UI.WinForms;

namespace Monaco_Template
{
	// Token: 0x02000006 RID: 6
	public partial class credits : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002C92 File Offset: 0x00000E92
		public credits()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002CAB File Offset: 0x00000EAB
		private void siticoneLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002CAD File Offset: 0x00000EAD
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002CB5 File Offset: 0x00000EB5
		private void credits_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002CB7 File Offset: 0x00000EB7
		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{
			new scripts().Show();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002CC4 File Offset: 0x00000EC4
		private void siticoneImageButton2_Click(object sender, EventArgs e)
		{
			new Form1().listBox2.Items.Add("[quartzz!]: killing boblox");
			Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002D0C File Offset: 0x00000F0C
		private void siticoneImageButton3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.listBox2.Items.Clear();
			form.listBox2.Items.Add("[clr-quartzz!]: cleared the console!");
		}

		// Token: 0x04000013 RID: 19
		private protected readonly Flux Fluxus = new Flux();
	}
}
