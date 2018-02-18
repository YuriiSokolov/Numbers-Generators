namespace Generators
{
    partial class L89
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L89));
            this.txtL89Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLSize = new System.Windows.Forms.TextBox();
            this.txtL89 = new System.Windows.Forms.TextBox();
            this.btnL89 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtL89Size
            // 
            this.txtL89Size.Location = new System.Drawing.Point(12, 59);
            this.txtL89Size.Name = "txtL89Size";
            this.txtL89Size.Size = new System.Drawing.Size(52, 20);
            this.txtL89Size.TabIndex = 57;
            this.txtL89Size.Text = "1000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "t";
            // 
            // txtLSize
            // 
            this.txtLSize.Location = new System.Drawing.Point(34, 10);
            this.txtLSize.Name = "txtLSize";
            this.txtLSize.Size = new System.Drawing.Size(27, 20);
            this.txtLSize.TabIndex = 54;
            this.txtLSize.Text = "89";
            // 
            // txtL89
            // 
            this.txtL89.Location = new System.Drawing.Point(75, 5);
            this.txtL89.Multiline = true;
            this.txtL89.Name = "txtL89";
            this.txtL89.Size = new System.Drawing.Size(263, 74);
            this.txtL89.TabIndex = 53;
            // 
            // btnL89
            // 
            this.btnL89.BackColor = System.Drawing.Color.White;
            this.btnL89.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL89.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnL89.Location = new System.Drawing.Point(344, 5);
            this.btnL89.Name = "btnL89";
            this.btnL89.Size = new System.Drawing.Size(75, 23);
            this.btnL89.TabIndex = 52;
            this.btnL89.Text = "Generate";
            this.btnL89.UseVisualStyleBackColor = false;
            this.btnL89.Click += new System.EventHandler(this.btnL89_Click);
            // 
            // L89
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 91);
            this.Controls.Add(this.txtL89Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLSize);
            this.Controls.Add(this.txtL89);
            this.Controls.Add(this.btnL89);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "L89";
            this.Text = "L89";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtL89Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLSize;
        private System.Windows.Forms.TextBox txtL89;
        private System.Windows.Forms.Button btnL89;
    }
}