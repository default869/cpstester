
namespace cpsTestet
{
    partial class CPSTester
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кликер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:05";
            // 
            // cpsLabel
            // 
            this.cpsLabel.AutoSize = true;
            this.cpsLabel.Location = new System.Drawing.Point(94, 238);
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Size = new System.Drawing.Size(16, 13);
            this.cpsLabel.TabIndex = 2;
            this.cpsLabel.Text = "0 ";
            this.cpsLabel.Click += new System.EventHandler(this.cpsLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clicks!";
            // 
            // CPSTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CPSTester";
            this.Text = "CPSTester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cpsLabel;
        private System.Windows.Forms.Label label2;
    }
}

