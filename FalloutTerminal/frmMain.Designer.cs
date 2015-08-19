namespace FalloutTerminal {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblWordSelect = new System.Windows.Forms.Label();
            this.cmbWordSelect = new System.Windows.Forms.ComboBox();
            this.lblCharacterMatches = new System.Windows.Forms.Label();
            this.nudCharacterMatches = new System.Windows.Forms.NumericUpDown();
            this.btnFilterWords = new System.Windows.Forms.Button();
            this.lstAvailableWords = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblEditText = new System.Windows.Forms.Label();
            this.lblNextGuess = new System.Windows.Forms.Label();
            this.lblNextGuessValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordSelect
            // 
            resources.ApplyResources(this.lblWordSelect, "lblWordSelect");
            this.lblWordSelect.Name = "lblWordSelect";
            // 
            // cmbWordSelect
            // 
            resources.ApplyResources(this.cmbWordSelect, "cmbWordSelect");
            this.cmbWordSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWordSelect.FormattingEnabled = true;
            this.cmbWordSelect.Name = "cmbWordSelect";
            this.cmbWordSelect.SelectedIndexChanged += new System.EventHandler(this.cmbWordSelect_SelectedIndexChanged);
            // 
            // lblCharacterMatches
            // 
            resources.ApplyResources(this.lblCharacterMatches, "lblCharacterMatches");
            this.lblCharacterMatches.Name = "lblCharacterMatches";
            // 
            // nudCharacterMatches
            // 
            resources.ApplyResources(this.nudCharacterMatches, "nudCharacterMatches");
            this.nudCharacterMatches.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCharacterMatches.Name = "nudCharacterMatches";
            this.nudCharacterMatches.Click += new System.EventHandler(this.nudCharacterMatches_Enter);
            this.nudCharacterMatches.Enter += new System.EventHandler(this.nudCharacterMatches_Enter);
            // 
            // btnFilterWords
            // 
            resources.ApplyResources(this.btnFilterWords, "btnFilterWords");
            this.btnFilterWords.Name = "btnFilterWords";
            this.btnFilterWords.UseVisualStyleBackColor = true;
            this.btnFilterWords.Click += new System.EventHandler(this.btnFilterWords_Click);
            // 
            // lstAvailableWords
            // 
            resources.ApplyResources(this.lstAvailableWords, "lstAvailableWords");
            this.lstAvailableWords.FormattingEnabled = true;
            this.lstAvailableWords.Name = "lstAvailableWords";
            this.lstAvailableWords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAvailableWords.TabStop = false;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblEditText
            // 
            resources.ApplyResources(this.lblEditText, "lblEditText");
            this.lblEditText.Name = "lblEditText";
            // 
            // lblNextGuess
            // 
            resources.ApplyResources(this.lblNextGuess, "lblNextGuess");
            this.lblNextGuess.Name = "lblNextGuess";
            // 
            // lblNextGuessValue
            // 
            resources.ApplyResources(this.lblNextGuessValue, "lblNextGuessValue");
            this.lblNextGuessValue.Name = "lblNextGuessValue";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNextGuessValue);
            this.Controls.Add(this.lblNextGuess);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstAvailableWords);
            this.Controls.Add(this.btnFilterWords);
            this.Controls.Add(this.nudCharacterMatches);
            this.Controls.Add(this.lblCharacterMatches);
            this.Controls.Add(this.cmbWordSelect);
            this.Controls.Add(this.lblWordSelect);
            this.Controls.Add(this.lblEditText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordSelect;
        private System.Windows.Forms.ComboBox cmbWordSelect;
        private System.Windows.Forms.Label lblCharacterMatches;
        private System.Windows.Forms.NumericUpDown nudCharacterMatches;
        private System.Windows.Forms.Button btnFilterWords;
        private System.Windows.Forms.ListBox lstAvailableWords;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Label lblNextGuess;
        private System.Windows.Forms.Label lblNextGuessValue;
    }
}

