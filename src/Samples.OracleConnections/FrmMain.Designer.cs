namespace Samples.OracleConnections
{
    partial class FrmMain
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.TimeOut = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnConnectionAll = new System.Windows.Forms.Button();
            this.InitialCatalog = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.DataSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnShow);
            this.pnTop.Controls.Add(this.TimeOut);
            this.pnTop.Controls.Add(this.btnConnect);
            this.pnTop.Controls.Add(this.btnConnectionAll);
            this.pnTop.Controls.Add(this.InitialCatalog);
            this.pnTop.Controls.Add(this.Password);
            this.pnTop.Controls.Add(this.UserId);
            this.pnTop.Controls.Add(this.DataSource);
            this.pnTop.Controls.Add(this.label7);
            this.pnTop.Controls.Add(this.label4);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(660, 124);
            this.pnTop.TabIndex = 12;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(470, 85);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 27);
            this.btnShow.TabIndex = 26;
            this.btnShow.Text = "Show Log";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShowClick);
            // 
            // TimeOut
            // 
            this.TimeOut.Location = new System.Drawing.Point(549, 15);
            this.TimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.TimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.Size = new System.Drawing.Size(62, 25);
            this.TimeOut.TabIndex = 25;
            this.TimeOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(11, 85);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(146, 27);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Add connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
            // 
            // btnConnectionAll
            // 
            this.btnConnectionAll.Location = new System.Drawing.Point(178, 85);
            this.btnConnectionAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectionAll.Name = "btnConnectionAll";
            this.btnConnectionAll.Size = new System.Drawing.Size(129, 26);
            this.btnConnectionAll.TabIndex = 23;
            this.btnConnectionAll.Text = "Disconnect All";
            this.btnConnectionAll.UseVisualStyleBackColor = true;
            this.btnConnectionAll.Click += new System.EventHandler(this.BtnConnectionAllClick);
            // 
            // InitialCatalog
            // 
            this.InitialCatalog.Location = new System.Drawing.Point(297, 39);
            this.InitialCatalog.Margin = new System.Windows.Forms.Padding(2);
            this.InitialCatalog.Name = "InitialCatalog";
            this.InitialCatalog.Size = new System.Drawing.Size(97, 25);
            this.InitialCatalog.TabIndex = 20;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(86, 38);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(98, 25);
            this.Password.TabIndex = 19;
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(86, 16);
            this.UserId.Margin = new System.Windows.Forms.Padding(2);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(98, 25);
            this.UserId.TabIndex = 13;
            // 
            // DataSource
            // 
            this.DataSource.Location = new System.Drawing.Point(297, 15);
            this.DataSource.Margin = new System.Windows.Forms.Padding(2);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(97, 25);
            this.DataSource.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Connection Timeout";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Initial Catalog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "DataSource";
            // 
            // Output
            // 
            this.Output.AcceptsReturn = true;
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(0, 129);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(660, 192);
            this.Output.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 321);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Oracle Connections - Sample -";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.NumericUpDown TimeOut;
        private System.Windows.Forms.Panel pnTop;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DataSource;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox InitialCatalog;
        private System.Windows.Forms.Button btnConnectionAll;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button btnShow;
    }
}

