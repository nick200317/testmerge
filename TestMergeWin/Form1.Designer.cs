
namespace TestMergeWin
{
	partial class MainForm
	{
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
			if(disposing && (components != null))
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
            this.nud_FirstNumber = new System.Windows.Forms.NumericUpDown();
            this.nud_SecondNumber = new System.Windows.Forms.NumericUpDown();
            this.tb_Res = new System.Windows.Forms.TextBox();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_FirstNumber
            // 
            this.nud_FirstNumber.Location = new System.Drawing.Point(21, 12);
            this.nud_FirstNumber.Name = "nud_FirstNumber";
            this.nud_FirstNumber.Size = new System.Drawing.Size(62, 20);
            this.nud_FirstNumber.TabIndex = 0;
            // 
            // nud_SecondNumber
            // 
            this.nud_SecondNumber.Location = new System.Drawing.Point(100, 12);
            this.nud_SecondNumber.Name = "nud_SecondNumber";
            this.nud_SecondNumber.Size = new System.Drawing.Size(62, 20);
            this.nud_SecondNumber.TabIndex = 1;
            // 
            // tb_Res
            // 
            this.tb_Res.Location = new System.Drawing.Point(21, 50);
            this.tb_Res.Name = "tb_Res";
            this.tb_Res.Size = new System.Drawing.Size(141, 20);
            this.tb_Res.TabIndex = 2;
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(21, 76);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(141, 23);
            this.btn_Sum.TabIndex = 3;
            this.btn_Sum.Text = "Сложить";
            this.btn_Sum.UseVisualStyleBackColor = true;
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(21, 105);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(141, 23);
            this.btn_Div.TabIndex = 4;
            this.btn_Div.Text = "Вычесть";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 137);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.tb_Res);
            this.Controls.Add(this.nud_SecondNumber);
            this.Controls.Add(this.nud_FirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nud_FirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nud_FirstNumber;
		private System.Windows.Forms.NumericUpDown nud_SecondNumber;
		private System.Windows.Forms.TextBox tb_Res;
		private System.Windows.Forms.Button btn_Sum;
		private System.Windows.Forms.Button btn_Div;
	}
}

