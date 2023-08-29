using System;
using System.Windows.Forms;

namespace QLTK;

internal static class Program
{
	[STAThread]
    [Obsolete]
    private static void Main()
	{
		AppDomain.CurrentDomain.AppendPrivatePath("Data\\lib");
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new QLTK());
	}
}
