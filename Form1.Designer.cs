namespace V9
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
            this.Ex1btn = new System.Windows.Forms.Button();
            this.Ex2btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вариант 9";
            // 
            // Ex1btn
            // 
            this.Ex1btn.Location = new System.Drawing.Point(12, 47);
            this.Ex1btn.Name = "Ex1btn";
            this.Ex1btn.Size = new System.Drawing.Size(118, 60);
            this.Ex1btn.TabIndex = 1;
            this.Ex1btn.Text = "Задание 1";
            this.Ex1btn.UseVisualStyleBackColor = true;
            this.Ex1btn.Click += new System.EventHandler(this.Ex1btn_Click);
            // 
            // Ex2btn
            // 
            this.Ex2btn.Location = new System.Drawing.Point(136, 47);
            this.Ex2btn.Name = "Ex2btn";
            this.Ex2btn.Size = new System.Drawing.Size(118, 60);
            this.Ex2btn.TabIndex = 2;
            this.Ex2btn.Text = "Задание 2";
            this.Ex2btn.UseVisualStyleBackColor = true;
            this.Ex2btn.Click += new System.EventHandler(this.Ex2btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 126);
            this.Controls.Add(this.Ex2btn);
            this.Controls.Add(this.Ex1btn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Навигация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ex1btn;
        private System.Windows.Forms.Button Ex2btn;
    }
}

