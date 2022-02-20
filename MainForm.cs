using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Вычислятор_Blitz
{
	public partial class MainWndw : Form
	{
		string[] стркі =
		{
			"Тут будет ",
			"опыта",
			"cеребра",
			"СереброLabel_0",
			"Дохуя "
		};

		public MainWndw()
		{
			InitializeComponent();
			Anime();
			GoldBox_0.KeyPress += (s, e) => ForBtns(GoldBox_0, e);
			GoldBox_1.KeyPress += (s, e) => ForBtns(GoldBox_1, e);
			GoldBox_0.TextChanged += (s, e) => Вычисление(GoldBox_0, СереброLabel_0);
			GoldBox_1.TextChanged += (s, e) => Вычисление(GoldBox_1, ОпытLabel_0);
			АкцияChecker_0.CheckedChanged += (s, e) => Вычисление(GoldBox_1, ОпытLabel_0);
			СереброLabel_0.Click += (s, e) => Точность(СереброLabel_0, стркі[2], GoldBox_0);
			ОпытLabel_0.Click += (s, e) => Точность(ОпытLabel_0, стркі[1], GoldBox_1);
		}

		public async void Anime()
		{
			for (Opacity = 0; Opacity < 1; Opacity += 0.1)
			{await Task.Delay(1);}
		}

		void ForBtns(Control tb, KeyPressEventArgs e)
		{e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || tb.Text == "" && e.KeyChar == 48;}

		string Ограничение(string tb, string line, ushort num)
		{return Convert.ToUInt64(tb) * num >= 800000000 ? стркі[4] + line: MyFrmt(Convert.ToUInt64(tb) * num);}

		void Вычисление(Control tb, Label lbl)
		{
			string t = tb.Text;
			if (t == "" || Convert.ToUInt64(t) == 0)
			{
				tb.Text = "";
				lbl.Text = lbl.Name == стркі[3] ?
					стркі[0] + "серебро":
					стркі[0] + "опыт";
			}
			else
			{
				tb.Text = (Convert.ToUInt64(tb.Text)).ToString();
				lbl.Text = lbl.Name == стркі[3] ?
					Ограничение(t, стркі[2], 400):
					!АкцияChecker_0.Checked ?
						Ограничение(t, стркі[1], 25):
						Ограничение(t, стркі[1], 30);
			}
		}

		void Точность(Label lbl, string line, Control txt)
		{
			if (lbl.Text.StartsWith(стркі[4]))
			{
				if (lbl.Name == стркі[3])
					Msg(line, txt, 400);
				else
				{
					if (!АкцияChecker_0.Checked)
						Msg(line, txt, 25);
					else
						Msg(line, txt, 30);
				}
			}
		}

		void Msg(string line, Control txt, ushort num)
		{MessageBox.Show(string.Format("А если быть точным, то {0} {1}.", MyFrmt(Convert.ToUInt64(txt.Text) * num), line), "Уточнение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);}

		string MyFrmt(UInt64 num)
		{return num.ToString("### ### ### ###").Trim();}
	}
}