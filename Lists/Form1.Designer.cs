namespace Lists
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
            this.listBoxL = new System.Windows.Forms.ListBox();
            this.listBoxR = new System.Windows.Forms.ListBox();
            this.btnToR = new System.Windows.Forms.Button();
            this.btnToL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxL
            // 
            this.listBoxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxL.FormattingEnabled = true;
            this.listBoxL.ItemHeight = 16;
            this.listBoxL.Location = new System.Drawing.Point(54, 28);
            this.listBoxL.Name = "listBoxL";
            this.listBoxL.Size = new System.Drawing.Size(258, 388);
            this.listBoxL.TabIndex = 0;
            // 
            // listBoxR
            // 
            this.listBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxR.FormattingEnabled = true;
            this.listBoxR.ItemHeight = 16;
            this.listBoxR.Location = new System.Drawing.Point(483, 28);
            this.listBoxR.Name = "listBoxR";
            this.listBoxR.Size = new System.Drawing.Size(258, 388);
            this.listBoxR.TabIndex = 1;
            // 
            // btnToR
            // 
            this.btnToR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToR.Location = new System.Drawing.Point(349, 128);
            this.btnToR.Name = "btnToR";
            this.btnToR.Size = new System.Drawing.Size(98, 63);
            this.btnToR.TabIndex = 2;
            this.btnToR.Text = ">>";
            this.btnToR.UseVisualStyleBackColor = true;
            this.btnToR.Click += new System.EventHandler(this.ToTheRight);
            // 
            // btnToL
            // 
            this.btnToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToL.Location = new System.Drawing.Point(349, 273);
            this.btnToL.Name = "btnToL";
            this.btnToL.Size = new System.Drawing.Size(98, 63);
            this.btnToL.TabIndex = 3;
            this.btnToL.Text = "<<";
            this.btnToL.UseVisualStyleBackColor = true;
            this.btnToL.Click += new System.EventHandler(this.ToTheLeft);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btnToL);
            this.Controls.Add(this.btnToR);
            this.Controls.Add(this.listBoxR);
            this.Controls.Add(this.listBoxL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxL;
        private System.Windows.Forms.ListBox listBoxR;
        private System.Windows.Forms.Button btnToR;
        private System.Windows.Forms.Button btnToL;
    }
}

