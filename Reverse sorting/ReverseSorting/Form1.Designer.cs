
namespace simplification
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
            this.chkbox1 = new System.Windows.Forms.CheckBox();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.nmb2 = new System.Windows.Forms.TextBox();
            this.nmb1 = new System.Windows.Forms.TextBox();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_how_much = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btn_srt = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btn_cln = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.nmb3 = new System.Windows.Forms.TextBox();
            this.nmb4 = new System.Windows.Forms.TextBox();
            this.nmb5 = new System.Windows.Forms.TextBox();
            this.nmb6 = new System.Windows.Forms.TextBox();
            this.nmb7 = new System.Windows.Forms.TextBox();
            this.nmb8 = new System.Windows.Forms.TextBox();
            this.nmb9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkbox1
            // 
            this.chkbox1.AutoSize = true;
            this.chkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.chkbox1.Location = new System.Drawing.Point(310, 69);
            this.chkbox1.Name = "chkbox1";
            this.chkbox1.Size = new System.Drawing.Size(15, 14);
            this.chkbox1.TabIndex = 0;
            this.chkbox1.UseVisualStyleBackColor = false;
            this.chkbox1.CheckedChanged += new System.EventHandler(this.Chkbox1_CheckedChanged);
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.txtbox_amount.Location = new System.Drawing.Point(261, 65);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(32, 23);
            this.txtbox_amount.TabIndex = 2;
            this.txtbox_amount.TextChanged += new System.EventHandler(this.Txtbox1_TextChanged);
            // 
            // nmb2
            // 
            this.nmb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb2.Location = new System.Drawing.Point(226, 135);
            this.nmb2.Name = "nmb2";
            this.nmb2.Size = new System.Drawing.Size(29, 23);
            this.nmb2.TabIndex = 9;
            this.nmb2.Visible = false;
            // 
            // nmb1
            // 
            this.nmb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb1.Location = new System.Drawing.Point(191, 135);
            this.nmb1.Name = "nmb1";
            this.nmb1.Size = new System.Drawing.Size(29, 23);
            this.nmb1.TabIndex = 8;
            this.nmb1.Visible = false;
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Location = new System.Drawing.Point(40, 138);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(145, 15);
            this.lbl_txt.TabIndex = 7;
            this.lbl_txt.Text = "Write number one by one:";
            this.lbl_txt.Visible = false;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(40, 97);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 15);
            this.lbl_msg.TabIndex = 16;
            // 
            // lbl_how_much
            // 
            this.lbl_how_much.AutoSize = true;
            this.lbl_how_much.Location = new System.Drawing.Point(36, 68);
            this.lbl_how_much.Name = "lbl_how_much";
            this.lbl_how_much.Size = new System.Drawing.Size(206, 15);
            this.lbl_how_much.TabIndex = 17;
            this.lbl_how_much.Text = "How much numbers contain in array?";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(130, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(289, 25);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Sort digits in descending order";
            // 
            // btn_srt
            // 
            this.btn_srt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btn_srt.Location = new System.Drawing.Point(36, 208);
            this.btn_srt.Name = "btn_srt";
            this.btn_srt.Size = new System.Drawing.Size(75, 23);
            this.btn_srt.TabIndex = 20;
            this.btn_srt.Text = "Sorting";
            this.btn_srt.UseVisualStyleBackColor = false;
            this.btn_srt.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(191, 179);
            this.listbox.Name = "listbox";
            this.listbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox.Size = new System.Drawing.Size(88, 154);
            this.listbox.TabIndex = 21;
            // 
            // btn_cln
            // 
            this.btn_cln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btn_cln.Location = new System.Drawing.Point(36, 237);
            this.btn_cln.Name = "btn_cln";
            this.btn_cln.Size = new System.Drawing.Size(75, 23);
            this.btn_cln.TabIndex = 22;
            this.btn_cln.Text = "Clean";
            this.btn_cln.UseVisualStyleBackColor = false;
            this.btn_cln.Click += new System.EventHandler(this.Btn_cln_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btn_add.Location = new System.Drawing.Point(36, 179);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // nmb3
            // 
            this.nmb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb3.Location = new System.Drawing.Point(261, 135);
            this.nmb3.Name = "nmb3";
            this.nmb3.Size = new System.Drawing.Size(29, 23);
            this.nmb3.TabIndex = 9;
            this.nmb3.Visible = false;
            // 
            // nmb4
            // 
            this.nmb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb4.Location = new System.Drawing.Point(296, 135);
            this.nmb4.Name = "nmb4";
            this.nmb4.Size = new System.Drawing.Size(29, 23);
            this.nmb4.TabIndex = 9;
            this.nmb4.Visible = false;
            // 
            // nmb5
            // 
            this.nmb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb5.Location = new System.Drawing.Point(331, 135);
            this.nmb5.Name = "nmb5";
            this.nmb5.Size = new System.Drawing.Size(29, 23);
            this.nmb5.TabIndex = 9;
            this.nmb5.Visible = false;
            // 
            // nmb6
            // 
            this.nmb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb6.Location = new System.Drawing.Point(366, 135);
            this.nmb6.Name = "nmb6";
            this.nmb6.Size = new System.Drawing.Size(29, 23);
            this.nmb6.TabIndex = 9;
            this.nmb6.Visible = false;
            // 
            // nmb7
            // 
            this.nmb7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb7.Location = new System.Drawing.Point(401, 135);
            this.nmb7.Name = "nmb7";
            this.nmb7.Size = new System.Drawing.Size(29, 23);
            this.nmb7.TabIndex = 9;
            this.nmb7.Visible = false;
            // 
            // nmb8
            // 
            this.nmb8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb8.Location = new System.Drawing.Point(436, 135);
            this.nmb8.Name = "nmb8";
            this.nmb8.Size = new System.Drawing.Size(29, 23);
            this.nmb8.TabIndex = 9;
            this.nmb8.Visible = false;
            // 
            // nmb9
            // 
            this.nmb9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.nmb9.Location = new System.Drawing.Point(471, 135);
            this.nmb9.Name = "nmb9";
            this.nmb9.Size = new System.Drawing.Size(29, 23);
            this.nmb9.TabIndex = 9;
            this.nmb9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(532, 354);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cln);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btn_srt);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbl_how_much);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.nmb9);
            this.Controls.Add(this.nmb8);
            this.Controls.Add(this.nmb7);
            this.Controls.Add(this.nmb6);
            this.Controls.Add(this.nmb5);
            this.Controls.Add(this.nmb4);
            this.Controls.Add(this.nmb3);
            this.Controls.Add(this.nmb2);
            this.Controls.Add(this.nmb1);
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.chkbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbox1;
        private System.Windows.Forms.TextBox txtbox_amount;
        private System.Windows.Forms.TextBox nmb2;
        private System.Windows.Forms.TextBox nmb1;
        private System.Windows.Forms.Label lbl_txt;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_how_much;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btn_srt;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btn_cln;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox nmb3;
        private System.Windows.Forms.TextBox nmb4;
        private System.Windows.Forms.TextBox nmb5;
        private System.Windows.Forms.TextBox nmb6;
        private System.Windows.Forms.TextBox nmb7;
        private System.Windows.Forms.TextBox nmb8;
        private System.Windows.Forms.TextBox nmb9;
    }
}

