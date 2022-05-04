
namespace Lap3_Bai4
{
    partial class Client
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
            this.listView_Message = new System.Windows.Forms.ListView();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Mesage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Message
            // 
            this.listView_Message.HideSelection = false;
            this.listView_Message.Location = new System.Drawing.Point(21, 12);
            this.listView_Message.Name = "listView_Message";
            this.listView_Message.Size = new System.Drawing.Size(767, 281);
            this.listView_Message.TabIndex = 0;
            this.listView_Message.UseCompatibleStateImageBehavior = false;
            this.listView_Message.View = System.Windows.Forms.View.List;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(42, 314);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(228, 22);
            this.txb_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // txb_Mesage
            // 
            this.txb_Mesage.Location = new System.Drawing.Point(12, 358);
            this.txb_Mesage.Multiline = true;
            this.txb_Mesage.Name = "txb_Mesage";
            this.txb_Mesage.Size = new System.Drawing.Size(595, 80);
            this.txb_Mesage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(644, 371);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 67);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txb_Mesage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.listView_Message);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Message;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Mesage;
        private System.Windows.Forms.Button btnSend;
    }
}