namespace kassa
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteForeverButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.menuLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLayout
            // 
            this.menuLayout.AutoSize = true;
            this.menuLayout.ColumnCount = 1;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayout.Controls.Add(this.addButton, 0, 0);
            this.menuLayout.Controls.Add(this.deleteButton, 0, 1);
            this.menuLayout.Controls.Add(this.deleteForeverButton, 0, 2);
            this.menuLayout.Controls.Add(this.logButton, 0, 3);
            this.menuLayout.Controls.Add(this.stockButton, 0, 4);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(0, 0);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.RowCount = 5;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.Size = new System.Drawing.Size(392, 358);
            this.menuLayout.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(386, 65);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Поступление товаров";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 74);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(386, 65);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Продажа товаров";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteForeverButton
            // 
            this.deleteForeverButton.AutoSize = true;
            this.deleteForeverButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteForeverButton.Location = new System.Drawing.Point(3, 145);
            this.deleteForeverButton.Name = "deleteForeverButton";
            this.deleteForeverButton.Size = new System.Drawing.Size(386, 65);
            this.deleteForeverButton.TabIndex = 2;
            this.deleteForeverButton.Text = "Удалить позицию";
            this.deleteForeverButton.UseVisualStyleBackColor = true;
            this.deleteForeverButton.Click += new System.EventHandler(this.deleteForeverButton_Click);
            // 
            // logButton
            // 
            this.logButton.AutoSize = true;
            this.logButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logButton.Location = new System.Drawing.Point(3, 216);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(386, 65);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Лог операций";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockButton.Location = new System.Drawing.Point(3, 287);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(386, 68);
            this.stockButton.TabIndex = 4;
            this.stockButton.Text = "Товары на складе";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 358);
            this.Controls.Add(this.menuLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Меню";
            this.menuLayout.ResumeLayout(false);
            this.menuLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menuLayout;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteForeverButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button stockButton;
    }
}

