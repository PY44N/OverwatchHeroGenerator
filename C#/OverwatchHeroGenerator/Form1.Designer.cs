namespace OverwatchHeroGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeroLabel = new System.Windows.Forms.Label();
            this.GenAll = new System.Windows.Forms.Button();
            this.GenTank = new System.Windows.Forms.Button();
            this.GenDamage = new System.Windows.Forms.Button();
            this.GenSupport = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // HeroLabel
            // 
            this.HeroLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroLabel.Location = new System.Drawing.Point(0, 0);
            this.HeroLabel.Name = "HeroLabel";
            this.HeroLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.HeroLabel.Size = new System.Drawing.Size(276, 311);
            this.HeroLabel.TabIndex = 0;
            this.HeroLabel.Text = "WRECKING BALL";
            this.HeroLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GenAll
            // 
            this.GenAll.Location = new System.Drawing.Point(37, 205);
            this.GenAll.Name = "GenAll";
            this.GenAll.Size = new System.Drawing.Size(208, 75);
            this.GenAll.TabIndex = 1;
            this.GenAll.Text = "Generate All";
            this.GenAll.UseVisualStyleBackColor = true;
            this.GenAll.Click += new System.EventHandler(this.GenAll_Click);
            // 
            // GenTank
            // 
            this.GenTank.Location = new System.Drawing.Point(37, 160);
            this.GenTank.Name = "GenTank";
            this.GenTank.Size = new System.Drawing.Size(65, 39);
            this.GenTank.TabIndex = 2;
            this.GenTank.Text = "Generate Tank";
            this.GenTank.UseVisualStyleBackColor = true;
            this.GenTank.Click += new System.EventHandler(this.GenTank_Click);
            // 
            // GenDamage
            // 
            this.GenDamage.Location = new System.Drawing.Point(108, 160);
            this.GenDamage.Name = "GenDamage";
            this.GenDamage.Size = new System.Drawing.Size(65, 39);
            this.GenDamage.TabIndex = 3;
            this.GenDamage.Text = "Generate Damage";
            this.GenDamage.UseVisualStyleBackColor = true;
            this.GenDamage.Click += new System.EventHandler(this.GenDamage_Click);
            // 
            // GenSupport
            // 
            this.GenSupport.Location = new System.Drawing.Point(179, 160);
            this.GenSupport.Name = "GenSupport";
            this.GenSupport.Size = new System.Drawing.Size(65, 39);
            this.GenSupport.TabIndex = 4;
            this.GenSupport.Text = "Generate Support";
            this.GenSupport.UseVisualStyleBackColor = true;
            this.GenSupport.Click += new System.EventHandler(this.GenSupport_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(22, 289);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(242, 13);
            this.GithubLink.TabIndex = 5;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Open Source Overwatch Hero Generator by Pyan";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 311);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.GenSupport);
            this.Controls.Add(this.GenDamage);
            this.Controls.Add(this.GenTank);
            this.Controls.Add(this.GenAll);
            this.Controls.Add(this.HeroLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Overwatch Hero Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeroLabel;
        private System.Windows.Forms.Button GenAll;
        private System.Windows.Forms.Button GenTank;
        private System.Windows.Forms.Button GenDamage;
        private System.Windows.Forms.Button GenSupport;
        private System.Windows.Forms.LinkLabel GithubLink;
    }
}

