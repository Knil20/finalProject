namespace finalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.basicUpgradeButton = new System.Windows.Forms.Button();
            this.mediumUpgradeButton = new System.Windows.Forms.Button();
            this.largeUpgradeButton = new System.Windows.Forms.Button();
            this.basicAutoButton = new System.Windows.Forms.Button();
            this.mediumAutoButton = new System.Windows.Forms.Button();
            this.largeAutoButton = new System.Windows.Forms.Button();
            this.cpsLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.autoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.totalLabel.Location = new System.Drawing.Point(309, 9);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(234, 36);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Candy = 0";
            this.totalLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::finalProject.Properties.Resources._1cb0e6cb885d6929042446568206c7b2_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 285);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(309, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click Upgrades";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(309, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basic +1 Click";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(309, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medium +10 Click";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(309, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Large +100 Click";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(309, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Auto Upgrades";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(309, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Basic +1 Auto";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(309, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Large +100 Auto";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(309, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Medium +10 Auto";
            this.label8.Visible = false;
            // 
            // basicUpgradeButton
            // 
            this.basicUpgradeButton.FlatAppearance.BorderSize = 0;
            this.basicUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicUpgradeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.basicUpgradeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.basicUpgradeButton.Location = new System.Drawing.Point(510, 107);
            this.basicUpgradeButton.Name = "basicUpgradeButton";
            this.basicUpgradeButton.Size = new System.Drawing.Size(174, 33);
            this.basicUpgradeButton.TabIndex = 11;
            this.basicUpgradeButton.Text = "Cost =";
            this.basicUpgradeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.basicUpgradeButton.UseVisualStyleBackColor = true;
            this.basicUpgradeButton.Visible = false;
            this.basicUpgradeButton.Click += new System.EventHandler(this.basicUpgradeButton_Click);
            // 
            // mediumUpgradeButton
            // 
            this.mediumUpgradeButton.FlatAppearance.BorderSize = 0;
            this.mediumUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumUpgradeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mediumUpgradeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mediumUpgradeButton.Location = new System.Drawing.Point(510, 146);
            this.mediumUpgradeButton.Name = "mediumUpgradeButton";
            this.mediumUpgradeButton.Size = new System.Drawing.Size(174, 33);
            this.mediumUpgradeButton.TabIndex = 12;
            this.mediumUpgradeButton.Text = "Cost =";
            this.mediumUpgradeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediumUpgradeButton.UseVisualStyleBackColor = true;
            this.mediumUpgradeButton.Visible = false;
            this.mediumUpgradeButton.Click += new System.EventHandler(this.mediumUpgradeButton_Click);
            // 
            // largeUpgradeButton
            // 
            this.largeUpgradeButton.FlatAppearance.BorderSize = 0;
            this.largeUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeUpgradeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.largeUpgradeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.largeUpgradeButton.Location = new System.Drawing.Point(510, 185);
            this.largeUpgradeButton.Name = "largeUpgradeButton";
            this.largeUpgradeButton.Size = new System.Drawing.Size(174, 33);
            this.largeUpgradeButton.TabIndex = 13;
            this.largeUpgradeButton.Text = "Cost =";
            this.largeUpgradeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.largeUpgradeButton.UseVisualStyleBackColor = true;
            this.largeUpgradeButton.Visible = false;
            this.largeUpgradeButton.Click += new System.EventHandler(this.largeUpgradeButton_Click);
            // 
            // basicAutoButton
            // 
            this.basicAutoButton.FlatAppearance.BorderSize = 0;
            this.basicAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicAutoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.basicAutoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.basicAutoButton.Location = new System.Drawing.Point(510, 257);
            this.basicAutoButton.Name = "basicAutoButton";
            this.basicAutoButton.Size = new System.Drawing.Size(174, 33);
            this.basicAutoButton.TabIndex = 14;
            this.basicAutoButton.Text = "Cost =";
            this.basicAutoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.basicAutoButton.UseVisualStyleBackColor = true;
            this.basicAutoButton.Visible = false;
            this.basicAutoButton.Click += new System.EventHandler(this.basicAutoButton_Click);
            // 
            // mediumAutoButton
            // 
            this.mediumAutoButton.FlatAppearance.BorderSize = 0;
            this.mediumAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumAutoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mediumAutoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mediumAutoButton.Location = new System.Drawing.Point(510, 293);
            this.mediumAutoButton.Name = "mediumAutoButton";
            this.mediumAutoButton.Size = new System.Drawing.Size(174, 33);
            this.mediumAutoButton.TabIndex = 15;
            this.mediumAutoButton.Text = "Cost =";
            this.mediumAutoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediumAutoButton.UseVisualStyleBackColor = true;
            this.mediumAutoButton.Visible = false;
            this.mediumAutoButton.Click += new System.EventHandler(this.mediumAutoButton_Click);
            // 
            // largeAutoButton
            // 
            this.largeAutoButton.FlatAppearance.BorderSize = 0;
            this.largeAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeAutoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.largeAutoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.largeAutoButton.Location = new System.Drawing.Point(510, 329);
            this.largeAutoButton.Name = "largeAutoButton";
            this.largeAutoButton.Size = new System.Drawing.Size(174, 33);
            this.largeAutoButton.TabIndex = 16;
            this.largeAutoButton.Text = "Cost =";
            this.largeAutoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.largeAutoButton.UseVisualStyleBackColor = true;
            this.largeAutoButton.Visible = false;
            this.largeAutoButton.Click += new System.EventHandler(this.largeAutoButton_Click);
            // 
            // cpsLabel
            // 
            this.cpsLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpsLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.cpsLabel.Location = new System.Drawing.Point(12, 416);
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Size = new System.Drawing.Size(155, 36);
            this.cpsLabel.TabIndex = 17;
            this.cpsLabel.Text = "CPS = 1";
            this.cpsLabel.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.autoLabel.Location = new System.Drawing.Point(173, 416);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(155, 36);
            this.autoLabel.TabIndex = 18;
            this.autoLabel.Text = "Auto = 0";
            this.autoLabel.Visible = false;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startButton.Location = new System.Drawing.Point(285, 185);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 44);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(672, 49);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "CANDY CLICKER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.resetButton.Location = new System.Drawing.Point(597, 416);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.cpsLabel);
            this.Controls.Add(this.largeAutoButton);
            this.Controls.Add(this.mediumAutoButton);
            this.Controls.Add(this.basicAutoButton);
            this.Controls.Add(this.largeUpgradeButton);
            this.Controls.Add(this.mediumUpgradeButton);
            this.Controls.Add(this.basicUpgradeButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totalLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label totalLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button basicUpgradeButton;
        private Button mediumUpgradeButton;
        private Button largeUpgradeButton;
        private Button basicAutoButton;
        private Button mediumAutoButton;
        private Button largeAutoButton;
        private Label cpsLabel;
        private System.Windows.Forms.Timer gameTimer;
        private Label autoLabel;
        private Button startButton;
        private Label titleLabel;
        private Button resetButton;
    }
}