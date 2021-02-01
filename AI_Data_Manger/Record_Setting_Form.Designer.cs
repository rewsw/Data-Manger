namespace AI_Data_Manger
{
    partial class Record_Setting_Form
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
            this.Data_usefor_cbox = new System.Windows.Forms.ComboBox();
            this.Model_cbox = new System.Windows.Forms.ComboBox();
            this.thick_cbox = new System.Windows.Forms.ComboBox();
            this.Frequency_cbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.Class_cbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_cbox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Collect_num_tb = new System.Windows.Forms.TextBox();
            this.Descriptor_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data_usefor_cbox
            // 
            this.Data_usefor_cbox.FormattingEnabled = true;
            this.Data_usefor_cbox.Items.AddRange(new object[] {
            "Train",
            "Test"});
            this.Data_usefor_cbox.Location = new System.Drawing.Point(62, 164);
            this.Data_usefor_cbox.Name = "Data_usefor_cbox";
            this.Data_usefor_cbox.Size = new System.Drawing.Size(76, 20);
            this.Data_usefor_cbox.TabIndex = 0;
            // 
            // Model_cbox
            // 
            this.Model_cbox.FormattingEnabled = true;
            this.Model_cbox.Items.AddRange(new object[] {
            "P3029",
            "P3022",
            "P3023",
            "P3008"});
            this.Model_cbox.Location = new System.Drawing.Point(62, 36);
            this.Model_cbox.Name = "Model_cbox";
            this.Model_cbox.Size = new System.Drawing.Size(76, 20);
            this.Model_cbox.TabIndex = 1;
            // 
            // thick_cbox
            // 
            this.thick_cbox.FormattingEnabled = true;
            this.thick_cbox.Items.AddRange(new object[] {
            "1.8mm",
            "4.0mm"});
            this.thick_cbox.Location = new System.Drawing.Point(62, 78);
            this.thick_cbox.Name = "thick_cbox";
            this.thick_cbox.Size = new System.Drawing.Size(76, 20);
            this.thick_cbox.TabIndex = 2;
            // 
            // Frequency_cbox
            // 
            this.Frequency_cbox.FormattingEnabled = true;
            this.Frequency_cbox.Items.AddRange(new object[] {
            "40KHz"});
            this.Frequency_cbox.Location = new System.Drawing.Point(62, 122);
            this.Frequency_cbox.Name = "Frequency_cbox";
            this.Frequency_cbox.Size = new System.Drawing.Size(76, 20);
            this.Frequency_cbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "型號 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "厚度 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "頻率 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "類型 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "日期 : ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 333);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "類別 : ";
            // 
            // Class_cbox
            // 
            this.Class_cbox.FormattingEnabled = true;
            this.Class_cbox.Items.AddRange(new object[] {
            "Hand",
            "Water"});
            this.Class_cbox.Location = new System.Drawing.Point(62, 206);
            this.Class_cbox.Name = "Class_cbox";
            this.Class_cbox.Size = new System.Drawing.Size(76, 20);
            this.Class_cbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "人名 : ";
            // 
            // Name_cbox
            // 
            this.Name_cbox.FormattingEnabled = true;
            this.Name_cbox.Items.AddRange(new object[] {
            "David",
            "Lance",
            "Hunter",
            "Jamie",
            "Jermy",
            "Peter"});
            this.Name_cbox.Location = new System.Drawing.Point(62, 247);
            this.Name_cbox.Name = "Name_cbox";
            this.Name_cbox.Size = new System.Drawing.Size(76, 20);
            this.Name_cbox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Finger",
            "Tumb",
            "Water",
            "Palm",
            "Water Finger"});
            this.comboBox1.Location = new System.Drawing.Point(62, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 20);
            this.comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "小類別 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "筆數 : ";
            // 
            // Collect_num_tb
            // 
            this.Collect_num_tb.Location = new System.Drawing.Point(56, 520);
            this.Collect_num_tb.Name = "Collect_num_tb";
            this.Collect_num_tb.Size = new System.Drawing.Size(72, 22);
            this.Collect_num_tb.TabIndex = 17;
            this.Collect_num_tb.Text = "1000";
            // 
            // Descriptor_tb
            // 
            this.Descriptor_tb.Location = new System.Drawing.Point(56, 558);
            this.Descriptor_tb.Multiline = true;
            this.Descriptor_tb.Name = "Descriptor_tb";
            this.Descriptor_tb.Size = new System.Drawing.Size(226, 69);
            this.Descriptor_tb.TabIndex = 18;
            this.Descriptor_tb.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "描述 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Record_Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Descriptor_tb);
            this.Controls.Add(this.Collect_num_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Name_cbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Class_cbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Frequency_cbox);
            this.Controls.Add(this.thick_cbox);
            this.Controls.Add(this.Model_cbox);
            this.Controls.Add(this.Data_usefor_cbox);
            this.Name = "Record_Setting_Form";
            this.Text = "Record_Setting_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Data_usefor_cbox;
        private System.Windows.Forms.ComboBox Model_cbox;
        private System.Windows.Forms.ComboBox thick_cbox;
        private System.Windows.Forms.ComboBox Frequency_cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Class_cbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Name_cbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Collect_num_tb;
        private System.Windows.Forms.TextBox Descriptor_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}