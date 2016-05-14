namespace Arduino_Control
{
    partial class Main
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
            System.Windows.Forms.Button rccarcontrol;
            this.label1 = new System.Windows.Forms.Label();
            this.comportselect = new System.Windows.Forms.ComboBox();
            rccarcontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rccarcontrol
            // 
            rccarcontrol.Location = new System.Drawing.Point(15, 78);
            rccarcontrol.Name = "rccarcontrol";
            rccarcontrol.Size = new System.Drawing.Size(150, 32);
            rccarcontrol.TabIndex = 3;
            rccarcontrol.Text = "RC Car Control";
            rccarcontrol.UseVisualStyleBackColor = true;
            rccarcontrol.Click += new System.EventHandler(this.rccarcontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Com Port";
            // 
            // comportselect
            // 
            this.comportselect.FormattingEnabled = true;
            this.comportselect.Location = new System.Drawing.Point(127, 6);
            this.comportselect.Name = "comportselect";
            this.comportselect.Size = new System.Drawing.Size(121, 24);
            this.comportselect.TabIndex = 2;
            this.comportselect.DropDown += new System.EventHandler(this.comportselect_DropDown);
            this.comportselect.SelectedIndexChanged += new System.EventHandler(this.comportselect_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 122);
            this.Controls.Add(rccarcontrol);
            this.Controls.Add(this.comportselect);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comportselect;
    }
}