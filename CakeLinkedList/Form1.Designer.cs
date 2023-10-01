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
            this.cakeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cakeGridView.Location = new System.Drawing.Point(12, 78);
            this.cakeGridView.Name = "cakeGridView";
            this.cakeGridView.Size = new System.Drawing.Size(642, 182);
            this.cakeGridView.TabIndex = 0;
            this.cakeGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.cakeGridView_CellValidating);
            // 
            // sortReverseButton
            // 
            this.sortReverseButton.Location = new System.Drawing.Point(235, 296);
            this.sortReverseButton.Name = "sortReverseButton";
            this.sortReverseButton.Size = new System.Drawing.Size(127, 23);
            this.sortReverseButton.TabIndex = 1;
            this.sortReverseButton.Text = "Ordenar de fin a inicio";
            this.sortReverseButton.UseVisualStyleBackColor = true;
            this.sortReverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(99, 296);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(130, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Ordenar de inicio a fin";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // addCakeButton
            // 
            this.addCakeButton.Location = new System.Drawing.Point(18, 296);
            this.addCakeButton.Name = "addCakeButton";
            this.addCakeButton.Size = new System.Drawing.Size(75, 23);
            this.addCakeButton.TabIndex = 5;
            this.addCakeButton.Text = "Agregar pastel";
            this.addCakeButton.UseVisualStyleBackColor = true;
            this.addCakeButton.Click += new System.EventHandler(this.addCakeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(210, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 25);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Pasteles en lista ligada";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 344);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addCakeButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortReverseButton);
            this.Controls.Add(this.cakeGridView);
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

