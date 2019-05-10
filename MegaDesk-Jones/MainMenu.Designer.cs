namespace MegaDesk_Jones
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewQuote = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuote
            // 
            this.NewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuote.Location = new System.Drawing.Point(72, 62);
            this.NewQuote.Name = "NewQuote";
            this.NewQuote.Size = new System.Drawing.Size(154, 60);
            this.NewQuote.TabIndex = 0;
            this.NewQuote.Text = "Add New Quote";
            this.NewQuote.UseVisualStyleBackColor = true;
            this.NewQuote.Click += new System.EventHandler(this.NewQuote_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(72, 260);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 60);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotes.Location = new System.Drawing.Point(72, 194);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(152, 60);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quote";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotes.Location = new System.Drawing.Point(72, 128);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(152, 60);
            this.ViewQuotes.TabIndex = 3;
            this.ViewQuotes.Text = "View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = true;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 245);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewQuote);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewQuote;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}