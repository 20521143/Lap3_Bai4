
namespace Lap3_Bai4
{
    partial class Sever
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
            this.btn_Listen = new System.Windows.Forms.Button();
            this.listView_Message = new System.Windows.Forms.ListView();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(694, 29);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen.TabIndex = 0;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // listView_Message
            // 
            this.listView_Message.HideSelection = false;
            this.listView_Message.Location = new System.Drawing.Point(21, 82);
            this.listView_Message.Name = "listView_Message";
            this.listView_Message.Size = new System.Drawing.Size(706, 356);
            this.listView_Message.TabIndex = 1;
            this.listView_Message.UseCompatibleStateImageBehavior = false;
            this.listView_Message.View = System.Windows.Forms.View.List;
            // 
            // txb_Message
            // 
            this.txb_Message.Location = new System.Drawing.Point(41, 13);
            this.txb_Message.Multiline = true;
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(624, 39);
            this.txb_Message.TabIndex = 2;
            this.txb_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.listView_Message);
            this.Controls.Add(this.btn_Listen);
            this.Name = "Sever";
            this.Text = "Sever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListView listView_Message;
        private System.Windows.Forms.TextBox txb_Message;
    }
}