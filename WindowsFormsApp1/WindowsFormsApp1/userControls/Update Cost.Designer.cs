namespace WindowsFormsApp1.userControls
{
    partial class Update_Cost
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costupdatebox = new System.Windows.Forms.TextBox();
            this.productnumbercostupdatebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "Update Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = " New Cost";
            // 
            // costupdatebox
            // 
            this.costupdatebox.Location = new System.Drawing.Point(433, 196);
            this.costupdatebox.Name = "costupdatebox";
            this.costupdatebox.Size = new System.Drawing.Size(213, 26);
            this.costupdatebox.TabIndex = 20;
            // 
            // productnumbercostupdatebox
            // 
            this.productnumbercostupdatebox.Location = new System.Drawing.Point(433, 138);
            this.productnumbercostupdatebox.Name = "productnumbercostupdatebox";
            this.productnumbercostupdatebox.Size = new System.Drawing.Size(213, 26);
            this.productnumbercostupdatebox.TabIndex = 17;
            // 
            // Update_Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costupdatebox);
            this.Controls.Add(this.productnumbercostupdatebox);
            this.Name = "Update_Cost";
            this.Text = "Update_Cost";
            this.Load += new System.EventHandler(this.Update_Cost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costupdatebox;
        private System.Windows.Forms.TextBox productnumbercostupdatebox;
    }
}