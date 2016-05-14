namespace Arduino_Control
{
    partial class RCCarControl
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
            this.mvoltage = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.FWD = new System.Windows.Forms.Button();
            this.STP = new System.Windows.Forms.Button();
            this.BWD = new System.Windows.Forms.Button();
            this.RGT = new System.Windows.Forms.Button();
            this.LFT = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.FBTB = new System.Windows.Forms.TrackBar();
            this.LRTB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.FBTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LRTB)).BeginInit();
            this.SuspendLayout();
            // 
            // mvoltage
            // 
            this.mvoltage.AutoSize = true;
            this.mvoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvoltage.Location = new System.Drawing.Point(12, 38);
            this.mvoltage.Name = "mvoltage";
            this.mvoltage.Size = new System.Drawing.Size(146, 69);
            this.mvoltage.TabIndex = 0;
            this.mvoltage.Text = "0.00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Distance (cm)";
            // 
            // FWD
            // 
            this.FWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FWD.Location = new System.Drawing.Point(348, 76);
            this.FWD.Name = "FWD";
            this.FWD.Size = new System.Drawing.Size(70, 55);
            this.FWD.TabIndex = 2;
            this.FWD.Text = "▲";
            this.FWD.UseVisualStyleBackColor = true;
            this.FWD.Click += new System.EventHandler(this.FWD_Click);
            // 
            // STP
            // 
            this.STP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STP.Location = new System.Drawing.Point(348, 137);
            this.STP.Name = "STP";
            this.STP.Size = new System.Drawing.Size(70, 55);
            this.STP.TabIndex = 4;
            this.STP.Text = "Stop";
            this.STP.UseVisualStyleBackColor = true;
            this.STP.Click += new System.EventHandler(this.STP_Click);
            // 
            // BWD
            // 
            this.BWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BWD.Location = new System.Drawing.Point(348, 198);
            this.BWD.Name = "BWD";
            this.BWD.Size = new System.Drawing.Size(70, 55);
            this.BWD.TabIndex = 5;
            this.BWD.Text = "▼";
            this.BWD.UseVisualStyleBackColor = true;
            this.BWD.Click += new System.EventHandler(this.BWD_Click);
            // 
            // RGT
            // 
            this.RGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGT.Location = new System.Drawing.Point(424, 137);
            this.RGT.Name = "RGT";
            this.RGT.Size = new System.Drawing.Size(70, 55);
            this.RGT.TabIndex = 6;
            this.RGT.Text = "▶";
            this.RGT.UseVisualStyleBackColor = true;
            this.RGT.Click += new System.EventHandler(this.RGT_Click);
            // 
            // LFT
            // 
            this.LFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFT.Location = new System.Drawing.Point(272, 137);
            this.LFT.Name = "LFT";
            this.LFT.Size = new System.Drawing.Size(70, 55);
            this.LFT.TabIndex = 7;
            this.LFT.Text = "◀";
            this.LFT.UseVisualStyleBackColor = true;
            this.LFT.Click += new System.EventHandler(this.LFT_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(24, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "AutoDrive";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(24, 171);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(137, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "DistanceEnabled";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FBTB
            // 
            this.FBTB.Location = new System.Drawing.Point(644, 38);
            this.FBTB.Maximum = 255;
            this.FBTB.Minimum = -255;
            this.FBTB.Name = "FBTB";
            this.FBTB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FBTB.Size = new System.Drawing.Size(56, 177);
            this.FBTB.TabIndex = 10;
            this.FBTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FBTB.Scroll += new System.EventHandler(this.FBTB_Scroll);
            // 
            // LRTB
            // 
            this.LRTB.Location = new System.Drawing.Point(569, 221);
            this.LRTB.Maximum = 255;
            this.LRTB.Minimum = -255;
            this.LRTB.Name = "LRTB";
            this.LRTB.Size = new System.Drawing.Size(177, 56);
            this.LRTB.TabIndex = 11;
            this.LRTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LRTB.Scroll += new System.EventHandler(this.LRTB_Scroll);
            // 
            // RCCarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 303);
            this.Controls.Add(this.LRTB);
            this.Controls.Add(this.FBTB);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LFT);
            this.Controls.Add(this.RGT);
            this.Controls.Add(this.BWD);
            this.Controls.Add(this.STP);
            this.Controls.Add(this.FWD);
            this.Controls.Add(this.label);
            this.Controls.Add(this.mvoltage);
            this.Name = "RCCarControl";
            this.Text = "Audrino Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RCCarControl_FormClosing);
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FBTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LRTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mvoltage;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button FWD;
        private System.Windows.Forms.Button STP;
        private System.Windows.Forms.Button BWD;
        private System.Windows.Forms.Button RGT;
        private System.Windows.Forms.Button LFT;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar FBTB;
        private System.Windows.Forms.TrackBar LRTB;
    }
}

