namespace WindowsFormsApplication1.Forms
{
	partial class SaveNeedForm
	{
		private System.Windows.Forms.Button buttonYes;
		private System.Windows.Forms.Button buttonNo;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonYes = new System.Windows.Forms.Button();
			this.buttonNo = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonYes
			// 
			this.buttonYes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.buttonYes.Location = new System.Drawing.Point(232, 88);
			this.buttonYes.Name = "buttonYes";
			this.buttonYes.Size = new System.Drawing.Size(75, 23);
			this.buttonYes.TabIndex = 0;
			this.buttonYes.Text = "Да";
			this.buttonYes.UseVisualStyleBackColor = false;
			// 
			// buttonNo
			// 
			this.buttonNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.buttonNo.Location = new System.Drawing.Point(232, 120);
			this.buttonNo.Name = "buttonNo";
			this.buttonNo.Size = new System.Drawing.Size(75, 23);
			this.buttonNo.TabIndex = 1;
			this.buttonNo.Text = "Нет";
			this.buttonNo.UseVisualStyleBackColor = false;
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(232, 152);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Отменить";
			this.buttonCancel.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 136);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(208, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Внимание!";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(208, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Документ был изменён.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(208, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Сохранить изменения?";
			// 
			// SaveNeedForm
			// 
			this.AcceptButton = this.buttonYes;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(352, 189);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonNo);
			this.Controls.Add(this.buttonYes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SaveNeedForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Несохранённые данные";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}