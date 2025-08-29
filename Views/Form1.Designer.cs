namespace CuaHangMayTinh.Views
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
            this.labelForm1 = new System.Windows.Forms.Label();
            this.buttonForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm1
            // 
            this.labelForm1.AutoSize = true;
            this.labelForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.labelForm1.Location = new System.Drawing.Point(55, 9);
            this.labelForm1.Name = "labelForm1";
            this.labelForm1.Size = new System.Drawing.Size(118, 39);
            this.labelForm1.TabIndex = 0;
            this.labelForm1.Text = "Form1";
            // 
            // buttonForm1
            // 
            this.buttonForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonForm1.Location = new System.Drawing.Point(62, 51);
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Size = new System.Drawing.Size(192, 58);
            this.buttonForm1.TabIndex = 1;
            this.buttonForm1.Text = "ButtonForm1";
            this.buttonForm1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonForm1);
            this.Controls.Add(this.labelForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm1;
        private System.Windows.Forms.Button buttonForm1;
    }
}