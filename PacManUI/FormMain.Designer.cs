﻿
namespace PacManUI
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelPointThreshold = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(2076, 475);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 82);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ticker
            // 
            this.ticker.Interval = 200;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(2076, 628);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 82);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(2120, 83);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(84, 21);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "得分：0";
            // 
            // labelPointThreshold
            // 
            this.labelPointThreshold.AutoSize = true;
            this.labelPointThreshold.Location = new System.Drawing.Point(2120, 144);
            this.labelPointThreshold.Name = "labelPointThreshold";
            this.labelPointThreshold.Size = new System.Drawing.Size(115, 21);
            this.labelPointThreshold.TabIndex = 4;
            this.labelPointThreshold.Text = "目标分数：\r\n";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(2120, 210);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(73, 21);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "关卡：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2408, 1002);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelPointThreshold);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelPointThreshold;
        private System.Windows.Forms.Label labelLevel;
    }
}

