
namespace ATMService
{
    partial class HomeForm
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
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.gridTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckBalance.Location = new System.Drawing.Point(76, 140);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(113, 34);
            this.btnCheckBalance.TabIndex = 0;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM ";
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMiniStatement.Location = new System.Drawing.Point(352, 126);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(113, 34);
            this.btnMiniStatement.TabIndex = 2;
            this.btnMiniStatement.Text = "Balance History";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithDraw.Location = new System.Drawing.Point(675, 126);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(113, 34);
            this.btnWithDraw.TabIndex = 3;
            this.btnWithDraw.Text = "WithDraw";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeposit.Location = new System.Drawing.Point(519, 126);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(113, 34);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposite";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 307);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(126, 304);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(12, 226);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(66, 13);
            this.lblCardNumber.TabIndex = 7;
            this.lblCardNumber.Text = "CardNumber";
            this.lblCardNumber.Click += new System.EventHandler(this.lblCardNumber_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(126, 226);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCardNumber.TabIndex = 8;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // gridTransaction
            // 
            this.gridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransaction.Location = new System.Drawing.Point(425, 236);
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(349, 119);
            this.gridTransaction.TabIndex = 9;
            this.gridTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransaction_CellContentClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridTransaction);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckBalance);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.DataGridView gridTransaction;
    }
}