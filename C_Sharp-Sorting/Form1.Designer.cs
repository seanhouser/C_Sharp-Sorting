namespace C_Sharp_Sorting
{
    partial class frmMain
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.rtbPresort = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 39);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(451, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 23);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(326, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Please enter the list of numbers to be sorted, separated by a comma";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(469, 39);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Submit";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(12, 87);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "MergeSort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // rtbPresort
            // 
            this.rtbPresort.Location = new System.Drawing.Point(12, 335);
            this.rtbPresort.Name = "rtbPresort";
            this.rtbPresort.Size = new System.Drawing.Size(451, 20);
            this.rtbPresort.TabIndex = 4;
            this.rtbPresort.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 401);
            this.Controls.Add(this.rtbPresort);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmMain";
            this.Text = "C# Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.RichTextBox rtbPresort;
    }
}

