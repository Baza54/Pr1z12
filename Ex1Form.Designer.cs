namespace V9
{
    partial class Ex1Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumTb = new System.Windows.Forms.TextBox();
            this.AccBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дано целое число, лежащее в диапазоне от 1 до 9999.\r\nВывести строку — словесное о" +
    "писание данного числа\r\nвида \"четное двузначное число\", \"нечетное четырехзначное " +
    "число\" и т.д.";
            // 
            // NumTb
            // 
            this.NumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumTb.Location = new System.Drawing.Point(15, 75);
            this.NumTb.Name = "NumTb";
            this.NumTb.Size = new System.Drawing.Size(100, 26);
            this.NumTb.TabIndex = 1;
            // 
            // AccBtn
            // 
            this.AccBtn.Location = new System.Drawing.Point(133, 77);
            this.AccBtn.Name = "AccBtn";
            this.AccBtn.Size = new System.Drawing.Size(114, 23);
            this.AccBtn.TabIndex = 2;
            this.AccBtn.Text = "Вывод";
            this.AccBtn.UseVisualStyleBackColor = true;
            this.AccBtn.Click += new System.EventHandler(this.AccBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(272, 77);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(119, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "К навигации";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLbl.Location = new System.Drawing.Point(15, 116);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(0, 20);
            this.OutputLbl.TabIndex = 4;
            // 
            // Ex1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 162);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AccBtn);
            this.Controls.Add(this.NumTb);
            this.Controls.Add(this.label1);
            this.Name = "Ex1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumTb;
        private System.Windows.Forms.Button AccBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label OutputLbl;
    }
}