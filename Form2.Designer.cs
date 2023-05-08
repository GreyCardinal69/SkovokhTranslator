
namespace Skovokh_Translator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.EnglishText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveWord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LatinText = new System.Windows.Forms.RichTextBox();
            this.SkovokhText = new System.Windows.Forms.RichTextBox();
            this.Events = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnglishText
            // 
            this.EnglishText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnglishText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnglishText.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnglishText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnglishText.Location = new System.Drawing.Point(44, 73);
            this.EnglishText.Name = "EnglishText";
            this.EnglishText.Size = new System.Drawing.Size(233, 313);
            this.EnglishText.TabIndex = 1;
            this.EnglishText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.MinimumSize = new System.Drawing.Size(230, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input ( English )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(283, 23);
            this.label2.MinimumSize = new System.Drawing.Size(230, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input ( Latin Skovokh )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveWord
            // 
            this.SaveWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveWord.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveWord.Location = new System.Drawing.Point(44, 392);
            this.SaveWord.Name = "SaveWord";
            this.SaveWord.Size = new System.Drawing.Size(314, 46);
            this.SaveWord.TabIndex = 4;
            this.SaveWord.Text = "Save";
            this.SaveWord.UseVisualStyleBackColor = false;
            this.SaveWord.Click += new System.EventHandler(this.SaveWord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(519, 23);
            this.label3.MinimumSize = new System.Drawing.Size(230, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output ( Skovokh )";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LatinText
            // 
            this.LatinText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LatinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LatinText.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LatinText.Location = new System.Drawing.Point(283, 73);
            this.LatinText.Name = "LatinText";
            this.LatinText.Size = new System.Drawing.Size(233, 313);
            this.LatinText.TabIndex = 6;
            this.LatinText.Text = "";
            this.LatinText.TextChanged += new System.EventHandler(this.LatinText_TextChanged);
            // 
            // SkovokhText
            // 
            this.SkovokhText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SkovokhText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkovokhText.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkovokhText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SkovokhText.Location = new System.Drawing.Point(522, 73);
            this.SkovokhText.Name = "SkovokhText";
            this.SkovokhText.Size = new System.Drawing.Size(233, 313);
            this.SkovokhText.TabIndex = 7;
            this.SkovokhText.Text = "";
            // 
            // Events
            // 
            this.Events.AutoSize = true;
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Events.Font = new System.Drawing.Font("Zekton Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Events.Location = new System.Drawing.Point(364, 393);
            this.Events.MinimumSize = new System.Drawing.Size(390, 45);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(390, 45);
            this.Events.TabIndex = 8;
            this.Events.Text = "Events";
            this.Events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.SkovokhText);
            this.Controls.Add(this.LatinText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnglishText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox EnglishText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox LatinText;
        private System.Windows.Forms.RichTextBox SkovokhText;
        private System.Windows.Forms.Label Events;
    }
}