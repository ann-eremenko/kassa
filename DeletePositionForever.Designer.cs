namespace kassa
{
    partial class DeletePositionForeverForm
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
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.barcodeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.barcodeInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.formLayout.SuspendLayout();
            this.nameLayout.SuspendLayout();
            this.barcodeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLayout
            // 
            this.formLayout.AutoSize = true;
            this.formLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formLayout.ColumnCount = 2;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.Controls.Add(this.nameLayout, 0, 1);
            this.formLayout.Controls.Add(this.barcodeLayout, 0, 0);
            this.formLayout.Controls.Add(this.okButton, 0, 2);
            this.formLayout.Controls.Add(this.cancelButton, 1, 2);
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayout.Location = new System.Drawing.Point(0, 0);
            this.formLayout.Name = "formLayout";
            this.formLayout.RowCount = 3;
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.formLayout.Size = new System.Drawing.Size(284, 261);
            this.formLayout.TabIndex = 0;
            // 
            // nameLayout
            // 
            this.nameLayout.ColumnCount = 1;
            this.formLayout.SetColumnSpan(this.nameLayout, 2);
            this.nameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameLayout.Controls.Add(this.nameLabel, 0, 0);
            this.nameLayout.Controls.Add(this.nameInput, 0, 1);
            this.nameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLayout.Location = new System.Drawing.Point(3, 111);
            this.nameLayout.Name = "nameLayout";
            this.nameLayout.RowCount = 2;
            this.nameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameLayout.Size = new System.Drawing.Size(278, 102);
            this.nameLayout.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Location = new System.Drawing.Point(3, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(272, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название товара:";
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInput.Location = new System.Drawing.Point(3, 54);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(272, 20);
            this.nameInput.TabIndex = 2;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // barcodeLayout
            // 
            this.barcodeLayout.ColumnCount = 1;
            this.formLayout.SetColumnSpan(this.barcodeLayout, 2);
            this.barcodeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.barcodeLayout.Controls.Add(this.barcodeLabel, 0, 0);
            this.barcodeLayout.Controls.Add(this.barcodeInput, 0, 1);
            this.barcodeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLayout.Location = new System.Drawing.Point(3, 3);
            this.barcodeLayout.Name = "barcodeLayout";
            this.barcodeLayout.RowCount = 2;
            this.barcodeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.barcodeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.barcodeLayout.Size = new System.Drawing.Size(278, 102);
            this.barcodeLayout.TabIndex = 3;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barcodeLabel.Location = new System.Drawing.Point(3, 38);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(272, 13);
            this.barcodeLabel.TabIndex = 1;
            this.barcodeLabel.Text = "Штрихкод:";
            // 
            // barcodeInput
            // 
            this.barcodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeInput.Location = new System.Drawing.Point(3, 54);
            this.barcodeInput.Name = "barcodeInput";
            this.barcodeInput.Size = new System.Drawing.Size(272, 20);
            this.barcodeInput.TabIndex = 2;
            this.barcodeInput.TextChanged += new System.EventHandler(this.barcodeInput_TextChanged);
            // 
            // okButton
            // 
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(3, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(136, 39);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(145, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 39);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DeletePositionForeverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.formLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeletePositionForeverForm";
            this.Text = "Удаление позиции из базы";
            this.formLayout.ResumeLayout(false);
            this.nameLayout.ResumeLayout(false);
            this.nameLayout.PerformLayout();
            this.barcodeLayout.ResumeLayout(false);
            this.barcodeLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel nameLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TableLayoutPanel barcodeLayout;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox barcodeInput;
    }
}