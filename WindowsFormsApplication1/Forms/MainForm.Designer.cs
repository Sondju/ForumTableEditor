namespace WindowsFormsApplication1.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNewFile = new System.Windows.Forms.ToolStripButton();
			this.tsbOpenFile = new System.Windows.Forms.ToolStripButton();
			this.tsbSaveFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCutText = new System.Windows.Forms.ToolStripButton();
			this.tsbCopyText = new System.Windows.Forms.ToolStripButton();
			this.tsbPasteText = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbUndoText = new System.Windows.Forms.ToolStripButton();
			this.tsbRedoText = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbSearchText = new System.Windows.Forms.ToolStripButton();
			this.tsbReplaceText = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewFile,
            this.tsbOpenFile,
            this.tsbSaveFile,
            this.toolStripSeparator1,
            this.tsbCutText,
            this.tsbCopyText,
            this.tsbPasteText,
            this.toolStripSeparator2,
            this.tsbUndoText,
            this.tsbRedoText,
            this.toolStripSeparator3,
            this.tsbSearchText,
            this.tsbReplaceText,
            this.toolStripSeparator4,
            this.toolStripButton12,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(784, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNewFile
			// 
			this.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNewFile.Image = global::WindowsFormsApplication1.Properties.Resources.New;
			this.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewFile.Name = "tsbNewFile";
			this.tsbNewFile.Size = new System.Drawing.Size(23, 22);
			this.tsbNewFile.Text = "Новый";
			this.tsbNewFile.Click += new System.EventHandler(this.tsbNewFile_Click);
			// 
			// tsbOpenFile
			// 
			this.tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpenFile.Image = global::WindowsFormsApplication1.Properties.Resources.Open;
			this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpenFile.Name = "tsbOpenFile";
			this.tsbOpenFile.Size = new System.Drawing.Size(23, 22);
			this.tsbOpenFile.Text = "Открыть";
			this.tsbOpenFile.Click += new System.EventHandler(this.tsbOpenFile_Click);
			// 
			// tsbSaveFile
			// 
			this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSaveFile.Image = global::WindowsFormsApplication1.Properties.Resources.Save_1;
			this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSaveFile.Name = "tsbSaveFile";
			this.tsbSaveFile.Size = new System.Drawing.Size(23, 22);
			this.tsbSaveFile.Text = "Сохранить";
			this.tsbSaveFile.Click += new System.EventHandler(this.tsbSaveFile_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbCutText
			// 
			this.tsbCutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCutText.Image = global::WindowsFormsApplication1.Properties.Resources.Copy_1;
			this.tsbCutText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCutText.Name = "tsbCutText";
			this.tsbCutText.Size = new System.Drawing.Size(23, 22);
			this.tsbCutText.Text = "Вырезать";
			this.tsbCutText.Click += new System.EventHandler(this.tsbCutText_Click);
			// 
			// tsbCopyText
			// 
			this.tsbCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCopyText.Image = global::WindowsFormsApplication1.Properties.Resources.Copy_2;
			this.tsbCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCopyText.Name = "tsbCopyText";
			this.tsbCopyText.Size = new System.Drawing.Size(23, 22);
			this.tsbCopyText.Text = "Копировать";
			this.tsbCopyText.Click += new System.EventHandler(this.tsbCopyText_Click);
			// 
			// tsbPasteText
			// 
			this.tsbPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPasteText.Image = global::WindowsFormsApplication1.Properties.Resources.Copy_3;
			this.tsbPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPasteText.Name = "tsbPasteText";
			this.tsbPasteText.Size = new System.Drawing.Size(23, 22);
			this.tsbPasteText.Text = "Вставить";
			this.tsbPasteText.Click += new System.EventHandler(this.tsbPasteText_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbUndoText
			// 
			this.tsbUndoText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbUndoText.Image = global::WindowsFormsApplication1.Properties.Resources.Cancel_1;
			this.tsbUndoText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbUndoText.Name = "tsbUndoText";
			this.tsbUndoText.Size = new System.Drawing.Size(23, 22);
			this.tsbUndoText.Text = "Отменить";
			this.tsbUndoText.Click += new System.EventHandler(this.tsbUndoText_Click);
			// 
			// tsbRedoText
			// 
			this.tsbRedoText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbRedoText.Image = global::WindowsFormsApplication1.Properties.Resources.Cancel_2;
			this.tsbRedoText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRedoText.Name = "tsbRedoText";
			this.tsbRedoText.Size = new System.Drawing.Size(23, 22);
			this.tsbRedoText.Text = "Вернуть";
			this.tsbRedoText.Click += new System.EventHandler(this.tsbRedoText_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbSearchText
			// 
			this.tsbSearchText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSearchText.Image = global::WindowsFormsApplication1.Properties.Resources.Search_1;
			this.tsbSearchText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSearchText.Name = "tsbSearchText";
			this.tsbSearchText.Size = new System.Drawing.Size(23, 22);
			this.tsbSearchText.Text = "Поиск";
			this.tsbSearchText.Click += new System.EventHandler(this.tsbSearchText_Click);
			// 
			// tsbReplaceText
			// 
			this.tsbReplaceText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbReplaceText.Image = global::WindowsFormsApplication1.Properties.Resources.Search_2;
			this.tsbReplaceText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbReplaceText.Name = "tsbReplaceText";
			this.tsbReplaceText.Size = new System.Drawing.Size(23, 22);
			this.tsbReplaceText.Text = "Заменить";
			this.tsbReplaceText.Click += new System.EventHandler(this.tsbReplaceText_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton12.Image = global::WindowsFormsApplication1.Properties.Resources.Table;
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton12.Text = "Добавить строку ячейки";
			this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Файл текста BBCode|*.bbcode";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Файл текста BBCode|*.bbcode";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 536);
			this.panel1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.DetectUrls = false;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.EnableAutoDragDrop = true;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.richTextBox1.Size = new System.Drawing.Size(784, 536);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::WindowsFormsApplication1.Properties.Resources.Link;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактор BB-Code таблиц";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNewFile;
		private System.Windows.Forms.ToolStripButton tsbOpenFile;
		private System.Windows.Forms.ToolStripButton tsbSaveFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbCutText;
		private System.Windows.Forms.ToolStripButton tsbCopyText;
		private System.Windows.Forms.ToolStripButton tsbPasteText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbUndoText;
		private System.Windows.Forms.ToolStripButton tsbRedoText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbSearchText;
		private System.Windows.Forms.ToolStripButton tsbReplaceText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton12;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}

