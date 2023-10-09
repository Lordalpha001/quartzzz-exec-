using System;
using System.Windows.Forms;

namespace Monaco_Template
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00005B12 File Offset: 0x00003D12
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
