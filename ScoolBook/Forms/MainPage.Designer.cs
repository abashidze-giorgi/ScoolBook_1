namespace ScoolBook.forms
{
    partial class MainPage
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
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_lets_learn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(60, 48);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(136, 44);
            this.btn_add_book.TabIndex = 0;
            this.btn_add_book.Text = "წიგნის დამატება";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_lets_learn
            // 
            this.btn_lets_learn.Location = new System.Drawing.Point(234, 48);
            this.btn_lets_learn.Name = "btn_lets_learn";
            this.btn_lets_learn.Size = new System.Drawing.Size(136, 44);
            this.btn_lets_learn.TabIndex = 1;
            this.btn_lets_learn.Text = "ვისწავლოთ";
            this.btn_lets_learn.UseVisualStyleBackColor = true;
            this.btn_lets_learn.Click += new System.EventHandler(this.btn_lets_learn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_lets_learn);
            this.Controls.Add(this.btn_add_book);
            this.Name = "MainPage";
            this.RightToLeftLayout = true;
            this.Text = "სკოლის წიგნი";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_lets_learn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

