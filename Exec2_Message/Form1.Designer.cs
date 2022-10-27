namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.ClickButton = new System.Windows.Forms.Button();
			this.LabelOne = new System.Windows.Forms.Label();
			this.LabelTwo = new System.Windows.Forms.Label();
			this.ClickButton2 = new System.Windows.Forms.Button();
			this.ClickLabel1 = new System.Windows.Forms.Button();
			this.ClickLabel2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ClickButton
			// 
			this.ClickButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClickButton.Location = new System.Drawing.Point(37, 12);
			this.ClickButton.Name = "ClickButton";
			this.ClickButton.Size = new System.Drawing.Size(169, 85);
			this.ClickButton.TabIndex = 0;
			this.ClickButton.Text = "視窗報時";
			this.ClickButton.UseVisualStyleBackColor = true;
			this.ClickButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// LabelOne
			// 
			this.LabelOne.AutoSize = true;
			this.LabelOne.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelOne.Location = new System.Drawing.Point(480, 37);
			this.LabelOne.Name = "LabelOne";
			this.LabelOne.Size = new System.Drawing.Size(123, 35);
			this.LabelOne.TabIndex = 1;
			this.LabelOne.Text = "一行報時";
			// 
			// LabelTwo
			// 
			this.LabelTwo.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelTwo.Location = new System.Drawing.Point(489, 120);
			this.LabelTwo.Name = "LabelTwo";
			this.LabelTwo.Size = new System.Drawing.Size(636, 68);
			this.LabelTwo.TabIndex = 1;
			this.LabelTwo.Text = "兩行報時";
			// 
			// ClickButton2
			// 
			this.ClickButton2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClickButton2.Location = new System.Drawing.Point(37, 103);
			this.ClickButton2.Name = "ClickButton2";
			this.ClickButton2.Size = new System.Drawing.Size(169, 85);
			this.ClickButton2.TabIndex = 0;
			this.ClickButton2.Text = "視窗報時兩行";
			this.ClickButton2.UseVisualStyleBackColor = true;
			this.ClickButton2.Click += new System.EventHandler(this.ClickButton2_Click);
			// 
			// ClickLabel1
			// 
			this.ClickLabel1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClickLabel1.Location = new System.Drawing.Point(271, 12);
			this.ClickLabel1.Name = "ClickLabel1";
			this.ClickLabel1.Size = new System.Drawing.Size(169, 85);
			this.ClickLabel1.TabIndex = 0;
			this.ClickLabel1.Text = "標籤報時";
			this.ClickLabel1.UseVisualStyleBackColor = true;
			this.ClickLabel1.Click += new System.EventHandler(this.ClickLabel1_Click);
			// 
			// ClickLabel2
			// 
			this.ClickLabel2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClickLabel2.Location = new System.Drawing.Point(271, 103);
			this.ClickLabel2.Name = "ClickLabel2";
			this.ClickLabel2.Size = new System.Drawing.Size(169, 85);
			this.ClickLabel2.TabIndex = 0;
			this.ClickLabel2.Text = "標籤報時2行";
			this.ClickLabel2.UseVisualStyleBackColor = true;
			this.ClickLabel2.Click += new System.EventHandler(this.ClickLabel2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1268, 281);
			this.Controls.Add(this.LabelTwo);
			this.Controls.Add(this.LabelOne);
			this.Controls.Add(this.ClickLabel2);
			this.Controls.Add(this.ClickButton2);
			this.Controls.Add(this.ClickLabel1);
			this.Controls.Add(this.ClickButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ClickButton;
		private System.Windows.Forms.Label LabelOne;
		private System.Windows.Forms.Label LabelTwo;
		private System.Windows.Forms.Button ClickButton2;
		private System.Windows.Forms.Button ClickLabel1;
		private System.Windows.Forms.Button ClickLabel2;
	}
}

