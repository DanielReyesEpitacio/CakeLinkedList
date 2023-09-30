namespace CakeLinkedList
{
    partial class Form1
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
            this.insertHeadButton = new System.Windows.Forms.Button();
            this.insertCakeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cakeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cakeGridView
            // 
            this.cakeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cakeGridView.Location = new System.Drawing.Point(18, 78);
            this.cakeGridView.Name = "cakeGridView";
            this.cakeGridView.Size = new System.Drawing.Size(576, 182);
            this.cakeGridView.TabIndex = 0;
            this.cakeGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.cakeGridView_CellValidating);
            // 
            // sortReverseButton
            // 
            this.sortReverseButton.Location = new System.Drawing.Point(154, 293);
            this.sortReverseButton.Name = "sortReverseButton";
            this.sortReverseButton.Size = new System.Drawing.Size(127, 28);
            this.sortReverseButton.TabIndex = 1;
            this.sortReverseButton.Text = "Ordenar de fin a inicio";
            this.sortReverseButton.UseVisualStyleBackColor = true;
            this.sortReverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // insertHeadButton
            // 
            this.insertHeadButton.Location = new System.Drawing.Point(323, 298);
            this.insertHeadButton.Name = "insertHeadButton";
            this.insertHeadButton.Size = new System.Drawing.Size(114, 23);
            this.insertHeadButton.TabIndex = 2;
            this.insertHeadButton.Text = "Insertar al inicio";
            this.insertHeadButton.UseVisualStyleBackColor = true;
            this.insertHeadButton.Click += new System.EventHandler(this.insertHeadButton_Click);
            // 
            // insertCakeButton
            // 
            this.insertCakeButton.Location = new System.Drawing.Point(443, 298);
            this.insertCakeButton.Name = "insertCakeButton";
            this.insertCakeButton.Size = new System.Drawing.Size(94, 23);
            this.insertCakeButton.TabIndex = 3;
            this.insertCakeButton.Text = "Insertar al final";
            this.insertCakeButton.UseVisualStyleBackColor = true;
            this.insertCakeButton.Click += new System.EventHandler(this.insertCakeButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(18, 296);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(130, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Ordenar de inicio a fin";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 344);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.insertCakeButton);
            this.Controls.Add(this.insertHeadButton);
            this.Controls.Add(this.sortReverseButton);
            this.Controls.Add(this.cakeGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cakeGridView;
        private System.Windows.Forms.Button sortReverseButton;
        private System.Windows.Forms.Button insertHeadButton;
        private System.Windows.Forms.Button insertCakeButton;
        private System.Windows.Forms.Button sortButton;
    }
}

