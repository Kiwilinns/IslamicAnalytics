namespace IslamicAnalytics
{
    partial class generatefastraportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generatefastraportForm));
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.genereatefastreportButton = new Guna.UI.WinForms.GunaButton();
            this.informationPanel = new Guna.UI.WinForms.GunaPanel();
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.fastdateLabel = new Guna.UI.WinForms.GunaLabel();
            this.informationLabel = new Guna.UI.WinForms.GunaLabel();
            this.fastdateDateTimerPicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.fasttypeLabel = new Guna.UI.WinForms.GunaLabel();
            this.fasttypeComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.nameoffastLabel = new Guna.UI.WinForms.GunaLabel();
            this.nameoffastTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.fastingpeopleTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.watermarkTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.watermarkLabel = new Guna.UI.WinForms.GunaLabel();
            this.titleDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.Radius = 10;
            this.formElipse.TargetControl = this;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 25.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(776, 41);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "IslamicAnalytics";
            // 
            // genereatefastreportButton
            // 
            this.genereatefastreportButton.AnimationHoverSpeed = 0.07F;
            this.genereatefastreportButton.AnimationSpeed = 0.03F;
            this.genereatefastreportButton.BackColor = System.Drawing.Color.Transparent;
            this.genereatefastreportButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.genereatefastreportButton.BorderColor = System.Drawing.Color.Silver;
            this.genereatefastreportButton.BorderSize = 1;
            this.genereatefastreportButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.genereatefastreportButton.FocusedColor = System.Drawing.Color.Empty;
            this.genereatefastreportButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genereatefastreportButton.ForeColor = System.Drawing.Color.White;
            this.genereatefastreportButton.Image = null;
            this.genereatefastreportButton.ImageSize = new System.Drawing.Size(20, 20);
            this.genereatefastreportButton.Location = new System.Drawing.Point(19, 390);
            this.genereatefastreportButton.Name = "genereatefastreportButton";
            this.genereatefastreportButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.genereatefastreportButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.genereatefastreportButton.OnHoverForeColor = System.Drawing.Color.White;
            this.genereatefastreportButton.OnHoverImage = null;
            this.genereatefastreportButton.OnPressedColor = System.Drawing.Color.Black;
            this.genereatefastreportButton.Radius = 5;
            this.genereatefastreportButton.Size = new System.Drawing.Size(769, 48);
            this.genereatefastreportButton.TabIndex = 2;
            this.genereatefastreportButton.Text = "Generate Fasting Report";
            this.genereatefastreportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genereatefastreportButton.Click += new System.EventHandler(this.genereatefastreportButton_Click);
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.informationPanel.Controls.Add(this.watermarkTextBox);
            this.informationPanel.Controls.Add(this.watermarkLabel);
            this.informationPanel.Controls.Add(this.fastingpeopleTextBox);
            this.informationPanel.Controls.Add(this.gunaLabel2);
            this.informationPanel.Controls.Add(this.nameoffastTextBox);
            this.informationPanel.Controls.Add(this.nameoffastLabel);
            this.informationPanel.Controls.Add(this.fasttypeComboBox);
            this.informationPanel.Controls.Add(this.fasttypeLabel);
            this.informationPanel.Controls.Add(this.saveButton);
            this.informationPanel.Controls.Add(this.fastdateDateTimerPicker);
            this.informationPanel.Controls.Add(this.informationLabel);
            this.informationPanel.Controls.Add(this.fastdateLabel);
            this.informationPanel.Location = new System.Drawing.Point(19, 53);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(769, 331);
            this.informationPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.AnimationHoverSpeed = 0.07F;
            this.saveButton.AnimationSpeed = 0.03F;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveButton.BorderColor = System.Drawing.Color.Silver;
            this.saveButton.BorderSize = 1;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = null;
            this.saveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.saveButton.Location = new System.Drawing.Point(542, 280);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.saveButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.saveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.saveButton.OnHoverImage = null;
            this.saveButton.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton.Radius = 5;
            this.saveButton.Size = new System.Drawing.Size(224, 48);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fastdateLabel
            // 
            this.fastdateLabel.AutoSize = true;
            this.fastdateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fastdateLabel.ForeColor = System.Drawing.Color.White;
            this.fastdateLabel.Location = new System.Drawing.Point(4, 49);
            this.fastdateLabel.Name = "fastdateLabel";
            this.fastdateLabel.Size = new System.Drawing.Size(82, 19);
            this.fastdateLabel.TabIndex = 0;
            this.fastdateLabel.Text = "Fast Date:";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.informationLabel.ForeColor = System.Drawing.Color.White;
            this.informationLabel.Location = new System.Drawing.Point(8, 8);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(143, 26);
            this.informationLabel.TabIndex = 1;
            this.informationLabel.Text = "Informations";
            // 
            // fastdateDateTimerPicker
            // 
            this.fastdateDateTimerPicker.BackColor = System.Drawing.Color.Transparent;
            this.fastdateDateTimerPicker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fastdateDateTimerPicker.BorderColor = System.Drawing.Color.Silver;
            this.fastdateDateTimerPicker.BorderSize = 1;
            this.fastdateDateTimerPicker.CustomFormat = null;
            this.fastdateDateTimerPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fastdateDateTimerPicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fastdateDateTimerPicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fastdateDateTimerPicker.ForeColor = System.Drawing.Color.White;
            this.fastdateDateTimerPicker.Location = new System.Drawing.Point(92, 42);
            this.fastdateDateTimerPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fastdateDateTimerPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fastdateDateTimerPicker.Name = "fastdateDateTimerPicker";
            this.fastdateDateTimerPicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.fastdateDateTimerPicker.OnHoverBorderColor = System.Drawing.Color.White;
            this.fastdateDateTimerPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fastdateDateTimerPicker.OnPressedColor = System.Drawing.Color.Black;
            this.fastdateDateTimerPicker.Radius = 5;
            this.fastdateDateTimerPicker.Size = new System.Drawing.Size(223, 35);
            this.fastdateDateTimerPicker.TabIndex = 2;
            this.fastdateDateTimerPicker.Text = "16 Mart 2023 Perşembe";
            this.fastdateDateTimerPicker.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // fasttypeLabel
            // 
            this.fasttypeLabel.AutoSize = true;
            this.fasttypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fasttypeLabel.ForeColor = System.Drawing.Color.White;
            this.fasttypeLabel.Location = new System.Drawing.Point(4, 89);
            this.fasttypeLabel.Name = "fasttypeLabel";
            this.fasttypeLabel.Size = new System.Drawing.Size(83, 19);
            this.fasttypeLabel.TabIndex = 7;
            this.fasttypeLabel.Text = "Fast Type:";
            // 
            // fasttypeComboBox
            // 
            this.fasttypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.fasttypeComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fasttypeComboBox.BorderColor = System.Drawing.Color.Silver;
            this.fasttypeComboBox.BorderSize = 1;
            this.fasttypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fasttypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fasttypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.fasttypeComboBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.fasttypeComboBox.ForeColor = System.Drawing.Color.White;
            this.fasttypeComboBox.FormattingEnabled = true;
            this.fasttypeComboBox.Items.AddRange(new object[] {
            "Normal",
            "Half-Fast"});
            this.fasttypeComboBox.Location = new System.Drawing.Point(92, 85);
            this.fasttypeComboBox.Name = "fasttypeComboBox";
            this.fasttypeComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fasttypeComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.fasttypeComboBox.Radius = 5;
            this.fasttypeComboBox.Size = new System.Drawing.Size(121, 31);
            this.fasttypeComboBox.StartIndex = 0;
            this.fasttypeComboBox.TabIndex = 8;
            this.fasttypeComboBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.fasttypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fasttypeComboBox_SelectedIndexChanged);
            // 
            // nameoffastLabel
            // 
            this.nameoffastLabel.AutoSize = true;
            this.nameoffastLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameoffastLabel.ForeColor = System.Drawing.Color.White;
            this.nameoffastLabel.Location = new System.Drawing.Point(4, 131);
            this.nameoffastLabel.Name = "nameoffastLabel";
            this.nameoffastLabel.Size = new System.Drawing.Size(113, 19);
            this.nameoffastLabel.TabIndex = 9;
            this.nameoffastLabel.Text = "Name of Fast:";
            // 
            // nameoffastTextBox
            // 
            this.nameoffastTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameoffastTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.nameoffastTextBox.BorderColor = System.Drawing.Color.Silver;
            this.nameoffastTextBox.BorderSize = 1;
            this.nameoffastTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameoffastTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nameoffastTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.nameoffastTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.nameoffastTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nameoffastTextBox.ForeColor = System.Drawing.Color.White;
            this.nameoffastTextBox.Location = new System.Drawing.Point(118, 125);
            this.nameoffastTextBox.Name = "nameoffastTextBox";
            this.nameoffastTextBox.PasswordChar = '\0';
            this.nameoffastTextBox.Radius = 5;
            this.nameoffastTextBox.SelectedText = "";
            this.nameoffastTextBox.Size = new System.Drawing.Size(160, 33);
            this.nameoffastTextBox.TabIndex = 10;
            this.nameoffastTextBox.Text = "Test Fast";
            this.nameoffastTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fastingpeopleTextBox
            // 
            this.fastingpeopleTextBox.BackColor = System.Drawing.Color.Transparent;
            this.fastingpeopleTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fastingpeopleTextBox.BorderColor = System.Drawing.Color.Silver;
            this.fastingpeopleTextBox.BorderSize = 1;
            this.fastingpeopleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastingpeopleTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fastingpeopleTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.fastingpeopleTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.fastingpeopleTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.fastingpeopleTextBox.ForeColor = System.Drawing.Color.White;
            this.fastingpeopleTextBox.Location = new System.Drawing.Point(227, 164);
            this.fastingpeopleTextBox.Name = "fastingpeopleTextBox";
            this.fastingpeopleTextBox.PasswordChar = '\0';
            this.fastingpeopleTextBox.Radius = 5;
            this.fastingpeopleTextBox.SelectedText = "";
            this.fastingpeopleTextBox.Size = new System.Drawing.Size(160, 33);
            this.fastingpeopleTextBox.TabIndex = 12;
            this.fastingpeopleTextBox.Text = "Kevin";
            this.fastingpeopleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(4, 172);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(218, 19);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Name of the person fasting:";
            // 
            // watermarkTextBox
            // 
            this.watermarkTextBox.BackColor = System.Drawing.Color.Transparent;
            this.watermarkTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.watermarkTextBox.BorderColor = System.Drawing.Color.Silver;
            this.watermarkTextBox.BorderSize = 1;
            this.watermarkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.watermarkTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.watermarkTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.watermarkTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.watermarkTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.watermarkTextBox.ForeColor = System.Drawing.Color.White;
            this.watermarkTextBox.Location = new System.Drawing.Point(191, 203);
            this.watermarkTextBox.Name = "watermarkTextBox";
            this.watermarkTextBox.PasswordChar = '\0';
            this.watermarkTextBox.Radius = 5;
            this.watermarkTextBox.SelectedText = "";
            this.watermarkTextBox.Size = new System.Drawing.Size(160, 33);
            this.watermarkTextBox.TabIndex = 14;
            this.watermarkTextBox.Text = "Made By jrKiwi";
            this.watermarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // watermarkLabel
            // 
            this.watermarkLabel.AutoSize = true;
            this.watermarkLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.watermarkLabel.ForeColor = System.Drawing.Color.White;
            this.watermarkLabel.Location = new System.Drawing.Point(4, 211);
            this.watermarkLabel.Name = "watermarkLabel";
            this.watermarkLabel.Size = new System.Drawing.Size(181, 19);
            this.watermarkLabel.TabIndex = 13;
            this.watermarkLabel.Text = "Watermark (Optional):";
            // 
            // titleDragControl
            // 
            this.titleDragControl.TargetControl = this.titleLabel;
            // 
            // generatefastraportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.genereatefastreportButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "generatefastraportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IslamicAnalytics: Generate Fast Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.generatefastraportForm_FormClosing);
            this.Load += new System.EventHandler(this.generatefastraportForm_Load);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaButton genereatefastreportButton;
        private Guna.UI.WinForms.GunaPanel informationPanel;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaLabel fastdateLabel;
        private Guna.UI.WinForms.GunaLabel informationLabel;
        private Guna.UI.WinForms.GunaDateTimePicker fastdateDateTimerPicker;
        private Guna.UI.WinForms.GunaLabel fasttypeLabel;
        private Guna.UI.WinForms.GunaComboBox fasttypeComboBox;
        private Guna.UI.WinForms.GunaLabel nameoffastLabel;
        private Guna.UI.WinForms.GunaTextBox nameoffastTextBox;
        private Guna.UI.WinForms.GunaTextBox fastingpeopleTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox watermarkTextBox;
        private Guna.UI.WinForms.GunaLabel watermarkLabel;
        private Guna.UI.WinForms.GunaDragControl titleDragControl;
    }
}