namespace dziedzczenie
{
    partial class start
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
            this.btnInherit = new System.Windows.Forms.Button();
            this.btnParent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInherit
            // 
            this.btnInherit.Location = new System.Drawing.Point(58, 52);
            this.btnInherit.Name = "btnInherit";
            this.btnInherit.Size = new System.Drawing.Size(75, 23);
            this.btnInherit.TabIndex = 0;
            this.btnInherit.Text = "Inherint";
            this.btnInherit.UseVisualStyleBackColor = true;
            this.btnInherit.Click += new System.EventHandler(this.btnInherit_Click);
            // 
            // btnParent
            // 
            this.btnParent.Location = new System.Drawing.Point(58, 133);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(75, 23);
            this.btnParent.TabIndex = 1;
            this.btnParent.Text = "Parent";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.btnInherit);
            this.Name = "start";
            this.Text = "start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInherit;
        private System.Windows.Forms.Button btnParent;
    }
}