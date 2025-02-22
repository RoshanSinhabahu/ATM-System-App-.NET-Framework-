namespace BankApp_v1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.AccDetailsGrid = new System.Windows.Forms.DataGridView();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(121, 61);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(183, 29);
            this.txtOwner.TabIndex = 1;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(121, 112);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(183, 42);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // AccDetailsGrid
            // 
            this.AccDetailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccDetailsGrid.Location = new System.Drawing.Point(351, 61);
            this.AccDetailsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccDetailsGrid.Name = "AccDetailsGrid";
            this.AccDetailsGrid.RowHeadersWidth = 49;
            this.AccDetailsGrid.RowTemplate.Height = 24;
            this.AccDetailsGrid.Size = new System.Drawing.Size(437, 241);
            this.AccDetailsGrid.TabIndex = 3;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(122, 322);
            this.numAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(183, 29);
            this.numAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(578, 310);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(210, 51);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click_1);
            // 
            // btnDeposite
            // 
            this.btnDeposite.Location = new System.Drawing.Point(352, 310);
            this.btnDeposite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(219, 51);
            this.btnDeposite.TabIndex = 7;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 391);
            this.Controls.Add(this.btnDeposite);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.AccDetailsGrid);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ATM System";
            ((System.ComponentModel.ISupportInitialize)(this.AccDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.DataGridView AccDetailsGrid;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposite;
    }
}

