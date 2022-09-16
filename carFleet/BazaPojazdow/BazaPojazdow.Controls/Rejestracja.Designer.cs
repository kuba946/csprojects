namespace BazaPojazdow.Controls
{
    partial class Rejestracja
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.textboxValue = new System.Windows.Forms.TextBox();
            this.validation = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(15, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(112, 17);
            this.title.TabIndex = 0;
            this.title.Text = "Nr Rejestracyjny";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxValue
            // 
            this.textboxValue.Location = new System.Drawing.Point(10, 60);
            this.textboxValue.Name = "textboxValue";
            this.textboxValue.Size = new System.Drawing.Size(180, 22);
            this.textboxValue.TabIndex = 1;
            // 
            // validation
            // 
            this.validation.ForeColor = System.Drawing.Color.OrangeRed;
            this.validation.Location = new System.Drawing.Point(10, 90);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(180, 17);
            this.validation.TabIndex = 2;
            this.validation.Text = "Error Message";
            this.validation.Visible = false;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.validation);
            this.Controls.Add(this.textboxValue);
            this.Controls.Add(this.title);
            this.Name = "Rejestracja";
            this.Size = new System.Drawing.Size(200, 130);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textboxValue;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label validation;
    }
}
