namespace TestingApp
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
            this.components = new System.ComponentModel.Container();
            this.GreenBar = new System.Windows.Forms.HScrollBar();
            this.RedBar = new System.Windows.Forms.HScrollBar();
            this.BlueBar = new System.Windows.Forms.HScrollBar();
            this.ColorSwitch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(87, 230);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(346, 18);
            this.GreenBar.TabIndex = 1;
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(87, 185);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(346, 18);
            this.RedBar.TabIndex = 2;
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(87, 273);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(346, 18);
            this.BlueBar.TabIndex = 3;
            // 
            // ColorSwitch
            // 
            this.ColorSwitch.Tick += new System.EventHandler(this.ColorSwitch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 387);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.GreenBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar GreenBar;
        private System.Windows.Forms.HScrollBar RedBar;
        private System.Windows.Forms.HScrollBar BlueBar;
        private System.Windows.Forms.Timer ColorSwitch;
    }
}

