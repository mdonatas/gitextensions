﻿namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    partial class GitConfigAdvancedSettingsPage
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
            if (disposing && (components is not null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxPullRebase = new CheckBox();
            checkBoxFetchPrune = new CheckBox();
            checkBoxMergeAutostash = new CheckBox();
            checkBoxRebaseAutostash = new CheckBox();
            checkBoxRebaseAutosquash = new CheckBox();
            checkBoxUpdateRefs = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxPullRebase
            // 
            checkBoxPullRebase.AutoSize = true;
            checkBoxPullRebase.Location = new Point(19, 14);
            checkBoxPullRebase.Name = "checkBoxPullRebase";
            checkBoxPullRebase.Size = new Size(303, 19);
            checkBoxPullRebase.TabIndex = 1;
            checkBoxPullRebase.Text = "Rebase local branch when pulling (instead of merge)";
            checkBoxPullRebase.UseVisualStyleBackColor = true;
            // 
            // checkBoxFetchPrune
            // 
            checkBoxFetchPrune.AutoSize = true;
            checkBoxFetchPrune.Location = new Point(19, 48);
            checkBoxFetchPrune.Name = "checkBoxFetchPrune";
            checkBoxFetchPrune.Size = new Size(217, 19);
            checkBoxFetchPrune.TabIndex = 2;
            checkBoxFetchPrune.Text = "Prune remote branches during fetch";
            checkBoxFetchPrune.UseVisualStyleBackColor = true;
            // 
            // checkBoxMergeAutostash
            // 
            checkBoxMergeAutostash.AutoSize = true;
            checkBoxMergeAutostash.Location = new Point(19, 82);
            checkBoxMergeAutostash.Name = "checkBoxMergeAutostash";
            checkBoxMergeAutostash.Size = new Size(247, 19);
            checkBoxMergeAutostash.TabIndex = 3;
            checkBoxMergeAutostash.Text = "Automatically stash before doing a merge";
            checkBoxMergeAutostash.UseVisualStyleBackColor = true;
            // 
            // checkBoxRebaseAutostash
            // 
            checkBoxRebaseAutostash.AutoSize = true;
            checkBoxRebaseAutostash.Location = new Point(19, 116);
            checkBoxRebaseAutostash.Name = "checkBoxRebaseAutostash";
            checkBoxRebaseAutostash.Size = new Size(247, 19);
            checkBoxRebaseAutostash.TabIndex = 3;
            checkBoxRebaseAutostash.Text = "Automatically stash before doing a rebase";
            checkBoxRebaseAutostash.UseVisualStyleBackColor = true;
            // 
            // checkBoxRebaseAutosquash
            // 
            checkBoxRebaseAutosquash.AutoSize = true;
            checkBoxRebaseAutosquash.Location = new Point(19, 150);
            checkBoxRebaseAutosquash.Name = "checkBoxRebaseAutosquash";
            checkBoxRebaseAutosquash.Size = new Size(367, 19);
            checkBoxRebaseAutosquash.TabIndex = 3;
            checkBoxRebaseAutosquash.Text = "Automatically squash commits when doing an interactive rebase";
            checkBoxRebaseAutosquash.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdateRefs
            // 
            checkBoxUpdateRefs.AutoSize = true;
            checkBoxUpdateRefs.Location = new Point(19, 184);
            checkBoxUpdateRefs.Name = "checkBoxUpdateRefs";
            checkBoxUpdateRefs.Size = new Size(198, 19);
            checkBoxUpdateRefs.TabIndex = 3;
            checkBoxUpdateRefs.Text = "Rebase also dependent branches";
            checkBoxUpdateRefs.UseVisualStyleBackColor = true;
            // 
            // GitConfigAdvancedSettingsPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(checkBoxPullRebase);
            Controls.Add(checkBoxFetchPrune);
            Controls.Add(checkBoxMergeAutostash);
            Controls.Add(checkBoxRebaseAutostash);
            Controls.Add(checkBoxRebaseAutosquash);
            Controls.Add(checkBoxUpdateRefs);
            Name = "GitConfigAdvancedSettingsPage";
            Size = new Size(1494, 820);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxPullRebase;
        private CheckBox checkBoxFetchPrune;
        private CheckBox checkBoxMergeAutostash;
        private CheckBox checkBoxRebaseAutostash;
        private CheckBox checkBoxRebaseAutosquash;
        private CheckBox checkBoxUpdateRefs;
    }
}
