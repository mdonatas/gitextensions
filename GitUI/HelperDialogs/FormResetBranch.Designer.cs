namespace GitUI.HelperDialogs
{
    partial class FormResetBranch
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
            this._NO_TRANSLATE_BranchInfo = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.commitSummaryUserControl1 = new GitUI.UserControls.CommitSummaryUserControl();
            this.ForceReset = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelResetBranchWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _NO_TRANSLATE_BranchInfo
            // 
            this._NO_TRANSLATE_BranchInfo.AutoSize = true;
            this._NO_TRANSLATE_BranchInfo.Location = new System.Drawing.Point(13, 13);
            this._NO_TRANSLATE_BranchInfo.Name = "_NO_TRANSLATE_BranchInfo";
            this._NO_TRANSLATE_BranchInfo.Size = new System.Drawing.Size(129, 15);
            this._NO_TRANSLATE_BranchInfo.TabIndex = 0;
            this._NO_TRANSLATE_BranchInfo.Text = "##Reset branch \'{0}\' to:";
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(302, 338);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(91, 25);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(399, 338);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 25);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // commitSummaryUserControl1
            // 
            this.commitSummaryUserControl1.Location = new System.Drawing.Point(16, 41);
            this.commitSummaryUserControl1.MinimumSize = new System.Drawing.Size(440, 160);
            this.commitSummaryUserControl1.Name = "commitSummaryUserControl1";
            this.commitSummaryUserControl1.Revision = null;
            this.commitSummaryUserControl1.Size = new System.Drawing.Size(477, 160);
            this.commitSummaryUserControl1.TabIndex = 8;
            // 
            // ForceReset
            // 
            this.ForceReset.AutoSize = true;
            this.ForceReset.Location = new System.Drawing.Point(16, 207);
            this.ForceReset.Name = "ForceReset";
            this.ForceReset.Size = new System.Drawing.Size(83, 19);
            this.ForceReset.TabIndex = 9;
            this.ForceReset.Text = "Force reset";
            this.ForceReset.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitUI.Properties.Images.Warning;
            this.pictureBox1.InitialImage = global::GitUI.Properties.Images.Warning;
            this.pictureBox1.Location = new System.Drawing.Point(16, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelDeleteBranchWarning
            // 
            this.labelResetBranchWarning.AutoSize = true;
            this.labelResetBranchWarning.ForeColor = System.Drawing.Color.Black;
            this.labelResetBranchWarning.Location = new System.Drawing.Point(43, 245);
            this.labelResetBranchWarning.MaximumSize = new System.Drawing.Size(450, 0);
            this.labelResetBranchWarning.Name = "labelResetBranchWarning";
            this.labelResetBranchWarning.Size = new System.Drawing.Size(423, 60);
            this.labelResetBranchWarning.TabIndex = 10;
            this.labelResetBranchWarning.Text = "You can only reset a branch safely if there is a direct path from it to selected " +
    "revision.\r\nForcing a branch to reset if it has not been merged might leave some " +
    "commits unreachable.";
            // 
            // FormResetBranch
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(502, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResetBranchWarning);
            this.Controls.Add(this.ForceReset);
            this.Controls.Add(this.commitSummaryUserControl1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this._NO_TRANSLATE_BranchInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResetBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset branch";
            this.Load += new System.EventHandler(this.FormResetBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _NO_TRANSLATE_BranchInfo;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private UserControls.CommitSummaryUserControl commitSummaryUserControl1;
        private System.Windows.Forms.CheckBox ForceReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelResetBranchWarning;
    }
}