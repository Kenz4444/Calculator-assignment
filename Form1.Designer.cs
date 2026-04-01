namespace Calculator_assignment
{
    partial class simplecalculator
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
            this.components = new System.ComponentModel.Container();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsquare = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btnsquareroot = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnenter = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(12, 234);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(451, 60);
            this.txtinput.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(28, 325);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 37);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsquare
            // 
            this.btnsquare.AutoSize = true;
            this.btnsquare.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsquare.Location = new System.Drawing.Point(133, 373);
            this.btnsquare.Name = "btnsquare";
            this.btnsquare.Size = new System.Drawing.Size(75, 37);
            this.btnsquare.TabIndex = 2;
            this.btnsquare.Text = "y²";
            this.btnsquare.UseVisualStyleBackColor = true;
            this.btnsquare.Click += new System.EventHandler(this.btnsquare_Click);
            // 
            // btndivide
            // 
            this.btndivide.AutoSize = true;
            this.btndivide.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(28, 373);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 37);
            this.btndivide.TabIndex = 3;
            this.btndivide.Text = "÷";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.AutoSize = true;
            this.btnmultiply.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.Location = new System.Drawing.Point(247, 325);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 37);
            this.btnmultiply.TabIndex = 4;
            this.btnmultiply.Text = "X";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnsubtract
            // 
            this.btnsubtract.AutoSize = true;
            this.btnsubtract.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtract.Location = new System.Drawing.Point(133, 325);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(75, 37);
            this.btnsubtract.TabIndex = 5;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = true;
            this.btnsubtract.Click += new System.EventHandler(this.btnsubtract_Click);
            // 
            // btnsquareroot
            // 
            this.btnsquareroot.AutoSize = true;
            this.btnsquareroot.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsquareroot.Location = new System.Drawing.Point(247, 373);
            this.btnsquareroot.Name = "btnsquareroot";
            this.btnsquareroot.Size = new System.Drawing.Size(75, 37);
            this.btnsquareroot.TabIndex = 6;
            this.btnsquareroot.Text = " √y";
            this.btnsquareroot.UseVisualStyleBackColor = true;
            this.btnsquareroot.Click += new System.EventHandler(this.btnsquareroot_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(347, 402);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 36);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnenter
            // 
            this.btnenter.AutoSize = true;
            this.btnenter.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(363, 325);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(100, 71);
            this.btnenter.TabIndex = 8;
            this.btnenter.Text = "=";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(22, 200);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 31);
            this.lbloutput.TabIndex = 9;
            // 
            // simplecalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsquareroot);
            this.Controls.Add(this.btnsubtract);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnsquare);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtinput);
            this.Name = "simplecalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsquare;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btnsquareroot;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbloutput;
    }
}

