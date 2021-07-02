namespace ComboboxGUI
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
            this.cblist = new System.Windows.Forms.ComboBox();
            this.btLoadItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cblist
            // 
            this.cblist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cblist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cblist.FormattingEnabled = true;
            this.cblist.Location = new System.Drawing.Point(51, 175);
            this.cblist.Name = "cblist";
            this.cblist.Size = new System.Drawing.Size(212, 28);
            this.cblist.TabIndex = 0;
            this.cblist.SelectedIndexChanged += new System.EventHandler(this.cblist_SelectedIndexChanged);
            this.cblist.SelectedValueChanged += new System.EventHandler(this.cblist_SelectedValueChanged);
            // 
            // btLoadItems
            // 
            this.btLoadItems.Location = new System.Drawing.Point(51, 64);
            this.btLoadItems.Name = "btLoadItems";
            this.btLoadItems.Size = new System.Drawing.Size(113, 43);
            this.btLoadItems.TabIndex = 1;
            this.btLoadItems.Text = "Load Items";
            this.btLoadItems.UseVisualStyleBackColor = true;
            this.btLoadItems.Click += new System.EventHandler(this.btLoadItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 433);
            this.Controls.Add(this.btLoadItems);
            this.Controls.Add(this.cblist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cblist;
        private System.Windows.Forms.Button btLoadItems;
    }
}

