namespace Zad_VlaNa
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
            this.Aut = new System.Windows.Forms.Button();
            this.Regi = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aut
            // 
            this.Aut.Location = new System.Drawing.Point(53, 78);
            this.Aut.Name = "Aut";
            this.Aut.Size = new System.Drawing.Size(113, 23);
            this.Aut.TabIndex = 0;
            this.Aut.Text = "Авторизация";
            this.Aut.UseVisualStyleBackColor = true;
            this.Aut.Click += new System.EventHandler(this.Aut_Click);
            // 
            // Regi
            // 
            this.Regi.Location = new System.Drawing.Point(53, 107);
            this.Regi.Name = "Regi";
            this.Regi.Size = new System.Drawing.Size(113, 23);
            this.Regi.TabIndex = 1;
            this.Regi.Text = "Регистрация";
            this.Regi.UseVisualStyleBackColor = true;
            this.Regi.Click += new System.EventHandler(this.Regi_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(53, 136);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Главное Меню";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Regi);
            this.Controls.Add(this.Aut);
            this.Name = "MainForm";
            this.Text = "Главное Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aut;
        private System.Windows.Forms.Button Regi;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

