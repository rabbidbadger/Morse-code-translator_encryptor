
namespace Morse_code_translator_encryptor
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userInput = new System.Windows.Forms.TextBox();
            this.encode_decode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decoded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.translateLoadedFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.translateMorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInput.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userInput.Location = new System.Drawing.Point(13, 47);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInput.Size = new System.Drawing.Size(531, 141);
            this.userInput.TabIndex = 1;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // encode_decode
            // 
            this.encode_decode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encode_decode.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encode_decode.ForeColor = System.Drawing.Color.Red;
            this.encode_decode.Location = new System.Drawing.Point(13, 395);
            this.encode_decode.Multiline = true;
            this.encode_decode.Name = "encode_decode";
            this.encode_decode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encode_decode.Size = new System.Drawing.Size(532, 146);
            this.encode_decode.TabIndex = 3;
            this.encode_decode.TextChanged += new System.EventHandler(this.encode_decode_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Press to make the magic happen with your own entered text:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter text for Encryption/Decryption below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translated text/morse will be shown below:";
            // 
            // decoded
            // 
            this.decoded.Location = new System.Drawing.Point(588, 395);
            this.decoded.Multiline = true;
            this.decoded.Name = "decoded";
            this.decoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decoded.Size = new System.Drawing.Size(498, 146);
            this.decoded.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(602, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decrypted user text:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(588, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(484, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load File:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(588, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 141);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // translateLoadedFile
            // 
            this.translateLoadedFile.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.translateLoadedFile.Location = new System.Drawing.Point(588, 229);
            this.translateLoadedFile.Name = "translateLoadedFile";
            this.translateLoadedFile.Size = new System.Drawing.Size(484, 29);
            this.translateLoadedFile.TabIndex = 11;
            this.translateLoadedFile.Text = "Translate Loaded text file";
            this.translateLoadedFile.UseVisualStyleBackColor = true;
            this.translateLoadedFile.Click += new System.EventHandler(this.translateLoadedFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(588, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loaded text will appear below:";
            // 
            // translateMorse
            // 
            this.translateMorse.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.translateMorse.Location = new System.Drawing.Point(588, 265);
            this.translateMorse.Name = "translateMorse";
            this.translateMorse.Size = new System.Drawing.Size(484, 29);
            this.translateMorse.TabIndex = 13;
            this.translateMorse.Text = "Translated Loaded morse code file";
            this.translateMorse.UseVisualStyleBackColor = true;
            this.translateMorse.Click += new System.EventHandler(this.translateMorse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1108, 553);
            this.Controls.Add(this.translateMorse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.translateLoadedFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decoded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encode_decode);
            this.Controls.Add(this.userInput);
            this.Name = "Form1";
            this.Text = "Decrypted user text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox encode_decode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decoded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button translateLoadedFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button translateMorse;
    }
}

