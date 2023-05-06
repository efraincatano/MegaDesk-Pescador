namespace MegaDesk___Pescador
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
            this.newQuoteTitle = new System.Windows.Forms.Label();
            this.costumerNameLabel = new System.Windows.Forms.Label();
            this.costumerName = new System.Windows.Forms.TextBox();
            this.deskSizeLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.rushOptions = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.btnCancelQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuoteTitle
            // 
            this.newQuoteTitle.AutoSize = true;
            this.newQuoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteTitle.Location = new System.Drawing.Point(212, 9);
            this.newQuoteTitle.Name = "newQuoteTitle";
            this.newQuoteTitle.Size = new System.Drawing.Size(220, 46);
            this.newQuoteTitle.TabIndex = 0;
            this.newQuoteTitle.Text = "New Quote";
            this.newQuoteTitle.Click += new System.EventHandler(this.newQuoteTitle_Click);
            // 
            // costumerNameLabel
            // 
            this.costumerNameLabel.AutoSize = true;
            this.costumerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerNameLabel.Location = new System.Drawing.Point(12, 60);
            this.costumerNameLabel.Name = "costumerNameLabel";
            this.costumerNameLabel.Size = new System.Drawing.Size(139, 22);
            this.costumerNameLabel.TabIndex = 1;
            this.costumerNameLabel.Text = "Costumer Name";
            this.costumerNameLabel.Click += new System.EventHandler(this.costumerNameText_Click);
            // 
            // costumerName
            // 
            this.costumerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerName.Location = new System.Drawing.Point(173, 60);
            this.costumerName.Name = "costumerName";
            this.costumerName.Size = new System.Drawing.Size(330, 27);
            this.costumerName.TabIndex = 2;
            // 
            // deskSizeLabel
            // 
            this.deskSizeLabel.AutoSize = true;
            this.deskSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskSizeLabel.Location = new System.Drawing.Point(30, 114);
            this.deskSizeLabel.Name = "deskSizeLabel";
            this.deskSizeLabel.Size = new System.Drawing.Size(62, 15);
            this.deskSizeLabel.TabIndex = 3;
            this.deskSizeLabel.Text = "Desk Size";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(116, 152);
            this.width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 20);
            this.width.TabIndex = 4;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(116, 198);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(120, 20);
            this.depth.TabIndex = 5;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(67, 198);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(43, 15);
            this.depthLabel.TabIndex = 6;
            this.depthLabel.Text = "Depth:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(67, 152);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(41, 15);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width:";
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.Location = new System.Drawing.Point(424, 124);
            this.numberOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(120, 20);
            this.numberOfDrawers.TabIndex = 8;
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(299, 129);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(119, 15);
            this.numDrawersLabel.TabIndex = 9;
            this.numDrawersLabel.Text = "Number Of Drawers:";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterial.Location = new System.Drawing.Point(429, 178);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterial.TabIndex = 10;
            this.surfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterial_SelectedIndexChanged);
            // 
            // rushOptions
            // 
            this.rushOptions.FormattingEnabled = true;
            this.rushOptions.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "No rush"});
            this.rushOptions.Location = new System.Drawing.Point(429, 224);
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.Size = new System.Drawing.Size(121, 21);
            this.rushOptions.TabIndex = 11;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(321, 184);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(100, 15);
            this.surfaceMaterialLabel.TabIndex = 12;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(365, 230);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(53, 15);
            this.deliveryLabel.TabIndex = 13;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(173, 280);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(107, 41);
            this.btnGetQuote.TabIndex = 14;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            // 
            // btnCancelQuote
            // 
            this.btnCancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelQuote.Location = new System.Drawing.Point(351, 280);
            this.btnCancelQuote.Name = "btnCancelQuote";
            this.btnCancelQuote.Size = new System.Drawing.Size(107, 41);
            this.btnCancelQuote.TabIndex = 15;
            this.btnCancelQuote.Text = "Cancel";
            this.btnCancelQuote.UseVisualStyleBackColor = true;
            this.btnCancelQuote.Click += new System.EventHandler(this.btnCancelQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelQuote);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.rushOptions);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.deskSizeLabel);
            this.Controls.Add(this.costumerName);
            this.Controls.Add(this.costumerNameLabel);
            this.Controls.Add(this.newQuoteTitle);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuoteTitle;
        private System.Windows.Forms.Label costumerNameLabel;
        private System.Windows.Forms.TextBox costumerName;
        private System.Windows.Forms.Label deskSizeLabel;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown numberOfDrawers;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.ComboBox rushOptions;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Button btnCancelQuote;
    }
}