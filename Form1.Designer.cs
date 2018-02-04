namespace LuckySeven
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
            this.numberOne = new System.Windows.Forms.TextBox();
            this.numberTwo = new System.Windows.Forms.TextBox();
            this.numberThree = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.rbtnMid = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nightModeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modEasy = new System.Windows.Forms.Button();
            this.modHard = new System.Windows.Forms.Button();
            this.modMid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOne
            // 
            this.numberOne.Enabled = false;
            this.numberOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOne.Location = new System.Drawing.Point(40, 162);
            this.numberOne.Multiline = true;
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(58, 49);
            this.numberOne.TabIndex = 0;
            // 
            // numberTwo
            // 
            this.numberTwo.Enabled = false;
            this.numberTwo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwo.Location = new System.Drawing.Point(133, 162);
            this.numberTwo.Multiline = true;
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(54, 49);
            this.numberTwo.TabIndex = 1;
            // 
            // numberThree
            // 
            this.numberThree.Enabled = false;
            this.numberThree.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThree.Location = new System.Drawing.Point(219, 162);
            this.numberThree.Multiline = true;
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(56, 49);
            this.numberThree.TabIndex = 2;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(317, 147);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 73);
            this.playButton.TabIndex = 3;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Location = new System.Drawing.Point(87, 243);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(53, 17);
            this.rbtnEasy.TabIndex = 4;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "EASY";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // rbtnMid
            // 
            this.rbtnMid.AutoSize = true;
            this.rbtnMid.Location = new System.Drawing.Point(87, 275);
            this.rbtnMid.Name = "rbtnMid";
            this.rbtnMid.Size = new System.Drawing.Size(45, 17);
            this.rbtnMid.TabIndex = 5;
            this.rbtnMid.TabStop = true;
            this.rbtnMid.Text = "MİD";
            this.rbtnMid.UseVisualStyleBackColor = true;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(87, 307);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(56, 17);
            this.rbtnHard.TabIndex = 6;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "HARD";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(52, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nightModeButton
            // 
            this.nightModeButton.BackColor = System.Drawing.Color.Transparent;
            this.nightModeButton.BackgroundImage = global::LuckySeven.Properties.Resources.sun;
            this.nightModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nightModeButton.Enabled = false;
            this.nightModeButton.FlatAppearance.BorderSize = 0;
            this.nightModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nightModeButton.Location = new System.Drawing.Point(23, 23);
            this.nightModeButton.Name = "nightModeButton";
            this.nightModeButton.Size = new System.Drawing.Size(75, 46);
            this.nightModeButton.TabIndex = 8;
            this.nightModeButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(263, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // modEasy
            // 
            this.modEasy.BackColor = System.Drawing.Color.Transparent;
            this.modEasy.BackgroundImage = global::LuckySeven.Properties.Resources.battery;
            this.modEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modEasy.Enabled = false;
            this.modEasy.FlatAppearance.BorderSize = 0;
            this.modEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modEasy.Location = new System.Drawing.Point(38, 237);
            this.modEasy.Name = "modEasy";
            this.modEasy.Size = new System.Drawing.Size(37, 23);
            this.modEasy.TabIndex = 10;
            this.modEasy.UseVisualStyleBackColor = false;
            // 
            // modHard
            // 
            this.modHard.BackColor = System.Drawing.Color.Transparent;
            this.modHard.BackgroundImage = global::LuckySeven.Properties.Resources.battery__2_;
            this.modHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modHard.Enabled = false;
            this.modHard.FlatAppearance.BorderSize = 0;
            this.modHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modHard.Location = new System.Drawing.Point(38, 301);
            this.modHard.Name = "modHard";
            this.modHard.Size = new System.Drawing.Size(37, 23);
            this.modHard.TabIndex = 11;
            this.modHard.UseVisualStyleBackColor = false;
            // 
            // modMid
            // 
            this.modMid.BackColor = System.Drawing.Color.Transparent;
            this.modMid.BackgroundImage = global::LuckySeven.Properties.Resources.battery__1_;
            this.modMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modMid.Enabled = false;
            this.modMid.FlatAppearance.BorderSize = 0;
            this.modMid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modMid.Location = new System.Drawing.Point(38, 269);
            this.modMid.Name = "modMid";
            this.modMid.Size = new System.Drawing.Size(37, 23);
            this.modMid.TabIndex = 12;
            this.modMid.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 361);
            this.Controls.Add(this.modMid);
            this.Controls.Add(this.modHard);
            this.Controls.Add(this.modEasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nightModeButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbtnHard);
            this.Controls.Add(this.rbtnMid);
            this.Controls.Add(this.rbtnEasy);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lucky Seven";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOne;
        private System.Windows.Forms.TextBox numberTwo;
        private System.Windows.Forms.TextBox numberThree;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.RadioButton rbtnEasy;
        private System.Windows.Forms.RadioButton rbtnMid;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button nightModeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modEasy;
        private System.Windows.Forms.Button modHard;
        private System.Windows.Forms.Button modMid;
    }
}

