namespace Zaychik
{
    partial class HipotesyX
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
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
            this.SuspendLayout();
            // 
            // raspredX
            // 
            this.raspredX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.inter,
            this.ni,
            this.Zi,
            this.Fi,
            this.pi,
            this.npi,
            this.res});
            this.raspredX.Location = new System.Drawing.Point(0, 0);
            this.raspredX.Name = "raspredX";
            this.raspredX.RowHeadersWidth = 51;
            this.raspredX.RowTemplate.Height = 24;
            this.raspredX.Size = new System.Drawing.Size(1204, 290);
            this.raspredX.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 125;
            // 
            // inter
            // 
            this.inter.HeaderText = "interval";
            this.inter.MinimumWidth = 6;
            this.inter.Name = "inter";
            this.inter.Width = 125;
            // 
            // ni
            // 
            this.ni.HeaderText = "Ni";
            this.ni.MinimumWidth = 6;
            this.ni.Name = "ni";
            this.ni.Width = 125;
            // 
            // Zi
            // 
            this.Zi.HeaderText = "Zi";
            this.Zi.MinimumWidth = 6;
            this.Zi.Name = "Zi";
            this.Zi.Width = 125;
            // 
            // Fi
            // 
            this.Fi.HeaderText = "Фi";
            this.Fi.MinimumWidth = 6;
            this.Fi.Name = "Fi";
            this.Fi.Width = 125;
            // 
            // pi
            // 
            this.pi.HeaderText = "Pi";
            this.pi.MinimumWidth = 6;
            this.pi.Name = "pi";
            this.pi.Width = 125;
            // 
            // npi
            // 
            this.npi.HeaderText = "npi";
            this.npi.MinimumWidth = 6;
            this.npi.Name = "npi";
            this.npi.Width = 125;
            // 
            // res
            // 
            this.res.HeaderText = "(ni - npi)^2/npi";
            this.res.MinimumWidth = 6;
            this.res.Name = "res";
            this.res.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "число интервалов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Х^2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Хв^2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "точность";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Х(0.95)^2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // HipotesyX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raspredX);
            this.Name = "HipotesyX";
            this.Text = "HypotesyX";
            this.Load += new System.EventHandler(this.Hipotesy_X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView raspredX;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn npi;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}