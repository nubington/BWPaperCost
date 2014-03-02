namespace BWPaperCost
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnIncreaseFontSize = new System.Windows.Forms.Button();
            this.btnDecreaseFontSize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxInput.Location = new System.Drawing.Point(0, 0);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(443, 20);
            this.txtBoxInput.TabIndex = 0;
            this.txtBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxInput_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 26);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(44, 20);
            this.btnGo.TabIndex = 2;
            this.btnGo.TabStop = false;
            this.btnGo.Text = "Enter";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResult.Location = new System.Drawing.Point(0, 20);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxResult.Size = new System.Drawing.Size(443, 234);
            this.txtBoxResult.TabIndex = 1;
            this.txtBoxResult.TabStop = false;
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxResult.Click += new System.EventHandler(this.txtBoxResult_Click);
            // 
            // btnIncreaseFontSize
            // 
            this.btnIncreaseFontSize.Location = new System.Drawing.Point(38, 104);
            this.btnIncreaseFontSize.Name = "btnIncreaseFontSize";
            this.btnIncreaseFontSize.Size = new System.Drawing.Size(20, 20);
            this.btnIncreaseFontSize.TabIndex = 4;
            this.btnIncreaseFontSize.TabStop = false;
            this.btnIncreaseFontSize.Text = "+";
            this.btnIncreaseFontSize.UseVisualStyleBackColor = true;
            this.btnIncreaseFontSize.Click += new System.EventHandler(this.btnIncreaseFontSize_Click);
            // 
            // btnDecreaseFontSize
            // 
            this.btnDecreaseFontSize.Location = new System.Drawing.Point(12, 104);
            this.btnDecreaseFontSize.Name = "btnDecreaseFontSize";
            this.btnDecreaseFontSize.Size = new System.Drawing.Size(20, 20);
            this.btnDecreaseFontSize.TabIndex = 5;
            this.btnDecreaseFontSize.TabStop = false;
            this.btnDecreaseFontSize.Text = "-";
            this.btnDecreaseFontSize.UseVisualStyleBackColor = true;
            this.btnDecreaseFontSize.Click += new System.EventHandler(this.btnDecreaseFontSize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 20);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(443, 254);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecreaseFontSize);
            this.Controls.Add(this.btnIncreaseFontSize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paper Cost Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnIncreaseFontSize;
        private System.Windows.Forms.Button btnDecreaseFontSize;
        private System.Windows.Forms.Button btnClear;
    }
}

