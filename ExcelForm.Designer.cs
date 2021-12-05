
namespace MyExcel
{
    partial class ExcelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.EditorSpace = new System.Windows.Forms.RichTextBox();
            this.MainDataView = new System.Windows.Forms.DataGridView();
            this.CoordinateBox = new System.Windows.Forms.TextBox();
            this.CoordLabel = new System.Windows.Forms.Label();
            this.FuncLabels = new System.Windows.Forms.Label();
            this.ReevaluateBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.AddColBtn = new System.Windows.Forms.Button();
            this.NewLabel = new System.Windows.Forms.Label();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveAsLabel = new System.Windows.Forms.Label();
            this.PropsLabel = new System.Windows.Forms.Label();
            this.RemRowBtn = new System.Windows.Forms.Button();
            this.RemColBtn = new System.Windows.Forms.Button();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorSpace
            // 
            resources.ApplyResources(this.EditorSpace, "EditorSpace");
            this.EditorSpace.Name = "EditorSpace";
            this.EditorSpace.Click += new System.EventHandler(this.EditorSpace_Click);
            this.EditorSpace.TextChanged += new System.EventHandler(this.EditorSpace_TextChanged);
            // 
            // MainDataView
            // 
            resources.ApplyResources(this.MainDataView, "MainDataView");
            this.MainDataView.AllowUserToAddRows = false;
            this.MainDataView.AllowUserToDeleteRows = false;
            this.MainDataView.AllowUserToOrderColumns = true;
            this.MainDataView.BackgroundColor = System.Drawing.Color.MintCream;
            this.MainDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainDataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.MainDataView.MultiSelect = false;
            this.MainDataView.Name = "MainDataView";
            this.MainDataView.ReadOnly = true;
            this.MainDataView.RowTemplate.Height = 25;
            this.MainDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataView_CellClick);
            this.MainDataView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataView_CellLeave);
            // 
            // CoordinateBox
            // 
            resources.ApplyResources(this.CoordinateBox, "CoordinateBox");
            this.CoordinateBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CoordinateBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CoordinateBox.Name = "CoordinateBox";
            this.CoordinateBox.ReadOnly = true;
            // 
            // CoordLabel
            // 
            resources.ApplyResources(this.CoordLabel, "CoordLabel");
            this.CoordLabel.Name = "CoordLabel";
            // 
            // FuncLabels
            // 
            resources.ApplyResources(this.FuncLabels, "FuncLabels");
            this.FuncLabels.Name = "FuncLabels";
            // 
            // ReevaluateBtn
            // 
            resources.ApplyResources(this.ReevaluateBtn, "ReevaluateBtn");
            this.ReevaluateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ReevaluateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReevaluateBtn.Name = "ReevaluateBtn";
            this.ReevaluateBtn.UseVisualStyleBackColor = false;
            this.ReevaluateBtn.Click += new System.EventHandler(this.ReevaluateBtn_Click);
            // 
            // AddRowBtn
            // 
            resources.ApplyResources(this.AddRowBtn, "AddRowBtn");
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // AddColBtn
            // 
            resources.ApplyResources(this.AddColBtn, "AddColBtn");
            this.AddColBtn.Name = "AddColBtn";
            this.AddColBtn.UseVisualStyleBackColor = true;
            this.AddColBtn.Click += new System.EventHandler(this.AddColBtn_Click);
            // 
            // NewLabel
            // 
            resources.ApplyResources(this.NewLabel, "NewLabel");
            this.NewLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewLabel.Name = "NewLabel";
            this.NewLabel.Click += new System.EventHandler(this.NewLabel_Click);
            // 
            // OpenLabel
            // 
            resources.ApplyResources(this.OpenLabel, "OpenLabel");
            this.OpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Click += new System.EventHandler(this.OpenLabel_Click);
            // 
            // SaveLabel
            // 
            resources.ApplyResources(this.SaveLabel, "SaveLabel");
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // SaveAsLabel
            // 
            resources.ApplyResources(this.SaveAsLabel, "SaveAsLabel");
            this.SaveAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Click += new System.EventHandler(this.SaveAsLabel_Click);
            // 
            // PropsLabel
            // 
            resources.ApplyResources(this.PropsLabel, "PropsLabel");
            this.PropsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PropsLabel.Name = "PropsLabel";
            this.PropsLabel.Click += new System.EventHandler(this.PropsLabel_Click);
            // 
            // RemRowBtn
            // 
            resources.ApplyResources(this.RemRowBtn, "RemRowBtn");
            this.RemRowBtn.Name = "RemRowBtn";
            this.RemRowBtn.UseVisualStyleBackColor = true;
            this.RemRowBtn.Click += new System.EventHandler(this.RemRowBtn_Click);
            // 
            // RemColBtn
            // 
            resources.ApplyResources(this.RemColBtn, "RemColBtn");
            this.RemColBtn.Name = "RemColBtn";
            this.RemColBtn.UseVisualStyleBackColor = true;
            this.RemColBtn.Click += new System.EventHandler(this.RemColBtn_Click);
            // 
            // AboutLabel
            // 
            resources.ApplyResources(this.AboutLabel, "AboutLabel");
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // HelpLabel
            // 
            resources.ApplyResources(this.HelpLabel, "HelpLabel");
            this.HelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // OpenFileDialog
            // 
            resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Unnamed";
            resources.ApplyResources(this.SaveFileDialog, "SaveFileDialog");
            // 
            // ExcelForm
            // 
            this.AcceptButton = this.ReevaluateBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.RemColBtn);
            this.Controls.Add(this.RemRowBtn);
            this.Controls.Add(this.PropsLabel);
            this.Controls.Add(this.SaveAsLabel);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.OpenLabel);
            this.Controls.Add(this.NewLabel);
            this.Controls.Add(this.AddColBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.ReevaluateBtn);
            this.Controls.Add(this.EditorSpace);
            this.Controls.Add(this.FuncLabels);
            this.Controls.Add(this.CoordinateBox);
            this.Controls.Add(this.CoordLabel);
            this.Controls.Add(this.MainDataView);
            this.Name = "ExcelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox EditorSpace;
        public System.Windows.Forms.DataGridView MainDataView;
        public System.Windows.Forms.TextBox CoordinateBox;
        public System.Windows.Forms.Label CoordLabel;
        public System.Windows.Forms.Label FuncLabels;
        public System.Windows.Forms.Button ReevaluateBtn;
        public System.Windows.Forms.Button AddRowBtn;
        public System.Windows.Forms.Button AddColBtn;
        public System.Windows.Forms.Label NewLabel;
        public System.Windows.Forms.Label OpenLabel;
        public System.Windows.Forms.Label SaveLabel;
        public System.Windows.Forms.Label SaveAsLabel;
        public System.Windows.Forms.Label PropsLabel;
        public System.Windows.Forms.Button RemRowBtn;
        public System.Windows.Forms.Button RemColBtn;
        public System.Windows.Forms.Label AboutLabel;
        public System.Windows.Forms.Label HelpLabel;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

