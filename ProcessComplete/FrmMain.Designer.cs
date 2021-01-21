
namespace ProcessComplete
{
    partial class FrmMain
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
            this.processComlete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processComlete
            // 
            this.processComlete.Location = new System.Drawing.Point(12, 12);
            this.processComlete.Name = "processComlete";
            this.processComlete.Size = new System.Drawing.Size(138, 23);
            this.processComlete.TabIndex = 1;
            this.processComlete.Text = "Process Comlete";
            this.processComlete.UseVisualStyleBackColor = true;
            this.processComlete.Click += new System.EventHandler(this.processComlete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processComlete);
            this.Name = "FrmMain";
            this.Text = "Frm Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processComlete;
    }
}

