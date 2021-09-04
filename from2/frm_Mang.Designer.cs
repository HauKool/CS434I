namespace from2
{
    partial class frm_Mang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_arr = new System.Windows.Forms.TextBox();
            this.txt_chan = new System.Windows.Forms.TextBox();
            this.txt_le = new System.Windows.Forms.TextBox();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_chan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_le = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số chẵn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng số lẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các phần tử";
            // 
            // txt_arr
            // 
            this.txt_arr.Location = new System.Drawing.Point(182, 25);
            this.txt_arr.Name = "txt_arr";
            this.txt_arr.Size = new System.Drawing.Size(306, 20);
            this.txt_arr.TabIndex = 4;
            // 
            // txt_chan
            // 
            this.txt_chan.Location = new System.Drawing.Point(182, 87);
            this.txt_chan.Name = "txt_chan";
            this.txt_chan.Size = new System.Drawing.Size(100, 20);
            this.txt_chan.TabIndex = 5;
            // 
            // txt_le
            // 
            this.txt_le.Location = new System.Drawing.Point(182, 146);
            this.txt_le.Name = "txt_le";
            this.txt_le.Size = new System.Drawing.Size(100, 20);
            this.txt_le.TabIndex = 6;
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(182, 198);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(100, 20);
            this.txt_tong.TabIndex = 7;
            // 
            // btn_chan
            // 
            this.btn_chan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_chan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chan.Location = new System.Drawing.Point(321, 84);
            this.btn_chan.Name = "btn_chan";
            this.btn_chan.Size = new System.Drawing.Size(75, 23);
            this.btn_chan.TabIndex = 8;
            this.btn_chan.Text = "Tính";
            this.btn_chan.UseVisualStyleBackColor = false;
            this.btn_chan.Click += new System.EventHandler(this.btn_chan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Tomato;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(434, 272);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Teal;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(321, 272);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_tong
            // 
            this.btn_tong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_tong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tong.Location = new System.Drawing.Point(321, 195);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(75, 23);
            this.btn_tong.TabIndex = 11;
            this.btn_tong.Text = "Tính";
            this.btn_tong.UseVisualStyleBackColor = false;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // btn_le
            // 
            this.btn_le.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_le.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_le.Location = new System.Drawing.Point(321, 138);
            this.btn_le.Name = "btn_le";
            this.btn_le.Size = new System.Drawing.Size(75, 23);
            this.btn_le.TabIndex = 12;
            this.btn_le.Text = "Tính";
            this.btn_le.UseVisualStyleBackColor = false;
            this.btn_le.Click += new System.EventHandler(this.btn_le_Click);
            // 
            // frm_Mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 337);
            this.Controls.Add(this.btn_le);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_chan);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.txt_le);
            this.Controls.Add(this.txt_chan);
            this.Controls.Add(this.txt_arr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Mang";
            this.Text = "Mang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_arr;
        private System.Windows.Forms.TextBox txt_chan;
        private System.Windows.Forms.TextBox txt_le;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_chan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_le;
    }
}