
namespace Discord_Multi_Instance_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.run_discord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // run_discord
            // 
            this.run_discord.Location = new System.Drawing.Point(12, 13);
            this.run_discord.Name = "run_discord";
            this.run_discord.Size = new System.Drawing.Size(463, 89);
            this.run_discord.TabIndex = 0;
            this.run_discord.Text = "ディスコード多重起動";
            this.run_discord.UseVisualStyleBackColor = true;
            this.run_discord.Click += new System.EventHandler(this._run_discord);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 115);
            this.Controls.Add(this.run_discord);
            this.Name = "Form1";
            this.Text = "Discord Multi Instance Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button run_discord;
    }
}

