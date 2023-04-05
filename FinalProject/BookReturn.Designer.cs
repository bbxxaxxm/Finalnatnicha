namespace FinalProject
{
    partial class BookReturn
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
            this.tbBookIDRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBubReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBookIDRe
            // 
            this.tbBookIDRe.Location = new System.Drawing.Point(97, 43);
            this.tbBookIDRe.Name = "tbBookIDRe";
            this.tbBookIDRe.Size = new System.Drawing.Size(144, 27);
            this.tbBookIDRe.TabIndex = 0;
            this.tbBookIDRe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสหนังสือ :";
            // 
            // buttonBubReturn
            // 
            this.buttonBubReturn.Location = new System.Drawing.Point(76, 95);
            this.buttonBubReturn.Name = "buttonBubReturn";
            this.buttonBubReturn.Size = new System.Drawing.Size(92, 29);
            this.buttonBubReturn.TabIndex = 4;
            this.buttonBubReturn.Text = "submit";
            this.buttonBubReturn.UseVisualStyleBackColor = true;
            this.buttonBubReturn.Click += new System.EventHandler(this.buttonBubReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBubReturn);
            this.groupBox1.Controls.Add(this.tbBookIDRe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลคืนหนังสือ";
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookReturn";
            this.Text = "BookReturn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbBookIDRe;
        private Label label1;
        private Button buttonBubReturn;
        private GroupBox groupBox1;
    }
}