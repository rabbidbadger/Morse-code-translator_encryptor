
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.encode_decode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please enter text for encryption/decryption below:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInput.Location = new System.Drawing.Point(13, 47);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(602, 234);
            this.userInput.TabIndex = 1;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(13, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(602, 28);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Encrypted/decryted text will be shown below:";
            // 
            // encode_decode
            // 
            this.encode_decode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encode_decode.Location = new System.Drawing.Point(12, 321);
            this.encode_decode.Multiline = true;
            this.encode_decode.Name = "encode_decode";
            this.encode_decode.Size = new System.Drawing.Size(603, 229);
            this.encode_decode.TabIndex = 3;
            this.encode_decode.TextChanged += new System.EventHandler(this.encode_decode_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(622, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Press to make the magic happen:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1108, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encode_decode);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox encode_decode;
        private System.Windows.Forms.Button button1;
    }
}

