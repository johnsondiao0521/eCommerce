namespace WindowForm
{
    partial class ChildFrm
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
            this.btnChild = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(190, 45);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(75, 23);
            this.btnChild.TabIndex = 0;
            this.btnChild.Text = "传值到父窗口";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(39, 46);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 21);
            this.txtMsg.TabIndex = 1;
            // 
            // ChildFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnChild);
            this.Name = "ChildFrm";
            this.Text = "ChildFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.TextBox txtMsg;
    }
}