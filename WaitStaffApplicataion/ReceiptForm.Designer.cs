namespace WaitStaffApplicataion
{
    partial class ReceiptForm
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
            this.ReceiptView = new System.Windows.Forms.TextBox();
            this.TipView = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Button();
            this.FinReciept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiptView
            // 
            this.ReceiptView.Location = new System.Drawing.Point(12, 12);
            this.ReceiptView.Multiline = true;
            this.ReceiptView.Name = "ReceiptView";
            this.ReceiptView.Size = new System.Drawing.Size(206, 487);
            this.ReceiptView.TabIndex = 0;
            // 
            // TipView
            // 
            this.TipView.Location = new System.Drawing.Point(256, 12);
            this.TipView.Name = "TipView";
            this.TipView.Size = new System.Drawing.Size(327, 20);
            this.TipView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip:";
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(395, 38);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(90, 51);
            this.Card.TabIndex = 3;
            this.Card.Text = "Card";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(491, 38);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(92, 51);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // FinReciept
            // 
            this.FinReciept.Location = new System.Drawing.Point(934, 448);
            this.FinReciept.Name = "FinReciept";
            this.FinReciept.Size = new System.Drawing.Size(92, 51);
            this.FinReciept.TabIndex = 5;
            this.FinReciept.Text = "Finish Receipt";
            this.FinReciept.UseVisualStyleBackColor = true;
            this.FinReciept.UseWaitCursor = true;
            this.FinReciept.Visible = false;
            this.FinReciept.Click += new System.EventHandler(this.FinReciept_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 511);
            this.Controls.Add(this.FinReciept);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipView);
            this.Controls.Add(this.ReceiptView);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiptView;
        private System.Windows.Forms.TextBox TipView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Card;
        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.Button FinReciept;
    }
}