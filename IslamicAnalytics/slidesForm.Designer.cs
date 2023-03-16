namespace IslamicAnalytics
{
    partial class slidesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slidesForm));
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ramadanQuizTrButton = new Guna.UI.WinForms.GunaButton();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.titleDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.Radius = 10;
            this.formElipse.TargetControl = this;
            // 
            // ramadanQuizTrButton
            // 
            this.ramadanQuizTrButton.AnimationHoverSpeed = 0.07F;
            this.ramadanQuizTrButton.AnimationSpeed = 0.03F;
            this.ramadanQuizTrButton.BackColor = System.Drawing.Color.Transparent;
            this.ramadanQuizTrButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ramadanQuizTrButton.BorderColor = System.Drawing.Color.Silver;
            this.ramadanQuizTrButton.BorderSize = 1;
            this.ramadanQuizTrButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ramadanQuizTrButton.FocusedColor = System.Drawing.Color.Empty;
            this.ramadanQuizTrButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ramadanQuizTrButton.ForeColor = System.Drawing.Color.White;
            this.ramadanQuizTrButton.Image = null;
            this.ramadanQuizTrButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ramadanQuizTrButton.Location = new System.Drawing.Point(12, 53);
            this.ramadanQuizTrButton.Name = "ramadanQuizTrButton";
            this.ramadanQuizTrButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ramadanQuizTrButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.ramadanQuizTrButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ramadanQuizTrButton.OnHoverImage = null;
            this.ramadanQuizTrButton.OnPressedColor = System.Drawing.Color.Black;
            this.ramadanQuizTrButton.Radius = 5;
            this.ramadanQuizTrButton.Size = new System.Drawing.Size(410, 48);
            this.ramadanQuizTrButton.TabIndex = 5;
            this.ramadanQuizTrButton.Text = "Ramadan Trivia (Türkçe) Turkish";
            this.ramadanQuizTrButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ramadanQuizTrButton.Click += new System.EventHandler(this.ramadanQuizTrButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 25.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(776, 41);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "IslamicAnalytics";
            // 
            // titleDragControl
            // 
            this.titleDragControl.TargetControl = this.titleLabel;
            // 
            // slidesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ramadanQuizTrButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "slidesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "slidesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaButton ramadanQuizTrButton;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaDragControl titleDragControl;
    }
}