namespace Week01Day04Demo01TimerStopwatch
{
    partial class TimerStopWatch
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
            this.UI_Timer1 = new System.Windows.Forms.Timer(this.components);
            this.UI_Screen_Lbl = new System.Windows.Forms.Label();
            this.UI_Time_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_List_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Timer1
            // 
            this.UI_Timer1.Interval = 1000;
            this.UI_Timer1.Tick += new System.EventHandler(this.UI_Timer1_Tick);
            // 
            // UI_Screen_Lbl
            // 
            this.UI_Screen_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Screen_Lbl.Location = new System.Drawing.Point(46, 23);
            this.UI_Screen_Lbl.Name = "UI_Screen_Lbl";
            this.UI_Screen_Lbl.Size = new System.Drawing.Size(183, 69);
            this.UI_Screen_Lbl.TabIndex = 3;
            this.UI_Screen_Lbl.Text = "0";
            this.UI_Screen_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Time_Tbx
            // 
            this.UI_Time_Tbx.Location = new System.Drawing.Point(304, 27);
            this.UI_Time_Tbx.Name = "UI_Time_Tbx";
            this.UI_Time_Tbx.Size = new System.Drawing.Size(246, 26);
            this.UI_Time_Tbx.TabIndex = 0;
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Location = new System.Drawing.Point(-9, 357);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(814, 98);
            this.UI_Stop_Btn.TabIndex = 1;
            this.UI_Stop_Btn.Text = "Stop Time";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            this.UI_Stop_Btn.Click += new System.EventHandler(this.UI_Stop_Btn_Click);
            // 
            // UI_List_Lbx
            // 
            this.UI_List_Lbx.FormattingEnabled = true;
            this.UI_List_Lbx.ItemHeight = 20;
            this.UI_List_Lbx.Location = new System.Drawing.Point(29, 126);
            this.UI_List_Lbx.Name = "UI_List_Lbx";
            this.UI_List_Lbx.Size = new System.Drawing.Size(340, 204);
            this.UI_List_Lbx.TabIndex = 2;
            // 
            // TimerStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 467);
            this.Controls.Add(this.UI_List_Lbx);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Controls.Add(this.UI_Time_Tbx);
            this.Controls.Add(this.UI_Screen_Lbl);
            this.Name = "TimerStopWatch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TimerStopWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UI_Timer1;
        private System.Windows.Forms.Label UI_Screen_Lbl;
        private System.Windows.Forms.TextBox UI_Time_Tbx;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.ListBox UI_List_Lbx;
    }
}

