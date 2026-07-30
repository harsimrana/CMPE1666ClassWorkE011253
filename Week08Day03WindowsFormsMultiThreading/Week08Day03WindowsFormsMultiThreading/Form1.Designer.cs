namespace Week08Day03WindowsFormsMultiThreading
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
            this.UI_CountClick_btn = new System.Windows.Forms.Button();
            this.UI_Stop_btn = new System.Windows.Forms.Button();
            this.UI_PerformCal_btn = new System.Windows.Forms.Button();
            this.UI_DisplayValues_lbx = new System.Windows.Forms.ListBox();
            this.UI_Count_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_CountClick_btn
            // 
            this.UI_CountClick_btn.Location = new System.Drawing.Point(636, 92);
            this.UI_CountClick_btn.Name = "UI_CountClick_btn";
            this.UI_CountClick_btn.Size = new System.Drawing.Size(202, 67);
            this.UI_CountClick_btn.TabIndex = 0;
            this.UI_CountClick_btn.Text = "Count Click";
            this.UI_CountClick_btn.UseVisualStyleBackColor = true;
            this.UI_CountClick_btn.Click += new System.EventHandler(this.UI_CountClick_btn_Click);
            // 
            // UI_Stop_btn
            // 
            this.UI_Stop_btn.Location = new System.Drawing.Point(636, 216);
            this.UI_Stop_btn.Name = "UI_Stop_btn";
            this.UI_Stop_btn.Size = new System.Drawing.Size(202, 67);
            this.UI_Stop_btn.TabIndex = 1;
            this.UI_Stop_btn.Text = "Stop Thread";
            this.UI_Stop_btn.UseVisualStyleBackColor = true;
            this.UI_Stop_btn.Click += new System.EventHandler(this.UI_Stop_btn_Click);
            // 
            // UI_PerformCal_btn
            // 
            this.UI_PerformCal_btn.Location = new System.Drawing.Point(636, 340);
            this.UI_PerformCal_btn.Name = "UI_PerformCal_btn";
            this.UI_PerformCal_btn.Size = new System.Drawing.Size(202, 67);
            this.UI_PerformCal_btn.TabIndex = 2;
            this.UI_PerformCal_btn.Text = "Perform Calculations";
            this.UI_PerformCal_btn.UseVisualStyleBackColor = true;
            this.UI_PerformCal_btn.Click += new System.EventHandler(this.UI_PerformCal_btn_Click);
            // 
            // UI_DisplayValues_lbx
            // 
            this.UI_DisplayValues_lbx.FormattingEnabled = true;
            this.UI_DisplayValues_lbx.ItemHeight = 20;
            this.UI_DisplayValues_lbx.Location = new System.Drawing.Point(97, 92);
            this.UI_DisplayValues_lbx.Name = "UI_DisplayValues_lbx";
            this.UI_DisplayValues_lbx.Size = new System.Drawing.Size(379, 324);
            this.UI_DisplayValues_lbx.TabIndex = 3;
            // 
            // UI_Count_lbl
            // 
            this.UI_Count_lbl.AutoSize = true;
            this.UI_Count_lbl.Location = new System.Drawing.Point(102, 478);
            this.UI_Count_lbl.Name = "UI_Count_lbl";
            this.UI_Count_lbl.Size = new System.Drawing.Size(0, 20);
            this.UI_Count_lbl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 554);
            this.Controls.Add(this.UI_Count_lbl);
            this.Controls.Add(this.UI_DisplayValues_lbx);
            this.Controls.Add(this.UI_PerformCal_btn);
            this.Controls.Add(this.UI_Stop_btn);
            this.Controls.Add(this.UI_CountClick_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_CountClick_btn;
        private System.Windows.Forms.Button UI_Stop_btn;
        private System.Windows.Forms.Button UI_PerformCal_btn;
        private System.Windows.Forms.ListBox UI_DisplayValues_lbx;
        private System.Windows.Forms.Label UI_Count_lbl;
    }
}

