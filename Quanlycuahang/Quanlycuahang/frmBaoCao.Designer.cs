
namespace Quanlycuahang
{
    partial class frmBaoCao
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
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Location = new System.Drawing.Point(-3, 119);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(803, 331);
            this.rpvBaoCao.TabIndex = 0;
            this.rpvBaoCao.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày sản xuất : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin sản phẩm :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(154, 34);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySanXuat.TabIndex = 3;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(386, 32);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(111, 25);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Tạo mới báo cáo ";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông tin chi tiết sản phẩm :";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.dtpNgaySanXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvBaoCao);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label3;
    }
}