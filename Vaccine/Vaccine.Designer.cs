namespace Vaccine
{
    partial class Vaccine
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
            groupBox1 = new GroupBox();
            tetafid = new RadioButton();
            bcj = new RadioButton();
            hepatit = new RadioButton();
            save_btn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tetafid);
            groupBox1.Controls.Add(bcj);
            groupBox1.Controls.Add(hepatit);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vaccines";
            // 
            // tetafid
            // 
            tetafid.AutoSize = true;
            tetafid.Location = new Point(6, 86);
            tetafid.Name = "tetafid";
            tetafid.Size = new Size(149, 24);
            tetafid.TabIndex = 2;
            tetafid.TabStop = true;
            tetafid.Text = "ТетаДиф ваксина";
            tetafid.UseVisualStyleBackColor = true;
            // 
            // bcj
            // 
            bcj.AutoSize = true;
            bcj.Location = new Point(6, 56);
            bcj.Name = "bcj";
            bcj.Size = new Size(123, 24);
            bcj.TabIndex = 1;
            bcj.TabStop = true;
            bcj.Text = "БЦЖ ваксина";
            bcj.UseVisualStyleBackColor = true;
            // 
            // hepatit
            // 
            hepatit.AutoSize = true;
            hepatit.Location = new Point(6, 26);
            hepatit.Name = "hepatit";
            hepatit.Size = new Size(194, 24);
            hepatit.TabIndex = 0;
            hepatit.TabStop = true;
            hepatit.Text = "Хепатит тип Б(1 прием)";
            hepatit.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(139, 178);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(111, 29);
            save_btn.TabIndex = 1;
            save_btn.Text = "Save in txt file";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // Vaccine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 219);
            Controls.Add(save_btn);
            Controls.Add(groupBox1);
            Name = "Vaccine";
            Text = "Vaccine";
            Load += Vaccine_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton tetafid;
        private RadioButton bcj;
        private RadioButton hepatit;
        private Button save_btn;
    }
}