namespace _86boxManager
{
    partial class dlgAddVM
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
            this.cbxOpenCFG = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPath1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tipLblPath1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxStartVM = new System.Windows.Forms.CheckBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tipTxtName = new System.Windows.Forms.ToolTip(this.components);
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.cbxImport = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.titleDescriptionlabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxOpenCFG
            // 
            this.cbxOpenCFG.AutoSize = true;
            this.cbxOpenCFG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxOpenCFG.Location = new System.Drawing.Point(294, 302);
            this.cbxOpenCFG.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOpenCFG.Name = "cbxOpenCFG";
            this.cbxOpenCFG.Size = new System.Drawing.Size(160, 28);
            this.cbxOpenCFG.TabIndex = 6;
            this.cbxOpenCFG.Text = "完成后配置实例";
            this.cbxOpenCFG.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(635, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(549, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "创建";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 180);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "名称:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(14, 222);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(48, 23);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "描述:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(73, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(642, 30);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(73, 219);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(642, 30);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPath1
            // 
            this.lblPath1.AutoEllipsis = true;
            this.lblPath1.Location = new System.Drawing.Point(100, 263);
            this.lblPath1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath1.MaximumSize = new System.Drawing.Size(536, 21);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(536, 21);
            this.lblPath1.TabIndex = 12;
            this.lblPath1.Text = "<path goes here>";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(14, 263);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(82, 23);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "实例路径:";
            // 
            // cbxStartVM
            // 
            this.cbxStartVM.AutoSize = true;
            this.cbxStartVM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxStartVM.Location = new System.Drawing.Point(19, 302);
            this.cbxStartVM.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStartVM.Name = "cbxStartVM";
            this.cbxStartVM.Size = new System.Drawing.Size(160, 28);
            this.cbxStartVM.TabIndex = 5;
            this.cbxStartVM.Text = "完成后启动实例";
            this.cbxStartVM.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 356);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(730, 65);
            this.pnlBottom.TabIndex = 15;
            // 
            // tipTxtName
            // 
            this.tipTxtName.Active = false;
            this.tipTxtName.AutomaticDelay = 0;
            this.tipTxtName.IsBalloon = true;
            this.tipTxtName.ShowAlways = true;
            this.tipTxtName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tipTxtName.ToolTipTitle = "Name contains invalid characters";
            // 
            // txtImportPath
            // 
            this.txtImportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportPath.Enabled = false;
            this.txtImportPath.Location = new System.Drawing.Point(19, 131);
            this.txtImportPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.Size = new System.Drawing.Size(604, 30);
            this.txtImportPath.TabIndex = 1;
            // 
            // cbxImport
            // 
            this.cbxImport.AutoSize = true;
            this.cbxImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxImport.Location = new System.Drawing.Point(19, 96);
            this.cbxImport.Margin = new System.Windows.Forms.Padding(4);
            this.cbxImport.Name = "cbxImport";
            this.cbxImport.Size = new System.Drawing.Size(164, 28);
            this.cbxImport.TabIndex = 0;
            this.cbxImport.Text = "从以下路径导入:";
            this.cbxImport.UseVisualStyleBackColor = true;
            this.cbxImport.CheckedChanged += new System.EventHandler(this.cbxImport_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Enabled = false;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Location = new System.Drawing.Point(629, 127);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 38);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // titleDescriptionlabel
            // 
            this.titleDescriptionlabel.AutoSize = true;
            this.titleDescriptionlabel.Location = new System.Drawing.Point(15, 59);
            this.titleDescriptionlabel.Name = "titleDescriptionlabel";
            this.titleDescriptionlabel.Size = new System.Drawing.Size(316, 23);
            this.titleDescriptionlabel.TabIndex = 20;
            this.titleDescriptionlabel.Text = "创建一个新实例，或从已有的实例导入。";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titlelabel.Location = new System.Drawing.Point(13, 22);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(119, 35);
            this.titlelabel.TabIndex = 19;
            this.titlelabel.Text = "创建实例";
            // 
            // dlgAddVM
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(730, 421);
            this.Controls.Add(this.titleDescriptionlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.txtImportPath);
            this.Controls.Add(this.cbxImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.cbxStartVM);
            this.Controls.Add(this.cbxOpenCFG);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblPath1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAddVM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "虚拟实例创建向导";
            this.Load += new System.EventHandler(this.dlgAddVM_Load);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxOpenCFG;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ToolTip tipLblPath1;
        private System.Windows.Forms.CheckBox cbxStartVM;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ToolTip tipTxtName;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.CheckBox cbxImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label titleDescriptionlabel;
        private System.Windows.Forms.Label titlelabel;
    }
}