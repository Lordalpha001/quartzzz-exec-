using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FluxAPI;
using quartzz.Properties;
using Siticone.UI.WinForms;

namespace quartzz
{
	// Token: 0x02000002 RID: 2
	public partial class scripts : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public scripts()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00000269
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002071 File Offset: 0x00000271
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			this.Fluxus.Execute("loadstring(game: HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002083 File Offset: 0x00000283
		private void scripts_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private protected readonly Flux Fluxus = new Flux();
	}
}
