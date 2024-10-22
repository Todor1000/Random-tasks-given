namespace Xerath
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
            this.Mana = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.health = new System.Windows.Forms.ProgressBar();
            this.AT = new System.Windows.Forms.Button();
            this.Arcanopulse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mana
            // 
            this.Mana.BackColor = System.Drawing.Color.White;
            this.Mana.ForeColor = System.Drawing.Color.Blue;
            this.Mana.Location = new System.Drawing.Point(29, 110);
            this.Mana.Name = "Mana";
            this.Mana.Size = new System.Drawing.Size(178, 23);
            this.Mana.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Mana.TabIndex = 0;
            this.Mana.Value = 100;
            this.Mana.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Xerath.Properties.Resources.Capture_PNG_PNG1;
            this.button2.Location = new System.Drawing.Point(405, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 242);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::Xerath.Properties.Resources.Capture;
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 242);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // health
            // 
            this.health.ForeColor = System.Drawing.Color.Red;
            this.health.Location = new System.Drawing.Point(441, 107);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(171, 26);
            this.health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.health.TabIndex = 3;
            this.health.Value = 100;
            // 
            // AT
            // 
            this.AT.BackgroundImage = global::Xerath.Properties.Resources.Capture2;
            this.AT.Location = new System.Drawing.Point(228, 261);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(157, 157);
            this.AT.TabIndex = 4;
            this.AT.Text = "AutoAttack";
            this.AT.UseVisualStyleBackColor = true;
            this.AT.Click += new System.EventHandler(this.AT_Click);
            // 
            // Arcanopulse
            // 
            this.Arcanopulse.BackgroundImage = global::Xerath.Properties.Resources.Capture_PNG32;
            this.Arcanopulse.Location = new System.Drawing.Point(228, 94);
            this.Arcanopulse.Name = "Arcanopulse";
            this.Arcanopulse.Size = new System.Drawing.Size(157, 161);
            this.Arcanopulse.TabIndex = 5;
            this.Arcanopulse.Text = "Arcanopulse";
            this.Arcanopulse.UseVisualStyleBackColor = true;
            this.Arcanopulse.Click += new System.EventHandler(this.Arcanopulse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Xerath.Properties.Resources.Capture_PNG3;
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.Arcanopulse);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.health);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Mana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar health;
        private System.Windows.Forms.Button AT;
        private System.Windows.Forms.Button Arcanopulse;
    }
}

