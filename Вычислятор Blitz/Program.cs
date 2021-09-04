using System;
using System.Windows.Forms;
namespace Вычислятор_Blitz
{
	sealed class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWndw());
		}
	}
}