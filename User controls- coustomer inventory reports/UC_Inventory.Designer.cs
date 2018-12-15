namespace WindowsFormsApp1.userControls
{
    partial class UC_Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.newProductButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelINup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelINrep = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picInupleft = new System.Windows.Forms.PictureBox();
            this.picInrepritht = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelINup.SuspendLayout();
            this.panelINrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInupleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInrepritht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(307, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // newProductButton
            // 
            this.newProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.newProductButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductButton.ForeColor = System.Drawing.Color.White;
            this.newProductButton.Location = new System.Drawing.Point(105, 163);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(156, 80);
            this.newProductButton.TabIndex = 2;
            this.newProductButton.Text = "New\r\n product";
            this.newProductButton.UseVisualStyleBackColor = false;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(472, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(105, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 78);
            this.button4.TabIndex = 2;
            this.button4.Text = "Update\r\n Quantity ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(105, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 70);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update\r\n Cost";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelINup
            // 
            this.panelINup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelINup.Controls.Add(this.pictureBox1);
            this.panelINup.Controls.Add(this.picInupleft);
            this.panelINup.Controls.Add(this.label2);
            this.panelINup.Location = new System.Drawing.Point(45, 111);
            this.panelINup.Name = "panelINup";
            this.panelINup.Size = new System.Drawing.Size(282, 396);
            this.panelINup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory\r\nupdate";
            // 
            // panelINrep
            // 
            this.panelINrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelINrep.Controls.Add(this.pictureBox2);
            this.panelINrep.Controls.Add(this.picInrepritht);
            this.panelINrep.Controls.Add(this.label3);
            this.panelINrep.Location = new System.Drawing.Point(419, 108);
            this.panelINrep.Name = "panelINrep";
            this.panelINrep.Size = new System.Drawing.Size(282, 399);
            this.panelINrep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 68);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inventory\r\nreport";
            // 
            // picInupleft
            // 
            this.picInupleft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picInupleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInupleft.Image = ((System.Drawing.Image)(resources.GetObject("picInupleft.Image")));
            this.picInupleft.Location = new System.Drawing.Point(245, 363);
            this.picInupleft.Name = "picInupleft";
            this.picInupleft.Size = new System.Drawing.Size(34, 30);
            this.picInupleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInupleft.TabIndex = 3;
            this.picInupleft.TabStop = false;
            this.picInupleft.Click += new System.EventHandler(this.picInupleft_Click);
            // 
            // picInrepritht
            // 
            this.picInrepritht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picInrepritht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInrepritht.Image = ((System.Drawing.Image)(resources.GetObject("picInrepritht.Image")));
            this.picInrepritht.Location = new System.Drawing.Point(245, 369);
            this.picInrepritht.Name = "picInrepritht";
            this.picInrepritht.Size = new System.Drawing.Size(34, 30);
            this.picInrepritht.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInrepritht.TabIndex = 4;
            this.picInrepritht.TabStop = false;
            this.picInrepritht.Click += new System.EventHandler(this.picInrepritht_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UC_Inventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelINrep);
            this.Controls.Add(this.panelINup);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProductButton);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(763, 531);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            this.panelINup.ResumeLayout(false);
            this.panelINup.PerformLayout();
            this.panelINrep.ResumeLayout(false);
            this.panelINrep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInupleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInrepritht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelINup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelINrep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picInupleft;
        private System.Windows.Forms.PictureBox picInrepritht;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
