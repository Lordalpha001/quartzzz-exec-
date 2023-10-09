using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DiscordRpcDemo;
using FluxAPI;
using quartzz;
using quartzz.Properties;
using Siticone.UI.WinForms;
using VisualStudioTabControl;

namespace Monaco_Template
{
	// Token: 0x02000007 RID: 7
	public partial class Form1 : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000037F4 File Offset: 0x000019F4
		public Form1()
		{
			this.InitializeComponent();
			this.Fluxus.InitializeAPI("quartzz");
			this.console();
			this.LoadScriptFilesToListBox();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000385C File Offset: 0x00001A5C
		private void LoadScriptFilesToListBox()
		{
			string scriptFolderPath = Path.Combine(Environment.CurrentDirectory, "scriptfiles");
			if (Directory.Exists(scriptFolderPath))
			{
				foreach (string filePath in Directory.GetFiles(scriptFolderPath, "*.lua"))
				{
					this.listBox1.Items.Add(Path.GetFileName(filePath));
				}
				return;
			}
			MessageBox.Show("The 'scriptfiles' folder does not exist.");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000038C2 File Offset: 0x00001AC2
		private void console()
		{
			this.listBox2.Items.Add("[quartzz!]: hello!!");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000038DA File Offset: 0x00001ADA
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000038DC File Offset: 0x00001ADC
		private void addIntel(string label, string kind, string detail, string insertText)
		{
			"\"" + label + "\"";
			"\"" + kind + "\"";
			"\"" + detail + "\"";
			"\"" + insertText + "\"";
			this.webBrowser1.Document.InvokeScript("AddIntellisense", new object[]
			{
				label,
				kind,
				detail,
				insertText
			});
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000395C File Offset: 0x00001B5C
		private void addGlobalF()
		{
			foreach (string text in File.ReadAllLines(this.defPath + "//globalf.txt"))
			{
				if (text.Contains(':'))
				{
					this.addIntel(text, "Function", text, text.Substring(1));
				}
				else
				{
					this.addIntel(text, "Function", text, text);
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000039C0 File Offset: 0x00001BC0
		private void addGlobalV()
		{
			foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
			{
				this.addIntel(text, "Variable", text, text);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A24 File Offset: 0x00001C24
		private void addGlobalNS()
		{
			foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
			{
				this.addIntel(text, "Class", text, text);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003A88 File Offset: 0x00001C88
		private void addMath()
		{
			foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
			{
				this.addIntel(text, "Method", text, text);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003AEC File Offset: 0x00001CEC
		private void addBase()
		{
			foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
			{
				this.addIntel(text, "Keyword", text, text);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B50 File Offset: 0x00001D50
		private void Form1_Load(object sender, EventArgs e)
		{
			Form1.<Form1_Load>d__15 <Form1_Load>d__;
			<Form1_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Form1_Load>d__.<>4__this = this;
			<Form1_Load>d__.<>1__state = -1;
			<Form1_Load>d__.<>t__builder.Start<Form1.<Form1_Load>d__15>(ref <Form1_Load>d__);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B88 File Offset: 0x00001D88
		private void ExecuteBatchCode(string batchCode)
		{
			string tempBatchFile = "temp_batch.bat";
			File.WriteAllText(tempBatchFile, batchCode);
			Process process = new Process();
			process.StartInfo.FileName = tempBatchFile;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			string output = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			Console.WriteLine(output);
			File.Delete(tempBatchFile);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003BEF File Offset: 0x00001DEF
		private void FadeTimer_Tick(object sender, EventArgs e)
		{
			if (base.Opacity >= 1.0)
			{
				((Timer)sender).Stop();
				return;
			}
			base.Opacity += 0.05;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003C24 File Offset: 0x00001E24
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C26 File Offset: 0x00001E26
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C28 File Offset: 0x00001E28
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003C31 File Offset: 0x00001E31
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003C39 File Offset: 0x00001E39
		private void siticoneLabel1_Click(object sender, EventArgs e)
		{
			this.webBrowser1.Url = new Uri(string.Format("https://shattereddisk.github.io/rickroll", Array.Empty<object>()));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003C5A File Offset: 0x00001E5A
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			new credits().Show();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003C66 File Offset: 0x00001E66
		private void siticoneLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003C68 File Offset: 0x00001E68
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: trying to execute..");
			WebBrowser webBrowserInTab = this.visualStudioTabControl1.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault<WebBrowser>();
			if (webBrowserInTab != null)
			{
				HtmlDocument document = webBrowserInTab.Document;
				string scriptName = "GetText";
				object[] array = new string[0];
				object[] args = array;
				string script = document.InvokeScript(scriptName, args).ToString();
				this.Fluxus.Execute(script);
				return;
			}
			MessageBox.Show("WebBrowser control not found in the selected tab.");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003CE5 File Offset: 0x00001EE5
		private void button3_Click_1(object sender, EventArgs e)
		{
			this.Fluxus.Inject();
			this.listBox2.Items.Add("[quartzz!]: locking and loading!");
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D08 File Offset: 0x00001F08
		private void siticoneButton4_Click_1(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: clearing the board!!!");
			WebBrowser webBrowserInTab = this.visualStudioTabControl1.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault<WebBrowser>();
			if (webBrowserInTab != null)
			{
				webBrowserInTab.Document.InvokeScript("SetText", new object[]
				{
					""
				});
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003D68 File Offset: 0x00001F68
		private void siticoneButton5_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: killing boblox");
			Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003DAC File Offset: 0x00001FAC
		private void siticoneButton6_Click(object sender, EventArgs e)
		{
			this.Fluxus.Execute("loadstring(game: HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private void siticoneButton7_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: save it for later!!!");
			string str = "Script.lua";
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Lua files (.lua)|*.lua";
				saveFileDialog.Title = "Save script as";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					str = Path.GetFileName(saveFileDialog.FileName);
				}
			}
			try
			{
				File.Create(Path.Combine(Environment.CurrentDirectory, "scriptfiles", str)).Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error creating the file: " + ex.Message);
				return;
			}
			string contents = this.webBrowser1.Document.InvokeScript("GetText", new object[0]).ToString();
			File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "scriptfiles", str), contents);
			this.listBox1.Items.Clear();
			foreach (string file in Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "scriptfiles"), "*", SearchOption.AllDirectories))
			{
				this.listBox1.Items.Add(Path.GetFileName(file));
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F10 File Offset: 0x00002110
		private void siticoneButton8_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: open file prompt..");
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|Lua Files (.lua)|*.lua";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			this.webBrowser1.Document.InvokeScript("SetText", new object[]
			{
				File.ReadAllText(openFileDialog.FileName)
			});
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003F78 File Offset: 0x00002178
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedItem != null)
			{
				string selectedFile = this.listBox1.SelectedItem.ToString();
				string filePath = Path.Combine(Environment.CurrentDirectory, "scriptfiles", selectedFile);
				if (File.Exists(filePath))
				{
					string fileContent = File.ReadAllText(filePath);
					WebBrowser webBrowserInTab = this.visualStudioTabControl1.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault<WebBrowser>();
					if (webBrowserInTab != null)
					{
						webBrowserInTab.Document.InvokeScript("SetText", new object[]
						{
							fileContent
						});
						return;
					}
					MessageBox.Show("WebBrowser control not found in the selected tab.");
					return;
				}
				else
				{
					MessageBox.Show("File does not exist.");
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004017 File Offset: 0x00002217
		private void siticoneButton6_Click_1(object sender, EventArgs e)
		{
			new scripts().Show();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004024 File Offset: 0x00002224
		private void siticoneButton9_Click(object sender, EventArgs e)
		{
			if (this.tabCount < 7)
			{
				this.listBox2.Items.Add("[quartzz!]: hewo new tab!!");
				TabPage tb = new TabPage();
				tb.Text = "new tab " + (this.tabCount + 1).ToString();
				new SiticoneElipse().TargetControl = tb;
				new WebBrowser
				{
					ScriptErrorsSuppressed = false,
					AllowWebBrowserDrop = false,
					Parent = tb,
					Dock = DockStyle.Fill
				}.Navigate(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
				this.visualStudioTabControl1.Controls.Add(tb);
				this.visualStudioTabControl1.SelectTab(tb);
				this.tabCount++;
				return;
			}
			MessageBox.Show("The maximum tab limit of 7 has been reached.", "Tab Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000040F8 File Offset: 0x000022F8
		private void siticoneButton10_Click(object sender, EventArgs e)
		{
			if (this.visualStudioTabControl1.TabCount > 1)
			{
				int tabIndexToRemove = this.visualStudioTabControl1.TabCount - 1;
				this.visualStudioTabControl1.SelectTab(tabIndexToRemove - 1);
				this.visualStudioTabControl1.TabPages.RemoveAt(tabIndexToRemove);
				this.tabCount--;
				this.listBox2.Items.Add("[quartzz!]: say goodbye!!");
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004164 File Offset: 0x00002364
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004166 File Offset: 0x00002366
		private void siticoneButton11_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Clear();
			this.listBox2.Items.Add("[clr-quartzz!]: cleared the console!");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000418E File Offset: 0x0000238E
		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{
			new scripts().Show();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000419C File Offset: 0x0000239C
		private void siticoneImageButton2_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Add("[quartzz!]: killing boblox");
			Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000041E0 File Offset: 0x000023E0
		private void siticoneImageButton3_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Clear();
			this.listBox2.Items.Add("[clr-quartzz!]: cleared the console!");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004208 File Offset: 0x00002408
		private void siticoneLabel5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000420A File Offset: 0x0000240A
		private void siticoneLabel3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000420C File Offset: 0x0000240C
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000420E File Offset: 0x0000240E
		private void siticoneLabel4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004210 File Offset: 0x00002410
		private void visualStudioTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004212 File Offset: 0x00002412
		private void siticoneButton3_Click_1(object sender, EventArgs e)
		{
			new credits().Show();
		}

		// Token: 0x04000023 RID: 35
		private protected readonly Flux Fluxus = new Flux();

		// Token: 0x04000024 RID: 36
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000025 RID: 37
		private DiscordRpc.RichPresence presence;

		// Token: 0x04000026 RID: 38
		private WebClient wc = new WebClient();

		// Token: 0x04000027 RID: 39
		private string defPath = Application.StartupPath + "//Monaco//";

		// Token: 0x04000028 RID: 40
		private double opacity;

		// Token: 0x04000029 RID: 41
		private bool fadingOut;

		// Token: 0x0400002A RID: 42
		private int tabCount = 1;

		// Token: 0x0400002B RID: 43
		private const int maxTabs = 7;
	}
}
