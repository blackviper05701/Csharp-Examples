namespace UpdaterLibrary
{
    partial class UpdaterForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersions = new System.Windows.Forms.Label();
            this.rtxtbxDescription = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::UpdaterLibrary.Properties.Resources.updater;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersions
            // 
            this.lblVersions.Location = new System.Drawing.Point(104, 25);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(113, 41);
            this.lblVersions.TabIndex = 1;
            this.lblVersions.Text = "Version";
            // 
            // rtxtbxDescription
            // 
            this.rtxtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtbxDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtbxDescription.Location = new System.Drawing.Point(11, 130);
            this.rtxtbxDescription.Name = "rtxtbxDescription";
            this.rtxtbxDescription.ReadOnly = true;
            this.rtxtbxDescription.Size = new System.Drawing.Size(245, 50);
            this.rtxtbxDescription.TabIndex = 2;
            this.rtxtbxDescription.TabStop = false;
            this.rtxtbxDescription.Text = "";
            this.rtxtbxDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtbxDescription_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(82, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 32);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 227);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtxtbxDescription);
            this.Controls.Add(this.lblVersions);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdaterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdaterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersions;
        private System.Windows.Forms.RichTextBox rtxtbxDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;
    }
}