
namespace Bankrekeningen
{
    partial class BankForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbSaldo1 = new System.Windows.Forms.Label();
            this.tbBedrag1 = new System.Windows.Forms.TextBox();
            this.btStorten1 = new System.Windows.Forms.Button();
            this.btOpnemen1 = new System.Windows.Forms.Button();
            this.btOvermaken1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOvermaken2 = new System.Windows.Forms.Button();
            this.btOpnemen2 = new System.Windows.Forms.Button();
            this.btStorten2 = new System.Windows.Forms.Button();
            this.tbBedrag2 = new System.Windows.Forms.TextBox();
            this.lbSaldo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSaldo1
            // 
            this.lbSaldo1.AutoSize = true;
            this.lbSaldo1.Location = new System.Drawing.Point(18, 35);
            this.lbSaldo1.Name = "lbSaldo1";
            this.lbSaldo1.Size = new System.Drawing.Size(50, 20);
            this.lbSaldo1.TabIndex = 0;
            this.lbSaldo1.Text = "Saldo:";
            // 
            // tbBedrag1
            // 
            this.tbBedrag1.Location = new System.Drawing.Point(87, 92);
            this.tbBedrag1.Name = "tbBedrag1";
            this.tbBedrag1.Size = new System.Drawing.Size(125, 27);
            this.tbBedrag1.TabIndex = 3;
            // 
            // btStorten1
            // 
            this.btStorten1.Location = new System.Drawing.Point(18, 125);
            this.btStorten1.Name = "btStorten1";
            this.btStorten1.Size = new System.Drawing.Size(94, 29);
            this.btStorten1.TabIndex = 5;
            this.btStorten1.Text = "Storten";
            this.btStorten1.UseVisualStyleBackColor = true;
            this.btStorten1.Click += new System.EventHandler(this.BtStorten1_Click);
            // 
            // btOpnemen1
            // 
            this.btOpnemen1.Location = new System.Drawing.Point(118, 125);
            this.btOpnemen1.Name = "btOpnemen1";
            this.btOpnemen1.Size = new System.Drawing.Size(94, 29);
            this.btOpnemen1.TabIndex = 6;
            this.btOpnemen1.Text = "Opnemen";
            this.btOpnemen1.UseVisualStyleBackColor = true;
            this.btOpnemen1.Click += new System.EventHandler(this.BtOpnemen1_Click);
            // 
            // btOvermaken1
            // 
            this.btOvermaken1.Location = new System.Drawing.Point(218, 125);
            this.btOvermaken1.Name = "btOvermaken1";
            this.btOvermaken1.Size = new System.Drawing.Size(94, 29);
            this.btOvermaken1.TabIndex = 7;
            this.btOvermaken1.Text = "Overmaken";
            this.btOvermaken1.UseVisualStyleBackColor = true;
            this.btOvermaken1.Click += new System.EventHandler(this.BtOvermaken1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btOvermaken1);
            this.groupBox1.Controls.Add(this.btOpnemen1);
            this.groupBox1.Controls.Add(this.btStorten1);
            this.groupBox1.Controls.Add(this.tbBedrag1);
            this.groupBox1.Controls.Add(this.lbSaldo1);
            this.groupBox1.Location = new System.Drawing.Point(31, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rekening 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bedrag: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btOvermaken2);
            this.groupBox2.Controls.Add(this.btOpnemen2);
            this.groupBox2.Controls.Add(this.btStorten2);
            this.groupBox2.Controls.Add(this.tbBedrag2);
            this.groupBox2.Controls.Add(this.lbSaldo2);
            this.groupBox2.Location = new System.Drawing.Point(402, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 183);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rekening 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bedrag: ";
            // 
            // btOvermaken2
            // 
            this.btOvermaken2.Location = new System.Drawing.Point(218, 125);
            this.btOvermaken2.Name = "btOvermaken2";
            this.btOvermaken2.Size = new System.Drawing.Size(94, 29);
            this.btOvermaken2.TabIndex = 7;
            this.btOvermaken2.Text = "Overmaken";
            this.btOvermaken2.UseVisualStyleBackColor = true;
            this.btOvermaken2.Click += new System.EventHandler(this.BtOvermaken2_Click);
            // 
            // btOpnemen2
            // 
            this.btOpnemen2.Location = new System.Drawing.Point(118, 125);
            this.btOpnemen2.Name = "btOpnemen2";
            this.btOpnemen2.Size = new System.Drawing.Size(94, 29);
            this.btOpnemen2.TabIndex = 6;
            this.btOpnemen2.Text = "Opnemen";
            this.btOpnemen2.UseVisualStyleBackColor = true;
            this.btOpnemen2.Click += new System.EventHandler(this.BtOpnemen2_Click);
            // 
            // btStorten2
            // 
            this.btStorten2.Location = new System.Drawing.Point(18, 125);
            this.btStorten2.Name = "btStorten2";
            this.btStorten2.Size = new System.Drawing.Size(94, 29);
            this.btStorten2.TabIndex = 5;
            this.btStorten2.Text = "Storten";
            this.btStorten2.UseVisualStyleBackColor = true;
            this.btStorten2.Click += new System.EventHandler(this.BtStorten2_Click);
            // 
            // tbBedrag2
            // 
            this.tbBedrag2.Location = new System.Drawing.Point(87, 92);
            this.tbBedrag2.Name = "tbBedrag2";
            this.tbBedrag2.Size = new System.Drawing.Size(125, 27);
            this.tbBedrag2.TabIndex = 3;
            // 
            // lbSaldo2
            // 
            this.lbSaldo2.AutoSize = true;
            this.lbSaldo2.Location = new System.Drawing.Point(18, 35);
            this.lbSaldo2.Name = "lbSaldo2";
            this.lbSaldo2.Size = new System.Drawing.Size(50, 20);
            this.lbSaldo2.TabIndex = 0;
            this.lbSaldo2.Text = "Saldo:";
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.Load += new System.EventHandler(this.BankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbSaldo1;
        private System.Windows.Forms.TextBox tbBedrag1;
        private System.Windows.Forms.Button btStorten1;
        private System.Windows.Forms.Button btOpnemen1;
        private System.Windows.Forms.Button btOvermaken1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOvermaken2;
        private System.Windows.Forms.Button btOpnemen2;
        private System.Windows.Forms.Button btStorten2;
        private System.Windows.Forms.TextBox tbBedrag2;
        private System.Windows.Forms.Label lbSaldo2;
    }
}

