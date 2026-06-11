namespace Week01Day03Demo01WindowForm
{
    partial class UI_Form_Form1
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
            this.UI_Login_btn = new System.Windows.Forms.Button();
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Input1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Input2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Btn = new System.Windows.Forms.Button();
            this.UI_Screen_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Login_btn
            // 
            this.UI_Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UI_Login_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UI_Login_btn.Location = new System.Drawing.Point(215, 98);
            this.UI_Login_btn.Name = "UI_Login_btn";
            this.UI_Login_btn.Padding = new System.Windows.Forms.Padding(5);
            this.UI_Login_btn.Size = new System.Drawing.Size(209, 68);
            this.UI_Login_btn.TabIndex = 0;
            this.UI_Login_btn.Text = "Transfer Text";
            this.UI_Login_btn.UseVisualStyleBackColor = false;
            this.UI_Login_btn.Click += new System.EventHandler(this.UI_Login_btn_Click);
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(36, 27);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Padding = new System.Windows.Forms.Padding(10);
            this.UI_Display_Lbl.Size = new System.Drawing.Size(159, 46);
            this.UI_Display_Lbl.TabIndex = 1;
            this.UI_Display_Lbl.Text = "Value";
            this.UI_Display_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Location = new System.Drawing.Point(215, 40);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(243, 26);
            this.UI_Input_Tbx.TabIndex = 2;
            // 
            // UI_Input1_Tbx
            // 
            this.UI_Input1_Tbx.Location = new System.Drawing.Point(175, 277);
            this.UI_Input1_Tbx.Name = "UI_Input1_Tbx";
            this.UI_Input1_Tbx.Size = new System.Drawing.Size(132, 26);
            this.UI_Input1_Tbx.TabIndex = 3;
            this.UI_Input1_Tbx.Text = "0";
            // 
            // UI_Input2_Tbx
            // 
            this.UI_Input2_Tbx.Location = new System.Drawing.Point(362, 277);
            this.UI_Input2_Tbx.Name = "UI_Input2_Tbx";
            this.UI_Input2_Tbx.Size = new System.Drawing.Size(132, 26);
            this.UI_Input2_Tbx.TabIndex = 4;
            this.UI_Input2_Tbx.Text = "0";
            // 
            // UI_Sum_Btn
            // 
            this.UI_Sum_Btn.BackColor = System.Drawing.Color.Green;
            this.UI_Sum_Btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sum_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UI_Sum_Btn.Location = new System.Drawing.Point(215, 361);
            this.UI_Sum_Btn.Name = "UI_Sum_Btn";
            this.UI_Sum_Btn.Padding = new System.Windows.Forms.Padding(5);
            this.UI_Sum_Btn.Size = new System.Drawing.Size(209, 68);
            this.UI_Sum_Btn.TabIndex = 5;
            this.UI_Sum_Btn.Text = "SUM";
            this.UI_Sum_Btn.UseVisualStyleBackColor = false;
            this.UI_Sum_Btn.Click += new System.EventHandler(this.UI_Sum_Btn_Click);
            // 
            // UI_Screen_Lbl
            // 
            this.UI_Screen_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Screen_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UI_Screen_Lbl.Location = new System.Drawing.Point(175, 203);
            this.UI_Screen_Lbl.Name = "UI_Screen_Lbl";
            this.UI_Screen_Lbl.Padding = new System.Windows.Forms.Padding(10);
            this.UI_Screen_Lbl.Size = new System.Drawing.Size(319, 46);
            this.UI_Screen_Lbl.TabIndex = 6;
            this.UI_Screen_Lbl.Text = "0";
            this.UI_Screen_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Form_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.UI_Screen_Lbl);
            this.Controls.Add(this.UI_Sum_Btn);
            this.Controls.Add(this.UI_Input2_Tbx);
            this.Controls.Add(this.UI_Input1_Tbx);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Controls.Add(this.UI_Login_btn);
            this.Name = "UI_Form_Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_Form_Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_Form_Form1_FormClosed);
            this.Load += new System.EventHandler(this.UI_Form_Form1_Load);
            this.Shown += new System.EventHandler(this.UI_Form_Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UI_Form_Form1_Paint);
            this.MouseLeave += new System.EventHandler(this.UI_Form_Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UI_Form_Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Login_btn;
        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.TextBox UI_Input1_Tbx;
        private System.Windows.Forms.TextBox UI_Input2_Tbx;
        private System.Windows.Forms.Button UI_Sum_Btn;
        private System.Windows.Forms.Label UI_Screen_Lbl;
    }
}

