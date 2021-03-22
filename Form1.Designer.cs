
namespace Fsearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.textbox_url = new System.Windows.Forms.TextBox();
            this.button_url = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(702, 401);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // textbox_url
            // 
            this.textbox_url.Location = new System.Drawing.Point(156, 25);
            this.textbox_url.Name = "textbox_url";
            this.textbox_url.Size = new System.Drawing.Size(486, 23);
            this.textbox_url.TabIndex = 2;
            // 
            // button_url
            // 
            this.button_url.Location = new System.Drawing.Point(75, 24);
            this.button_url.Name = "button_url";
            this.button_url.Size = new System.Drawing.Size(75, 23);
            this.button_url.TabIndex = 3;
            this.button_url.Text = "Выбор";
            this.button_url.UseVisualStyleBackColor = true;
            this.button_url.Click += new System.EventHandler(this.button_url_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 65);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(765, 330);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_url);
            this.Controls.Add(this.textbox_url);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FSearch";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox textbox_url;
        private System.Windows.Forms.Button button_url;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

