namespace RetiredPlayers
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.player = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(67, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(43, 21);
            this.number.TabIndex = 1;
            this.number.SelectedIndexChanged += new System.EventHandler(this.number_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player.Location = new System.Drawing.Point(192, 12);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(95, 23);
            this.player.TabIndex = 2;
            this.player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year
            // 
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.year.Location = new System.Drawing.Point(377, 12);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(55, 23);
            this.year.TabIndex = 3;
            this.year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "and retired in ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "was worn by ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 49);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.year);
            this.Controls.Add(this.player);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Retired Jersey Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

