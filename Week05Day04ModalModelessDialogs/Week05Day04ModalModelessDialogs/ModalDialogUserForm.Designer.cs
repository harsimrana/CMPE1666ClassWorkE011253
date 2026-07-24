namespace Week05Day04ModalModelessDialogs
{
    partial class ModalDialogUserForm
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
            this.UI_Lbl_Username = new System.Windows.Forms.Label();
            this.UI_Tbx_InputUsername = new System.Windows.Forms.TextBox();
            this.UI_Btn_Ok = new System.Windows.Forms.Button();
            this.UI_Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Lbl_Username
            // 
            this.UI_Lbl_Username.AutoSize = true;
            this.UI_Lbl_Username.Location = new System.Drawing.Point(89, 83);
            this.UI_Lbl_Username.Name = "UI_Lbl_Username";
            this.UI_Lbl_Username.Size = new System.Drawing.Size(83, 20);
            this.UI_Lbl_Username.TabIndex = 0;
            this.UI_Lbl_Username.Text = "Username";
            // 
            // UI_Tbx_InputUsername
            // 
            this.UI_Tbx_InputUsername.Location = new System.Drawing.Point(241, 80);
            this.UI_Tbx_InputUsername.Name = "UI_Tbx_InputUsername";
            this.UI_Tbx_InputUsername.Size = new System.Drawing.Size(311, 26);
            this.UI_Tbx_InputUsername.TabIndex = 1;
            // 
            // UI_Btn_Ok
            // 
            this.UI_Btn_Ok.Location = new System.Drawing.Point(93, 196);
            this.UI_Btn_Ok.Name = "UI_Btn_Ok";
            this.UI_Btn_Ok.Size = new System.Drawing.Size(206, 73);
            this.UI_Btn_Ok.TabIndex = 2;
            this.UI_Btn_Ok.Text = "OK";
            this.UI_Btn_Ok.UseVisualStyleBackColor = true;
            this.UI_Btn_Ok.Click += new System.EventHandler(this.UI_Btn_Ok_Click);
            // 
            // UI_Btn_Cancel
            // 
            this.UI_Btn_Cancel.Location = new System.Drawing.Point(346, 196);
            this.UI_Btn_Cancel.Name = "UI_Btn_Cancel";
            this.UI_Btn_Cancel.Size = new System.Drawing.Size(206, 73);
            this.UI_Btn_Cancel.TabIndex = 3;
            this.UI_Btn_Cancel.Text = "Cancel";
            this.UI_Btn_Cancel.UseVisualStyleBackColor = true;
            this.UI_Btn_Cancel.Click += new System.EventHandler(this.UI_Btn_Cancel_Click);
            // 
            // ModalDialogUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 343);
            this.Controls.Add(this.UI_Btn_Cancel);
            this.Controls.Add(this.UI_Btn_Ok);
            this.Controls.Add(this.UI_Tbx_InputUsername);
            this.Controls.Add(this.UI_Lbl_Username);
            this.Name = "ModalDialogUserForm";
            this.Text = "ModalDialogUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Lbl_Username;
        private System.Windows.Forms.TextBox UI_Tbx_InputUsername;
        private System.Windows.Forms.Button UI_Btn_Ok;
        private System.Windows.Forms.Button UI_Btn_Cancel;
    }
}