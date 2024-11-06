namespace csharp_2_4
{
    partial class Form1
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.goTop = new System.Windows.Forms.Button();
            this.goRight = new System.Windows.Forms.Button();
            this.goLeft = new System.Windows.Forms.Button();
            this.gotDown = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = global::csharp_2_4.Properties.Resources.eliaschen;
            this.picture.Location = new System.Drawing.Point(21, 22);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 200);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // goTop
            // 
            this.goTop.Font = new System.Drawing.Font("新細明體", 16F);
            this.goTop.Location = new System.Drawing.Point(138, 297);
            this.goTop.Name = "goTop";
            this.goTop.Size = new System.Drawing.Size(65, 46);
            this.goTop.TabIndex = 1;
            this.goTop.Text = "上";
            this.goTop.UseVisualStyleBackColor = true;
            // 
            // goRight
            // 
            this.goRight.Font = new System.Drawing.Font("新細明體", 16F);
            this.goRight.Location = new System.Drawing.Point(209, 349);
            this.goRight.Name = "goRight";
            this.goRight.Size = new System.Drawing.Size(65, 46);
            this.goRight.TabIndex = 2;
            this.goRight.Text = "右";
            this.goRight.UseVisualStyleBackColor = true;
            // 
            // goLeft
            // 
            this.goLeft.Font = new System.Drawing.Font("新細明體", 16F);
            this.goLeft.Location = new System.Drawing.Point(68, 349);
            this.goLeft.Name = "goLeft";
            this.goLeft.Size = new System.Drawing.Size(65, 46);
            this.goLeft.TabIndex = 3;
            this.goLeft.Text = "左";
            this.goLeft.UseVisualStyleBackColor = true;
            // 
            // gotDown
            // 
            this.gotDown.Font = new System.Drawing.Font("新細明體", 16F);
            this.gotDown.Location = new System.Drawing.Point(138, 400);
            this.gotDown.Name = "gotDown";
            this.gotDown.Size = new System.Drawing.Size(65, 46);
            this.gotDown.TabIndex = 4;
            this.gotDown.Text = "下";
            this.gotDown.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("新細明體", 16F);
            this.reset.Location = new System.Drawing.Point(309, 346);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(152, 53);
            this.reset.TabIndex = 5;
            this.reset.Text = "表單左上角";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // zoomOut
            // 
            this.zoomOut.Font = new System.Drawing.Font("新細明體", 16F);
            this.zoomOut.Location = new System.Drawing.Point(502, 393);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(94, 53);
            this.zoomOut.TabIndex = 6;
            this.zoomOut.Text = "縮小";
            this.zoomOut.UseVisualStyleBackColor = true;
            // 
            // zoomIn
            // 
            this.zoomIn.Font = new System.Drawing.Font("新細明體", 16F);
            this.zoomIn.Location = new System.Drawing.Point(502, 297);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(94, 53);
            this.zoomIn.TabIndex = 7;
            this.zoomIn.Text = "放大";
            this.zoomIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 521);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.gotDown);
            this.Controls.Add(this.goLeft);
            this.Controls.Add(this.goRight);
            this.Controls.Add(this.goTop);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button goTop;
        private System.Windows.Forms.Button goRight;
        private System.Windows.Forms.Button goLeft;
        private System.Windows.Forms.Button gotDown;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button zoomIn;
    }
}

