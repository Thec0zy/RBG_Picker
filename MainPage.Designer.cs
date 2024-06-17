namespace RBG_CG
{
    partial class MainPage
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
            this.cmdUpload = new System.Windows.Forms.Button();
            this.cmdPickColour = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUpload
            // 
            this.cmdUpload.BackColor = System.Drawing.Color.White;
            this.cmdUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.Location = new System.Drawing.Point(115, 127);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(156, 47);
            this.cmdUpload.TabIndex = 0;
            this.cmdUpload.Text = "Upload an Image";
            this.cmdUpload.UseVisualStyleBackColor = false;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // cmdPickColour
            // 
            this.cmdPickColour.BackColor = System.Drawing.Color.White;
            this.cmdPickColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPickColour.Location = new System.Drawing.Point(115, 347);
            this.cmdPickColour.Name = "cmdPickColour";
            this.cmdPickColour.Size = new System.Drawing.Size(156, 48);
            this.cmdPickColour.TabIndex = 1;
            this.cmdPickColour.Text = "Pick a colour";
            this.cmdPickColour.UseVisualStyleBackColor = false;
            this.cmdPickColour.Click += new System.EventHandler(this.cmdPickColour_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(298, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(303, 272);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // txtRGB
            // 
            this.txtRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGB.Location = new System.Drawing.Point(298, 347);
            this.txtRGB.Multiline = true;
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(159, 37);
            this.txtRGB.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RBG_CG.Properties.Resources.rgbcgbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 509);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cmdPickColour);
            this.Controls.Add(this.cmdUpload);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Button cmdPickColour;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtRGB;
    }
}