namespace CakeLinkedList
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cakeGridView = new System.Windows.Forms.DataGridView();
            this.sortReverseButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.addCakeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cakeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cakeGridView
            // 
            this.cakeGridView.BackgroundColor = System.Drawing.Color.White;
            this.cakeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cakeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cakeGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.cakeGridView.GridColor = System.Drawing.Color.MistyRose;
            this.cakeGridView.Location = new System.Drawing.Point(23, 162);
            this.cakeGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cakeGridView.Name = "cakeGridView";
            this.cakeGridView.RowHeadersWidth = 62;
            this.cakeGridView.Size = new System.Drawing.Size(951, 288);
            this.cakeGridView.TabIndex = 0;
            this.cakeGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.cakeGridView_CellValidating);
            // 
            // sortReverseButton
            // 
            this.sortReverseButton.BackColor = System.Drawing.Color.Snow;
            this.sortReverseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.sortReverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortReverseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortReverseButton.ForeColor = System.Drawing.Color.DarkRed;
            this.sortReverseButton.Location = new System.Drawing.Point(638, 504);
            this.sortReverseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortReverseButton.Name = "sortReverseButton";
            this.sortReverseButton.Size = new System.Drawing.Size(336, 62);
            this.sortReverseButton.TabIndex = 1;
            this.sortReverseButton.Text = "Ordenar de fin a inicio";
            this.sortReverseButton.UseVisualStyleBackColor = false;
            this.sortReverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.Snow;
            this.sortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.Color.DarkRed;
            this.sortButton.Location = new System.Drawing.Point(289, 504);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(341, 62);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Ordenar de inicio a fin";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // addCakeButton
            // 
            this.addCakeButton.BackColor = System.Drawing.Color.Snow;
            this.addCakeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.addCakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCakeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCakeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.addCakeButton.Location = new System.Drawing.Point(23, 504);
            this.addCakeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCakeButton.Name = "addCakeButton";
            this.addCakeButton.Size = new System.Drawing.Size(258, 62);
            this.addCakeButton.TabIndex = 5;
            this.addCakeButton.Text = "Agregar pastel";
            this.addCakeButton.UseVisualStyleBackColor = false;
            this.addCakeButton.Click += new System.EventHandler(this.addCakeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(14, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(212, 49);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Pastelería";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CakeLinkedList.Properties.Resources.Backlist2;
            this.ClientSize = new System.Drawing.Size(1012, 620);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addCakeButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortReverseButton);
            this.Controls.Add(this.cakeGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasteles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cakeGridView;
        private System.Windows.Forms.Button sortReverseButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button addCakeButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

