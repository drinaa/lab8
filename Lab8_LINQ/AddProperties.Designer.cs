namespace Lab8_LINQ
{
    partial class AddProperties
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
                #region Windows Form Designer generated code
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox rateTxtBox;
        private System.Windows.Forms.TextBox discountTxtBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dateConversLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label timeStartLabel;
        private System.Windows.Forms.Label timeFinishLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;

        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.rateTxtBox = new System.Windows.Forms.TextBox();
            this.discountTxtBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dateConversLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.timeStartLabel = new System.Windows.Forms.Label();
            this.timeFinishLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // surnameLabel
            //
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Width = 150;
            this.surnameLabel.Location = new System.Drawing.Point(25, 10);
            this.surnameLabel.Text = "Фамилия: ";
            // 
            // surnameTxtBox
            // 
            //this.surnameTxtBox.Location = new System.Drawing.Point(25, 35);
            //this.surnameTxtBox.Name = "surnameTxtBox";
            //this.surnameTxtBox.Size = new System.Drawing.Size(350, 22);
            //this.surnameTxtBox.TabIndex = 0;
            this.maskedTextBox4.Location = new System.Drawing.Point(25, 35);
            this.maskedTextBox4.Mask = ">L<LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(350, 22);
            this.maskedTextBox4.TabIndex = 0;
            //
            // phoneLabel
            //
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Width = 150;
            this.phoneLabel.Location = new System.Drawing.Point(25, 60);
            this.phoneLabel.Text = "Номер телефона: ";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(25, 85);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(350, 22);
            this.phoneTxtBox.TabIndex = 3;
            //
            // dateConversLabel
            //
            this.dateConversLabel.Name = "dateConversLabel";
            this.dateConversLabel.Width = 150;
            this.dateConversLabel.Location = new System.Drawing.Point(25, 110);
            this.dateConversLabel.Text = "Дата разговора: ";
            // 
            // dateConversTxtBox
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(25, 135);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(350, 22);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            //
            // rateLabel
            //
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Width = 300;
            this.rateLabel.Location = new System.Drawing.Point(25, 160);
            this.rateLabel.Text = "Тариф: ";
            // 
            // rateTxtBox
            // 
            this.rateTxtBox.Location = new System.Drawing.Point(25, 185);
            this.rateTxtBox.Name = "rateTxtBox";
            this.rateTxtBox.Size = new System.Drawing.Size(350, 22);
            this.rateTxtBox.TabIndex = 5;
            //
            // discountLabel
            //
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Width = 300;
            this.discountLabel.Location = new System.Drawing.Point(25, 210);
            this.discountLabel.Text = "Скидка в %: ";
            // 
            // discountTxtBox
            // 
            this.discountTxtBox.Location = new System.Drawing.Point(25, 235);
            this.discountTxtBox.Name = "discountTxtBox";
            this.discountTxtBox.Size = new System.Drawing.Size(350, 22);
            this.discountTxtBox.TabIndex = 6;
            //
            // timeStartLabel
            //
            this.timeStartLabel.Name = "timeStartLabel";
            this.timeStartLabel.Width = 300;
            this.timeStartLabel.Location = new System.Drawing.Point(25, 260);
            this.timeStartLabel.Text = "Время начала разговора: ";
            // 
            // timeStartTxtBox
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(25, 285);
            this.maskedTextBox2.Mask = "00:00:00";
            this.maskedTextBox2.Name = "timeStartTxtBox";
            this.maskedTextBox2.Size = new System.Drawing.Size(350, 22);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            //
            // timeFinishLabel
            //
            this.timeFinishLabel.Name = "timeFinishLabel";
            this.timeFinishLabel.Width = 300;
            this.timeFinishLabel.Location = new System.Drawing.Point(25, 310);
            this.timeFinishLabel.Text = "Время окончания разговора: ";
            // 
            // timeFinishTxtBox
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(25, 335);
            this.maskedTextBox3.Mask = "00:00:00";
            this.maskedTextBox3.Name = "timeFinishTxtBox";
            this.maskedTextBox3.Size = new System.Drawing.Size(350, 22);
            this.maskedTextBox3.TabIndex = 8;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.dateConversLabel);
            this.Controls.Add(this.timeStartLabel);
            this.Controls.Add(this.timeFinishLabel);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.rateTxtBox);
            this.Controls.Add(this.discountTxtBox);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProperties";
            this.Text = "Добавить разговор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}