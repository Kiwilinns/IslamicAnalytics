namespace IslamicAnalytics
{
    partial class startForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.genereatefastreportButton = new Guna.UI.WinForms.GunaButton();
            this.slidesButton = new Guna.UI.WinForms.GunaButton();
            this.titleDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
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
            this.titleLabel.TabIndex = 0;
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
            this.genereatefastreportButton.Location = new System.Drawing.Point(19, 106);
            this.genereatefastreportButton.Name = "genereatefastreportButton";
            this.genereatefastreportButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.genereatefastreportButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.genereatefastreportButton.OnHoverForeColor = System.Drawing.Color.White;
            this.genereatefastreportButton.OnHoverImage = null;
            this.genereatefastreportButton.OnPressedColor = System.Drawing.Color.Black;
            this.genereatefastreportButton.Radius = 5;
            this.genereatefastreportButton.Size = new System.Drawing.Size(371, 48);
            this.genereatefastreportButton.TabIndex = 1;
            this.genereatefastreportButton.Text = "Generate Fasting Report";
            this.genereatefastreportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genereatefastreportButton.Click += new System.EventHandler(this.genereatefastreportButton_Click);
            // 
            // slidesButton
            // 
            this.slidesButton.AnimationHoverSpeed = 0.07F;
            this.slidesButton.AnimationSpeed = 0.03F;
            this.slidesButton.BackColor = System.Drawing.Color.Transparent;
            this.slidesButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.slidesButton.BorderColor = System.Drawing.Color.Silver;
            this.slidesButton.BorderSize = 1;
            this.slidesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.slidesButton.FocusedColor = System.Drawing.Color.Empty;
            this.slidesButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slidesButton.ForeColor = System.Drawing.Color.White;
            this.slidesButton.Image = null;
            this.slidesButton.ImageSize = new System.Drawing.Size(20, 20);
            this.slidesButton.Location = new System.Drawing.Point(19, 308);
            this.slidesButton.Name = "slidesButton";
            this.slidesButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.slidesButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.slidesButton.OnHoverForeColor = System.Drawing.Color.White;
            this.slidesButton.OnHoverImage = null;
            this.slidesButton.OnPressedColor = System.Drawing.Color.Black;
            this.slidesButton.Radius = 5;
            this.slidesButton.Size = new System.Drawing.Size(371, 48);
            this.slidesButton.TabIndex = 2;
            this.slidesButton.Text = "Slides";
            this.slidesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slidesButton.Click += new System.EventHandler(this.slidesButton_Click);
            // 
            // titleDragControl
            // 
            this.titleDragControl.TargetControl = this.titleLabel;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slidesButton);
            this.Controls.Add(this.genereatefastreportButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IslamicAnalytics: Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStart_FormClosing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaButton genereatefastreportButton;
        private Guna.UI.WinForms.GunaButton slidesButton;
        private Guna.UI.WinForms.GunaDragControl titleDragControl;
    }
}

