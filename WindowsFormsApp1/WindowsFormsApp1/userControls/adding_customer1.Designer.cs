namespace WindowsFormsApp1.userControls
{
    partial class adding_customer1
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
            this.PHONENUMBERCUSTOMERBOX = new System.Windows.Forms.TextBox();
            this.LASTNAMECUSTOMERBOX = new System.Windows.Forms.TextBox();
            this.FIRSTNAMECUSTOMERBOX = new System.Windows.Forms.TextBox();
            this.IDCUSTOMERBOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PHONENUMBERCUSTOMERBOX
            // 
            this.PHONENUMBERCUSTOMERBOX.Location = new System.Drawing.Point(338, 322);
            this.PHONENUMBERCUSTOMERBOX.Name = "PHONENUMBERCUSTOMERBOX";
            this.PHONENUMBERCUSTOMERBOX.Size = new System.Drawing.Size(315, 26);
            this.PHONENUMBERCUSTOMERBOX.TabIndex = 10;
            // 
            // LASTNAMECUSTOMERBOX
            // 
            this.LASTNAMECUSTOMERBOX.Location = new System.Drawing.Point(338, 264);
            this.LASTNAMECUSTOMERBOX.Name = "LASTNAMECUSTOMERBOX";
            this.LASTNAMECUSTOMERBOX.Size = new System.Drawing.Size(315, 26);
            this.LASTNAMECUSTOMERBOX.TabIndex = 11;
            // 
            // FIRSTNAMECUSTOMERBOX
            // 
            this.FIRSTNAMECUSTOMERBOX.Location = new System.Drawing.Point(338, 206);
            this.FIRSTNAMECUSTOMERBOX.Name = "FIRSTNAMECUSTOMERBOX";
            this.FIRSTNAMECUSTOMERBOX.Size = new System.Drawing.Size(315, 26);
            this.FIRSTNAMECUSTOMERBOX.TabIndex = 12;
            // 
            // IDCUSTOMERBOX
            // 
            this.IDCUSTOMERBOX.Location = new System.Drawing.Point(338, 147);
            this.IDCUSTOMERBOX.Name = "IDCUSTOMERBOX";
            this.IDCUSTOMERBOX.Size = new System.Drawing.Size(315, 26);
            this.IDCUSTOMERBOX.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 30);
            this.label6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "first name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adding New Customre";
            // 
            // adding_customer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 664);
            this.Controls.Add(this.PHONENUMBERCUSTOMERBOX);
            this.Controls.Add(this.LASTNAMECUSTOMERBOX);
            this.Controls.Add(this.FIRSTNAMECUSTOMERBOX);
            this.Controls.Add(this.IDCUSTOMERBOX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adding_customer1";
            this.Text = "adding_customer1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PHONENUMBERCUSTOMERBOX;
        private System.Windows.Forms.TextBox LASTNAMECUSTOMERBOX;
        private System.Windows.Forms.TextBox FIRSTNAMECUSTOMERBOX;
        private System.Windows.Forms.TextBox IDCUSTOMERBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}