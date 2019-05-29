namespace MegaDesk_Jones
{
    partial class DisplayQuote
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.surfaceMat = new System.Windows.Forms.Label();
            this.NumDrawers = new System.Windows.Forms.Label();
            this.deskSize = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.newQuote = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtDrawers = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(312, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 43);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(190, 343);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(100, 43);
            this.btnAddQuote.TabIndex = 31;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Depth:";
            // 
            // widthTxt
            // 
            this.widthTxt.AutoSize = true;
            this.widthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTxt.Location = new System.Drawing.Point(264, 130);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(54, 20);
            this.widthTxt.TabIndex = 26;
            this.widthTxt.Text = "Width:";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Location = new System.Drawing.Point(150, 244);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(91, 24);
            this.delivery.TabIndex = 25;
            this.delivery.Text = "Delivery:";
            // 
            // surfaceMat
            // 
            this.surfaceMat.AutoSize = true;
            this.surfaceMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMat.Location = new System.Drawing.Point(150, 292);
            this.surfaceMat.Name = "surfaceMat";
            this.surfaceMat.Size = new System.Drawing.Size(176, 24);
            this.surfaceMat.TabIndex = 24;
            this.surfaceMat.Text = "Surface Materials:";
            // 
            // NumDrawers
            // 
            this.NumDrawers.AutoSize = true;
            this.NumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawers.Location = new System.Drawing.Point(150, 204);
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.Size = new System.Drawing.Size(196, 24);
            this.NumDrawers.TabIndex = 23;
            this.NumDrawers.Text = "Number of Drawers:";
            // 
            // deskSize
            // 
            this.deskSize.AutoSize = true;
            this.deskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskSize.Location = new System.Drawing.Point(150, 140);
            this.deskSize.Name = "deskSize";
            this.deskSize.Size = new System.Drawing.Size(108, 24);
            this.deskSize.TabIndex = 22;
            this.deskSize.Text = "Desk Size:";
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(150, 84);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(166, 24);
            this.custName.TabIndex = 20;
            this.custName.Text = "Customer Name:";
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(183, 7);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(229, 46);
            this.newQuote.TabIndex = 19;
            this.newQuote.Text = "New Quote";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(323, 87);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 33;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(247, 248);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(100, 20);
            this.txtDelivery.TabIndex = 34;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Location = new System.Drawing.Point(352, 208);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(100, 20);
            this.txtDrawers.TabIndex = 35;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(324, 160);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 20);
            this.txtDepth.TabIndex = 36;
            this.txtDepth.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(324, 130);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 37;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(332, 297);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(100, 20);
            this.txtSurface.TabIndex = 38;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 401);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.surfaceMat);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.deskSize);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.newQuote);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayQuote";
            this.Text = "Current Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label widthTxt;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label surfaceMat;
        private System.Windows.Forms.Label NumDrawers;
        private System.Windows.Forms.Label deskSize;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label newQuote;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtDrawers;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtSurface;
    }
}