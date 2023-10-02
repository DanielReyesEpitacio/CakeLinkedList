namespace CakeLinkedList
{
    partial class CakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CakeForm));
            this.addCakeButton = new System.Windows.Forms.Button();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.flavorTxt = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTxt = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.portionsLabel = new System.Windows.Forms.Label();
            this.portionsTxt = new System.Windows.Forms.TextBox();
            this.distributorLabel = new System.Windows.Forms.Label();
            this.distributorTxt = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.actionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addCakeButton
            // 
            this.addCakeButton.BackColor = System.Drawing.Color.Snow;
            this.addCakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCakeButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCakeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.addCakeButton.Location = new System.Drawing.Point(116, 632);
            this.addCakeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCakeButton.Name = "addCakeButton";
            this.addCakeButton.Size = new System.Drawing.Size(208, 45);
            this.addCakeButton.TabIndex = 0;
            this.addCakeButton.Text = "Agregar pastel";
            this.addCakeButton.UseVisualStyleBackColor = false;
            this.addCakeButton.Click += new System.EventHandler(this.addCakeButton_Click);
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.Location = new System.Drawing.Point(46, 109);
            this.flavorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(56, 20);
            this.flavorLabel.TabIndex = 1;
            this.flavorLabel.Text = "Sabor:";
            // 
            // flavorTxt
            // 
            this.flavorTxt.Location = new System.Drawing.Point(51, 134);
            this.flavorTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flavorTxt.Name = "flavorTxt";
            this.flavorTxt.Size = new System.Drawing.Size(344, 26);
            this.flavorTxt.TabIndex = 2;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(46, 183);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(71, 20);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Tamaño:";
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(51, 208);
            this.sizeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(344, 26);
            this.sizeTxt.TabIndex = 4;
            this.sizeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeTxt_KeyPress);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(48, 258);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(50, 20);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            // 
            // colorTxt
            // 
            this.colorTxt.Location = new System.Drawing.Point(51, 283);
            this.colorTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorTxt.Name = "colorTxt";
            this.colorTxt.Size = new System.Drawing.Size(344, 26);
            this.colorTxt.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(46, 335);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 20);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Precio:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(51, 360);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(344, 26);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // portionsLabel
            // 
            this.portionsLabel.AutoSize = true;
            this.portionsLabel.Location = new System.Drawing.Point(48, 409);
            this.portionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portionsLabel.Name = "portionsLabel";
            this.portionsLabel.Size = new System.Drawing.Size(83, 20);
            this.portionsLabel.TabIndex = 9;
            this.portionsLabel.Text = "Porciones:";
            // 
            // portionsTxt
            // 
            this.portionsTxt.Location = new System.Drawing.Point(51, 434);
            this.portionsTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portionsTxt.Name = "portionsTxt";
            this.portionsTxt.Size = new System.Drawing.Size(344, 26);
            this.portionsTxt.TabIndex = 10;
            this.portionsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portionsTxt_KeyPress);
            
            // 
            // distributorLabel
            // 
            this.distributorLabel.AutoSize = true;
            this.distributorLabel.Location = new System.Drawing.Point(46, 483);
            this.distributorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.distributorLabel.Name = "distributorLabel";
            this.distributorLabel.Size = new System.Drawing.Size(93, 20);
            this.distributorLabel.TabIndex = 11;
            this.distributorLabel.Text = "Distribuidor:";
            // 
            // distributorTxt
            // 
            this.distributorTxt.Location = new System.Drawing.Point(52, 508);
            this.distributorTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.distributorTxt.Name = "distributorTxt";
            this.distributorTxt.Size = new System.Drawing.Size(344, 26);
            this.distributorTxt.TabIndex = 12;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(110, 32);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(208, 37);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Nuevo pastel";
            // 
            // actionTypeComboBox
            // 
            this.actionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeComboBox.FormattingEnabled = true;
            this.actionTypeComboBox.Items.AddRange(new object[] {
            "Agregar al inicio",
            "Agregar al final"});
            this.actionTypeComboBox.Location = new System.Drawing.Point(51, 571);
            this.actionTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionTypeComboBox.Name = "actionTypeComboBox";
            this.actionTypeComboBox.Size = new System.Drawing.Size(344, 28);
            this.actionTypeComboBox.TabIndex = 14;
            // 
            // CakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 702);
            this.Controls.Add(this.actionTypeComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.distributorTxt);
            this.Controls.Add(this.distributorLabel);
            this.Controls.Add(this.portionsTxt);
            this.Controls.Add(this.portionsLabel);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.colorTxt);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.flavorTxt);
            this.Controls.Add(this.flavorLabel);
            this.Controls.Add(this.addCakeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCakeButton;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.TextBox flavorTxt;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorTxt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label portionsLabel;
        private System.Windows.Forms.TextBox portionsTxt;
        private System.Windows.Forms.Label distributorLabel;
        private System.Windows.Forms.TextBox distributorTxt;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox actionTypeComboBox;
    }
}