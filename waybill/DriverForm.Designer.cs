namespace waybill
{
    partial class DriverForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMedFor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCertSer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCertFor = new System.Windows.Forms.TextBox();
            this.textBoxCertNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(80, 47);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(39, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 3;
            this.name.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "med_for";
            // 
            // textBoxMedFor
            // 
            this.textBoxMedFor.Location = new System.Drawing.Point(80, 99);
            this.textBoxMedFor.Name = "textBoxMedFor";
            this.textBoxMedFor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedFor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "cert";
            // 
            // textBoxCertSer
            // 
            this.textBoxCertSer.Location = new System.Drawing.Point(80, 125);
            this.textBoxCertSer.Name = "textBoxCertSer";
            this.textBoxCertSer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCertSer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "cert_for";
            // 
            // textBoxCertFor
            // 
            this.textBoxCertFor.Location = new System.Drawing.Point(80, 151);
            this.textBoxCertFor.Name = "textBoxCertFor";
            this.textBoxCertFor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCertFor.TabIndex = 8;
            // 
            // textBoxCertNum
            // 
            this.textBoxCertNum.Location = new System.Drawing.Point(186, 125);
            this.textBoxCertNum.Name = "textBoxCertNum";
            this.textBoxCertNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxCertNum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 76);
            this.button1.TabIndex = 11;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCertNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCertFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCertSer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMedFor);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMedFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCertSer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCertFor;
        private System.Windows.Forms.TextBox textBoxCertNum;
        private System.Windows.Forms.Button button1;
    }
}

