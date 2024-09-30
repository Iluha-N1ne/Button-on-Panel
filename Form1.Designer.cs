namespace CardsMark3
{
    partial class Cards
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Helper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(10, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(521, 440);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            // 
            // Helper
            // 
            this.Helper.AutoSize = true;
            this.Helper.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Helper.Location = new System.Drawing.Point(185, 214);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(127, 19);
            this.Helper.TabIndex = 0;
            this.Helper.Text = "Tap to add button";
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 464);
            this.Controls.Add(this.Helper);
            this.Controls.Add(this.panel);
            this.Name = "Cards";
            this.Text = "Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label Helper;
    }
}

