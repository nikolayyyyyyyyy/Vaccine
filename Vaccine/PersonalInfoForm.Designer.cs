namespace Vaccine
{
    partial class PersonalInfoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            male = new RadioButton();
            female = new RadioButton();
            ok_button = new Button();
            first_name = new TextBox();
            last_name = new TextBox();
            egn = new TextBox();
            years = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "first name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "EGN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "birth date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Location = new Point(17, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 98);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "sex";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(15, 32);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(14, 64);
            female.Name = "female";
            female.Size = new Size(76, 24);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "female";
            female.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            ok_button.Location = new Point(316, 301);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(94, 29);
            ok_button.TabIndex = 6;
            ok_button.Text = "Ok";
            ok_button.UseVisualStyleBackColor = true;
            // 
            // first_name
            // 
            first_name.Location = new Point(103, 28);
            first_name.Name = "first_name";
            first_name.Size = new Size(307, 27);
            first_name.TabIndex = 7;
            // 
            // last_name
            // 
            last_name.Location = new Point(103, 68);
            last_name.Name = "last_name";
            last_name.Size = new Size(307, 27);
            last_name.TabIndex = 8;
            // 
            // egn
            // 
            egn.Location = new Point(103, 107);
            egn.Name = "egn";
            egn.Size = new Size(307, 27);
            egn.TabIndex = 9;
            // 
            // years
            // 
            years.Location = new Point(103, 144);
            years.Name = "years";
            years.Size = new Size(307, 27);
            years.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // PersonalInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 339);
            Controls.Add(dateTimePicker1);
            Controls.Add(years);
            Controls.Add(egn);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(ok_button);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonalInfoForm";
            Text = "PersonalInfoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton female;
        private RadioButton male;
        private Button ok_button;
        private TextBox first_name;
        private TextBox last_name;
        private TextBox egn;
        private TextBox years;
        private DateTimePicker dateTimePicker1;
    }
}