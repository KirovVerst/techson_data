namespace TechsonData
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.digitsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.segmentLabel = new System.Windows.Forms.Label();
            this.uploadTitleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mNumericBox = new System.Windows.Forms.NumericUpDown();
            this.nNumericBox = new System.Windows.Forms.NumericUpDown();
            this.nUploadedImagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(333, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.chooseImage);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::TechsonData.Properties.Resources.image_not_found_4a963b95bf081c3ea02923dceaeb3f8085e1a654fc54840aac61a57a60903fef;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(315, 320);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // digitsComboBox
            // 
            this.digitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.digitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digitsComboBox.FormattingEnabled = true;
            this.digitsComboBox.Location = new System.Drawing.Point(409, 50);
            this.digitsComboBox.Name = "digitsComboBox";
            this.digitsComboBox.Size = new System.Drawing.Size(93, 24);
            this.digitsComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цифра:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // usersComboBox
            // 
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(409, 80);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(93, 24);
            this.usersComboBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(333, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Загрузить на сервер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // segmentLabel
            // 
            this.segmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.segmentLabel.ForeColor = System.Drawing.Color.Green;
            this.segmentLabel.Location = new System.Drawing.Point(335, 202);
            this.segmentLabel.Name = "segmentLabel";
            this.segmentLabel.Size = new System.Drawing.Size(167, 48);
            this.segmentLabel.TabIndex = 8;
            this.segmentLabel.Text = "Сегментирование завершено";
            this.segmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.segmentLabel.Visible = false;
            // 
            // uploadTitleLabel
            // 
            this.uploadTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.uploadTitleLabel.Location = new System.Drawing.Point(335, 250);
            this.uploadTitleLabel.Name = "uploadTitleLabel";
            this.uploadTitleLabel.Size = new System.Drawing.Size(167, 30);
            this.uploadTitleLabel.TabIndex = 10;
            this.uploadTitleLabel.Text = "Загружено:";
            this.uploadTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadTitleLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(335, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Строки:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(335, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Столбцы:";
            // 
            // mNumericBox
            // 
            this.mNumericBox.Location = new System.Drawing.Point(409, 113);
            this.mNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumericBox.Name = "mNumericBox";
            this.mNumericBox.Size = new System.Drawing.Size(93, 20);
            this.mNumericBox.TabIndex = 15;
            this.mNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nNumericBox
            // 
            this.nNumericBox.Location = new System.Drawing.Point(409, 140);
            this.nNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumericBox.Name = "nNumericBox";
            this.nNumericBox.Size = new System.Drawing.Size(93, 20);
            this.nNumericBox.TabIndex = 16;
            this.nNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUploadedImagesLabel
            // 
            this.nUploadedImagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUploadedImagesLabel.ForeColor = System.Drawing.Color.Black;
            this.nUploadedImagesLabel.Location = new System.Drawing.Point(371, 280);
            this.nUploadedImagesLabel.Name = "nUploadedImagesLabel";
            this.nUploadedImagesLabel.Size = new System.Drawing.Size(93, 22);
            this.nUploadedImagesLabel.TabIndex = 17;
            this.nUploadedImagesLabel.Text = "0 из 10";
            this.nUploadedImagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nUploadedImagesLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.nUploadedImagesLabel);
            this.Controls.Add(this.nNumericBox);
            this.Controls.Add(this.mNumericBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uploadTitleLabel);
            this.Controls.Add(this.segmentLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digitsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TechsonData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox digitsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label segmentLabel;
        private System.Windows.Forms.Label uploadTitleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mNumericBox;
        private System.Windows.Forms.NumericUpDown nNumericBox;
        private System.Windows.Forms.Label nUploadedImagesLabel;
    }
}

