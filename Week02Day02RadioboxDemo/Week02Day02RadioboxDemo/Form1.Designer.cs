namespace Week02Day02RadioboxDemo
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
            this.UI_ColorType_Gb = new System.Windows.Forms.GroupBox();
            this.UI_Blue_Rb = new System.Windows.Forms.RadioButton();
            this.UI_Red_Rb = new System.Windows.Forms.RadioButton();
            this.UI_Color_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ColorType_Gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_ColorType_Gb
            // 
            this.UI_ColorType_Gb.Controls.Add(this.UI_Blue_Rb);
            this.UI_ColorType_Gb.Controls.Add(this.UI_Red_Rb);
            this.UI_ColorType_Gb.Location = new System.Drawing.Point(115, 117);
            this.UI_ColorType_Gb.Name = "UI_ColorType_Gb";
            this.UI_ColorType_Gb.Size = new System.Drawing.Size(208, 130);
            this.UI_ColorType_Gb.TabIndex = 0;
            this.UI_ColorType_Gb.TabStop = false;
            this.UI_ColorType_Gb.Text = "Pick Color";
            // 
            // UI_Blue_Rb
            // 
            this.UI_Blue_Rb.AutoSize = true;
            this.UI_Blue_Rb.Checked = true;
            this.UI_Blue_Rb.Location = new System.Drawing.Point(23, 87);
            this.UI_Blue_Rb.Name = "UI_Blue_Rb";
            this.UI_Blue_Rb.Size = new System.Drawing.Size(66, 24);
            this.UI_Blue_Rb.TabIndex = 1;
            this.UI_Blue_Rb.TabStop = true;
            this.UI_Blue_Rb.Text = "Blue";
            this.UI_Blue_Rb.UseVisualStyleBackColor = true;
            this.UI_Blue_Rb.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // UI_Red_Rb
            // 
            this.UI_Red_Rb.AutoSize = true;
            this.UI_Red_Rb.Location = new System.Drawing.Point(23, 34);
            this.UI_Red_Rb.Name = "UI_Red_Rb";
            this.UI_Red_Rb.Size = new System.Drawing.Size(64, 24);
            this.UI_Red_Rb.TabIndex = 0;
            this.UI_Red_Rb.Text = "Red";
            this.UI_Red_Rb.UseVisualStyleBackColor = true;
            this.UI_Red_Rb.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // UI_Color_Tbx
            // 
            this.UI_Color_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Color_Tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.UI_Color_Tbx.Location = new System.Drawing.Point(444, 117);
            this.UI_Color_Tbx.Multiline = true;
            this.UI_Color_Tbx.Name = "UI_Color_Tbx";
            this.UI_Color_Tbx.ReadOnly = true;
            this.UI_Color_Tbx.Size = new System.Drawing.Size(242, 62);
            this.UI_Color_Tbx.TabIndex = 1;
            this.UI_Color_Tbx.Text = "Color Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Color_Tbx);
            this.Controls.Add(this.UI_ColorType_Gb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_ColorType_Gb.ResumeLayout(false);
            this.UI_ColorType_Gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_ColorType_Gb;
        private System.Windows.Forms.RadioButton UI_Blue_Rb;
        private System.Windows.Forms.RadioButton UI_Red_Rb;
        private System.Windows.Forms.TextBox UI_Color_Tbx;
    }
}

