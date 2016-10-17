using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1.Forms
{
	public partial class MainForm : Form
	{
		public bool m_DocumentChanged;

		public MainForm()
		{
			InitializeComponent();
		}

		private static readonly Dictionary<Color, Regex> Items = new Dictionary<Color, Regex>
		 {
			 { Color.Blue, new Regex("\\[(\\/?)tr\\]|\\[(\\/?)td\\]|\\[(\\/?)b\\]", RegexOptions.Compiled) },
			 { Color.Brown, new Regex("\\[url=(.+?)\\]|\\[(\\/?)url\\]", RegexOptions.Compiled) },
			 { Color.ForestGreen, new Regex("\\[(\\/?)img\\]", RegexOptions.Compiled) },
			 { Color.CornflowerBlue, new Regex("\\|\\[(\\/?)color\\]", RegexOptions.Compiled) }
		 };

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			var startCursorPosition = richTextBox1.SelectionStart;
			foreach (var item in Items)
			{
				var matches = item.Value.Matches(richTextBox1.Text);
				foreach (Match match in matches)
				{
					var startIndex = match.Index;
					var stopIndex = match.Length;
					richTextBox1.Select(startIndex, stopIndex);
					richTextBox1.SelectionColor = item.Key;
					richTextBox1.SelectionStart = startCursorPosition;
					richTextBox1.SelectionColor = Color.Black;
				}
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			m_DocumentChanged = true;
			tsbSaveFile.Image = Resources.Save_2;
		}

		private void tsbNewFile_Click(object sender, EventArgs e)
		{
			if (m_DocumentChanged)
			{
				SaveNeedForm dialog = new
				  SaveNeedForm();
				DialogResult result = dialog.ShowDialog();

				switch (result)
				{
					case DialogResult.Yes:
						{
							MenuFileSaveAs();
							break;
						}
					case DialogResult.Cancel:
						{
							return;
						}
				}
			}

			richTextBox1.Clear();
			DocementNotChanged();
		}

		private void tsbOpenFile_Click(object sender, EventArgs e)
		{
			if (m_DocumentChanged)
			{
				SaveNeedForm dialog = new
				  SaveNeedForm();
				DialogResult result = dialog.ShowDialog();

				switch (result)
				{
					case DialogResult.Yes:
						{
							MenuFileSaveAs();
							break;
						}
					case DialogResult.Cancel:
						{
							return;
						}
				}
			}
			//Если диалог отображен и нажата кнопка выбрать
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//Имя файла и директории хранитя в войстве FileName как строка
				var filename = openFileDialog1.FileName;

				//Покажем имя 
				Text = filename;

				//Создаем поток
				Stream stream = openFileDialog1.OpenFile();

				//Загружаем файл в RichTextBox
				richTextBox1.LoadFile(stream, RichTextBoxStreamType.RichText);

				//Закрываем поток
				stream.Close();
			}

			DocementNotChanged();
		}

		private void tsbSaveFile_Click(object sender, EventArgs e)
		{
			MenuFileSaveAs();
		}

		private void MenuFileSaveAs()
		{
			MemoryStream memorystream = new MemoryStream();
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//ассоциируем поток с именем файла - если фйла нет создаем
				var filestream = saveFileDialog1.OpenFile();
				memorystream.Position = 0;
				//сохраняем в поток содержимое richTextBox1
				richTextBox1.SaveFile(memorystream,
					  RichTextBoxStreamType.RichText);
				//переносим в файл информацию и закрываем поток
				memorystream.WriteTo(filestream);
				filestream.Close();

				DocementNotChanged();
			}
}

		private void DocementNotChanged()
		{
			m_DocumentChanged = false;
			tsbSaveFile.Image = Resources.Save_1;
		}

		private void tsbCutText_Click(object sender, EventArgs e)
		{
			// Ensure that text is currently selected in the text box.   
			if (richTextBox1.SelectedText != "")
				richTextBox1.Cut();
		}

		private void tsbCopyText_Click(object sender, EventArgs e)
		{
			// Ensure that text is selected in the text box.   
			if (richTextBox1.SelectionLength > 0)
				richTextBox1.Copy();
		}

		private void tsbPasteText_Click(object sender, EventArgs e)
		{
			// Determine if there is any text in the Clipboard to paste into the text box.
			var dataObject = Clipboard.GetDataObject();
			if (dataObject != null && dataObject.GetDataPresent(DataFormats.Text))
			{
				richTextBox1.Paste();
			}
		}

		private void tsbUndoText_Click(object sender, EventArgs e)
		{
			// Determine if last operation can be undone in text box.   
			if (richTextBox1.CanUndo)
			{
				richTextBox1.Undo();
			}
		}

		private void tsbRedoText_Click(object sender, EventArgs e)
		{
			// Determine if last operation can be undone in text box.   
			if (richTextBox1.CanRedo)
			{
				richTextBox1.Redo();
			}
		}
		
		private void tsbSearchText_Click(object sender, EventArgs e)
		{

		}

		private void tsbReplaceText_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton12_Click(object sender, EventArgs e)
		{
			TableData tableStringData = new TableData();
			if (tableStringData.ShowDialog(this) == DialogResult.OK)
			{
				richTextBox1.Paste();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			richTextBox1.AutoWordSelection = false;
		}
	}
}
