namespace kassa
{
    partial class CurrentStockForm
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
            this.logGrid = new System.Windows.Forms.DataGridView();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).BeginInit();
            this.formLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // logGrid
            // 
            this.logGrid.AllowUserToAddRows = false;
            this.logGrid.AllowUserToDeleteRows = false;
            this.logGrid.AllowUserToResizeRows = false;
            this.logGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.logGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumn,
            this.nameColumn,
            this.quantityColumn});
            this.logGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGrid.Location = new System.Drawing.Point(3, 3);
            this.logGrid.MultiSelect = false;
            this.logGrid.Name = "logGrid";
            this.logGrid.ReadOnly = true;
            this.logGrid.RowHeadersWidth = 20;
            this.logGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.logGrid.Size = new System.Drawing.Size(398, 245);
            this.logGrid.TabIndex = 0;
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeColumn.HeaderText = "Штрихкод";
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.ReadOnly = true;
            this.barcodeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Название товара";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityColumn.HeaderText = "Количество";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // formLayout
            // 
            this.formLayout.ColumnCount = 1;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayout.Controls.Add(this.logGrid, 0, 0);
            this.formLayout.Controls.Add(this.closeButton, 0, 1);
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayout.Location = new System.Drawing.Point(0, 0);
            this.formLayout.Name = "formLayout";
            this.formLayout.RowCount = 2;
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.formLayout.Size = new System.Drawing.Size(404, 289);
            this.formLayout.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(3, 254);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(398, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CurrentStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 289);
            this.Controls.Add(this.formLayout);
            this.Name = "CurrentStockForm";
            this.Text = "Товары на складе";
            this.Load += new System.EventHandler(this.CurrentStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).EndInit();
            this.formLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logGrid;
        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
    }
}