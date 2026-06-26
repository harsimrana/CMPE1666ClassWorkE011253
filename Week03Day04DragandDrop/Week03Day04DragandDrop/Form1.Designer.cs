namespace Week03Day04DragandDrop
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
            this.UI_DisplayData_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_DisplayData_Tbx
            // 
            this.UI_DisplayData_Tbx.AllowDrop = true;
            this.UI_DisplayData_Tbx.Location = new System.Drawing.Point(50, 141);
            this.UI_DisplayData_Tbx.Multiline = true;
            this.UI_DisplayData_Tbx.Name = "UI_DisplayData_Tbx";
            this.UI_DisplayData_Tbx.Size = new System.Drawing.Size(688, 231);
            this.UI_DisplayData_Tbx.TabIndex = 0;
            this.UI_DisplayData_Tbx.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DisplayData_Tbx_DragDrop);
            this.UI_DisplayData_Tbx.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DisplayData_Tbx_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_DisplayData_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_DisplayData_Tbx;
    }
}

