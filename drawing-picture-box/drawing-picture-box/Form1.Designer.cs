namespace drawing_picture_box
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
            this.btnline = new System.Windows.Forms.Button();
            this.btncircle = new System.Windows.Forms.Button();
            this.btnelip = new System.Windows.Forms.Button();
            this.btnstring = new System.Windows.Forms.Button();
            this.ptdraw = new System.Windows.Forms.PictureBox();
            this.btRectangle = new System.Windows.Forms.Button();
            this.btRotate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnline
            // 
            this.btnline.Location = new System.Drawing.Point(1066, 66);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(129, 49);
            this.btnline.TabIndex = 0;
            this.btnline.Text = "LINE";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btncircle
            // 
            this.btncircle.Location = new System.Drawing.Point(1066, 148);
            this.btncircle.Name = "btncircle";
            this.btncircle.Size = new System.Drawing.Size(129, 49);
            this.btncircle.TabIndex = 1;
            this.btncircle.Text = "CIRCLE";
            this.btncircle.UseVisualStyleBackColor = true;
            this.btncircle.Click += new System.EventHandler(this.btncircle_Click);
            // 
            // btnelip
            // 
            this.btnelip.Location = new System.Drawing.Point(1066, 245);
            this.btnelip.Name = "btnelip";
            this.btnelip.Size = new System.Drawing.Size(129, 49);
            this.btnelip.TabIndex = 2;
            this.btnelip.Text = "ELLIP";
            this.btnelip.UseVisualStyleBackColor = true;
            this.btnelip.Click += new System.EventHandler(this.btnelip_Click);
            // 
            // btnstring
            // 
            this.btnstring.Location = new System.Drawing.Point(1066, 337);
            this.btnstring.Name = "btnstring";
            this.btnstring.Size = new System.Drawing.Size(129, 49);
            this.btnstring.TabIndex = 3;
            this.btnstring.Text = "STRING";
            this.btnstring.UseVisualStyleBackColor = true;
            this.btnstring.Click += new System.EventHandler(this.btnstring_Click);
            // 
            // ptdraw
            // 
            this.ptdraw.BackColor = System.Drawing.Color.Black;
            this.ptdraw.Location = new System.Drawing.Point(61, 60);
            this.ptdraw.Name = "ptdraw";
            this.ptdraw.Size = new System.Drawing.Size(946, 600);
            this.ptdraw.TabIndex = 4;
            this.ptdraw.TabStop = false;
            // 
            // btRectangle
            // 
            this.btRectangle.Location = new System.Drawing.Point(1066, 427);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(129, 49);
            this.btRectangle.TabIndex = 5;
            this.btRectangle.Text = "RECTANGLE";
            this.btRectangle.UseVisualStyleBackColor = true;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // btRotate
            // 
            this.btRotate.Location = new System.Drawing.Point(1066, 519);
            this.btRotate.Name = "btRotate";
            this.btRotate.Size = new System.Drawing.Size(129, 49);
            this.btRotate.TabIndex = 6;
            this.btRotate.Text = "ROTATE 10";
            this.btRotate.UseVisualStyleBackColor = true;
            this.btRotate.Click += new System.EventHandler(this.btRotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 944);
            this.Controls.Add(this.btRotate);
            this.Controls.Add(this.btRectangle);
            this.Controls.Add(this.ptdraw);
            this.Controls.Add(this.btnstring);
            this.Controls.Add(this.btnelip);
            this.Controls.Add(this.btncircle);
            this.Controls.Add(this.btnline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptdraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btncircle;
        private System.Windows.Forms.Button btnelip;
        private System.Windows.Forms.Button btnstring;
        private System.Windows.Forms.PictureBox ptdraw;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btRotate;
    }
}

