
namespace DataGridView
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtGV_Menu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_PrdNa = new System.Windows.Forms.TextBox();
            this.tbx_PrdPr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "[飲品清單]";
            // 
            // dtGV_Menu
            // 
            this.dtGV_Menu.AllowUserToAddRows = false;
            this.dtGV_Menu.AllowUserToDeleteRows = false;
            this.dtGV_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtGV_Menu.Location = new System.Drawing.Point(30, 82);
            this.dtGV_Menu.Name = "dtGV_Menu";
            this.dtGV_Menu.ReadOnly = true;
            this.dtGV_Menu.RowTemplate.Height = 24;
            this.dtGV_Menu.Size = new System.Drawing.Size(279, 294);
            this.dtGV_Menu.TabIndex = 1;
            this.dtGV_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Menu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "飲品名稱";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "建議售價";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "品名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "價格：";
            // 
            // tbx_PrdNa
            // 
            this.tbx_PrdNa.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_PrdNa.Location = new System.Drawing.Point(96, 413);
            this.tbx_PrdNa.Name = "tbx_PrdNa";
            this.tbx_PrdNa.ReadOnly = true;
            this.tbx_PrdNa.Size = new System.Drawing.Size(133, 33);
            this.tbx_PrdNa.TabIndex = 3;
            // 
            // tbx_PrdPr
            // 
            this.tbx_PrdPr.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_PrdPr.Location = new System.Drawing.Point(96, 472);
            this.tbx_PrdPr.Name = "tbx_PrdPr";
            this.tbx_PrdPr.ReadOnly = true;
            this.tbx_PrdPr.Size = new System.Drawing.Size(133, 33);
            this.tbx_PrdPr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(242, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "元";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 638);
            this.ControlBox = false;
            this.Controls.Add(this.tbx_PrdPr);
            this.Controls.Add(this.tbx_PrdNa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGV_Menu);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "飲料選購單";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGV_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_PrdNa;
        private System.Windows.Forms.TextBox tbx_PrdPr;
        private System.Windows.Forms.Label label4;
    }
}

