namespace MegaDesk_Jones
{
    partial class AddQuote
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
            this.newQuote = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.deskSize = new System.Windows.Forms.Label();
            this.NumDrawers = new System.Windows.Forms.Label();
            this.surfaceMat = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numDrawer = new System.Windows.Forms.NumericUpDown();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dropDelivery = new System.Windows.Forms.ComboBox();
            this.cmbxSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.txtValdaitionWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(92, 20);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(229, 46);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "New Quote";
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(26, 108);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(166, 24);
            this.custName.TabIndex = 1;
            this.custName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(198, 108);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(173, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // deskSize
            // 
            this.deskSize.AutoSize = true;
            this.deskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskSize.Location = new System.Drawing.Point(26, 164);
            this.deskSize.Name = "deskSize";
            this.deskSize.Size = new System.Drawing.Size(108, 24);
            this.deskSize.TabIndex = 4;
            this.deskSize.Text = "Desk Size:";
            // 
            // NumDrawers
            // 
            this.NumDrawers.AutoSize = true;
            this.NumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawers.Location = new System.Drawing.Point(26, 228);
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.Size = new System.Drawing.Size(196, 24);
            this.NumDrawers.TabIndex = 5;
            this.NumDrawers.Text = "Number of Drawers:";
            // 
            // surfaceMat
            // 
            this.surfaceMat.AutoSize = true;
            this.surfaceMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMat.Location = new System.Drawing.Point(26, 316);
            this.surfaceMat.Name = "surfaceMat";
            this.surfaceMat.Size = new System.Drawing.Size(176, 24);
            this.surfaceMat.TabIndex = 6;
            this.surfaceMat.Text = "Surface Materials:";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Location = new System.Drawing.Point(26, 268);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(91, 24);
            this.delivery.TabIndex = 7;
            this.delivery.Text = "Delivery:";
            // 
            // widthTxt
            // 
            this.widthTxt.AutoSize = true;
            this.widthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTxt.Location = new System.Drawing.Point(140, 154);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(54, 20);
            this.widthTxt.TabIndex = 8;
            this.widthTxt.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Depth:";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidth.Location = new System.Drawing.Point(200, 148);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(77, 26);
            this.numWidth.TabIndex = 10;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numDepth
            // 
            this.numDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepth.Location = new System.Drawing.Point(200, 180);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(77, 26);
            this.numDepth.TabIndex = 11;
            this.numDepth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numDrawer
            // 
            this.numDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawer.Location = new System.Drawing.Point(228, 228);
            this.numDrawer.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawer.Name = "numDrawer";
            this.numDrawer.Size = new System.Drawing.Size(77, 26);
            this.numDrawer.TabIndex = 14;
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(67, 367);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(100, 43);
            this.btnAddQuote.TabIndex = 15;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(188, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dropDelivery
            // 
            this.dropDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDelivery.FormattingEnabled = true;
            this.dropDelivery.Items.AddRange(new object[] {
            "3",
            "5 ",
            "7 ",
            "14"});
            this.dropDelivery.Location = new System.Drawing.Point(123, 268);
            this.dropDelivery.Name = "dropDelivery";
            this.dropDelivery.Size = new System.Drawing.Size(121, 28);
            this.dropDelivery.TabIndex = 17;
            // 
            // cmbxSurfaceMaterial
            // 
            this.cmbxSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSurfaceMaterial.FormattingEnabled = true;
            this.cmbxSurfaceMaterial.Location = new System.Drawing.Point(208, 316);
            this.cmbxSurfaceMaterial.Name = "cmbxSurfaceMaterial";
            this.cmbxSurfaceMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbxSurfaceMaterial.TabIndex = 18;
            // 
            // txtValdaitionWarning
            // 
            this.txtValdaitionWarning.AutoSize = true;
            this.txtValdaitionWarning.Location = new System.Drawing.Point(87, 76);
            this.txtValdaitionWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtValdaitionWarning.Name = "txtValdaitionWarning";
            this.txtValdaitionWarning.Size = new System.Drawing.Size(0, 13);
            this.txtValdaitionWarning.TabIndex = 19;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.txtValdaitionWarning);
            this.Controls.Add(this.cmbxSurfaceMaterial);
            this.Controls.Add(this.dropDelivery);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.numDrawer);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.surfaceMat);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.deskSize);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.newQuote);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuote;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label deskSize;
        private System.Windows.Forms.Label NumDrawers;
        private System.Windows.Forms.Label surfaceMat;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label widthTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numDrawer;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox dropDelivery;
        private System.Windows.Forms.ComboBox cmbxSurfaceMaterial;
        private System.Windows.Forms.Label txtValdaitionWarning;
    }
}