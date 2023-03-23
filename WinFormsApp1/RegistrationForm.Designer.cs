﻿namespace WinFormsApp1
{
    partial class RegistrationForm
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
            this.buttonShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userLoginField = new System.Windows.Forms.TextBox();
            this.userPassField = new System.Windows.Forms.TextBox();
            this.userPassField2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonСontinue = new System.Windows.Forms.Button();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.AutoSize = true;
            this.buttonShowPass.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowPass.Location = new System.Drawing.Point(281, 165);
            this.buttonShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(117, 17);
            this.buttonShowPass.TabIndex = 7;
            this.buttonShowPass.Text = "Показать пароль";
            this.buttonShowPass.UseMnemonic = false;
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.CheckedChanged += new System.EventHandler(this.buttonShowPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // userLoginField
            // 
            this.userLoginField.Location = new System.Drawing.Point(23, 58);
            this.userLoginField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userLoginField.Name = "userLoginField";
            this.userLoginField.Size = new System.Drawing.Size(252, 23);
            this.userLoginField.TabIndex = 1;
            // 
            // userPassField
            // 
            this.userPassField.Location = new System.Drawing.Point(23, 110);
            this.userPassField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPassField.Name = "userPassField";
            this.userPassField.Size = new System.Drawing.Size(252, 23);
            this.userPassField.TabIndex = 2;
            // 
            // userPassField2
            // 
            this.userPassField2.Location = new System.Drawing.Point(23, 162);
            this.userPassField2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPassField2.Name = "userPassField2";
            this.userPassField2.Size = new System.Drawing.Size(252, 23);
            this.userPassField2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повторите пароль";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(23, 206);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 20);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonСontinue
            // 
            this.buttonСontinue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonСontinue.Location = new System.Drawing.Point(281, 206);
            this.buttonСontinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonСontinue.Name = "buttonСontinue";
            this.buttonСontinue.Size = new System.Drawing.Size(105, 20);
            this.buttonСontinue.TabIndex = 9;
            this.buttonСontinue.Text = "Продолжить";
            this.buttonСontinue.UseVisualStyleBackColor = true;
            this.buttonСontinue.Click += new System.EventHandler(this.buttonСontinue_Click);
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAuthorization.Location = new System.Drawing.Point(154, 206);
            this.buttonAuthorization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(105, 20);
            this.buttonAuthorization.TabIndex = 10;
            this.buttonAuthorization.Text = "Авторизация";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 251);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.buttonСontinue);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPassField2);
            this.Controls.Add(this.userPassField);
            this.Controls.Add(this.userLoginField);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(440, 290);
            this.MinimumSize = new System.Drawing.Size(440, 290);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox userLoginField;
        private TextBox userPassField;
        private TextBox userPassField2;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox buttonShowPass;
        private Button buttonCancel;
        private Button buttonСontinue;
        private Button buttonAuthorization;
    }
}