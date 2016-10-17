using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
	public partial class TableData : Form
	{
		public string myString = "";
		public TableData()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			returnedText();
			DialogResult=DialogResult.OK;
			Close();
		}

		private void returnedText()
		{
			// Добавляем в таблицу начало новой строки
			myString += "[tr]";

			// Добавляем ячейку выбора редакции
			myString += "[td]";
			if (checkBox9.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/26052.png[/img]";
			}
			myString += "[/td]";

			// Добавляем ячейку с названием и ссылкой
			myString += "[td][url=" + textBox2.Text + "]" + textBox1.Text + "[/url][/td]";

			// Добавляем ячейку автора
			myString += "[td]" + textBox3.Text + "[/td]";

			// Добавляем ячейку версии
			myString += "[td]" + textBox4.Text;
			if (checkBox11.Checked)
			{
				myString += "[color=red] Alpha[/color]";
			}
			else if (checkBox10.Checked)
			{
				myString += "[color=blue] Beta[/color]";
			}
			myString += "[/td]";

			// Открываем ячейку языков
			myString += "[td]";
			// Русский
			if (checkBox2.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/85893.png[/img]";
			}
			// Английский
			if (checkBox1.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/50560.png[/img]";
			}
			// Испанский
			if (checkBox5.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/81795.png[/img]";
			}
			// Итальянский
			if (checkBox4.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/95942.png[/img]";
			}
			// Китайский
			if (checkBox8.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/88458.png[/img]";
			}
			// Немецкий
			if (checkBox3.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/32939.png[/img]";
			}
			// Французский
			if (checkBox6.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/66762.png[/img]";
			}
			// Японский
			if (checkBox7.Checked)
			{
				myString += "[img]http://3bb.forum4.ru/files/0017/d1/b9/84794.png[/img]";
			}
			// Закрываем ячейку языков
			myString += "[/td]";

			// Добавляем ячейку функций
			myString += "[td]" + textBox6.Text + "[/td]";

			// Добавляем в таблицу конец строки
			myString += "[/tr]";

			// Копируем результат в буфер обмена
			textBox5.Text = myString;
			textBox5.SelectionStart = 0;
			textBox5.SelectionLength = textBox5.Text.Length;
			textBox5.Copy();
		}
	}
}
