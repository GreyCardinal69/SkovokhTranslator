
using System.Drawing;

namespace Skovokh_Translator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.FinalPicture = new System.Windows.Forms.PictureBox();
            this.EngToLatin = new System.Windows.Forms.Button();
            this.EngToSkov = new System.Windows.Forms.Button();
            this.LatinToEng = new System.Windows.Forms.Button();
            this.LatinToSkov = new System.Windows.Forms.Button();
            this.SkovToEng = new System.Windows.Forms.Button();
            this.SkovToLatin = new System.Windows.Forms.Button();
            this.GenerateImage = new System.Windows.Forms.Button();
            this.TransMode = new System.Windows.Forms.Button();
            this.ImageSkovokhText = new System.Windows.Forms.RichTextBox();
            this.ChangeImageMode = new System.Windows.Forms.Button();
            this.DictionaryEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FinalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Zekton Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Input.Location = new System.Drawing.Point(323, 25);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(695, 347);
            this.Input.TabIndex = 6;
            this.Input.Text = "Input";
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Zekton Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Output.Location = new System.Drawing.Point(323, 404);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(695, 357);
            this.Output.TabIndex = 7;
            this.Output.Text = "Output";
            // 
            // FinalPicture
            // 
            this.FinalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("FinalPicture.ErrorImage")));
            this.FinalPicture.Image = ((System.Drawing.Image)(resources.GetObject("FinalPicture.Image")));
            this.FinalPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("FinalPicture.InitialImage")));
            this.FinalPicture.Location = new System.Drawing.Point(34, 465);
            this.FinalPicture.Name = "FinalPicture";
            this.FinalPicture.Size = new System.Drawing.Size(270, 296);
            this.FinalPicture.TabIndex = 17;
            this.FinalPicture.TabStop = false;
            // 
            // EngToLatin
            // 
            this.EngToLatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EngToLatin.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.EngToLatin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngToLatin.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EngToLatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EngToLatin.Location = new System.Drawing.Point(34, 25);
            this.EngToLatin.Name = "EngToLatin";
            this.EngToLatin.Size = new System.Drawing.Size(270, 38);
            this.EngToLatin.TabIndex = 18;
            this.EngToLatin.Text = "English To Latin Skovokh";
            this.EngToLatin.UseVisualStyleBackColor = false;
            this.EngToLatin.Click += new System.EventHandler(this.EngToLatin_Click);
            // 
            // EngToSkov
            // 
            this.EngToSkov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EngToSkov.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.EngToSkov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngToSkov.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EngToSkov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EngToSkov.Location = new System.Drawing.Point(34, 69);
            this.EngToSkov.Name = "EngToSkov";
            this.EngToSkov.Size = new System.Drawing.Size(270, 38);
            this.EngToSkov.TabIndex = 19;
            this.EngToSkov.Text = "English To Skovokh";
            this.EngToSkov.UseVisualStyleBackColor = false;
            this.EngToSkov.Click += new System.EventHandler(this.EngToSkov_Click);
            // 
            // LatinToEng
            // 
            this.LatinToEng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LatinToEng.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.LatinToEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LatinToEng.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatinToEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LatinToEng.Location = new System.Drawing.Point(34, 113);
            this.LatinToEng.Name = "LatinToEng";
            this.LatinToEng.Size = new System.Drawing.Size(270, 38);
            this.LatinToEng.TabIndex = 20;
            this.LatinToEng.Text = "Latin Skovokh To English";
            this.LatinToEng.UseVisualStyleBackColor = false;
            this.LatinToEng.Click += new System.EventHandler(this.LatinToEng_Click);
            // 
            // LatinToSkov
            // 
            this.LatinToSkov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LatinToSkov.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.LatinToSkov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LatinToSkov.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatinToSkov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LatinToSkov.Location = new System.Drawing.Point(34, 157);
            this.LatinToSkov.Name = "LatinToSkov";
            this.LatinToSkov.Size = new System.Drawing.Size(270, 38);
            this.LatinToSkov.TabIndex = 21;
            this.LatinToSkov.Text = "Latin Skovokh To Skovokh";
            this.LatinToSkov.UseVisualStyleBackColor = false;
            this.LatinToSkov.Click += new System.EventHandler(this.LatinToSkov_Click);
            // 
            // SkovToEng
            // 
            this.SkovToEng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SkovToEng.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.SkovToEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkovToEng.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkovToEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SkovToEng.Location = new System.Drawing.Point(34, 201);
            this.SkovToEng.Name = "SkovToEng";
            this.SkovToEng.Size = new System.Drawing.Size(270, 38);
            this.SkovToEng.TabIndex = 22;
            this.SkovToEng.Text = "Skovokh To English";
            this.SkovToEng.UseVisualStyleBackColor = false;
            this.SkovToEng.Click += new System.EventHandler(this.SkovToEng_Click);
            // 
            // SkovToLatin
            // 
            this.SkovToLatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SkovToLatin.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.SkovToLatin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkovToLatin.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkovToLatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SkovToLatin.Location = new System.Drawing.Point(34, 245);
            this.SkovToLatin.Name = "SkovToLatin";
            this.SkovToLatin.Size = new System.Drawing.Size(270, 38);
            this.SkovToLatin.TabIndex = 23;
            this.SkovToLatin.Text = "Skovokh To Latin Skovokh";
            this.SkovToLatin.UseVisualStyleBackColor = false;
            this.SkovToLatin.Click += new System.EventHandler(this.SkovToLatin_Click);
            // 
            // GenerateImage
            // 
            this.GenerateImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GenerateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateImage.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GenerateImage.Location = new System.Drawing.Point(34, 422);
            this.GenerateImage.Name = "GenerateImage";
            this.GenerateImage.Size = new System.Drawing.Size(270, 38);
            this.GenerateImage.TabIndex = 24;
            this.GenerateImage.Text = "Generate Image";
            this.GenerateImage.UseVisualStyleBackColor = false;
            this.GenerateImage.Click += new System.EventHandler(this.GenerateImage_Click);
            // 
            // TransMode
            // 
            this.TransMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TransMode.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.TransMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransMode.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TransMode.Location = new System.Drawing.Point(34, 289);
            this.TransMode.Name = "TransMode";
            this.TransMode.Size = new System.Drawing.Size(270, 38);
            this.TransMode.TabIndex = 25;
            this.TransMode.Text = "Mode";
            this.TransMode.UseVisualStyleBackColor = false;
            // 
            // ImageSkovokhText
            // 
            this.ImageSkovokhText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ImageSkovokhText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageSkovokhText.Font = new System.Drawing.Font("Zekton Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageSkovokhText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ImageSkovokhText.Location = new System.Drawing.Point(1040, 25);
            this.ImageSkovokhText.Name = "ImageSkovokhText";
            this.ImageSkovokhText.Size = new System.Drawing.Size(447, 736);
            this.ImageSkovokhText.TabIndex = 26;
            this.ImageSkovokhText.Text = "Input text for image generation here";
            // 
            // ChangeImageMode
            // 
            this.ChangeImageMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ChangeImageMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImageMode.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeImageMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChangeImageMode.Location = new System.Drawing.Point(34, 378);
            this.ChangeImageMode.Name = "ChangeImageMode";
            this.ChangeImageMode.Size = new System.Drawing.Size(270, 38);
            this.ChangeImageMode.TabIndex = 27;
            this.ChangeImageMode.Text = "20 Chars per layer";
            this.ChangeImageMode.UseVisualStyleBackColor = false;
            this.ChangeImageMode.Click += new System.EventHandler(this.ChangeImageMode_Click);
            // 
            // DictionaryEditor
            // 
            this.DictionaryEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DictionaryEditor.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.DictionaryEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DictionaryEditor.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DictionaryEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DictionaryEditor.Location = new System.Drawing.Point(34, 334);
            this.DictionaryEditor.Name = "DictionaryEditor";
            this.DictionaryEditor.Size = new System.Drawing.Size(270, 38);
            this.DictionaryEditor.TabIndex = 28;
            this.DictionaryEditor.Text = "Open Dictionary Editor";
            this.DictionaryEditor.UseVisualStyleBackColor = false;
            this.DictionaryEditor.Click += new System.EventHandler(this.DictionaryEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1499, 785);
            this.Controls.Add(this.DictionaryEditor);
            this.Controls.Add(this.ChangeImageMode);
            this.Controls.Add(this.ImageSkovokhText);
            this.Controls.Add(this.TransMode);
            this.Controls.Add(this.GenerateImage);
            this.Controls.Add(this.SkovToLatin);
            this.Controls.Add(this.SkovToEng);
            this.Controls.Add(this.LatinToSkov);
            this.Controls.Add(this.LatinToEng);
            this.Controls.Add(this.EngToSkov);
            this.Controls.Add(this.EngToLatin);
            this.Controls.Add(this.FinalPicture);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FinalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.PictureBox FinalPicture;
        private System.Windows.Forms.Button EngToLatin;
        private System.Windows.Forms.Button EngToSkov;
        private System.Windows.Forms.Button LatinToEng;
        private System.Windows.Forms.Button LatinToSkov;
        private System.Windows.Forms.Button SkovToEng;
        private System.Windows.Forms.Button SkovToLatin;
        private System.Windows.Forms.Button GenerateImage;
        private System.Windows.Forms.Button TransMode;
        private System.Windows.Forms.RichTextBox ImageSkovokhText;
        private System.Windows.Forms.Button ChangeImageMode;
        private System.Windows.Forms.Button DictionaryEditor;
    }
}

