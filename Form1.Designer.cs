﻿namespace Example1
{
    partial class lblDateTime
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ldlDateTime = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ldlDateTime
            // 
            this.ldlDateTime.AutoSize = true;
            this.ldlDateTime.Location = new System.Drawing.Point(37, 33);
            this.ldlDateTime.Name = "ldlDateTime";
            this.ldlDateTime.Size = new System.Drawing.Size(29, 12);
            this.ldlDateTime.TabIndex = 0;
            this.ldlDateTime.Text = "lebel";
            this.ldlDateTime.Click += new System.EventHandler(this.ldlDateTime_Click);
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(98, 193);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 1;
            this.btnExec.Text = "日時取得";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // lblDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.ldlDateTime);
            this.Name = "lblDateTime";
            this.Text = "現在の日時表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlDateTime;
        private System.Windows.Forms.Button btnExec;
    }
}
