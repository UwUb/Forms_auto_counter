
namespace WindowsFormsApp1
{
    partial class Form_First
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DarkSoul = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DarkSoul
            // 
            this.DarkSoul.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DarkSoul.Location = new System.Drawing.Point(215, 159);
            this.DarkSoul.Name = "DarkSoul";
            this.DarkSoul.Size = new System.Drawing.Size(399, 62);
            this.DarkSoul.TabIndex = 0;
            this.DarkSoul.Text = "自動(手動)計數器";
            this.DarkSoul.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(348, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "開始計數";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DarkSoul);
            this.Name = "Form_First";
            this.Text = "Form_First";
            this.Load += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DarkSoul;
        private System.Windows.Forms.Button button6;
    }
}

