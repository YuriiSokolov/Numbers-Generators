namespace Generators
{
    partial class L20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L20));
            this.btnL20 = new System.Windows.Forms.Button();
            this.txtL20 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtL20Size = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnL20
            // 
            this.btnL20.BackColor = System.Drawing.Color.White;
            this.btnL20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL20.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnL20.Location = new System.Drawing.Point(344, 12);
            this.btnL20.Name = "btnL20";
            this.btnL20.Size = new System.Drawing.Size(75, 23);
            this.btnL20.TabIndex = 46;
            this.btnL20.Text = "Generate";
            this.btnL20.UseVisualStyleBackColor = false;
            this.btnL20.Click += new System.EventHandler(this.btnL20_Click);
            // 
            // txtL20
            // 
            this.txtL20.Location = new System.Drawing.Point(75, 12);
            this.txtL20.Multiline = true;
            this.txtL20.Name = "txtL20";
            this.txtL20.Size = new System.Drawing.Size(263, 74);
            this.txtL20.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "t";
            // 
            // txtLSize
            // 
            this.txtLSize.Location = new System.Drawing.Point(34, 17);
            this.txtLSize.Name = "txtLSize";
            this.txtLSize.Size = new System.Drawing.Size(27, 20);
            this.txtLSize.TabIndex = 48;
            this.txtLSize.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Size";
            // 
            // txtL20Size
            // 
            this.txtL20Size.Location = new System.Drawing.Point(12, 66);
            this.txtL20Size.Name = "txtL20Size";
            this.txtL20Size.Size = new System.Drawing.Size(52, 20);
            this.txtL20Size.TabIndex = 51;
            this.txtL20Size.Text = "1000000";
            // 
            // L20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 101);
            this.Controls.Add(this.txtL20Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLSize);
            this.Controls.Add(this.txtL20);
            this.Controls.Add(this.btnL20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "L20";
            this.Text = "L20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnL20;
        private System.Windows.Forms.TextBox txtL20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtL20Size;
    }
}