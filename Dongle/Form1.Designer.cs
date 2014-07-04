namespace Dongle
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.encrypt_b = new System.Windows.Forms.Button();
            this.decrypt_b = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // encrypt_b
            // 
            this.encrypt_b.Location = new System.Drawing.Point(12, 12);
            this.encrypt_b.Name = "encrypt_b";
            this.encrypt_b.Size = new System.Drawing.Size(166, 56);
            this.encrypt_b.TabIndex = 0;
            this.encrypt_b.Text = "Encrypt";
            this.encrypt_b.UseVisualStyleBackColor = true;
            this.encrypt_b.Click += new System.EventHandler(this.encrypt_b_Click);
            // 
            // decrypt_b
            // 
            this.decrypt_b.AllowDrop = true;
            this.decrypt_b.Location = new System.Drawing.Point(12, 81);
            this.decrypt_b.Name = "decrypt_b";
            this.decrypt_b.Size = new System.Drawing.Size(166, 56);
            this.decrypt_b.TabIndex = 1;
            this.decrypt_b.Text = "Decrypt";
            this.decrypt_b.UseVisualStyleBackColor = true;
            this.decrypt_b.Click += new System.EventHandler(this.decrypt_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 149);
            this.Controls.Add(this.decrypt_b);
            this.Controls.Add(this.encrypt_b);
            this.Name = "Form1";
            this.Text = "Dongle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encrypt_b;
        private System.Windows.Forms.Button decrypt_b;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

