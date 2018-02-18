namespace Generators
{
    partial class Standart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standart));
            this.label8 = new System.Windows.Forms.Label();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.txtStandart = new System.Windows.Forms.TextBox();
            this.btnStandart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Size";
            // 
            // txtSSize
            // 
            this.txtSSize.Location = new System.Drawing.Point(12, 35);
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(52, 20);
            this.txtSSize.TabIndex = 42;
            this.txtSSize.Text = "1000000";
            // 
            // txtStandart
            // 
            this.txtStandart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStandart.Location = new System.Drawing.Point(70, 9);
            this.txtStandart.Multiline = true;
            this.txtStandart.Name = "txtStandart";
            this.txtStandart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStandart.Size = new System.Drawing.Size(312, 228);
            this.txtStandart.TabIndex = 41;
            // 
            // btnStandart
            // 
            this.btnStandart.BackColor = System.Drawing.Color.White;
            this.btnStandart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStandart.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStandart.Location = new System.Drawing.Point(388, 9);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(75, 23);
            this.btnStandart.TabIndex = 45;
            this.btnStandart.Text = "Generate";
            this.btnStandart.UseVisualStyleBackColor = false;
            this.btnStandart.Click += new System.EventHandler(this.btnGeffe_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(388, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Standart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(474, 249);
            this.Controls.Add(this.btnStandart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSSize);
            this.Controls.Add(this.txtStandart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Standart";
            this.Text = "Standart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSSize;
        private System.Windows.Forms.TextBox txtStandart;
        private System.Windows.Forms.Button btnStandart;
        private System.Windows.Forms.Button btnExit;
    }
}