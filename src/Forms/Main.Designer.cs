namespace respi
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.onButt = new System.Windows.Forms.Button();
            this.offButt = new System.Windows.Forms.Button();
            this.splitSymbolSelect = new System.Windows.Forms.ComboBox();
            this.speedSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Location = new System.Drawing.Point(12, 12);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(305, 24);
            this.portSelector.TabIndex = 0;
            // 
            // onButt
            // 
            this.onButt.Location = new System.Drawing.Point(216, 100);
            this.onButt.Name = "onButt";
            this.onButt.Size = new System.Drawing.Size(101, 38);
            this.onButt.TabIndex = 1;
            this.onButt.Text = "вкл";
            this.onButt.UseVisualStyleBackColor = true;
            this.onButt.Click += new System.EventHandler(this.onButt_Click);
            // 
            // offButt
            // 
            this.offButt.Location = new System.Drawing.Point(12, 100);
            this.offButt.Name = "offButt";
            this.offButt.Size = new System.Drawing.Size(99, 38);
            this.offButt.TabIndex = 2;
            this.offButt.Text = "выкл";
            this.offButt.UseVisualStyleBackColor = true;
            this.offButt.Click += new System.EventHandler(this.offButt_Click);
            // 
            // splitSymbolSelect
            // 
            this.splitSymbolSelect.FormattingEnabled = true;
            this.splitSymbolSelect.Location = new System.Drawing.Point(12, 50);
            this.splitSymbolSelect.Name = "splitSymbolSelect";
            this.splitSymbolSelect.Size = new System.Drawing.Size(148, 24);
            this.splitSymbolSelect.TabIndex = 6;
            // 
            // speedSelect
            // 
            this.speedSelect.FormattingEnabled = true;
            this.speedSelect.Location = new System.Drawing.Point(170, 50);
            this.speedSelect.Name = "speedSelect";
            this.speedSelect.Size = new System.Drawing.Size(148, 24);
            this.speedSelect.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.speedSelect);
            this.Controls.Add(this.splitSymbolSelect);
            this.Controls.Add(this.offButt);
            this.Controls.Add(this.onButt);
            this.Controls.Add(this.portSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button offButt;
        private System.Windows.Forms.Button onButt;
        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.ComboBox speedSelect;
        private System.Windows.Forms.ComboBox splitSymbolSelect;

        #endregion
    }
}

