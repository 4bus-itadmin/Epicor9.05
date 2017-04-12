using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Epicor.Mfg.BO;
using Epicor.Mfg.UI;
using Epicor.Mfg.UI.Adapters;
using Epicor.Mfg.UI.Customization;
using Epicor.Mfg.UI.ExtendedProps;
using Epicor.Mfg.UI.FormFunctions;
using Epicor.Mfg.UI.FrameWork;
using Epicor.Mfg.UI.Searches;
using Infragistics.Win.UltraWinToolbars;

namespace Epicor.Mfg.Custom.Template
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Infragistics.Win.UltraWinStatusBar.UltraStatusBar baseStatusBar;
        private Infragistics.Win.Misc.UltraPanel Form1_Fill_Panel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager baseToolbarsManager;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Bottom;
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
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("MainMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool1 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("File");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool2 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edit");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool3 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Tools");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool4 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Action");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool5 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Help");
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar2 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("Standard Tools");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("New");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Save");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Refresh");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Clear");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Print");
            Infragistics.Win.UltraWinToolbars.TextBoxTool textBoxTool2 = new Infragistics.Win.UltraWinToolbars.TextBoxTool("Close");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool6 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("File");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool7 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edit");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool8 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Tools");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool9 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Action");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool10 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Help");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("New");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Save");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool8 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Refresh");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool9 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Clear");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool10 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Print");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baseStatusBar = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            this.Form1_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this.baseToolbarsManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._Form1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            ((System.ComponentModel.ISupportInitialize)(this.baseStatusBar)).BeginInit();
            this.Form1_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseToolbarsManager)).BeginInit();
            this.SuspendLayout();
            // 
            // baseStatusBar
            // 
            this.baseStatusBar.Location = new System.Drawing.Point(0, 644);
            this.baseStatusBar.Name = "baseStatusBar";
            this.baseStatusBar.Size = new System.Drawing.Size(1303, 23);
            this.baseStatusBar.TabIndex = 0;
            this.baseStatusBar.Text = "Ready";
            // 
            // Form1_Fill_Panel
            // 
            this.Form1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Form1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1_Fill_Panel.Location = new System.Drawing.Point(0, 48);
            this.Form1_Fill_Panel.Name = "Form1_Fill_Panel";
            this.Form1_Fill_Panel.Size = new System.Drawing.Size(1303, 596);
            this.Form1_Fill_Panel.TabIndex = 1;
            // 
            // baseToolbarsManager
            // 
            this.baseToolbarsManager.DesignerFlags = 1;
            this.baseToolbarsManager.DockWithinContainer = this;
            this.baseToolbarsManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.IsMainMenuBar = true;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            popupMenuTool1,
            popupMenuTool2,
            popupMenuTool3,
            popupMenuTool4,
            popupMenuTool5});
            ultraToolbar1.Text = "MainMenu";
            ultraToolbar2.DockedColumn = 0;
            ultraToolbar2.DockedRow = 1;
            ultraToolbar2.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            buttonTool2,
            buttonTool3,
            buttonTool4,
            buttonTool5});
            ultraToolbar2.Text = "Standard Tools";
            this.baseToolbarsManager.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1,
            ultraToolbar2});
            textBoxTool2.SharedPropsInternal.Caption = "Close";
            popupMenuTool6.SharedPropsInternal.Caption = "File";
            popupMenuTool7.SharedPropsInternal.Caption = "Edit";
            popupMenuTool8.SharedPropsInternal.Caption = "Tools";
            popupMenuTool9.SharedPropsInternal.Caption = "Action";
            popupMenuTool10.SharedPropsInternal.Caption = "Help";
            buttonTool6.SharedPropsInternal.Caption = "New";
            buttonTool7.SharedPropsInternal.Caption = "Save";
            buttonTool8.SharedPropsInternal.Caption = "Refresh";
            buttonTool9.SharedPropsInternal.Caption = "Clear";
            buttonTool10.SharedPropsInternal.Caption = "Print";
            this.baseToolbarsManager.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            textBoxTool2,
            popupMenuTool6,
            popupMenuTool7,
            popupMenuTool8,
            popupMenuTool9,
            popupMenuTool10,
            buttonTool6,
            buttonTool7,
            buttonTool8,
            buttonTool9,
            buttonTool10});
            this.baseToolbarsManager.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // _Form1_Toolbars_Dock_Area_Left
            // 
            this._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control;
            this._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 48);
            this._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left";
            this._Form1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 596);
            this._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = this.baseToolbarsManager;
            // 
            // _Form1_Toolbars_Dock_Area_Right
            // 
            this._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control;
            this._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1303, 48);
            this._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right";
            this._Form1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 596);
            this._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = this.baseToolbarsManager;
            // 
            // _Form1_Toolbars_Dock_Area_Top
            // 
            this._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control;
            this._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top";
            this._Form1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1303, 48);
            this._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = this.baseToolbarsManager;
            // 
            // _Form1_Toolbars_Dock_Area_Bottom
            // 
            this._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control;
            this._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 644);
            this._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom";
            this._Form1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1303, 0);
            this._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.baseToolbarsManager;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 667);
            this.Controls.Add(this.Form1_Fill_Panel);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this.baseStatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baseStatusBar)).EndInit();
            this.Form1_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseToolbarsManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void InsertToolsOnToolbar(string btnType, string btnName, string btnCaption, string btnImageIndex, string btnParentToolbar)
        {
            try
            {
                if(btnType=="ButtonTool")
                {
                    ButtonTool prinTool = new ButtonTool(btnName);
                    prinTool.SharedProps.Caption = btnCaption;
                    prinTool.SharedProps.Enabled = true;
                    prinTool.SharedProps.Visible = true;
                    prinTool.SharedProps.AppearancesSmall.Appearance.Image = EpiUIImages.SmallEnabledImages.Images[EpiUIImages.IndexOf("Print")];

                    baseToolbarsManager.Tools.Add(prinTool);
                    baseToolbarsManager.Toolbars["Standard Tools"].Tools.AddTool(btnName);
                }
            }
            catch (Exception e)
            {
                ExceptionBox.Show(e);
            }
        }
    }
}

