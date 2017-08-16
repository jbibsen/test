namespace ping
{
    partial class Form1
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
            this.BT_Ping = new System.Windows.Forms.Button();
            this.TB_Ping = new System.Windows.Forms.TextBox();
            this.LB_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Ping
            // 
            this.BT_Ping.Location = new System.Drawing.Point(25, 99);
            this.BT_Ping.Name = "BT_Ping";
            this.BT_Ping.Size = new System.Drawing.Size(123, 43);
            this.BT_Ping.TabIndex = 0;
            this.BT_Ping.Text = "Ping IP or DNS";
            this.BT_Ping.UseVisualStyleBackColor = true;
            this.BT_Ping.Click += new System.EventHandler(this.BT_Ping_Click);
            // 
            // TB_Ping
            // 
            this.TB_Ping.Location = new System.Drawing.Point(25, 61);
            this.TB_Ping.Name = "TB_Ping";
            this.TB_Ping.Size = new System.Drawing.Size(227, 20);
            this.TB_Ping.TabIndex = 1;
            // 
            // LB_Message
            // 
            this.LB_Message.AutoSize = true;
            this.LB_Message.Location = new System.Drawing.Point(22, 30);
            this.LB_Message.Name = "LB_Message";
            this.LB_Message.Size = new System.Drawing.Size(0, 13);
            this.LB_Message.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 165);
            this.Controls.Add(this.LB_Message);
            this.Controls.Add(this.TB_Ping);
            this.Controls.Add(this.BT_Ping);
            this.Name = "Form1";
            this.Text = "Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Ping;
        private System.Windows.Forms.TextBox TB_Ping;
        private System.Windows.Forms.Label LB_Message;
    }
}

