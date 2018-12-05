namespace WindowsFormsApp
{
    partial class MainForm
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
            this.btnDisplayMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplayMessage
            // 
            this.btnDisplayMessage.Location = new System.Drawing.Point(160, 35);
            this.btnDisplayMessage.Name = "btnDisplayMessage";
            this.btnDisplayMessage.Size = new System.Drawing.Size(150, 23);
            this.btnDisplayMessage.TabIndex = 0;
            this.btnDisplayMessage.Text = "Display Message";
            this.btnDisplayMessage.UseVisualStyleBackColor = true;
            this.btnDisplayMessage.Click += new System.EventHandler(this.btnDisplayMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(37, 93);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(400, 101);
            this.txtMessage.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 229);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnDisplayMessage);
            this.Name = "MainForm";
            this.Text = "Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

