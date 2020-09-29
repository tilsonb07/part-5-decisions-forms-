namespace part_5_decisions__forms_
{
    partial class frmRandomDivisible
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxAnswer = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 13);
            this.lblInstructions.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtboxAnswer
            // 
            this.txtboxAnswer.Location = new System.Drawing.Point(12, 40);
            this.txtboxAnswer.Name = "txtboxAnswer";
            this.txtboxAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtboxAnswer.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(93, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // frmRandomDivisible
            // 
            this.ClientSize = new System.Drawing.Size(832, 517);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtboxAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmRandomDivisible";
            this.Text = "Random Divisible!";
            this.Load += new System.EventHandler(this.frmRandomDivisible_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxAnswer;
        private System.Windows.Forms.Label lblResult;
    }
}

