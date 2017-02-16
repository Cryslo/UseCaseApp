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
            this.Actor3text = new System.Windows.Forms.TextBox();
            this.Actor2text = new System.Windows.Forms.TextBox();
            this.Actor1text = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectRB = new System.Windows.Forms.RadioButton();
            this.editRB = new System.Windows.Forms.RadioButton();
            this.gfxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 54);
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
            this.gfxPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gfxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gfxPanel.Controls.Add(this.Actor3text);
            this.gfxPanel.Controls.Add(this.Actor2text);
            this.gfxPanel.Controls.Add(this.Actor1text);
            this.gfxPanel.Controls.Add(this.pictureBox3);
            this.gfxPanel.Controls.Add(this.pictureBox2);
            this.gfxPanel.Controls.Add(this.pictureBox1);
            this.gfxPanel.Location = new System.Drawing.Point(12, 118);
            this.gfxPanel.Name = "gfxPanel";
            this.gfxPanel.Size = new System.Drawing.Size(919, 379);
            this.gfxPanel.TabIndex = 5;
            this.gfxPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gfxPanel_MouseClick);
            // 
            // Actor3text
            // 
            this.Actor3text.Location = new System.Drawing.Point(3, 352);
            this.Actor3text.Name = "Actor3text";
            this.Actor3text.Size = new System.Drawing.Size(73, 20);
            this.Actor3text.TabIndex = 5;
            this.Actor3text.Tag = "Actor3";
            this.Actor3text.Visible = false;
            // 
            // Actor2text
            // 
            this.Actor2text.Location = new System.Drawing.Point(4, 221);
            this.Actor2text.Name = "Actor2text";
            this.Actor2text.Size = new System.Drawing.Size(72, 20);
            this.Actor2text.TabIndex = 4;
            this.Actor2text.Tag = "Actor2";
            this.Actor2text.Visible = false;
            // 
            // Actor1text
            // 
            this.Actor1text.Location = new System.Drawing.Point(4, 99);
            this.Actor1text.Name = "Actor1text";
            this.Actor1text.Size = new System.Drawing.Size(72, 20);
            this.Actor1text.TabIndex = 3;
            this.Actor1text.Tag = "Actor1";
            this.Actor1text.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UseCaseApp.Properties.Resources.Actor;
            this.pictureBox3.Location = new System.Drawing.Point(3, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Actor3";
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UseCaseApp.Properties.Resources.Actor;
            this.pictureBox2.Location = new System.Drawing.Point(4, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Actor2";
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UseCaseApp.Properties.Resources.Actor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Actor1";
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectRB);
            this.groupBox2.Controls.Add(this.editRB);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // selectRB
            // 
            this.selectRB.AutoSize = true;
            this.selectRB.Location = new System.Drawing.Point(7, 44);
            this.selectRB.Name = "selectRB";
            this.selectRB.Size = new System.Drawing.Size(55, 17);
            this.selectRB.TabIndex = 1;
            this.selectRB.Text = "Select";
            this.selectRB.UseVisualStyleBackColor = true;
            this.selectRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectRB_MouseClick);
            // 
            // editRB
            // 
            this.editRB.AutoSize = true;
            this.editRB.Checked = true;
            this.editRB.Location = new System.Drawing.Point(7, 20);
            this.editRB.Name = "editRB";
            this.editRB.Size = new System.Drawing.Size(43, 17);
            this.editRB.TabIndex = 0;
            this.editRB.TabStop = true;
            this.editRB.Text = "Edit";
            this.editRB.UseVisualStyleBackColor = true;
            this.editRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editRB_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gfxPanel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gfxPanel.ResumeLayout(false);
            this.gfxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox Actor3text;
        private System.Windows.Forms.TextBox Actor2text;
        private System.Windows.Forms.TextBox Actor1text;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton selectRB;
        private System.Windows.Forms.RadioButton editRB;
    }
}

