namespace Week01Day04Demo02AnchoringList
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
            this.UI_StName_Lbl = new System.Windows.Forms.Label();
            this.UI_StName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddSt_Btn = new System.Windows.Forms.Button();
            this.UI_StMarks_Lbl = new System.Windows.Forms.Label();
            this.UI_Email_Lbl = new System.Windows.Forms.Label();
            this.UI_StAge_Lbl = new System.Windows.Forms.Label();
            this.UI_IndexPSN_Lbx = new System.Windows.Forms.Label();
            this.UI_StMarks_Tbx = new System.Windows.Forms.TextBox();
            this.UI_RemoveSt_Btn = new System.Windows.Forms.Button();
            this.UI_StEmail_Tbx = new System.Windows.Forms.TextBox();
            this.UI_StAge_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ListIndex_Tbx = new System.Windows.Forms.TextBox();
            this.UI_InsertAtIndex_Btn = new System.Windows.Forms.Button();
            this.UI_ClearSt_Btn = new System.Windows.Forms.Button();
            this.UI_Stdents_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_StName_Lbl
            // 
            this.UI_StName_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_StName_Lbl.Location = new System.Drawing.Point(29, 47);
            this.UI_StName_Lbl.Name = "UI_StName_Lbl";
            this.UI_StName_Lbl.Size = new System.Drawing.Size(150, 35);
            this.UI_StName_Lbl.TabIndex = 0;
            this.UI_StName_Lbl.Text = "Student Name";
            // 
            // UI_StName_Tbx
            // 
            this.UI_StName_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StName_Tbx.Location = new System.Drawing.Point(235, 44);
            this.UI_StName_Tbx.Name = "UI_StName_Tbx";
            this.UI_StName_Tbx.Size = new System.Drawing.Size(349, 26);
            this.UI_StName_Tbx.TabIndex = 0;
            // 
            // UI_AddSt_Btn
            // 
            this.UI_AddSt_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_AddSt_Btn.Location = new System.Drawing.Point(629, 41);
            this.UI_AddSt_Btn.Name = "UI_AddSt_Btn";
            this.UI_AddSt_Btn.Size = new System.Drawing.Size(199, 33);
            this.UI_AddSt_Btn.TabIndex = 4;
            this.UI_AddSt_Btn.Text = "Add Student";
            this.UI_AddSt_Btn.UseVisualStyleBackColor = true;
            this.UI_AddSt_Btn.Click += new System.EventHandler(this.UI_AddSt_Btn_Click);
            // 
            // UI_StMarks_Lbl
            // 
            this.UI_StMarks_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_StMarks_Lbl.Location = new System.Drawing.Point(29, 102);
            this.UI_StMarks_Lbl.Name = "UI_StMarks_Lbl";
            this.UI_StMarks_Lbl.Size = new System.Drawing.Size(150, 35);
            this.UI_StMarks_Lbl.TabIndex = 0;
            this.UI_StMarks_Lbl.Text = "Student Marks";
            // 
            // UI_Email_Lbl
            // 
            this.UI_Email_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Email_Lbl.Location = new System.Drawing.Point(29, 163);
            this.UI_Email_Lbl.Name = "UI_Email_Lbl";
            this.UI_Email_Lbl.Size = new System.Drawing.Size(150, 35);
            this.UI_Email_Lbl.TabIndex = 0;
            this.UI_Email_Lbl.Text = "Student Email";
            // 
            // UI_StAge_Lbl
            // 
            this.UI_StAge_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_StAge_Lbl.Location = new System.Drawing.Point(29, 221);
            this.UI_StAge_Lbl.Name = "UI_StAge_Lbl";
            this.UI_StAge_Lbl.Size = new System.Drawing.Size(150, 35);
            this.UI_StAge_Lbl.TabIndex = 0;
            this.UI_StAge_Lbl.Text = "Student Age";
            // 
            // UI_IndexPSN_Lbx
            // 
            this.UI_IndexPSN_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_IndexPSN_Lbx.Location = new System.Drawing.Point(29, 282);
            this.UI_IndexPSN_Lbx.Name = "UI_IndexPSN_Lbx";
            this.UI_IndexPSN_Lbx.Size = new System.Drawing.Size(150, 35);
            this.UI_IndexPSN_Lbx.TabIndex = 0;
            this.UI_IndexPSN_Lbx.Text = "Insert Index";
            // 
            // UI_StMarks_Tbx
            // 
            this.UI_StMarks_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StMarks_Tbx.Location = new System.Drawing.Point(235, 102);
            this.UI_StMarks_Tbx.Name = "UI_StMarks_Tbx";
            this.UI_StMarks_Tbx.Size = new System.Drawing.Size(349, 26);
            this.UI_StMarks_Tbx.TabIndex = 1;
            // 
            // UI_RemoveSt_Btn
            // 
            this.UI_RemoveSt_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_RemoveSt_Btn.Location = new System.Drawing.Point(629, 95);
            this.UI_RemoveSt_Btn.Name = "UI_RemoveSt_Btn";
            this.UI_RemoveSt_Btn.Size = new System.Drawing.Size(199, 33);
            this.UI_RemoveSt_Btn.TabIndex = 7;
            this.UI_RemoveSt_Btn.Text = "Remove Student";
            this.UI_RemoveSt_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_StEmail_Tbx
            // 
            this.UI_StEmail_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StEmail_Tbx.Location = new System.Drawing.Point(235, 163);
            this.UI_StEmail_Tbx.Name = "UI_StEmail_Tbx";
            this.UI_StEmail_Tbx.Size = new System.Drawing.Size(349, 26);
            this.UI_StEmail_Tbx.TabIndex = 2;
            // 
            // UI_StAge_Tbx
            // 
            this.UI_StAge_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StAge_Tbx.Location = new System.Drawing.Point(235, 222);
            this.UI_StAge_Tbx.Name = "UI_StAge_Tbx";
            this.UI_StAge_Tbx.Size = new System.Drawing.Size(349, 26);
            this.UI_StAge_Tbx.TabIndex = 3;
            // 
            // UI_ListIndex_Tbx
            // 
            this.UI_ListIndex_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ListIndex_Tbx.Location = new System.Drawing.Point(235, 282);
            this.UI_ListIndex_Tbx.Name = "UI_ListIndex_Tbx";
            this.UI_ListIndex_Tbx.Size = new System.Drawing.Size(349, 26);
            this.UI_ListIndex_Tbx.TabIndex = 5;
            // 
            // UI_InsertAtIndex_Btn
            // 
            this.UI_InsertAtIndex_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_InsertAtIndex_Btn.Location = new System.Drawing.Point(629, 156);
            this.UI_InsertAtIndex_Btn.Name = "UI_InsertAtIndex_Btn";
            this.UI_InsertAtIndex_Btn.Size = new System.Drawing.Size(199, 33);
            this.UI_InsertAtIndex_Btn.TabIndex = 6;
            this.UI_InsertAtIndex_Btn.Text = "Insert At Index";
            this.UI_InsertAtIndex_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_ClearSt_Btn
            // 
            this.UI_ClearSt_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ClearSt_Btn.Location = new System.Drawing.Point(629, 215);
            this.UI_ClearSt_Btn.Name = "UI_ClearSt_Btn";
            this.UI_ClearSt_Btn.Size = new System.Drawing.Size(199, 33);
            this.UI_ClearSt_Btn.TabIndex = 8;
            this.UI_ClearSt_Btn.Text = "Clear All Students";
            this.UI_ClearSt_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Stdents_Lbx
            // 
            this.UI_Stdents_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Stdents_Lbx.FormattingEnabled = true;
            this.UI_Stdents_Lbx.ItemHeight = 20;
            this.UI_Stdents_Lbx.Location = new System.Drawing.Point(34, 363);
            this.UI_Stdents_Lbx.Name = "UI_Stdents_Lbx";
            this.UI_Stdents_Lbx.Size = new System.Drawing.Size(775, 304);
            this.UI_Stdents_Lbx.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.UI_Stdents_Lbx);
            this.Controls.Add(this.UI_ClearSt_Btn);
            this.Controls.Add(this.UI_InsertAtIndex_Btn);
            this.Controls.Add(this.UI_RemoveSt_Btn);
            this.Controls.Add(this.UI_AddSt_Btn);
            this.Controls.Add(this.UI_ListIndex_Tbx);
            this.Controls.Add(this.UI_StAge_Tbx);
            this.Controls.Add(this.UI_StEmail_Tbx);
            this.Controls.Add(this.UI_StMarks_Tbx);
            this.Controls.Add(this.UI_StName_Tbx);
            this.Controls.Add(this.UI_IndexPSN_Lbx);
            this.Controls.Add(this.UI_StAge_Lbl);
            this.Controls.Add(this.UI_Email_Lbl);
            this.Controls.Add(this.UI_StMarks_Lbl);
            this.Controls.Add(this.UI_StName_Lbl);
            this.Name = "Form1";
            this.Text = "Student Manager App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_StName_Lbl;
        private System.Windows.Forms.TextBox UI_StName_Tbx;
        private System.Windows.Forms.Button UI_AddSt_Btn;
        private System.Windows.Forms.Label UI_StMarks_Lbl;
        private System.Windows.Forms.Label UI_Email_Lbl;
        private System.Windows.Forms.Label UI_StAge_Lbl;
        private System.Windows.Forms.Label UI_IndexPSN_Lbx;
        private System.Windows.Forms.TextBox UI_StMarks_Tbx;
        private System.Windows.Forms.Button UI_RemoveSt_Btn;
        private System.Windows.Forms.TextBox UI_StEmail_Tbx;
        private System.Windows.Forms.TextBox UI_StAge_Tbx;
        private System.Windows.Forms.TextBox UI_ListIndex_Tbx;
        private System.Windows.Forms.Button UI_InsertAtIndex_Btn;
        private System.Windows.Forms.Button UI_ClearSt_Btn;
        private System.Windows.Forms.ListBox UI_Stdents_Lbx;
    }
}

