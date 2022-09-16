namespace Pracownicy.Controls
{
    partial class Status
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.message.Location = new System.Drawing.Point(25, 65);
            this.message.Margin = new System.Windows.Forms.Padding(0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(77, 20);
            this.message.TabIndex = 0;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.message);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Status";
            this.Size = new System.Drawing.Size(200, 100);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Status_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
    }
}
