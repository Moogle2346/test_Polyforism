
namespace test211016_Polyforism
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
            this.TB_Notice = new System.Windows.Forms.TextBox();
            this.btn_Print_A = new System.Windows.Forms.Button();
            this.btn_Print_B = new System.Windows.Forms.Button();
            this.btn_Print_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Notice
            // 
            this.TB_Notice.Location = new System.Drawing.Point(12, 12);
            this.TB_Notice.Multiline = true;
            this.TB_Notice.Name = "TB_Notice";
            this.TB_Notice.Size = new System.Drawing.Size(406, 308);
            this.TB_Notice.TabIndex = 0;
            // 
            // btn_Print_A
            // 
            this.btn_Print_A.Location = new System.Drawing.Point(424, 12);
            this.btn_Print_A.Name = "btn_Print_A";
            this.btn_Print_A.Size = new System.Drawing.Size(149, 51);
            this.btn_Print_A.TabIndex = 1;
            this.btn_Print_A.Text = "Type A";
            this.btn_Print_A.UseVisualStyleBackColor = true;
            this.btn_Print_A.Click += new System.EventHandler(this.btn_Print_A_Click);
            // 
            // btn_Print_B
            // 
            this.btn_Print_B.Location = new System.Drawing.Point(424, 69);
            this.btn_Print_B.Name = "btn_Print_B";
            this.btn_Print_B.Size = new System.Drawing.Size(149, 51);
            this.btn_Print_B.TabIndex = 2;
            this.btn_Print_B.Text = "Type B";
            this.btn_Print_B.UseVisualStyleBackColor = true;
            this.btn_Print_B.Click += new System.EventHandler(this.btn_Print_B_Click);
            // 
            // btn_Print_C
            // 
            this.btn_Print_C.Location = new System.Drawing.Point(424, 126);
            this.btn_Print_C.Name = "btn_Print_C";
            this.btn_Print_C.Size = new System.Drawing.Size(149, 51);
            this.btn_Print_C.TabIndex = 3;
            this.btn_Print_C.Text = "Type C";
            this.btn_Print_C.UseVisualStyleBackColor = true;
            this.btn_Print_C.Click += new System.EventHandler(this.btn_Print_C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 332);
            this.Controls.Add(this.btn_Print_C);
            this.Controls.Add(this.btn_Print_B);
            this.Controls.Add(this.btn_Print_A);
            this.Controls.Add(this.TB_Notice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Notice;
        private System.Windows.Forms.Button btn_Print_A;
        private System.Windows.Forms.Button btn_Print_B;
        private System.Windows.Forms.Button btn_Print_C;
    }
}

