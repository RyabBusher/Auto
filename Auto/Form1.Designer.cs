namespace Auto
{
    partial class Form1
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
            this.buttonOpenCars = new System.Windows.Forms.Button();
            this.buttonEditCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenCars
            // 
            this.buttonOpenCars.Location = new System.Drawing.Point(12, 173);
            this.buttonOpenCars.Name = "buttonOpenCars";
            this.buttonOpenCars.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenCars.TabIndex = 0;
            this.buttonOpenCars.Text = "Машины";
            this.buttonOpenCars.UseVisualStyleBackColor = true;
            this.buttonOpenCars.Click += new System.EventHandler(this.buttonOpenCars_Click);
            // 
            // buttonEditCars
            // 
            this.buttonEditCars.Location = new System.Drawing.Point(12, 227);
            this.buttonEditCars.Name = "buttonEditCars";
            this.buttonEditCars.Size = new System.Drawing.Size(255, 48);
            this.buttonEditCars.TabIndex = 1;
            this.buttonEditCars.Text = "Изменить информацию";
            this.buttonEditCars.UseVisualStyleBackColor = true;
            this.buttonEditCars.Click += new System.EventHandler(this.buttonEditCars_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 340);
            this.Controls.Add(this.buttonEditCars);
            this.Controls.Add(this.buttonOpenCars);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenCars;
        private System.Windows.Forms.Button buttonEditCars;
    }
}

