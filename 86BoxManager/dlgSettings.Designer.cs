﻿namespace _86boxManager
{
    partial class dlgSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSettings));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxShowConsole = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gbxBehaviour = new System.Windows.Forms.GroupBox();
            this.cbxMinimizeTray = new System.Windows.Forms.CheckBox();
            this.cbxCloseTray = new System.Windows.Forms.CheckBox();
            this.cbxMinimize = new System.Windows.Forms.CheckBox();
            this.gbxPaths = new System.Windows.Forms.GroupBox();
            this.lbl86BoxVer1 = new System.Windows.Forms.Label();
            this.lbl86BoxVer = new System.Windows.Forms.Label();
            this.lblCFGdir = new System.Windows.Forms.Label();
            this.txtCFGdir = new System.Windows.Forms.TextBox();
            this.txtEXEdir = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblEXEdir = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.cbxLogging = new System.Windows.Forms.CheckBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.cbxGrid = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.translatorlink = new System.Windows.Forms.LinkLabel();
            this.translatorlabel = new System.Windows.Forms.Label();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.lnkGithub2 = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titlelabel = new System.Windows.Forms.Label();
            this.titleDescriptionlabel = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbxBehaviour.SuspendLayout();
            this.gbxPaths.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.gbxLogging.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Location = new System.Drawing.Point(791, 14);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 38);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(705, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(619, 14);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 38);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxShowConsole
            // 
            this.cbxShowConsole.AutoSize = true;
            this.cbxShowConsole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxShowConsole.Location = new System.Drawing.Point(356, 29);
            this.cbxShowConsole.Margin = new System.Windows.Forms.Padding(2);
            this.cbxShowConsole.Name = "cbxShowConsole";
            this.cbxShowConsole.Size = new System.Drawing.Size(182, 28);
            this.cbxShowConsole.TabIndex = 13;
            this.cbxShowConsole.Text = "使用 86Box 控制台";
            this.cbxShowConsole.UseVisualStyleBackColor = true;
            this.cbxShowConsole.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDefaults.Location = new System.Drawing.Point(14, 14);
            this.btnDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(123, 38);
            this.btnDefaults.TabIndex = 14;
            this.btnDefaults.Text = "恢复默认设置";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnDefaults);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 465);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(886, 65);
            this.pnlBottom.TabIndex = 14;
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabGeneral);
            this.tbcSettings.Controls.Add(this.tabAdvanced);
            this.tbcSettings.Controls.Add(this.tabAbout);
            this.tbcSettings.Location = new System.Drawing.Point(11, 92);
            this.tbcSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(861, 360);
            this.tbcSettings.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gbxBehaviour);
            this.tabGeneral.Controls.Add(this.gbxPaths);
            this.tabGeneral.Location = new System.Drawing.Point(4, 32);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.tabGeneral.Size = new System.Drawing.Size(853, 324);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "常规";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gbxBehaviour
            // 
            this.gbxBehaviour.Controls.Add(this.cbxMinimizeTray);
            this.gbxBehaviour.Controls.Add(this.cbxCloseTray);
            this.gbxBehaviour.Controls.Add(this.cbxMinimize);
            this.gbxBehaviour.Location = new System.Drawing.Point(8, 176);
            this.gbxBehaviour.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBehaviour.Name = "gbxBehaviour";
            this.gbxBehaviour.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBehaviour.Size = new System.Drawing.Size(836, 108);
            this.gbxBehaviour.TabIndex = 6;
            this.gbxBehaviour.TabStop = false;
            this.gbxBehaviour.Text = "程序偏好";
            // 
            // cbxMinimizeTray
            // 
            this.cbxMinimizeTray.AutoSize = true;
            this.cbxMinimizeTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimizeTray.Location = new System.Drawing.Point(11, 29);
            this.cbxMinimizeTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimizeTray.Name = "cbxMinimizeTray";
            this.cbxMinimizeTray.Size = new System.Drawing.Size(177, 28);
            this.cbxMinimizeTray.TabIndex = 5;
            this.cbxMinimizeTray.Text = "最小化至系统托盘";
            this.cbxMinimizeTray.UseVisualStyleBackColor = true;
            this.cbxMinimizeTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxCloseTray
            // 
            this.cbxCloseTray.AutoSize = true;
            this.cbxCloseTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCloseTray.Location = new System.Drawing.Point(421, 29);
            this.cbxCloseTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCloseTray.Name = "cbxCloseTray";
            this.cbxCloseTray.Size = new System.Drawing.Size(279, 28);
            this.cbxCloseTray.TabIndex = 6;
            this.cbxCloseTray.Text = "点击关闭按钮时仅退出到任务栏";
            this.cbxCloseTray.UseVisualStyleBackColor = true;
            this.cbxCloseTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxMinimize
            // 
            this.cbxMinimize.AutoSize = true;
            this.cbxMinimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimize.Location = new System.Drawing.Point(11, 64);
            this.cbxMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimize.Name = "cbxMinimize";
            this.cbxMinimize.Size = new System.Drawing.Size(301, 28);
            this.cbxMinimize.TabIndex = 7;
            this.cbxMinimize.Text = "实例启动时最小化 86Box Manager";
            this.cbxMinimize.UseVisualStyleBackColor = true;
            this.cbxMinimize.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // gbxPaths
            // 
            this.gbxPaths.Controls.Add(this.lbl86BoxVer1);
            this.gbxPaths.Controls.Add(this.lbl86BoxVer);
            this.gbxPaths.Controls.Add(this.lblCFGdir);
            this.gbxPaths.Controls.Add(this.txtCFGdir);
            this.gbxPaths.Controls.Add(this.txtEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse2);
            this.gbxPaths.Controls.Add(this.lblEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse1);
            this.gbxPaths.Location = new System.Drawing.Point(8, 8);
            this.gbxPaths.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPaths.Name = "gbxPaths";
            this.gbxPaths.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPaths.Size = new System.Drawing.Size(836, 161);
            this.gbxPaths.TabIndex = 5;
            this.gbxPaths.TabStop = false;
            this.gbxPaths.Text = "86Box 设置";
            // 
            // lbl86BoxVer1
            // 
            this.lbl86BoxVer1.AutoSize = true;
            this.lbl86BoxVer1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl86BoxVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl86BoxVer1.Location = new System.Drawing.Point(117, 74);
            this.lbl86BoxVer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer1.Name = "lbl86BoxVer1";
            this.lbl86BoxVer1.Size = new System.Drawing.Size(207, 23);
            this.lbl86BoxVer1.TabIndex = 6;
            this.lbl86BoxVer1.Text = "<status string goes here>";
            // 
            // lbl86BoxVer
            // 
            this.lbl86BoxVer.AutoSize = true;
            this.lbl86BoxVer.Location = new System.Drawing.Point(6, 74);
            this.lbl86BoxVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer.Name = "lbl86BoxVer";
            this.lbl86BoxVer.Size = new System.Drawing.Size(99, 23);
            this.lbl86BoxVer.TabIndex = 5;
            this.lbl86BoxVer.Text = "86Box 版本:";
            // 
            // lblCFGdir
            // 
            this.lblCFGdir.AutoSize = true;
            this.lblCFGdir.Location = new System.Drawing.Point(6, 116);
            this.lblCFGdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFGdir.Name = "lblCFGdir";
            this.lblCFGdir.Size = new System.Drawing.Size(82, 23);
            this.lblCFGdir.TabIndex = 4;
            this.lblCFGdir.Text = "实例位置:";
            // 
            // txtCFGdir
            // 
            this.txtCFGdir.Location = new System.Drawing.Point(116, 112);
            this.txtCFGdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtCFGdir.Name = "txtCFGdir";
            this.txtCFGdir.Size = new System.Drawing.Size(620, 30);
            this.txtCFGdir.TabIndex = 3;
            this.txtCFGdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtEXEdir
            // 
            this.txtEXEdir.Location = new System.Drawing.Point(116, 29);
            this.txtEXEdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtEXEdir.Name = "txtEXEdir";
            this.txtEXEdir.Size = new System.Drawing.Size(620, 30);
            this.txtEXEdir.TabIndex = 1;
            this.txtEXEdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse2.Location = new System.Drawing.Point(742, 109);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(88, 38);
            this.btnBrowse2.TabIndex = 4;
            this.btnBrowse2.Text = "浏览...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lblEXEdir
            // 
            this.lblEXEdir.AutoSize = true;
            this.lblEXEdir.Location = new System.Drawing.Point(6, 32);
            this.lblEXEdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEXEdir.Name = "lblEXEdir";
            this.lblEXEdir.Size = new System.Drawing.Size(99, 23);
            this.lblEXEdir.TabIndex = 3;
            this.lblEXEdir.Text = "86Box 位置:";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse1.Location = new System.Drawing.Point(742, 25);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(88, 38);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "浏览...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.gbxLogging);
            this.tabAdvanced.Controls.Add(this.gbxMisc);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 32);
            this.tabAdvanced.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdvanced.Size = new System.Drawing.Size(853, 324);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "高级";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.cbxLogging);
            this.gbxLogging.Controls.Add(this.txtLogPath);
            this.gbxLogging.Controls.Add(this.btnBrowse3);
            this.gbxLogging.Location = new System.Drawing.Point(8, 8);
            this.gbxLogging.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLogging.Size = new System.Drawing.Size(836, 116);
            this.gbxLogging.TabIndex = 18;
            this.gbxLogging.TabStop = false;
            this.gbxLogging.Text = "Log 模式";
            // 
            // cbxLogging
            // 
            this.cbxLogging.AutoSize = true;
            this.cbxLogging.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLogging.Location = new System.Drawing.Point(11, 29);
            this.cbxLogging.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLogging.Name = "cbxLogging";
            this.cbxLogging.Size = new System.Drawing.Size(309, 28);
            this.cbxLogging.TabIndex = 9;
            this.cbxLogging.Text = "保存 86Box 的运行 Log 到以下文件:";
            this.cbxLogging.UseVisualStyleBackColor = true;
            this.cbxLogging.CheckedChanged += new System.EventHandler(this.cbxLogging_CheckedChanged);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(11, 65);
            this.txtLogPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(724, 30);
            this.txtLogPath.TabIndex = 10;
            this.txtLogPath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse3.Location = new System.Drawing.Point(742, 61);
            this.btnBrowse3.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(88, 38);
            this.btnBrowse3.TabIndex = 11;
            this.btnBrowse3.Text = "浏览...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // gbxMisc
            // 
            this.gbxMisc.Controls.Add(this.cbxGrid);
            this.gbxMisc.Controls.Add(this.cbxShowConsole);
            this.gbxMisc.Location = new System.Drawing.Point(8, 131);
            this.gbxMisc.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMisc.Size = new System.Drawing.Size(836, 71);
            this.gbxMisc.TabIndex = 17;
            this.gbxMisc.TabStop = false;
            this.gbxMisc.Text = "杂项";
            // 
            // cbxGrid
            // 
            this.cbxGrid.AutoSize = true;
            this.cbxGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxGrid.Location = new System.Drawing.Point(11, 29);
            this.cbxGrid.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGrid.Name = "cbxGrid";
            this.cbxGrid.Size = new System.Drawing.Size(262, 28);
            this.cbxGrid.TabIndex = 12;
            this.cbxGrid.Text = "在虚拟实例列表中启用网格线";
            this.cbxGrid.UseVisualStyleBackColor = true;
            this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.translatorlink);
            this.tabAbout.Controls.Add(this.translatorlabel);
            this.tabAbout.Controls.Add(this.lnkGithub);
            this.tabAbout.Controls.Add(this.imgLogo);
            this.tabAbout.Controls.Add(this.lblVersion1);
            this.tabAbout.Controls.Add(this.lnkGithub2);
            this.tabAbout.Controls.Add(this.lblCopyright);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblDesc);
            this.tabAbout.Controls.Add(this.lblTitle);
            this.tabAbout.Location = new System.Drawing.Point(4, 32);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4);
            this.tabAbout.Size = new System.Drawing.Size(853, 324);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "关于";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // translatorlink
            // 
            this.translatorlink.AutoSize = true;
            this.translatorlink.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.translatorlink.Location = new System.Drawing.Point(19, 286);
            this.translatorlink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.translatorlink.Name = "translatorlink";
            this.translatorlink.Size = new System.Drawing.Size(359, 23);
            this.translatorlink.TabIndex = 19;
            this.translatorlink.TabStop = true;
            this.translatorlink.Text = "https://github.com/Kira-Killua/86BoxManager";
            this.translatorlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.translatorlink_LinkClicked);
            // 
            // translatorlabel
            // 
            this.translatorlabel.AutoSize = true;
            this.translatorlabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.translatorlabel.Location = new System.Drawing.Point(19, 258);
            this.translatorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.translatorlabel.Name = "translatorlabel";
            this.translatorlabel.Size = new System.Drawing.Size(287, 23);
            this.translatorlabel.TabIndex = 18;
            this.translatorlabel.Text = "本程序由 Kira 汉化。查看汉化仓库：";
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub.Location = new System.Drawing.Point(357, 215);
            this.lnkGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(328, 23);
            this.lnkGithub.TabIndex = 12;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/86Box/86BoxManager";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(23, 19);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(48, 48);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            // 
            // lblVersion1
            // 
            this.lblVersion1.AutoSize = true;
            this.lblVersion1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion1.Location = new System.Drawing.Point(64, 104);
            this.lblVersion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion1.Name = "lblVersion1";
            this.lblVersion1.Size = new System.Drawing.Size(168, 23);
            this.lblVersion1.TabIndex = 16;
            this.lblVersion1.Text = "<version goes here>";
            // 
            // lnkGithub2
            // 
            this.lnkGithub2.AutoSize = true;
            this.lnkGithub2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub2.Location = new System.Drawing.Point(19, 215);
            this.lnkGithub2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGithub2.Name = "lnkGithub2";
            this.lnkGithub2.Size = new System.Drawing.Size(260, 23);
            this.lnkGithub2.TabIndex = 10;
            this.lnkGithub2.TabStop = true;
            this.lnkGithub2.Text = "https://github.com/86Box/86Box";
            this.lnkGithub2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub2_LinkClicked);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCopyright.Location = new System.Drawing.Point(19, 139);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(612, 69);
            this.lblCopyright.TabIndex = 15;
            this.lblCopyright.Text = "© 2018-2024 David Simunič 版权所有。\r\n本程序由 MIT 许可证授予许可。\r\n请参阅 LICENSE 文件查看许可证信息，查看 AUTH" +
    "ORS 文件以获取贡献者列表。";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion.Location = new System.Drawing.Point(19, 104);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 23);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "版本:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesc.Location = new System.Drawing.Point(19, 69);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(231, 23);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "86Box 仿真器的配置管理器。";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(79, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 35);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "86Box Manager";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titlelabel.Location = new System.Drawing.Point(17, 21);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(246, 35);
            this.titlelabel.TabIndex = 15;
            this.titlelabel.Text = "设置 86Box Manager";
            // 
            // titleDescriptionlabel
            // 
            this.titleDescriptionlabel.AutoSize = true;
            this.titleDescriptionlabel.Location = new System.Drawing.Point(19, 58);
            this.titleDescriptionlabel.Name = "titleDescriptionlabel";
            this.titleDescriptionlabel.Size = new System.Drawing.Size(224, 23);
            this.titleDescriptionlabel.TabIndex = 16;
            this.titleDescriptionlabel.Text = "调整 86Box Manager 选项。";
            // 
            // dlgSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(886, 530);
            this.Controls.Add(this.titleDescriptionlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.tbcSettings);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgSettings_FormClosing);
            this.Load += new System.EventHandler(this.dlgSettings_Load);
            this.pnlBottom.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gbxBehaviour.ResumeLayout(false);
            this.gbxBehaviour.PerformLayout();
            this.gbxPaths.ResumeLayout(false);
            this.gbxPaths.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxMisc.ResumeLayout(false);
            this.gbxMisc.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbxShowConsole;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gbxBehaviour;
        private System.Windows.Forms.CheckBox cbxMinimizeTray;
        private System.Windows.Forms.CheckBox cbxCloseTray;
        private System.Windows.Forms.CheckBox cbxMinimize;
        private System.Windows.Forms.GroupBox gbxPaths;
        private System.Windows.Forms.Label lblCFGdir;
        private System.Windows.Forms.TextBox txtCFGdir;
        private System.Windows.Forms.TextBox txtEXEdir;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblEXEdir;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label lbl86BoxVer1;
        private System.Windows.Forms.Label lbl86BoxVer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.CheckBox cbxLogging;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.CheckBox cbxGrid;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblVersion1;
        private System.Windows.Forms.LinkLabel lnkGithub2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label titleDescriptionlabel;
        private System.Windows.Forms.LinkLabel translatorlink;
        private System.Windows.Forms.Label translatorlabel;
    }
}