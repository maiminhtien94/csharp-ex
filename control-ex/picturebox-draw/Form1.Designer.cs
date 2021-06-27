namespace picturebox_draw
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
            this.ptDraw = new System.Windows.Forms.PictureBox();
            this.btCircle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // ptDraw
            // 
            this.ptDraw.BackColor = System.Drawing.Color.Black;
            this.ptDraw.Location = new System.Drawing.Point(42, 33);
            this.ptDraw.Name = "ptDraw";
            this.ptDraw.Size = new System.Drawing.Size(812, 454);
            this.ptDraw.TabIndex = 0;
            this.ptDraw.TabStop = false;
            // 
            // btCircle
            // 
            this.btCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCircle.Location = new System.Drawing.Point(990, 53);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(126, 78);
            this.btCircle.TabIndex = 1;
            this.btCircle.Text = "Line";
            this.btCircle.UseVisualStyleBackColor = true;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 583);
            this.Controls.Add(this.btCircle);
            this.Controls.Add(this.ptDraw);
            this.Name = "Form1";
            this.Text = "Drawing Form";
            ((System.ComponentModel.ISupportInitialize)(this.ptDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptDraw;
        private System.Windows.Forms.Button btCircle;
    }
}

