namespace Muzamil_Khan_Operating_System_Project
{
    partial class formDirectoryDetailsOfCurrentProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Location = new System.Drawing.Point(484, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 42);
            this.panel1.TabIndex = 118;
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::Muzamil_Khan_Operating_System_Project.Properties.Resources.arrow_99_24;
            this.button14.Location = new System.Drawing.Point(3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 34);
            this.button14.TabIndex = 16;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::Muzamil_Khan_Operating_System_Project.Properties.Resources.shutdown_icon_18_24;
            this.button13.Location = new System.Drawing.Point(42, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 34);
            this.button13.TabIndex = 15;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(549, 144);
            this.richTextBox1.TabIndex = 119;
            this.richTextBox1.Text = "";
            // 
            // formDirectoryDetailsOfCurrentProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 308);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "formDirectoryDetailsOfCurrentProject";
            this.Resizable = false;
            this.Text = "Directory Details Of Project";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDirectoryDetailsOfCurrentProject_FormClosing);
            this.Load += new System.EventHandler(this.formDirectoryDetailsOfCurrentProject_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}