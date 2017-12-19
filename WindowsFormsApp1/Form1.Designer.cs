namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myButton3 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton2 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton1 = new WindowsFormsControlLibrary1.MyButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 182);
            this.dataGridView1.TabIndex = 3;
            // 
            // myButton3
            // 
            this.myButton3.FillColor1 = System.Drawing.Color.Orange;
            this.myButton3.FillColor2 = System.Drawing.Color.Gray;
            this.myButton3.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton3.Location = new System.Drawing.Point(67, 230);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(168, 122);
            this.myButton3.TabIndex = 2;
            this.myButton3.Text = "myButton3";
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton2
            // 
            this.myButton2.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.myButton2.FillColor2 = System.Drawing.Color.White;
            this.myButton2.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Rectangle;
            this.myButton2.Location = new System.Drawing.Point(89, 140);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(108, 54);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "myButton2";
            // 
            // myButton1
            // 
            this.myButton1.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.myButton1.FillColor2 = System.Drawing.Color.White;
            this.myButton1.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton1.Location = new System.Drawing.Point(89, 51);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(108, 54);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(269, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(587, 225);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 525);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.MyButton myButton1;
        private WindowsFormsControlLibrary1.MyButton myButton2;
        private WindowsFormsControlLibrary1.MyButton myButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

