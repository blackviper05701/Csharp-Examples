namespace Delegates
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_review = new System.Windows.Forms.Button();
            this.txtBx_status = new System.Windows.Forms.TextBox();
            this.btn_process_file = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(294, 27);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(192, 55);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 26);
            this.textBox2.TabIndex = 2;
            // 
            // btn_review
            // 
            this.btn_review.Location = new System.Drawing.Point(294, 127);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(192, 55);
            this.btn_review.TabIndex = 3;
            this.btn_review.Text = "Review";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // txtBx_status
            // 
            this.txtBx_status.Location = new System.Drawing.Point(43, 141);
            this.txtBx_status.Name = "txtBx_status";
            this.txtBx_status.Size = new System.Drawing.Size(201, 26);
            this.txtBx_status.TabIndex = 4;
            this.txtBx_status.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_process_file
            // 
            this.btn_process_file.Location = new System.Drawing.Point(294, 211);
            this.btn_process_file.Name = "btn_process_file";
            this.btn_process_file.Size = new System.Drawing.Size(192, 55);
            this.btn_process_file.TabIndex = 5;
            this.btn_process_file.Text = "Process";
            this.btn_process_file.UseVisualStyleBackColor = true;
            this.btn_process_file.Click += new System.EventHandler(this.btn_process_file_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(588, 211);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(52, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Count";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(294, 297);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(192, 55);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Check For Updates";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btn_process_file);
            this.Controls.Add(this.txtBx_status);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.TextBox txtBx_status;
        private System.Windows.Forms.Button btn_process_file;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btn_update;
    }
}

