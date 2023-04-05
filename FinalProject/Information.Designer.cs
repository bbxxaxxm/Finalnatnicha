namespace FinalProject
{
    partial class Information
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYearClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBorrow = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMajor = new System.Windows.Forms.TextBox();
            this.tbBookShelf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 27);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ-สกุล :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสนักศึกษา :";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(126, 77);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(151, 27);
            this.tbID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชั้นปี :";
            // 
            // tbYearClass
            // 
            this.tbYearClass.Location = new System.Drawing.Point(126, 146);
            this.tbYearClass.Name = "tbYearClass";
            this.tbYearClass.Size = new System.Drawing.Size(151, 27);
            this.tbYearClass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ชื่อหนังสือ :";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(124, 179);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(151, 27);
            this.tbBookName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "รหัสหนังสือ :";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(124, 211);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(151, 27);
            this.tbBookID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "วันที่ยืม :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "วันที่ส่งคืน :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeReturn);
            this.groupBox1.Controls.Add(this.dateTimeBorrow);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMajor);
            this.groupBox1.Controls.Add(this.tbBookShelf);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbYearClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbBookID);
            this.groupBox1.Controls.Add(this.tbBookName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 355);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ยืมหนังสือ";
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(124, 313);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(250, 27);
            this.dateTimeReturn.TabIndex = 18;
            // 
            // dateTimeBorrow
            // 
            this.dateTimeBorrow.Location = new System.Drawing.Point(124, 280);
            this.dateTimeBorrow.Name = "dateTimeBorrow";
            this.dateTimeBorrow.Size = new System.Drawing.Size(250, 27);
            this.dateTimeBorrow.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ชั้นหนังสือที่ :";
            // 
            // tbMajor
            // 
            this.tbMajor.Location = new System.Drawing.Point(124, 110);
            this.tbMajor.Name = "tbMajor";
            this.tbMajor.Size = new System.Drawing.Size(151, 27);
            this.tbMajor.TabIndex = 14;
            // 
            // tbBookShelf
            // 
            this.tbBookShelf.Location = new System.Drawing.Point(126, 244);
            this.tbBookShelf.Name = "tbBookShelf";
            this.tbBookShelf.Size = new System.Drawing.Size(151, 27);
            this.tbBookShelf.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "สาขา :";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(168, 373);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(98, 37);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 422);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Information";
            this.Text = "Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbID;
        private Label label3;
        private TextBox tbYearClass;
        private Label label4;
        private TextBox tbBookName;
        private Label label5;
        private TextBox tbBookID;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tbMajor;
        private Label label8;
        private Label label9;
        private TextBox tbBookShelf;
        private Button buttonSubmit;
        private DateTimePicker dateTimeReturn;
        private DateTimePicker dateTimeBorrow;
    }
}