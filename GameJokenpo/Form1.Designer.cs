namespace GameJokenpo
{
    partial class Form1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPerson = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelQuestionMarkResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEqual = new System.Windows.Forms.Label();
            this.btnPictureScissors = new System.Windows.Forms.Button();
            this.btnPicturePaper = new System.Windows.Forms.Button();
            this.btnPictureStone = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxMachine = new System.Windows.Forms.PictureBox();
            this.pictureBoxPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(775, 169);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerson.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPerson.Location = new System.Drawing.Point(68, 208);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(94, 32);
            this.labelPerson.TabIndex = 4;
            this.labelPerson.Text = "VOCÊ";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMachine.Location = new System.Drawing.Point(372, 208);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(53, 32);
            this.labelMachine.TabIndex = 5;
            this.labelMachine.Text = "PC";
            // 
            // labelQuestionMarkResult
            // 
            this.labelQuestionMarkResult.AutoSize = true;
            this.labelQuestionMarkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionMarkResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelQuestionMarkResult.Location = new System.Drawing.Point(655, 208);
            this.labelQuestionMarkResult.Name = "labelQuestionMarkResult";
            this.labelQuestionMarkResult.Size = new System.Drawing.Size(30, 32);
            this.labelQuestionMarkResult.TabIndex = 6;
            this.labelQuestionMarkResult.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(241, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "VS";
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEqual.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEqual.Location = new System.Drawing.Point(520, 208);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(30, 32);
            this.labelEqual.TabIndex = 8;
            this.labelEqual.Text = "=";
            // 
            // btnPictureScissors
            // 
            this.btnPictureScissors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPictureScissors.BackgroundImage = global::GameJokenpo.Properties.Resources.Tesoura;
            this.btnPictureScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPictureScissors.Location = new System.Drawing.Point(570, 345);
            this.btnPictureScissors.Name = "btnPictureScissors";
            this.btnPictureScissors.Size = new System.Drawing.Size(200, 200);
            this.btnPictureScissors.TabIndex = 11;
            this.btnPictureScissors.UseVisualStyleBackColor = false;
            this.btnPictureScissors.Click += new System.EventHandler(this.btnPictureScissors_Click);
            // 
            // btnPicturePaper
            // 
            this.btnPicturePaper.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPicturePaper.BackgroundImage = global::GameJokenpo.Properties.Resources.Papel;
            this.btnPicturePaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicturePaper.Location = new System.Drawing.Point(299, 345);
            this.btnPicturePaper.Name = "btnPicturePaper";
            this.btnPicturePaper.Size = new System.Drawing.Size(200, 200);
            this.btnPicturePaper.TabIndex = 10;
            this.btnPicturePaper.UseVisualStyleBackColor = false;
            this.btnPicturePaper.Click += new System.EventHandler(this.btnPicturePaper_Click);
            // 
            // btnPictureStone
            // 
            this.btnPictureStone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPictureStone.BackgroundImage = global::GameJokenpo.Properties.Resources.Pedra;
            this.btnPictureStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPictureStone.Location = new System.Drawing.Point(12, 345);
            this.btnPictureStone.Name = "btnPictureStone";
            this.btnPictureStone.Size = new System.Drawing.Size(200, 200);
            this.btnPictureStone.TabIndex = 9;
            this.btnPictureStone.UseVisualStyleBackColor = false;
            this.btnPictureStone.Click += new System.EventHandler(this.btnPictureStone_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(570, 128);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxResult.TabIndex = 3;
            this.pictureBoxResult.TabStop = false;
            // 
            // pictureBoxMachine
            // 
            this.pictureBoxMachine.Location = new System.Drawing.Point(299, 128);
            this.pictureBoxMachine.Name = "pictureBoxMachine";
            this.pictureBoxMachine.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMachine.TabIndex = 2;
            this.pictureBoxMachine.TabStop = false;
            // 
            // pictureBoxPerson
            // 
            this.pictureBoxPerson.Location = new System.Drawing.Point(12, 128);
            this.pictureBoxPerson.Name = "pictureBoxPerson";
            this.pictureBoxPerson.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPerson.TabIndex = 1;
            this.pictureBoxPerson.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 553);
            this.Controls.Add(this.btnPictureScissors);
            this.Controls.Add(this.btnPicturePaper);
            this.Controls.Add(this.btnPictureStone);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelQuestionMarkResult);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxMachine);
            this.Controls.Add(this.pictureBoxPerson);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.PictureBox pictureBoxMachine;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelQuestionMarkResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Button btnPictureStone;
        private System.Windows.Forms.Button btnPicturePaper;
        private System.Windows.Forms.Button btnPictureScissors;
    }
}

