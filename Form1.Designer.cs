
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
            this.find_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.textbox_url = new System.Windows.Forms.TextBox();
            this.button_url = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1_KW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_search_into = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(652, 26);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(124, 52);
            this.find_button.TabIndex = 0;
            this.find_button.Text = "3. Запустить поиск файлов";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(356, 464);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "4. Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // textbox_url
            // 
            this.textbox_url.Location = new System.Drawing.Point(143, 42);
            this.textbox_url.Name = "textbox_url";
            this.textbox_url.Size = new System.Drawing.Size(486, 23);
            this.textbox_url.TabIndex = 2;
            // 
            // button_url
            // 
            this.button_url.Location = new System.Drawing.Point(12, 42);
            this.button_url.Name = "button_url";
            this.button_url.Size = new System.Drawing.Size(123, 23);
            this.button_url.TabIndex = 3;
            this.button_url.Text = "2. Выберите путь:";
            this.button_url.UseVisualStyleBackColor = true;
            this.button_url.Click += new System.EventHandler(this.button_url_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(44, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 304);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1_KW
            // 
            this.textBox1_KW.Location = new System.Drawing.Point(177, 10);
            this.textBox1_KW.Name = "textBox1_KW";
            this.textBox1_KW.Size = new System.Drawing.Size(114, 23);
            this.textBox1_KW.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Введите ключевую фразу";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(437, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 303);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Здесь будет текст файла....";
            // 
            // button_search_into
            // 
            this.button_search_into.Location = new System.Drawing.Point(652, 84);
            this.button_search_into.Name = "button_search_into";
            this.button_search_into.Size = new System.Drawing.Size(124, 52);
            this.button_search_into.TabIndex = 8;
            this.button_search_into.Text = "3. Запустить поиск внутри файлов";
            this.button_search_into.UseVisualStyleBackColor = true;
            this.button_search_into.Click += new System.EventHandler(this.button_search_into_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.button_search_into);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_KW);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_url);
            this.Controls.Add(this.textbox_url);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.find_button);
            this.Name = "Form1";
            this.Text = "FSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox textbox_url;
        private System.Windows.Forms.Button button_url;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1_KW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_search_into;
    }
}

