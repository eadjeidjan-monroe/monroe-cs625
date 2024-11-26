namespace DemoWindowsForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			txtName = new TextBox();
			label2 = new Label();
			dateTimePicker1 = new DateTimePicker();
			lblInfo = new Label();
			obnOk = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(208, 62);
			label1.Name = "label1";
			label1.Size = new Size(52, 20);
			label1.TabIndex = 0;
			label1.Text = "Name:";
			// 
			// txtName
			// 
			txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtName.Location = new Point(266, 62);
			txtName.Name = "txtName";
			txtName.Size = new Size(483, 27);
			txtName.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(166, 119);
			label2.Name = "label2";
			label2.Size = new Size(94, 20);
			label2.TabIndex = 2;
			label2.Text = "Date of Birth";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePicker1.Location = new Point(286, 119);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 27);
			dateTimePicker1.TabIndex = 3;
			// 
			// lblInfo
			// 
			lblInfo.AutoSize = true;
			lblInfo.Font = new Font("Gigi", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lblInfo.ForeColor = SystemColors.MenuHighlight;
			lblInfo.Location = new Point(333, 230);
			lblInfo.Name = "lblInfo";
			lblInfo.Size = new Size(0, 32);
			lblInfo.TabIndex = 4;
			// 
			// obnOk
			// 
			obnOk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			obnOk.Location = new Point(311, 350);
			obnOk.Name = "obnOk";
			obnOk.Size = new Size(151, 47);
			obnOk.TabIndex = 5;
			obnOk.Text = "OK";
			obnOk.UseVisualStyleBackColor = true;
			obnOk.Click += obnOk_Click;
			// 
			// button1
			// 
			button1.Location = new Point(549, 337);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 6;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(obnOk);
			Controls.Add(lblInfo);
			Controls.Add(dateTimePicker1);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(label1);
			IsMdiContainer = true;
			Name = "Form1";
			Text = "My Demo Forms Application";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtName;
		private Label label2;
		private DateTimePicker dateTimePicker1;
		private Label lblInfo;
		private Button obnOk;
		private Button button1;
	}
}
