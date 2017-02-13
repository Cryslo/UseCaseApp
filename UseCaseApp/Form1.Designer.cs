namespace UseCaseApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ActorRadioButton = new System.Windows.Forms.RadioButton();
            this.UsecaseRadioButton = new System.Windows.Forms.RadioButton();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.gfxPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ActorRadioButton
            // 
            this.ActorRadioButton.AutoSize = true;
            this.ActorRadioButton.Checked = true;
            this.ActorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ActorRadioButton.Name = "ActorRadioButton";
            this.ActorRadioButton.Size = new System.Drawing.Size(50, 17);
            this.ActorRadioButton.TabIndex = 2;
            this.ActorRadioButton.TabStop = true;
            this.ActorRadioButton.Text = "Actor";
            this.ActorRadioButton.UseVisualStyleBackColor = true;
            // 
            // UsecaseRadioButton
            // 
            this.UsecaseRadioButton.AutoSize = true;
            this.UsecaseRadioButton.Location = new System.Drawing.Point(6, 42);
            this.UsecaseRadioButton.Name = "UsecaseRadioButton";
            this.UsecaseRadioButton.Size = new System.Drawing.Size(71, 17);
            this.UsecaseRadioButton.TabIndex = 3;
            this.UsecaseRadioButton.Text = "Use Case";
            this.UsecaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.AutoSize = true;
            this.LineRadioButton.Location = new System.Drawing.Point(6, 65);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LineRadioButton.TabIndex = 4;
            this.LineRadioButton.Text = "Line";
            this.LineRadioButton.UseVisualStyleBackColor = true;
            // 
            // gfxPanel
            // 
            this.gfxPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gfxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gfxPanel.Location = new System.Drawing.Point(12, 118);
            this.gfxPanel.Name = "gfxPanel";
            this.gfxPanel.Size = new System.Drawing.Size(919, 379);
            this.gfxPanel.TabIndex = 5;
            this.gfxPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gfxPanel_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActorRadioButton);
            this.groupBox1.Controls.Add(this.UsecaseRadioButton);
            this.groupBox1.Controls.Add(this.LineRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gfxPanel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton ActorRadioButton;
        private System.Windows.Forms.RadioButton UsecaseRadioButton;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.Panel gfxPanel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

