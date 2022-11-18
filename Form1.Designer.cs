namespace crudWinFormApp
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
            this.comboxBox = new System.Windows.Forms.ComboBox();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.select_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboxBox
            // 
            this.comboxBox.FormattingEnabled = true;
            this.comboxBox.Location = new System.Drawing.Point(235, 77);
            this.comboxBox.Name = "comboxBox";
            this.comboxBox.Size = new System.Drawing.Size(211, 28);
            this.comboxBox.TabIndex = 0;
            this.comboxBox.SelectedIndexChanged += new System.EventHandler(this.comboxBox_SelectedIndexChanged);
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(235, 159);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(212, 27);
            this.input_textBox.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(41, 344);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(106, 36);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Location = new System.Drawing.Point(177, 344);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(106, 36);
            this.modify_btn.TabIndex = 3;
            this.modify_btn.Text = "Modify";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(302, 344);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 36);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(440, 344);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 36);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(574, 344);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(106, 36);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(177, 162);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(46, 20);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.Location = new System.Drawing.Point(177, 80);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(47, 20);
            this.select_lbl.TabIndex = 8;
            this.select_lbl.Text = "select";
            this.select_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.select_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.comboxBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboxBox;
        private TextBox input_textBox;
        private Button add_btn;
        private Button modify_btn;
        private Button delete_btn;
        private Button save_btn;
        private Button cancel_btn;
        private Label name_lbl;
        private Label select_lbl;
    }
}