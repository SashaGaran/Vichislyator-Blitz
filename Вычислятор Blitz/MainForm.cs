using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вычислятор_Blitz
{
	public partial class MainWndw : Form
	{
		string[] строкі =
		{
			"Тут будет ",
			"опыта",
			"cеребра"
		};

		public MainWndw()
		{
			InitializeComponent();
			Anime();
			GoldBox_0.KeyPress += (s, e) => ForBtns(GoldBox_0, e);
			GoldBox_1.KeyPress += (s, e) => ForBtns(GoldBox_1, e);
			GoldBox_0.TextChanged += (s, e) => Вычисление(GoldBox_0, СереброLabel_0, 'З');
			GoldBox_1.TextChanged += (s, e) => Вычисление(GoldBox_1, ОпытLabel_0, 'О');
			АкцияChecker_0.CheckedChanged += (s, e) => Вычисление(GoldBox_1, ОпытLabel_0, 'О');
			СереброLabel_0.Click += (s, e) => Точность(СереброLabel_0, строкі[2]);
		}

		public async void Anime()
		{
			for (Opacity = 0; Opacity < 1; Opacity += 0.1)
			{await Task.Delay(1);}
		}

		void ForBtns(TextBox tb, KeyPressEventArgs e)
		{e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || tb.Text == "" && e.KeyChar == 48;}

		string Ограничение(string tb, string line, ushort num)
		{return Convert.ToUInt64(tb) * num >= 800000000 ? "Дохуя " + line: MyFrmt(Convert.ToUInt64(tb) * num);}

		void Вычисление(TextBox tb, Label lbl, char tp)
		{
			string t = tb.Text;
			if (t == "" || Convert.ToUInt64(t) == 0)
			{
				tb.Text = "";
				lbl.Text = tp == 'З' ?
					строкі[0] + "серебро":
					строкі[0] + "опыт";
			}
			else
			{
				tb.Text = (Convert.ToUInt64(tb.Text)).ToString();
				lbl.Text = tp == 'З' ?
					Ограничение(t, строкі[2], 400):
					!АкцияChecker_0.Checked ?
						Ограничение(t, строкі[1], 25):
						Ограничение(t, строкі[1], 30);
			}
		}

		void Точность(Label lbl, string line)
		{
			if (lbl.Text.StartsWith("Д"))
				MessageBox.Show(string.Format("А если быть точным, то {0} {1}.", MyFrmt(Convert.ToUInt64(GoldBox_0.Text) * 400), line), "Уточнение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		string MyFrmt(UInt64 num)
		{return num.ToString("### ### ### ###").Trim();}
	}
}