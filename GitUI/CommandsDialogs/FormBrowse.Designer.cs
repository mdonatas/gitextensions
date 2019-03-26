﻿using System.Drawing;
using System.Windows.Forms;
using GitExtUtils.GitUI;

namespace GitUI.CommandsDialogs
{
    partial class FormBrowse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
            this.ToolStrip = new GitUI.ToolStripEx();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleBranchTreePanel = new System.Windows.Forms.ToolStripButton();
            this.toggleSplitViewLayout = new System.Windows.Forms.ToolStripButton();
            this.menuCommitInfoPosition = new System.Windows.Forms.ToolStripSplitButton();
            this.commitInfoBelowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitInfoLeftwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitInfoRightwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLevelUp = new System.Windows.Forms.ToolStripSplitButton();
            this._NO_TRANSLATE_WorkingDir = new System.Windows.Forms.ToolStripSplitButton();
            this.branchSelect = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitStash = new System.Windows.Forms.ToolStripSplitButton();
            this.stashChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stashPopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.manageStashesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAStashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonCommit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPull = new System.Windows.Forms.ToolStripSplitButton();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchPruneAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultPullButtonActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonPush = new GitUI.CommandsDialogs.ToolStripPushButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFileExplorer = new System.Windows.Forms.ToolStripButton();
            this.GitBash = new System.Windows.Forms.ToolStripButton();
            this.EditSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBranchFilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBranchFilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRevisionFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripRevisionFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripRevisionFilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ShowFirstParent = new System.Windows.Forms.ToolStripButton();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.repoObjectsTree = new GitUI.BranchTreePanel.RepoObjectsTree();
            this.RightSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RevisionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RevisionGridContainer = new System.Windows.Forms.Panel();
            this.RevisionGrid = new GitUI.RevisionGridControl();
            this.RevisionHeader = new GitUI.UserControls.InteractiveGitActionControl();
            this.CommitInfoTabControl = new GitUI.CommandsDialogs.FullBleedTabControl();
            this.CommitInfoTabPage = new System.Windows.Forms.TabPage();
            this.RevisionInfo = new GitUI.CommitInfo.CommitInfo();
            this.TreeTabPage = new System.Windows.Forms.TabPage();
            this.fileTree = new GitUI.CommandsDialogs.RevisionFileTreeControl();
            this.DiffTabPage = new System.Windows.Forms.TabPage();
            this.revisionDiff = new GitUI.CommandsDialogs.RevisionDiffControl();
            this.GpgInfoTabPage = new System.Windows.Forms.TabPage();
            this.revisionGpgInfo1 = new GitUI.CommandsDialogs.RevisionGpgInfoControl();
            this.FilterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initNewRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavouriteRepositories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecentRepositories = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRecentRepositoriesListToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRecentRepositoriesClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.manageRemoteRepositoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator43 = new System.Windows.Forms.ToolStripSeparator();
            this.manageSubmodulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllSubmodulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeAllSubmodulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemWorktrees = new System.Windows.Forms.ToolStripMenuItem();
            this.createWorktreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageWorktreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator44 = new System.Windows.Forms.ToolStripSeparator();
            this.editgitignoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editgitinfoexcludeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGitAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editmailmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemSparse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gitMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressGitDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoverLostObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIndexLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLocalGitConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repoSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.gitBashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoLastCommitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.stashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMergetoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator45 = new System.Windows.Forms.ToolStripSeparator();
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.cherryPickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReflog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.formatPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator46 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator42 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PuTTYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAuthenticationAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateOrImportKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._repositoryHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._forkCloneRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._viewPullRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._createPullRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.pluginSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTelemetryEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitcommandLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new GitUI.MenuStripEx();
            this.gitItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gitRevisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolPanel = new System.Windows.Forms.ToolStripContainer();
            this._addUpstreamRemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightSplitContainer)).BeginInit();
            this.RightSplitContainer.Panel1.SuspendLayout();
            this.RightSplitContainer.Panel2.SuspendLayout();
            this.RightSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevisionsSplitContainer)).BeginInit();
            this.RevisionsSplitContainer.Panel1.SuspendLayout();
            this.RevisionsSplitContainer.SuspendLayout();
            this.RevisionGridContainer.SuspendLayout();
            this.CommitInfoTabControl.SuspendLayout();
            this.CommitInfoTabPage.SuspendLayout();
            this.TreeTabPage.SuspendLayout();
            this.DiffTabPage.SuspendLayout();
            this.GpgInfoTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitRevisionBindingSource)).BeginInit();
            this.toolPanel.ContentPanel.SuspendLayout();
            this.toolPanel.TopToolStripPanel.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            toolStripMenuItem2.Text = "...";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(83, 22);
            toolStripMenuItem4.Text = "...";
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new System.Drawing.Size(236, 6);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ClickThrough = true;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.toolStripSeparator0,
            this.toggleBranchTreePanel,
            this.toggleSplitViewLayout,
            this.menuCommitInfoPosition,
            this.toolStripSeparator17,
            this.toolStripButtonLevelUp,
            this._NO_TRANSLATE_WorkingDir,
            this.branchSelect,
            this.toolStripSeparator1,
            this.toolStripButtonPull,
            this.toolStripButtonPush,
            this.toolStripButtonCommit,
            this.toolStripSplitStash,
            this.toolStripSeparator2,
            this.toolStripFileExplorer,
            this.GitBash,
            this.EditSettings,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripBranchFilterComboBox,
            this.toolStripBranchFilterDropDownButton,
            this.toolStripSeparator19,
            this.toolStripRevisionFilterLabel,
            this.toolStripRevisionFilterTextBox,
            this.toolStripRevisionFilterDropDownButton,
            this.ShowFirstParent});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(920, 25);
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ToolStrip.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::GitUI.Properties.Images.ReloadRevisions;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.White;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshToolStripMenuItemClick);
            // 
            // toolStripSeparator0
            // 
            this.toolStripSeparator0.Name = "toolStripSeparator0";
            this.toolStripSeparator0.Size = new System.Drawing.Size(6, 25);
            // 
            // toggleBranchTreePanel
            // 
            this.toggleBranchTreePanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleBranchTreePanel.Image = global::GitUI.Properties.Images.LayoutSidebarLeft;
            this.toggleBranchTreePanel.Name = "toggleBranchTreePanel";
            this.toggleBranchTreePanel.Size = new System.Drawing.Size(23, 22);
            this.toggleBranchTreePanel.ToolTipText = "Toggle left panel";
            this.toggleBranchTreePanel.Click += new System.EventHandler(this.toggleBranchTreePanel_Click);
            // 
            // toggleSplitViewLayout
            // 
            this.toggleSplitViewLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleSplitViewLayout.Image = global::GitUI.Properties.Images.LayoutFooter;
            this.toggleSplitViewLayout.Name = "toggleSplitViewLayout";
            this.toggleSplitViewLayout.Size = new System.Drawing.Size(23, 22);
            this.toggleSplitViewLayout.ToolTipText = "Toggle split view layout";
            this.toggleSplitViewLayout.Click += new System.EventHandler(this.toggleSplitViewLayout_Click);
            // 
            // menuCommitInfoPosition
            // 
            this.menuCommitInfoPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuCommitInfoPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitInfoBelowMenuItem,
            this.commitInfoLeftwardMenuItem,
            this.commitInfoRightwardMenuItem});
            this.menuCommitInfoPosition.Image = global::GitUI.Properties.Images.LayoutFooterTab;
            this.menuCommitInfoPosition.Name = "menuCommitInfoPosition";
            this.menuCommitInfoPosition.Size = new System.Drawing.Size(32, 22);
            this.menuCommitInfoPosition.ToolTipText = "Commit info position";
            this.menuCommitInfoPosition.Click += new System.EventHandler(this.CommitInfoPositionClick);
            // 
            // commitInfoBelowMenuItem
            // 
            this.commitInfoBelowMenuItem.Image = global::GitUI.Properties.Images.LayoutFooterTab;
            this.commitInfoBelowMenuItem.Name = "commitInfoBelowMenuItem";
            this.commitInfoBelowMenuItem.Size = new System.Drawing.Size(259, 22);
            this.commitInfoBelowMenuItem.Text = "Commit info below graph";
            this.commitInfoBelowMenuItem.Click += new System.EventHandler(this.CommitInfoBelowClick);
            // 
            // commitInfoLeftwardMenuItem
            // 
            this.commitInfoLeftwardMenuItem.Image = global::GitUI.Properties.Images.LayoutSidebarTopLeft;
            this.commitInfoLeftwardMenuItem.Name = "commitInfoLeftwardMenuItem";
            this.commitInfoLeftwardMenuItem.Size = new System.Drawing.Size(259, 22);
            this.commitInfoLeftwardMenuItem.Text = "Commit info left of graph";
            this.commitInfoLeftwardMenuItem.Click += new System.EventHandler(this.CommitInfoLeftwardClick);
            // 
            // commitInfoRightwardMenuItem
            // 
            this.commitInfoRightwardMenuItem.Image = global::GitUI.Properties.Images.LayoutSidebarTopRight;
            this.commitInfoRightwardMenuItem.Name = "commitInfoRightwardMenuItem";
            this.commitInfoRightwardMenuItem.Size = new System.Drawing.Size(259, 22);
            this.commitInfoRightwardMenuItem.Text = "Commit info right of graph";
            this.commitInfoRightwardMenuItem.Click += new System.EventHandler(this.CommitInfoRightwardClick);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLevelUp
            // 
            this.toolStripButtonLevelUp.AutoToolTip = false;
            this.toolStripButtonLevelUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLevelUp.Image = global::GitUI.Properties.Images.SubmodulesManage;
            this.toolStripButtonLevelUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLevelUp.Name = "toolStripButtonLevelUp";
            this.toolStripButtonLevelUp.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonLevelUp.Text = "";
            this.toolStripButtonLevelUp.ToolTipText = "";
            this.toolStripButtonLevelUp.ButtonClick += new System.EventHandler(this.toolStripButtonLevelUp_ButtonClick);
            this.toolStripButtonLevelUp.DropDownOpening += new System.EventHandler(this.toolStripButtonLevelUp_DropDownOpening);
            // 
            // _NO_TRANSLATE_WorkingDir
            // 
            this._NO_TRANSLATE_WorkingDir.Image = global::GitUI.Properties.Resources.RepoOpen;
            this._NO_TRANSLATE_WorkingDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._NO_TRANSLATE_WorkingDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._NO_TRANSLATE_WorkingDir.Name = "_NO_TRANSLATE_WorkingDir";
            this._NO_TRANSLATE_WorkingDir.Size = new System.Drawing.Size(83, 22);
            this._NO_TRANSLATE_WorkingDir.Text = "WorkingDir";
            this._NO_TRANSLATE_WorkingDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._NO_TRANSLATE_WorkingDir.ToolTipText = "Change working directory";
            this._NO_TRANSLATE_WorkingDir.ButtonClick += new System.EventHandler(this.WorkingDirClick);
            this._NO_TRANSLATE_WorkingDir.DropDownOpening += new System.EventHandler(this.WorkingDirDropDownOpening);
            this._NO_TRANSLATE_WorkingDir.MouseUp += new System.Windows.Forms.MouseEventHandler(this._NO_TRANSLATE_WorkingDir_MouseUp);
            // 
            // branchSelect
            // 
            this.branchSelect.Image = global::GitUI.Properties.Resources.branch;
            this.branchSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.branchSelect.Name = "branchSelect";
            this.branchSelect.Size = new System.Drawing.Size(60, 22);
            this.branchSelect.Text = "Branch";
            this.branchSelect.ToolTipText = "Change current branch";
            this.branchSelect.ButtonClick += new System.EventHandler(this.CurrentBranchClick);
            this.branchSelect.DropDownOpening += new System.EventHandler(this.CurrentBranchDropDownOpening);
            this.branchSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.branchSelect_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitStash
            // 
            this.toolStripSplitStash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stashChangesToolStripMenuItem,
            this.stashPopToolStripMenuItem,
            this.toolStripSeparator9,
            this.manageStashesToolStripMenuItem,
            this.createAStashToolStripMenuItem});
            this.toolStripSplitStash.Image = global::GitUI.Properties.Images.Stash;
            this.toolStripSplitStash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitStash.Name = "toolStripSplitStash";
            this.toolStripSplitStash.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitStash.ToolTipText = "Manage stashes";
            this.toolStripSplitStash.ButtonClick += new System.EventHandler(this.ToolStripSplitStashButtonClick);
            this.toolStripSplitStash.DropDownOpened += new System.EventHandler(this.toolStripSplitStash_DropDownOpened);
            // 
            // stashChangesToolStripMenuItem
            // 
            this.stashChangesToolStripMenuItem.Name = "stashChangesToolStripMenuItem";
            this.stashChangesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.stashChangesToolStripMenuItem.Text = "Stash";
            this.stashChangesToolStripMenuItem.ToolTipText = "Stash changes";
            this.stashChangesToolStripMenuItem.Click += new System.EventHandler(this.StashChangesToolStripMenuItemClick);
            // 
            // stashPopToolStripMenuItem
            // 
            this.stashPopToolStripMenuItem.Name = "stashPopToolStripMenuItem";
            this.stashPopToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.stashPopToolStripMenuItem.Text = "Stash pop";
            this.stashPopToolStripMenuItem.ToolTipText = "Apply and drop single stash";
            this.stashPopToolStripMenuItem.Click += new System.EventHandler(this.StashPopToolStripMenuItemClick);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(164, 6);
            // 
            // manageStashesToolStripMenuItem
            // 
            this.manageStashesToolStripMenuItem.Name = "manageStashesToolStripMenuItem";
            this.manageStashesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.manageStashesToolStripMenuItem.Text = "Manage stashes...";
            this.manageStashesToolStripMenuItem.ToolTipText = "Manage stashes";
            this.manageStashesToolStripMenuItem.Click += new System.EventHandler(this.ManageStashesToolStripMenuItemClick);
            // 
            // createAStashToolStripMenuItem
            // 
            this.createAStashToolStripMenuItem.Name = "createAStashToolStripMenuItem";
            this.createAStashToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.createAStashToolStripMenuItem.Text = "Create a stash...";
            this.createAStashToolStripMenuItem.Click += new System.EventHandler(this.CreateStashToolStripMenuItemClick);
            // 
            // toolStripButtonCommit
            // 
            this.toolStripButtonCommit.Image = global::GitUI.Properties.Images.RepoStateClean;
            this.toolStripButtonCommit.ImageAlign = ContentAlignment.MiddleLeft;
            this.toolStripButtonCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCommit.Name = "toolStripButtonCommit";
            this.toolStripButtonCommit.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonCommit.Text = "Commit";
            this.toolStripButtonCommit.TextAlign = ContentAlignment.MiddleLeft;
            this.toolStripButtonCommit.Click += new System.EventHandler(this.CommitToolStripMenuItemClick);
            // 
            // toolStripButtonPull
            // 
            this.toolStripButtonPull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPull.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pullToolStripMenuItem1,
            toolStripSeparator11,
            this.mergeToolStripMenuItem,
            this.rebaseToolStripMenuItem1,
            this.fetchToolStripMenuItem,
            this.fetchAllToolStripMenuItem,
            this.fetchPruneAllToolStripMenuItem,
            toolStripSeparator14,
            this.setDefaultPullButtonActionToolStripMenuItem});
            this.toolStripButtonPull.Image = global::GitUI.Properties.Images.Pull;
            this.toolStripButtonPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPull.Name = "toolStripButtonPull";
            this.toolStripButtonPull.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonPull.Text = "Pull";
            this.toolStripButtonPull.ButtonClick += new System.EventHandler(this.ToolStripButtonPullClick);
            this.toolStripButtonPull.DropDownOpened += new System.EventHandler(this.toolStripButtonPull_DropDownOpened);
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(236, 6);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Image = global::GitUI.Properties.Images.PullMerge;
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.mergeToolStripMenuItem.Text = "Pull - merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // rebaseToolStripMenuItem1
            // 
            this.rebaseToolStripMenuItem1.Image = global::GitUI.Properties.Images.PullRebase;
            this.rebaseToolStripMenuItem1.Name = "rebaseToolStripMenuItem1";
            this.rebaseToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.rebaseToolStripMenuItem1.Text = "Pull - rebase";
            this.rebaseToolStripMenuItem1.Click += new System.EventHandler(this.rebaseToolStripMenuItem1_Click);
            // 
            // fetchToolStripMenuItem
            // 
            this.fetchToolStripMenuItem.Image = global::GitUI.Properties.Images.PullFetch;
            this.fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            this.fetchToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.fetchToolStripMenuItem.Text = "Fetch";
            this.fetchToolStripMenuItem.ToolTipText = "Fetch branches and tags";
            this.fetchToolStripMenuItem.Click += new System.EventHandler(this.fetchToolStripMenuItem_Click);
            // 
            // pullToolStripMenuItem1
            // 
            this.pullToolStripMenuItem1.Image = global::GitUI.Properties.Images.Pull;
            this.pullToolStripMenuItem1.Name = "pullToolStripMenuItem1";
            this.pullToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.pullToolStripMenuItem1.Text = "Open pull dialog...";
            this.pullToolStripMenuItem1.Click += new System.EventHandler(this.pullToolStripMenuItem1_Click);
            // 
            // fetchAllToolStripMenuItem
            // 
            this.fetchAllToolStripMenuItem.Image = global::GitUI.Properties.Images.PullFetchAll;
            this.fetchAllToolStripMenuItem.Name = "fetchAllToolStripMenuItem";
            this.fetchAllToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.fetchAllToolStripMenuItem.Text = "Fetch all";
            this.fetchAllToolStripMenuItem.ToolTipText = "Fetch branches and tags from all remote repositories";
            this.fetchAllToolStripMenuItem.Click += new System.EventHandler(this.fetchAllToolStripMenuItem_Click);
            // 
            // fetchPruneAllToolStripMenuItem
            // 
            this.fetchPruneAllToolStripMenuItem.Image = global::GitUI.Properties.Images.PullFetchPruneAll;
            this.fetchPruneAllToolStripMenuItem.Name = "fetchPruneAllToolStripMenuItem";
            this.fetchPruneAllToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.fetchPruneAllToolStripMenuItem.Text = "Fetch and prune all";
            this.fetchPruneAllToolStripMenuItem.ToolTipText = "Fetch branches and tags from all remote repositories also prune deleted refs";
            this.fetchPruneAllToolStripMenuItem.Click += new System.EventHandler(this.fetchPruneAllToolStripMenuItem_Click);
            // 
            // setDefaultPullButtonActionToolStripMenuItem
            // 
            this.setDefaultPullButtonActionToolStripMenuItem.Name = "setDefaultPullButtonActionToolStripMenuItem";
            this.setDefaultPullButtonActionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.setDefaultPullButtonActionToolStripMenuItem.Text = "Set default Pull button action";
            // 
            // toolStripButtonPush
            // 
            this.toolStripButtonPush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPush.Image = global::GitUI.Properties.Images.Push;
            this.toolStripButtonPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPush.Name = "toolStripButtonPush";
            this.toolStripButtonPush.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPush.Text = "Push";
            this.toolStripButtonPush.Click += new System.EventHandler(this.ToolStripButtonPushClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripFileExplorer
            // 
            this.toolStripFileExplorer.Enabled = false;
            this.toolStripFileExplorer.Image = global::GitUI.Properties.Images.BrowseFileExplorer;
            this.toolStripFileExplorer.ImageTransparentColor = System.Drawing.Color.Gray;
            this.toolStripFileExplorer.Name = "toolStripFileExplorer";
            this.toolStripFileExplorer.Size = new System.Drawing.Size(23, 22);
            this.toolStripFileExplorer.ToolTipText = "File Explorer";
            this.toolStripFileExplorer.Click += new System.EventHandler(this.FileExplorerToolStripMenuItemClick);
            // 
            // GitBash
            // 
            this.GitBash.Image = global::GitUI.Properties.Images.GitForWindows;
            this.GitBash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GitBash.Name = "GitBash";
            this.GitBash.Size = new System.Drawing.Size(23, 22);
            this.GitBash.ToolTipText = "Git bash";
            this.GitBash.Click += new System.EventHandler(this.GitBashClick);
            // 
            // EditSettings
            // 
            this.EditSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditSettings.Image = global::GitUI.Properties.Images.Settings;
            this.EditSettings.Name = "EditSettings";
            this.EditSettings.Size = new System.Drawing.Size(23, 22);
            this.EditSettings.ToolTipText = "Settings";
            this.EditSettings.Click += new System.EventHandler(this.OnShowSettingsClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Branches:";
            // 
            // toolStripBranchFilterComboBox
            // 
            this.toolStripBranchFilterComboBox.AutoSize = false;
            this.toolStripBranchFilterComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripBranchFilterComboBox.DropDownWidth = 300;
            this.toolStripBranchFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripBranchFilterComboBox.Name = "toolStripBranchFilterComboBox";
            this.toolStripBranchFilterComboBox.Size = new System.Drawing.Size(100, 23);
            this.toolStripBranchFilterComboBox.Click += new System.EventHandler(this.toolStripBranchFilterComboBox_Click);
            // 
            // toolStripBranchFilterDropDownButton
            // 
            this.toolStripBranchFilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBranchFilterDropDownButton.Image = global::GitUI.Properties.Images.EditFilter;
            this.toolStripBranchFilterDropDownButton.Name = "toolStripBranchFilterDropDownButton";
            this.toolStripBranchFilterDropDownButton.Size = new System.Drawing.Size(29, 22);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRevisionFilterLabel
            // 
            this.toolStripRevisionFilterLabel.Name = "toolStripRevisionFilterLabel";
            this.toolStripRevisionFilterLabel.Size = new System.Drawing.Size(36, 22);
            this.toolStripRevisionFilterLabel.Text = "Filter:";
            // 
            // toolStripRevisionFilterTextBox
            // 
            this.toolStripRevisionFilterTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripRevisionFilterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripRevisionFilterTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripRevisionFilterTextBox.Name = "toolStripRevisionFilterTextBox";
            this.toolStripRevisionFilterTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripRevisionFilterDropDownButton
            // 
            this.toolStripRevisionFilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRevisionFilterDropDownButton.Image = global::GitUI.Properties.Images.EditFilter;
            this.toolStripRevisionFilterDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRevisionFilterDropDownButton.Name = "toolStripRevisionFilterDropDownButton";
            this.toolStripRevisionFilterDropDownButton.Size = new System.Drawing.Size(29, 22);
            // 
            // ShowFirstParent
            // 
            this.ShowFirstParent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowFirstParent.Image = global::GitUI.Properties.Images.ShowFirstParent;
            this.ShowFirstParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFirstParent.Name = "ShowFirstParent";
            this.ShowFirstParent.Size = new System.Drawing.Size(23, 20);
            this.ShowFirstParent.ToolTipText = "Show first parents";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.repoObjectsTree);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.RightSplitContainer);
            this.MainSplitContainer.Size = new System.Drawing.Size(923, 502);
            this.MainSplitContainer.SplitterWidth = 6;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // repoObjectsTree
            // 
            this.repoObjectsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repoObjectsTree.Location = new System.Drawing.Point(0, 0);
            this.repoObjectsTree.MinimumSize = new System.Drawing.Size(190, 0);
            this.repoObjectsTree.Margin = new System.Windows.Forms.Padding(0);
            this.repoObjectsTree.Name = "repoObjectsTree";
            this.repoObjectsTree.Size = new System.Drawing.Size(267, 502);
            this.repoObjectsTree.TabIndex = 0;
            // 
            // RightSplitContainer
            // 
            this.RightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RightSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RightSplitContainer.Name = "RightSplitContainer";
            this.RightSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RightSplitContainer.Panel1
            // 
            this.RightSplitContainer.Panel1.Controls.Add(this.RevisionsSplitContainer);
            // 
            // RightSplitContainer.Panel2
            // 
            this.RightSplitContainer.Panel2.Controls.Add(this.CommitInfoTabControl);
            this.RightSplitContainer.Panel2MinSize = 0;
            this.RightSplitContainer.Size = new System.Drawing.Size(650, 502);
            this.RightSplitContainer.SplitterDistance = 209;
            this.RightSplitContainer.SplitterWidth = 6;
            this.RightSplitContainer.TabIndex = 1;
            this.RightSplitContainer.TabStop = false;
            // 
            // RevisionsSplitContainer
            // 
            this.RevisionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.RevisionsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RevisionsSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RevisionsSplitContainer.Name = "RevisionsSplitContainer";
            // 
            // RevisionsSplitContainer.Panel1
            // 
            this.RevisionsSplitContainer.Size = new System.Drawing.Size(650, 209);
            this.RevisionsSplitContainer.SplitterDistance = 350;
            this.RevisionsSplitContainer.SplitterWidth = 6;
            this.RevisionsSplitContainer.Panel1.Controls.Add(this.RevisionGridContainer);
            this.RevisionsSplitContainer.TabIndex = 0;
            // 
            // RevisionGridContainer
            // 
            this.RevisionGridContainer.Controls.Add(this.RevisionGrid);
            this.RevisionGridContainer.Controls.Add(this.RevisionHeader);
            this.RevisionGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionGridContainer.Location = new System.Drawing.Point(0, 0);
            this.RevisionGridContainer.Name = "RevisionGridContainer";
            this.RevisionGridContainer.Size = new System.Drawing.Size(606, 205);
            this.RevisionGridContainer.TabIndex = 2;
            // 
            // RevisionGrid
            // 
            this.RevisionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionGrid.Location = new System.Drawing.Point(0, 0);
            this.RevisionGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RevisionGrid.Name = "RevisionGrid";
            this.RevisionGrid.Size = new System.Drawing.Size(350, 209);
            this.RevisionGrid.TabIndex = 0;
            // 
            // RevisionHeader
            // 
            this.RevisionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevisionHeader.Location = new System.Drawing.Point(0, 0);
            this.RevisionHeader.MinimumSize = new System.Drawing.Size(0, 33);
            this.RevisionHeader.Name = "RevisionHeader";
            this.RevisionHeader.Size = new System.Drawing.Size(561, 33);
            this.RevisionHeader.TabIndex = 1;
            this.RevisionHeader.Visible = false;
            // 
            // CommitInfoTabControl
            // 
            this.CommitInfoTabControl.Controls.Add(this.CommitInfoTabPage);
            this.CommitInfoTabControl.Controls.Add(this.DiffTabPage);
            this.CommitInfoTabControl.Controls.Add(this.TreeTabPage);
            this.CommitInfoTabControl.Controls.Add(this.GpgInfoTabPage);
            this.CommitInfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommitInfoTabControl.Location = new System.Drawing.Point(0, 0);
            this.CommitInfoTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.CommitInfoTabControl.Name = "CommitInfoTabControl";
            this.CommitInfoTabControl.Padding = new System.Drawing.Point(0, 0);
            this.CommitInfoTabControl.SelectedIndex = 0;
            this.CommitInfoTabControl.Size = new System.Drawing.Size(650, 287);
            this.CommitInfoTabControl.TabIndex = 0;
            this.CommitInfoTabControl.SelectedIndexChanged += new System.EventHandler(this.CommitInfoTabControl_SelectedIndexChanged);
            // 
            // CommitInfoTabPage
            // 
            this.CommitInfoTabPage.Controls.Add(this.RevisionInfo);
            this.CommitInfoTabPage.Location = new System.Drawing.Point(1, 21);
            this.CommitInfoTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.CommitInfoTabPage.Name = "CommitInfoTabPage";
            this.CommitInfoTabPage.Size = new System.Drawing.Size(646, 264);
            this.CommitInfoTabPage.TabIndex = 2;
            this.CommitInfoTabPage.Text = "Commit";
            this.CommitInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // RevisionInfo
            // 
            this.RevisionInfo.BackColor = System.Drawing.SystemColors.Window;
            this.RevisionInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RevisionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionInfo.Location = new System.Drawing.Point(0, 0);
            this.RevisionInfo.Margin = new System.Windows.Forms.Padding(0);
            this.RevisionInfo.Name = "RevisionInfo";
            this.RevisionInfo.ShowBranchesAsLinks = true;
            this.RevisionInfo.Size = new System.Drawing.Size(646, 264);
            this.RevisionInfo.TabIndex = 0;
            this.RevisionInfo.CommandClicked += new System.EventHandler<GitUI.CommitInfo.CommandEventArgs>(this.RevisionInfo_CommandClicked);
            // 
            // TreeTabPage
            // 
            this.TreeTabPage.Controls.Add(this.fileTree);
            this.TreeTabPage.Location = new System.Drawing.Point(1, 21);
            this.TreeTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.TreeTabPage.Name = "TreeTabPage";
            this.TreeTabPage.Size = new System.Drawing.Size(646, 264);
            this.TreeTabPage.TabIndex = 0;
            this.TreeTabPage.Text = "File tree";
            this.TreeTabPage.UseVisualStyleBackColor = true;
            // 
            // fileTree
            // 
            this.fileTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTree.Location = new System.Drawing.Point(0, 0);
            this.fileTree.Margin = new System.Windows.Forms.Padding(0);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(646, 264);
            this.fileTree.TabIndex = 0;
            // 
            // DiffTabPage
            // 
            this.DiffTabPage.Controls.Add(this.revisionDiff);
            this.DiffTabPage.Location = new System.Drawing.Point(1, 21);
            this.DiffTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.DiffTabPage.Name = "DiffTabPage";
            this.DiffTabPage.Size = new System.Drawing.Size(DpiUtil.Scale(646), 264);
            this.DiffTabPage.TabIndex = 1;
            this.DiffTabPage.Text = "Diff";
            this.DiffTabPage.UseVisualStyleBackColor = true;
            // 
            // revisionDiff
            // 
            this.revisionDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revisionDiff.Location = new System.Drawing.Point(0, 0);
            this.revisionDiff.Margin = new System.Windows.Forms.Padding(0);
            this.revisionDiff.Name = "revisionDiff";
            this.revisionDiff.Size = new System.Drawing.Size(646, 264);
            this.revisionDiff.TabIndex = 0;
            // 
            // GpgInfoTabPage
            // 
            this.GpgInfoTabPage.Controls.Add(this.revisionGpgInfo1);
            this.GpgInfoTabPage.Location = new System.Drawing.Point(1, 21);
            this.GpgInfoTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.GpgInfoTabPage.Name = "GpgInfoTabPage";
            this.GpgInfoTabPage.Size = new System.Drawing.Size(646, 264);
            this.GpgInfoTabPage.TabIndex = 3;
            this.GpgInfoTabPage.Text = "GPG";
            this.GpgInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // revisionGpgInfo1
            // 
            this.revisionGpgInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revisionGpgInfo1.Location = new System.Drawing.Point(0, 0);
            this.revisionGpgInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.revisionGpgInfo1.Name = "revisionGpgInfo1";
            this.revisionGpgInfo1.Padding = new System.Windows.Forms.Padding(8);
            this.revisionGpgInfo1.Size = new System.Drawing.Size(646, 264);
            this.revisionGpgInfo1.TabIndex = 0;
            // 
            // FilterToolTip
            // 
            this.FilterToolTip.AutomaticDelay = 100;
            this.FilterToolTip.ShowAlways = true;
            this.FilterToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.FilterToolTip.ToolTipTitle = "RegEx";
            this.FilterToolTip.UseAnimation = false;
            this.FilterToolTip.UseFading = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initNewRepositoryToolStripMenuItem,
            this.openToolStripMenuItem,
            this.tsmiFavouriteRepositories,
            this.tsmiRecentRepositories,
            this.toolStripSeparator12,
            this.cloneToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "&Start";
            // 
            // initNewRepositoryToolStripMenuItem
            // 
            this.initNewRepositoryToolStripMenuItem.Image = global::GitUI.Properties.Images.RepoCreate;
            this.initNewRepositoryToolStripMenuItem.Name = "initNewRepositoryToolStripMenuItem";
            this.initNewRepositoryToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.initNewRepositoryToolStripMenuItem.Text = "Create new repository...";
            this.initNewRepositoryToolStripMenuItem.Click += new System.EventHandler(this.InitNewRepositoryToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::GitUI.Properties.Images.RepoOpen;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // tsmiFavouriteRepositories
            // 
            this.tsmiFavouriteRepositories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem4});
            this.tsmiFavouriteRepositories.Image = global::GitUI.Properties.Images.Star;
            this.tsmiFavouriteRepositories.Name = "tsmiFavouriteRepositories";
            this.tsmiFavouriteRepositories.Size = new System.Drawing.Size(198, 22);
            this.tsmiFavouriteRepositories.Text = "Favourite Repositories";
            this.tsmiFavouriteRepositories.DropDownOpening += new System.EventHandler(this.tsmiFavouriteRepositories_DropDownOpening);
            // 
            // tsmiRecentRepositories
            // 
            this.tsmiRecentRepositories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem2,
            this.clearRecentRepositoriesListToolStripMenuItem,
            this.tsmiRecentRepositoriesClear});
            this.tsmiRecentRepositories.Image = global::GitUI.Properties.Images.RecentRepositories;
            this.tsmiRecentRepositories.Name = "tsmiRecentRepositories";
            this.tsmiRecentRepositories.Size = new System.Drawing.Size(198, 22);
            this.tsmiRecentRepositories.Text = "Recent Repositories";
            this.tsmiRecentRepositories.DropDownOpening += new System.EventHandler(this.tsmiRecentRepositories_DropDownOpening);
            // 
            // clearRecentRepositoriesListToolStripMenuItem
            // 
            this.clearRecentRepositoriesListToolStripMenuItem.Name = "clearRecentRepositoriesListToolStripMenuItem";
            this.clearRecentRepositoriesListToolStripMenuItem.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiRecentRepositoriesClear
            // 
            this.tsmiRecentRepositoriesClear.Name = "tsmiRecentRepositoriesClear";
            this.tsmiRecentRepositoriesClear.Size = new System.Drawing.Size(122, 22);
            this.tsmiRecentRepositoriesClear.Text = "Clear List";
            this.tsmiRecentRepositoriesClear.Click += new System.EventHandler(this.tsmiRecentRepositoriesClear_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(195, 6);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Image = global::GitUI.Properties.Images.CloneRepoGit;
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cloneToolStripMenuItem.Text = "Clone repository...";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.CloneToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::GitUI.Properties.Images.DashboardFolderGit;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.closeToolStripMenuItem.Text = "Close (go to Dashboard)";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::GitUI.Properties.Images.ReloadRevisions;
            this.refreshToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItemClick);
            // 
            // refreshDashboardToolStripMenuItem
            // 
            this.refreshDashboardToolStripMenuItem.Image = global::GitUI.Properties.Images.ReloadRevisions;
            this.refreshDashboardToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.refreshDashboardToolStripMenuItem.Name = "refreshDashboardToolStripMenuItem";
            this.refreshDashboardToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshDashboardToolStripMenuItem.Text = "&Refresh";
            this.refreshDashboardToolStripMenuItem.Click += new System.EventHandler(this.RefreshDashboardToolStripMenuItemClick);
            // 
            // fileExplorerToolStripMenuItem
            // 
            this.fileExplorerToolStripMenuItem.Image = global::GitUI.Properties.Images.BrowseFileExplorer;
            this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            this.fileExplorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.O)));
            this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fileExplorerToolStripMenuItem.Text = "File Explorer";
            this.fileExplorerToolStripMenuItem.Click += new System.EventHandler(this.FileExplorerToolStripMenuItemClick);
            // 
            // repositoryToolStripMenuItem
            // 
            this.repositoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.fileExplorerToolStripMenuItem,
            this.toolStripSeparator8,
            this.manageRemoteRepositoriesToolStripMenuItem1,
            this.toolStripSeparator43,
            this.manageSubmodulesToolStripMenuItem,
            this.updateAllSubmodulesToolStripMenuItem,
            this.synchronizeAllSubmodulesToolStripMenuItem,
            this.toolStripSeparator10,
            this.toolStripMenuItemWorktrees,
            this.toolStripSeparator44,
            this.editgitignoreToolStripMenuItem1,
            this.editgitinfoexcludeToolStripMenuItem,
            this.editGitAttributesToolStripMenuItem,
            this.editmailmapToolStripMenuItem,
            this.menuitemSparse,
            this.toolStripSeparator4,
            this.gitMaintenanceToolStripMenuItem,
            this.repoSettingsToolStripMenuItem,
            this.toolStripSeparator13,
            this.closeToolStripMenuItem});
            this.repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            this.repositoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.repositoryToolStripMenuItem.Text = "&Repository";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(218, 6);
            // 
            // manageRemoteRepositoriesToolStripMenuItem1
            // 
            this.manageRemoteRepositoriesToolStripMenuItem1.Image = global::GitUI.Properties.Images.Remotes;
            this.manageRemoteRepositoriesToolStripMenuItem1.Name = "manageRemoteRepositoriesToolStripMenuItem1";
            this.manageRemoteRepositoriesToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.manageRemoteRepositoriesToolStripMenuItem1.Text = "Remote repositories...";
            this.manageRemoteRepositoriesToolStripMenuItem1.Click += new System.EventHandler(this.ManageRemoteRepositoriesToolStripMenuItemClick);
            // 
            // toolStripSeparator43
            // 
            this.toolStripSeparator43.Name = "toolStripSeparator43";
            this.toolStripSeparator43.Size = new System.Drawing.Size(218, 6);
            // 
            // manageSubmodulesToolStripMenuItem
            // 
            this.manageSubmodulesToolStripMenuItem.Image = global::GitUI.Properties.Images.SubmodulesManage;
            this.manageSubmodulesToolStripMenuItem.Name = "manageSubmodulesToolStripMenuItem";
            this.manageSubmodulesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.manageSubmodulesToolStripMenuItem.Text = "Manage submodules...";
            this.manageSubmodulesToolStripMenuItem.Click += new System.EventHandler(this.ManageSubmodulesToolStripMenuItemClick);
            // 
            // updateAllSubmodulesToolStripMenuItem
            // 
            this.updateAllSubmodulesToolStripMenuItem.Image = global::GitUI.Properties.Images.SubmodulesUpdate;
            this.updateAllSubmodulesToolStripMenuItem.Name = "updateAllSubmodulesToolStripMenuItem";
            this.updateAllSubmodulesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.updateAllSubmodulesToolStripMenuItem.Text = "Update all submodules";
            this.updateAllSubmodulesToolStripMenuItem.Click += new System.EventHandler(this.UpdateAllSubmodulesToolStripMenuItemClick);
            // 
            // synchronizeAllSubmodulesToolStripMenuItem
            // 
            this.synchronizeAllSubmodulesToolStripMenuItem.Image = global::GitUI.Properties.Images.SubmodulesSync;
            this.synchronizeAllSubmodulesToolStripMenuItem.Name = "synchronizeAllSubmodulesToolStripMenuItem";
            this.synchronizeAllSubmodulesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.synchronizeAllSubmodulesToolStripMenuItem.Text = "Synchronize all submodules";
            this.synchronizeAllSubmodulesToolStripMenuItem.Click += new System.EventHandler(this.SynchronizeAllSubmodulesToolStripMenuItemClick);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(218, 6);
            // 
            // toolStripMenuItemWorktrees
            // 
            this.toolStripMenuItemWorktrees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWorktreeToolStripMenuItem,
            this.manageWorktreeToolStripMenuItem});
            this.toolStripMenuItemWorktrees.Image = global::GitUI.Properties.Images.WorkTree;
            this.toolStripMenuItemWorktrees.Name = "toolStripMenuItemWorktrees";
            this.toolStripMenuItemWorktrees.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItemWorktrees.Text = "Worktrees";
            // 
            // createWorktreeToolStripMenuItem
            // 
            this.createWorktreeToolStripMenuItem.Name = "createWorktreeToolStripMenuItem";
            this.createWorktreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createWorktreeToolStripMenuItem.Text = "Create a worktree...";
            this.createWorktreeToolStripMenuItem.Click += new System.EventHandler(this.createWorktreeToolStripMenuItem_Click);
            // 
            // manageWorktreeToolStripMenuItem
            // 
            this.manageWorktreeToolStripMenuItem.Name = "manageWorktreeToolStripMenuItem";
            this.manageWorktreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageWorktreeToolStripMenuItem.Text = "Manage worktrees...";
            this.manageWorktreeToolStripMenuItem.Click += new System.EventHandler(this.manageWorktreeToolStripMenuItem_Click);
            // 
            // toolStripSeparator44
            // 
            this.toolStripSeparator44.Name = "toolStripSeparator44";
            this.toolStripSeparator44.Size = new System.Drawing.Size(218, 6);
            // 
            // editgitignoreToolStripMenuItem1
            // 
            this.editgitignoreToolStripMenuItem1.Image = global::GitUI.Properties.Images.EditGitIgnore;
            this.editgitignoreToolStripMenuItem1.Name = "editgitignoreToolStripMenuItem1";
            this.editgitignoreToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.editgitignoreToolStripMenuItem1.Text = "Edit .gitignore";
            this.editgitignoreToolStripMenuItem1.Click += new System.EventHandler(this.EditGitignoreToolStripMenuItem1Click);
            // 
            // editgitinfoexcludeToolStripMenuItem
            // 
            this.editgitinfoexcludeToolStripMenuItem.Name = "editgitinfoexcludeToolStripMenuItem";
            this.editgitinfoexcludeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editgitinfoexcludeToolStripMenuItem.Text = "Edit .git/info/exclude";
            this.editgitinfoexcludeToolStripMenuItem.Click += new System.EventHandler(this.EditGitInfoExcludeToolStripMenuItemClick);
            // 
            // editGitAttributesToolStripMenuItem
            // 
            this.editGitAttributesToolStripMenuItem.Name = "editGitAttributesToolStripMenuItem";
            this.editGitAttributesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editGitAttributesToolStripMenuItem.Text = "Edit .gitattributes";
            this.editGitAttributesToolStripMenuItem.Click += new System.EventHandler(this.editGitAttributesToolStripMenuItem_Click);
            // 
            // editmailmapToolStripMenuItem
            // 
            this.editmailmapToolStripMenuItem.Name = "editmailmapToolStripMenuItem";
            this.editmailmapToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editmailmapToolStripMenuItem.Text = "Edit .mailmap";
            this.editmailmapToolStripMenuItem.Click += new System.EventHandler(this.EditMailMapToolStripMenuItemClick);
            // 
            // menuitemSparse
            // 
            this.menuitemSparse.Name = "menuitemSparse";
            this.menuitemSparse.Size = new System.Drawing.Size(221, 22);
            this.menuitemSparse.Text = "Sparse Working Copy";
            this.menuitemSparse.Click += new System.EventHandler(this.menuitemSparseWorkingCopy_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // gitMaintenanceToolStripMenuItem
            // 
            this.gitMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressGitDatabaseToolStripMenuItem,
            this.recoverLostObjectsToolStripMenuItem,
            this.deleteIndexLockToolStripMenuItem,
            this.editLocalGitConfigToolStripMenuItem});
            this.gitMaintenanceToolStripMenuItem.Image = global::GitUI.Properties.Images.Maintenance;
            this.gitMaintenanceToolStripMenuItem.Name = "gitMaintenanceToolStripMenuItem";
            this.gitMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.gitMaintenanceToolStripMenuItem.Text = "Git maintenance";
            // 
            // compressGitDatabaseToolStripMenuItem
            // 
            this.compressGitDatabaseToolStripMenuItem.Image = global::GitUI.Properties.Images.CompressGitDatabase;
            this.compressGitDatabaseToolStripMenuItem.Name = "compressGitDatabaseToolStripMenuItem";
            this.compressGitDatabaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.compressGitDatabaseToolStripMenuItem.Text = "Compress git database";
            this.compressGitDatabaseToolStripMenuItem.Click += new System.EventHandler(this.CompressGitDatabaseToolStripMenuItemClick);
            // 
            // recoverLostObjectsToolStripMenuItem
            // 
            this.recoverLostObjectsToolStripMenuItem.Image = global::GitUI.Properties.Images.RecoverLostObjects;
            this.recoverLostObjectsToolStripMenuItem.Name = "recoverLostObjectsToolStripMenuItem";
            this.recoverLostObjectsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recoverLostObjectsToolStripMenuItem.Text = "Recover lost objects...";
            this.recoverLostObjectsToolStripMenuItem.Click += new System.EventHandler(this.recoverLostObjectsToolStripMenuItemClick);
            // 
            // deleteIndexLockToolStripMenuItem
            // 
            this.deleteIndexLockToolStripMenuItem.Image = global::GitUI.Properties.Images.DeleteIndexLock;
            this.deleteIndexLockToolStripMenuItem.Name = "deleteIndexLockToolStripMenuItem";
            this.deleteIndexLockToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteIndexLockToolStripMenuItem.Text = "Delete index.lock";
            this.deleteIndexLockToolStripMenuItem.Click += new System.EventHandler(this.deleteIndexLockToolStripMenuItem_Click);
            // 
            // editLocalGitConfigToolStripMenuItem
            // 
            this.editLocalGitConfigToolStripMenuItem.Image = global::GitUI.Properties.Images.EditGitConfig;
            this.editLocalGitConfigToolStripMenuItem.Name = "editLocalGitConfigToolStripMenuItem";
            this.editLocalGitConfigToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editLocalGitConfigToolStripMenuItem.Text = "Edit .git/config";
            this.editLocalGitConfigToolStripMenuItem.Click += new System.EventHandler(this.EditLocalGitConfigToolStripMenuItemClick);
            // 
            // repoSettingsToolStripMenuItem
            // 
            this.repoSettingsToolStripMenuItem.Image = global::GitUI.Properties.Images.Settings;
            this.repoSettingsToolStripMenuItem.Name = "repoSettingsToolStripMenuItem";
            this.repoSettingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.repoSettingsToolStripMenuItem.Text = "Repository settings";
            this.repoSettingsToolStripMenuItem.Click += new System.EventHandler(this.RepoSettingsToolStripMenuItemClick);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(218, 6);
            // 
            // gitBashToolStripMenuItem
            // 
            this.gitBashToolStripMenuItem.Image = global::GitUI.Properties.Images.GitForWindows;
            this.gitBashToolStripMenuItem.Name = "gitBashToolStripMenuItem";
            this.gitBashToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gitBashToolStripMenuItem.Text = "Git bash";
            this.gitBashToolStripMenuItem.Click += new System.EventHandler(this.GitBashToolStripMenuItemClick1);
            // 
            // gitGUIToolStripMenuItem
            // 
            this.gitGUIToolStripMenuItem.Image = global::GitUI.Properties.Images.GitGui;
            this.gitGUIToolStripMenuItem.Name = "gitGUIToolStripMenuItem";
            this.gitGUIToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gitGUIToolStripMenuItem.Text = "Git GUI";
            this.gitGUIToolStripMenuItem.Click += new System.EventHandler(this.GitGuiToolStripMenuItemClick);
            // 
            // kGitToolStripMenuItem
            // 
            this.kGitToolStripMenuItem.Image = global::GitUI.Properties.Images.Gitk;
            this.kGitToolStripMenuItem.Name = "kGitToolStripMenuItem";
            this.kGitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.kGitToolStripMenuItem.Text = "GitK";
            this.kGitToolStripMenuItem.Click += new System.EventHandler(this.KGitToolStripMenuItemClick);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitToolStripMenuItem,
            this.undoLastCommitToolStripMenuItem,
            this.pullToolStripMenuItem,
            this.pushToolStripMenuItem,
            this.toolStripSeparator21,
            this.stashToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.cleanupToolStripMenuItem,
            this.toolStripSeparator25,
            this.branchToolStripMenuItem,
            this.deleteBranchToolStripMenuItem,
            this.checkoutBranchToolStripMenuItem,
            this.mergeBranchToolStripMenuItem,
            this.rebaseToolStripMenuItem,
            this.runMergetoolToolStripMenuItem,
            this.toolStripSeparator45,
            this.tagToolStripMenuItem,
            this.deleteTagToolStripMenuItem,
            this.toolStripSeparator23,
            this.cherryPickToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.bisectToolStripMenuItem,
            this.toolStripMenuItemReflog,
            this.toolStripSeparator22,
            this.formatPatchToolStripMenuItem,
            this.applyPatchToolStripMenuItem,
            this.patchToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "&Commands";
            // 
            // commitToolStripMenuItem
            // 
            this.commitToolStripMenuItem.Image = global::GitUI.Properties.Images.RepoStateClean;
            this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            this.commitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.commitToolStripMenuItem.Text = "Commit...";
            this.commitToolStripMenuItem.Click += new System.EventHandler(this.CommitToolStripMenuItemClick);
            // 
            // undoLastCommitToolStripMenuItem
            // 
            this.undoLastCommitToolStripMenuItem.Image = global::GitUI.Properties.Images.ResetFileTo;
            this.undoLastCommitToolStripMenuItem.Name = "undoLastCommitToolStripMenuItem";
            this.undoLastCommitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.undoLastCommitToolStripMenuItem.Text = "Undo last commit";
            this.undoLastCommitToolStripMenuItem.Click += new System.EventHandler(this.undoLastCommitToolStripMenuItem_Click);
            // 
            // pullToolStripMenuItem
            // 
            this.pullToolStripMenuItem.Image = global::GitUI.Properties.Images.Pull;
            this.pullToolStripMenuItem.Name = "pullToolStripMenuItem";
            this.pullToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.pullToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pullToolStripMenuItem.Text = "Pull/Fetch...";
            this.pullToolStripMenuItem.Click += new System.EventHandler(this.PullToolStripMenuItemClick);
            // 
            // pushToolStripMenuItem
            // 
            this.pushToolStripMenuItem.Image = global::GitUI.Properties.Images.Push;
            this.pushToolStripMenuItem.Name = "pushToolStripMenuItem";
            this.pushToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.pushToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pushToolStripMenuItem.Text = "Push...";
            this.pushToolStripMenuItem.Click += new System.EventHandler(this.PushToolStripMenuItemClick);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(210, 6);
            // 
            // stashToolStripMenuItem
            // 
            this.stashToolStripMenuItem.Image = global::GitUI.Properties.Images.Stash;
            this.stashToolStripMenuItem.Name = "stashToolStripMenuItem";
            this.stashToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.stashToolStripMenuItem.Text = "Manage stashes...";
            this.stashToolStripMenuItem.Click += new System.EventHandler(this.StashToolStripMenuItemClick);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::GitUI.Properties.Images.ResetWorkingDirChanges;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.resetToolStripMenuItem.Text = "Reset changes...";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // cleanupToolStripMenuItem
            // 
            this.cleanupToolStripMenuItem.Image = global::GitUI.Properties.Images.CleanupRepo;
            this.cleanupToolStripMenuItem.Name = "cleanupToolStripMenuItem";
            this.cleanupToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cleanupToolStripMenuItem.Text = "Clean working directory...";
            this.cleanupToolStripMenuItem.Click += new System.EventHandler(this.CleanupToolStripMenuItemClick);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(210, 6);
            // 
            // branchToolStripMenuItem
            // 
            this.branchToolStripMenuItem.Image = global::GitUI.Properties.Images.BranchCreate;
            this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            this.branchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.branchToolStripMenuItem.Text = "Create branch...";
            this.branchToolStripMenuItem.Click += new System.EventHandler(this.CreateBranchToolStripMenuItemClick);
            // 
            // deleteBranchToolStripMenuItem
            // 
            this.deleteBranchToolStripMenuItem.Image = global::GitUI.Properties.Images.BranchDelete;
            this.deleteBranchToolStripMenuItem.Name = "deleteBranchToolStripMenuItem";
            this.deleteBranchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteBranchToolStripMenuItem.Text = "Delete branch...";
            this.deleteBranchToolStripMenuItem.Click += new System.EventHandler(this.DeleteBranchToolStripMenuItemClick);
            // 
            // checkoutBranchToolStripMenuItem
            // 
            this.checkoutBranchToolStripMenuItem.Image = global::GitUI.Properties.Images.BranchCheckout;
            this.checkoutBranchToolStripMenuItem.Name = "checkoutBranchToolStripMenuItem";
            this.checkoutBranchToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+.";
            this.checkoutBranchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemPeriod)));
            this.checkoutBranchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.checkoutBranchToolStripMenuItem.Text = "Checkout branch...";
            this.checkoutBranchToolStripMenuItem.Click += new System.EventHandler(this.CheckoutBranchToolStripMenuItemClick);
            // 
            // mergeBranchToolStripMenuItem
            // 
            this.mergeBranchToolStripMenuItem.Image = global::GitUI.Properties.Images.Merge;
            this.mergeBranchToolStripMenuItem.Name = "mergeBranchToolStripMenuItem";
            this.mergeBranchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mergeBranchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mergeBranchToolStripMenuItem.Text = "Merge branches...";
            this.mergeBranchToolStripMenuItem.Click += new System.EventHandler(this.MergeBranchToolStripMenuItemClick);
            // 
            // rebaseToolStripMenuItem
            // 
            this.rebaseToolStripMenuItem.Image = global::GitUI.Properties.Images.Rebase;
            this.rebaseToolStripMenuItem.Name = "rebaseToolStripMenuItem";
            this.rebaseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.rebaseToolStripMenuItem.Text = "Rebase...";
            this.rebaseToolStripMenuItem.Click += new System.EventHandler(this.RebaseToolStripMenuItemClick);
            // 
            // runMergetoolToolStripMenuItem
            // 
            this.runMergetoolToolStripMenuItem.Image = global::GitUI.Properties.Images.Conflict;
            this.runMergetoolToolStripMenuItem.Name = "runMergetoolToolStripMenuItem";
            this.runMergetoolToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.runMergetoolToolStripMenuItem.Text = "Solve merge conflicts...";
            this.runMergetoolToolStripMenuItem.Click += new System.EventHandler(this.RunMergetoolToolStripMenuItemClick);
            // 
            // toolStripSeparator45
            // 
            this.toolStripSeparator45.Name = "toolStripSeparator45";
            this.toolStripSeparator45.Size = new System.Drawing.Size(210, 6);
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.Image = global::GitUI.Properties.Images.TagCreate;
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            this.tagToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tagToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.tagToolStripMenuItem.Text = "Create tag...";
            this.tagToolStripMenuItem.Click += new System.EventHandler(this.TagToolStripMenuItemClick);
            // 
            // deleteTagToolStripMenuItem
            // 
            this.deleteTagToolStripMenuItem.Image = global::GitUI.Properties.Images.TagDelete;
            this.deleteTagToolStripMenuItem.Name = "deleteTagToolStripMenuItem";
            this.deleteTagToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteTagToolStripMenuItem.Text = "Delete tag...";
            this.deleteTagToolStripMenuItem.Click += new System.EventHandler(this.DeleteTagToolStripMenuItemClick);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(210, 6);
            // 
            // cherryPickToolStripMenuItem
            // 
            this.cherryPickToolStripMenuItem.Image = global::GitUI.Properties.Images.CherryPick;
            this.cherryPickToolStripMenuItem.Name = "cherryPickToolStripMenuItem";
            this.cherryPickToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cherryPickToolStripMenuItem.Text = "Cherry pick...";
            this.cherryPickToolStripMenuItem.Click += new System.EventHandler(this.CherryPickToolStripMenuItemClick);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Image = global::GitUI.Properties.Images.ArchiveRevision;
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.archiveToolStripMenuItem.Text = "Archive revision...";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.ArchiveToolStripMenuItemClick);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Image = global::GitUI.Properties.Images.Checkout;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.checkoutToolStripMenuItem.Text = "Checkout revision...";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.CheckoutToolStripMenuItemClick);
            // 
            // bisectToolStripMenuItem
            // 
            this.bisectToolStripMenuItem.Image = global::GitUI.Properties.Images.Bisect;
            this.bisectToolStripMenuItem.Name = "bisectToolStripMenuItem";
            this.bisectToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.bisectToolStripMenuItem.Text = "Bisect...";
            this.bisectToolStripMenuItem.Click += new System.EventHandler(this.BisectClick);
            // 
            // toolStripMenuItemReflog
            // 
            this.toolStripMenuItemReflog.Image = global::GitUI.Properties.Images.Book;
            this.toolStripMenuItemReflog.Name = "toolStripMenuItemReflog";
            this.toolStripMenuItemReflog.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItemReflog.Text = "Show reflog...";
            this.toolStripMenuItemReflog.Click += new System.EventHandler(this.toolStripMenuItemReflog_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(210, 6);
            // 
            // formatPatchToolStripMenuItem
            // 
            this.formatPatchToolStripMenuItem.Image = global::GitUI.Properties.Images.PatchFormat;
            this.formatPatchToolStripMenuItem.Name = "formatPatchToolStripMenuItem";
            this.formatPatchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.formatPatchToolStripMenuItem.Text = "Format patch...";
            this.formatPatchToolStripMenuItem.Click += new System.EventHandler(this.FormatPatchToolStripMenuItemClick);
            // 
            // applyPatchToolStripMenuItem
            // 
            this.applyPatchToolStripMenuItem.Image = global::GitUI.Properties.Images.PatchApply;
            this.applyPatchToolStripMenuItem.Name = "applyPatchToolStripMenuItem";
            this.applyPatchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.applyPatchToolStripMenuItem.Text = "Apply patch...";
            this.applyPatchToolStripMenuItem.Click += new System.EventHandler(this.ApplyPatchToolStripMenuItemClick);
            // 
            // patchToolStripMenuItem
            // 
            this.patchToolStripMenuItem.Image = global::GitUI.Properties.Images.PatchView;
            this.patchToolStripMenuItem.Name = "patchToolStripMenuItem";
            this.patchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.patchToolStripMenuItem.Text = "View patch file...";
            this.patchToolStripMenuItem.Click += new System.EventHandler(this.PatchToolStripMenuItemClick);
            // 
            // toolStripSeparator46
            // 
            this.toolStripSeparator46.Name = "toolStripSeparator46";
            this.toolStripSeparator46.Size = new System.Drawing.Size(268, 6);
            // 
            // toolStripSeparator41
            // 
            this.toolStripSeparator41.Name = "toolStripSeparator41";
            this.toolStripSeparator41.Size = new System.Drawing.Size(214, 6);
            // 
            // toolStripSeparator42
            // 
            this.toolStripSeparator42.Name = "toolStripSeparator42";
            this.toolStripSeparator42.Size = new System.Drawing.Size(110, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(214, 6);
            // 
            // PuTTYToolStripMenuItem
            // 
            this.PuTTYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAuthenticationAgentToolStripMenuItem,
            this.generateOrImportKeyToolStripMenuItem});
            this.PuTTYToolStripMenuItem.Image = global::GitUI.Properties.Images.Putty;
            this.PuTTYToolStripMenuItem.Name = "PuTTYToolStripMenuItem";
            this.PuTTYToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.PuTTYToolStripMenuItem.Text = "PuTTY";
            // 
            // startAuthenticationAgentToolStripMenuItem
            // 
            this.startAuthenticationAgentToolStripMenuItem.Image = global::GitUI.Properties.Images.Pageant16;
            this.startAuthenticationAgentToolStripMenuItem.Name = "startAuthenticationAgentToolStripMenuItem";
            this.startAuthenticationAgentToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.startAuthenticationAgentToolStripMenuItem.Text = "Start authentication agent";
            this.startAuthenticationAgentToolStripMenuItem.Click += new System.EventHandler(this.StartAuthenticationAgentToolStripMenuItemClick);
            // 
            // generateOrImportKeyToolStripMenuItem
            // 
            this.generateOrImportKeyToolStripMenuItem.Image = global::GitUI.Properties.Images.PuttyGen;
            this.generateOrImportKeyToolStripMenuItem.Name = "generateOrImportKeyToolStripMenuItem";
            this.generateOrImportKeyToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.generateOrImportKeyToolStripMenuItem.Text = "Generate or import key";
            this.generateOrImportKeyToolStripMenuItem.Click += new System.EventHandler(this.GenerateOrImportKeyToolStripMenuItemClick);
            // 
            // _repositoryHostsToolStripMenuItem
            // 
            this._repositoryHostsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._forkCloneRepositoryToolStripMenuItem,
            this._viewPullRequestsToolStripMenuItem,
            this._createPullRequestsToolStripMenuItem,
            this._addUpstreamRemoteToolStripMenuItem});
            this._repositoryHostsToolStripMenuItem.Name = "_repositoryHostsToolStripMenuItem";
            this._repositoryHostsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this._repositoryHostsToolStripMenuItem.Text = "(Repository hosts)";
            // 
            // _forkCloneRepositoryToolStripMenuItem
            // 
            this._forkCloneRepositoryToolStripMenuItem.Name = "_forkCloneRepositoryToolStripMenuItem";
            this._forkCloneRepositoryToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this._forkCloneRepositoryToolStripMenuItem.Text = "Fork/Clone repository...";
            this._forkCloneRepositoryToolStripMenuItem.Click += new System.EventHandler(this._forkCloneMenuItem_Click);
            // 
            // _viewPullRequestsToolStripMenuItem
            // 
            this._viewPullRequestsToolStripMenuItem.Name = "_viewPullRequestsToolStripMenuItem";
            this._viewPullRequestsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this._viewPullRequestsToolStripMenuItem.Text = "View pull requests...";
            this._viewPullRequestsToolStripMenuItem.Click += new System.EventHandler(this._viewPullRequestsToolStripMenuItem_Click);
            // 
            // _createPullRequestsToolStripMenuItem
            // 
            this._createPullRequestsToolStripMenuItem.Name = "_createPullRequestsToolStripMenuItem";
            this._createPullRequestsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this._createPullRequestsToolStripMenuItem.Text = "Create pull requests...";
            this._createPullRequestsToolStripMenuItem.Click += new System.EventHandler(this._createPullRequestToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDashboardToolStripMenuItem,
            this.toolStripSeparator42});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "&Dashboard";
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator15,
            this.pluginSettingsToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "&Plugins";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(150, 6);
            // 
            // pluginSettingsToolStripMenuItem
            // 
            this.pluginSettingsToolStripMenuItem.Image = global::GitUI.Properties.Images.Settings;
            this.pluginSettingsToolStripMenuItem.Name = "pluginSettingsToolStripMenuItem";
            this.pluginSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pluginSettingsToolStripMenuItem.Text = "Plugin Settings";
            this.pluginSettingsToolStripMenuItem.Click += new System.EventHandler(this.PluginSettingsToolStripMenuItemClick);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::GitUI.Properties.Images.Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnShowSettingsClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.toolStripSeparator3,
            this.translateToolStripMenuItem,
            this.toolStripSeparator16,
            this.donateToolStripMenuItem,
            this.tsmiTelemetryEnabled,
            this.reportAnIssueToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.DropDownOpening += new System.EventHandler(this.HelpToolStripMenuItem_DropDownOpening);
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Image = global::GitUI.Properties.Images.GotoManual;
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.UserManualToolStripMenuItemClick);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Image = global::GitUI.Properties.Images.Changelog;
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.ChangelogToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Image = global::GitUI.Properties.Images.Translate;
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.TranslateToolStripMenuItemClick);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(167, 6);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::GitUI.Properties.Images.DollarSign;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItemClick);
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Image = global::GitUI.Properties.Images.BugReport;
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reportAnIssueToolStripMenuItem.Text = "Report an issue";
            this.reportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.reportAnIssueToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = global::GitUI.Properties.Images.CheckForUpdates;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GitUI.Properties.Images.Information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // tsmiTelemetryEnabled
            // 
            this.tsmiTelemetryEnabled.Checked = true;
            this.tsmiTelemetryEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiTelemetryEnabled.Name = "tsmiTelemetryEnabled";
            this.tsmiTelemetryEnabled.Size = new System.Drawing.Size(278, 34);
            this.tsmiTelemetryEnabled.Text = "Yes, I allow telemetry";
            this.tsmiTelemetryEnabled.Click += new System.EventHandler(this.TsmiTelemetryEnabled_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitBashToolStripMenuItem,
            this.gitGUIToolStripMenuItem,
            this.kGitToolStripMenuItem,
            this.toolStripSeparator6,
            this.PuTTYToolStripMenuItem,
            this.toolStripSeparator41,
            this.gitcommandLogToolStripMenuItem,
            this.toolStripSeparator7,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // gitcommandLogToolStripMenuItem
            // 
            this.gitcommandLogToolStripMenuItem.Image = global::GitUI.Properties.Images.GitCommandLog;
            this.gitcommandLogToolStripMenuItem.Name = "gitcommandLogToolStripMenuItem";
            this.gitcommandLogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.gitcommandLogToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gitcommandLogToolStripMenuItem.Text = "Git command log";
            this.gitcommandLogToolStripMenuItem.Click += new System.EventHandler(this.GitcommandLogToolStripMenuItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(214, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ClickThrough = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.repositoryToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this._repositoryHostsToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4);
            this.menuStrip1.TabIndex = 0;
            // 
            // toolPanel
            // 
            this.toolPanel.BottomToolStripPanelVisible = false;
            // 
            // toolPanel.ContentPanel
            // 
            this.toolPanel.ContentPanel.Controls.Add(this.MainSplitContainer);
            this.toolPanel.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolPanel.ContentPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.toolPanel.ContentPanel.Size = new System.Drawing.Size(1846, 1023);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolPanel.LeftToolStripPanelVisible = false;
            this.toolPanel.Location = new System.Drawing.Point(0, 24);
            this.toolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.toolPanel.RightToolStripPanelVisible = false;
            this.toolPanel.Size = new System.Drawing.Size(923, 527);
            this.toolPanel.TabIndex = 1;
            // 
            // toolPanel.TopToolStripPanel
            // 
            this.toolPanel.TopToolStripPanel.Controls.Add(this.ToolStrip);
            // 
            // addUpstreamRemoteToolStripMenuItem
            // 
            this._addUpstreamRemoteToolStripMenuItem.Name = "_addUpstreamRemoteToolStripMenuItem";
            this._addUpstreamRemoteToolStripMenuItem.Size = new System.Drawing.Size(360, 38);
            this._addUpstreamRemoteToolStripMenuItem.Text = "Add upstream remote";
            this._addUpstreamRemoteToolStripMenuItem.Click += new System.EventHandler(this._addUpstreamRemoteToolStripMenuItem_Click);
            // 
            // FormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(923, 573);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormBrowse";
            this.Text = "Git Extensions";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.RightSplitContainer.Panel1.ResumeLayout(false);
            this.RightSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightSplitContainer)).EndInit();
            this.RightSplitContainer.ResumeLayout(false);
            this.RevisionsSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RevisionsSplitContainer)).EndInit();
            this.RevisionsSplitContainer.ResumeLayout(false);
            this.RevisionGridContainer.ResumeLayout(false);
            this.CommitInfoTabControl.ResumeLayout(false);
            this.CommitInfoTabPage.ResumeLayout(false);
            this.TreeTabPage.ResumeLayout(false);
            this.DiffTabPage.ResumeLayout(false);
            this.GpgInfoTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitRevisionBindingSource)).EndInit();
            this.toolPanel.ContentPanel.ResumeLayout(false);
            this.toolPanel.TopToolStripPanel.ResumeLayout(false);
            this.toolPanel.TopToolStripPanel.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal SplitContainer MainSplitContainer;
        private SplitContainer RightSplitContainer;
        private SplitContainer RevisionsSplitContainer;

        private FullBleedTabControl CommitInfoTabControl;
        private TabPage CommitInfoTabPage;
        private TabPage DiffTabPage;
        private TabPage TreeTabPage;
        private TabPage GpgInfoTabPage;

        private BindingSource gitRevisionBindingSource;
        private BindingSource gitItemBindingSource;
        private GitUI.RevisionGridControl RevisionGrid;
        private ToolStripEx ToolStrip;
        private CommitInfo.CommitInfo RevisionInfo;
        private MenuStripEx menuStrip1;
        private GitUI.BranchTreePanel.RepoObjectsTree repoObjectsTree;
        private ToolTip FilterToolTip;
        private RevisionFileTreeControl fileTree;
        private RevisionDiffControl revisionDiff;
        private ToolStripContainer toolPanel;
        private RevisionGpgInfoControl revisionGpgInfo1;

        private ToolStripButton toolStripButtonCommit;
        private ToolStripSplitButton _NO_TRANSLATE_WorkingDir;
        private ToolStripSeparator toolStripSeparator0;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton GitBash;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton EditSettings;
        private ToolStripButton RefreshButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripTextBox toolStripRevisionFilterTextBox;
        private ToolStripPushButton toolStripButtonPush;
        private ToolStripLabel toolStripRevisionFilterLabel;
        private ToolStripSplitButton toolStripSplitStash;
        private ToolStripMenuItem stashChangesToolStripMenuItem;
        private ToolStripMenuItem stashPopToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem manageStashesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripBranchFilterComboBox;
        private ToolStripDropDownButton toolStripBranchFilterDropDownButton;
        private ToolStripDropDownButton toolStripRevisionFilterDropDownButton;
        private ToolStripSplitButton branchSelect;
        private ToolStripButton toggleBranchTreePanel;
        private ToolStripButton toggleSplitViewLayout;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem refreshDashboardToolStripMenuItem;
        private ToolStripMenuItem tsmiRecentRepositories;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem fileExplorerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem repositoryToolStripMenuItem;
        private ToolStripMenuItem gitBashToolStripMenuItem;
        private ToolStripMenuItem gitGUIToolStripMenuItem;
        private ToolStripMenuItem kGitToolStripMenuItem;
        private ToolStripMenuItem commandsToolStripMenuItem;
        private ToolStripMenuItem applyPatchToolStripMenuItem;
        private ToolStripMenuItem archiveToolStripMenuItem;
        private ToolStripMenuItem bisectToolStripMenuItem;
        private ToolStripMenuItem checkoutBranchToolStripMenuItem;
        private ToolStripMenuItem checkoutToolStripMenuItem;
        private ToolStripMenuItem cherryPickToolStripMenuItem;
        private ToolStripMenuItem cleanupToolStripMenuItem;
        private ToolStripMenuItem cloneToolStripMenuItem;
        private ToolStripMenuItem commitToolStripMenuItem;
        private ToolStripMenuItem branchToolStripMenuItem;
        private ToolStripMenuItem tagToolStripMenuItem;
        private ToolStripMenuItem deleteBranchToolStripMenuItem;
        private ToolStripMenuItem deleteTagToolStripMenuItem;
        private ToolStripMenuItem formatPatchToolStripMenuItem;
        private ToolStripMenuItem initNewRepositoryToolStripMenuItem;
        private ToolStripMenuItem mergeBranchToolStripMenuItem;
        private ToolStripMenuItem pullToolStripMenuItem;
        private ToolStripMenuItem pushToolStripMenuItem;
        private ToolStripMenuItem rebaseToolStripMenuItem;
        private ToolStripMenuItem runMergetoolToolStripMenuItem;
        private ToolStripMenuItem stashToolStripMenuItem;
        private ToolStripMenuItem patchToolStripMenuItem;
        private ToolStripMenuItem manageRemoteRepositoriesToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem PuTTYToolStripMenuItem;
        private ToolStripMenuItem startAuthenticationAgentToolStripMenuItem;
        private ToolStripMenuItem generateOrImportKeyToolStripMenuItem;
        private ToolStripMenuItem _repositoryHostsToolStripMenuItem;
        private ToolStripMenuItem _forkCloneRepositoryToolStripMenuItem;
        private ToolStripMenuItem _viewPullRequestsToolStripMenuItem;
        private ToolStripMenuItem _createPullRequestsToolStripMenuItem;
        private ToolStripMenuItem _addUpstreamRemoteToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem manageSubmodulesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem updateAllSubmodulesToolStripMenuItem;
        private ToolStripMenuItem synchronizeAllSubmodulesToolStripMenuItem;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem pluginSettingsToolStripMenuItem;
        private ToolStripMenuItem repoSettingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripMenuItem gitMaintenanceToolStripMenuItem;
        private ToolStripMenuItem editLocalGitConfigToolStripMenuItem;
        private ToolStripMenuItem compressGitDatabaseToolStripMenuItem;
        private ToolStripMenuItem recoverLostObjectsToolStripMenuItem;
        private ToolStripMenuItem deleteIndexLockToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem editgitignoreToolStripMenuItem1;
        private ToolStripMenuItem editGitAttributesToolStripMenuItem;
        private ToolStripMenuItem editmailmapToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem userManualToolStripMenuItem;
        private ToolStripMenuItem changelogToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem translateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem donateToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator21;
        private ToolStripSeparator toolStripSeparator25;
        private ToolStripSeparator toolStripSeparator22;
        private ToolStripSeparator toolStripSeparator23;
        private ToolStripSplitButton toolStripButtonLevelUp;
        private ToolStripSplitButton toolStripButtonPull;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private ToolStripMenuItem rebaseToolStripMenuItem1;
        private ToolStripMenuItem fetchToolStripMenuItem;
        private ToolStripMenuItem pullToolStripMenuItem1;
        private ToolStripMenuItem setDefaultPullButtonActionToolStripMenuItem;
        private ToolStripMenuItem fetchAllToolStripMenuItem;
        private ToolStripMenuItem fetchPruneAllToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator41;
        private ToolStripSeparator toolStripSeparator42;
        private ToolStripSeparator toolStripSeparator43;
        private ToolStripSeparator toolStripSeparator44;
        private ToolStripSeparator toolStripSeparator45;
        private ToolStripSeparator toolStripSeparator46;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem gitcommandLogToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem menuitemSparse;
        private ToolStripButton ShowFirstParent;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem editgitinfoexcludeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemReflog;
        private ToolStripMenuItem manageWorktreeToolStripMenuItem;
        private ToolStripMenuItem createWorktreeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemWorktrees;
        private ToolStripMenuItem tsmiRecentRepositoriesClear;
        private ToolStripSeparator clearRecentRepositoriesListToolStripMenuItem;
        private ToolStripButton toolStripFileExplorer;
        private ToolStripMenuItem createAStashToolStripMenuItem;
        private ToolStripMenuItem undoLastCommitToolStripMenuItem;
        private ToolStripMenuItem tsmiFavouriteRepositories;
        private ToolStripSplitButton menuCommitInfoPosition;
        private ToolStripMenuItem commitInfoBelowMenuItem;
        private ToolStripMenuItem commitInfoLeftwardMenuItem;
        private ToolStripMenuItem commitInfoRightwardMenuItem;
        private ToolStripMenuItem tsmiTelemetryEnabled;
        private Panel RevisionGridContainer;
        private UserControls.InteractiveGitActionControl RevisionHeader;
    }
}
