namespace Muzamil_Khan_Operating_System_Project
{
    partial class formDetailsOfCurrentProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Location = new System.Drawing.Point(72, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 42);
            this.panel1.TabIndex = 117;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(23, 63);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(548, 226);
            this.listView.TabIndex = 118;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(548, 20);
            this.textBox1.TabIndex = 120;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Muzamil_Khan_Operating_System_Project.Properties.Resources.visible_16;
            this.button8.Location = new System.Drawing.Point(180, 7);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 29);
            this.button8.TabIndex = 37;
            this.button8.Text = "See";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::Muzamil_Khan_Operating_System_Project.Properties.Resources.arrow_99_24;
            this.button14.Location = new System.Drawing.Point(3, 7);
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
            this.button13.Location = new System.Drawing.Point(392, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 34);
            this.button13.TabIndex = 15;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // formDetailsOfCurrentProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 370);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "formDetailsOfCurrentProject";
            this.Resizable = false;
            this.Text = "Details Of Current Project";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDetailsOfCurrentProject_FormClosing);
            this.Load += new System.EventHandler(this.formDetailsOfCurrentProject_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
    }
}