
namespace Lap3_Bai4
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
            this.bn_Sever = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_Sever
            // 
            this.bn_Sever.Location = new System.Drawing.Point(118, 128);
            this.bn_Sever.Name = "bn_Sever";
            this.bn_Sever.Size = new System.Drawing.Size(211, 88);
            this.bn_Sever.TabIndex = 0;
            this.bn_Sever.Text = "Sever";
            this.bn_Sever.UseVisualStyleBackColor = true;
            this.bn_Sever.Click += new System.EventHandler(this.bn_Sever_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(379, 128);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(158, 88);
            this.btn_Client.TabIndex = 1;
            this.btn_Client.Text = "Client";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.bn_Sever);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Sever;
        private System.Windows.Forms.Button btn_Client;
    }
}

