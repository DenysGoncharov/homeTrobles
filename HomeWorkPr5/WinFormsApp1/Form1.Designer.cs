
namespace WinFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.loadFromXML = new System.Windows.Forms.Button();
            this.saveToXML = new System.Windows.Forms.Button();
            this.loadFromRegister = new System.Windows.Forms.Button();
            this.saveToRegister = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 94);
            this.listBox1.TabIndex = 0;
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Location = new System.Drawing.Point(15, 117);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(291, 33);
            this.chooseColorButton.TabIndex = 1;
            this.chooseColorButton.Text = "Choose Color";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.chooseColorButton_Click);
            // 
            // loadFromXML
            // 
            this.loadFromXML.Location = new System.Drawing.Point(15, 156);
            this.loadFromXML.Name = "loadFromXML";
            this.loadFromXML.Size = new System.Drawing.Size(120, 23);
            this.loadFromXML.TabIndex = 2;
            this.loadFromXML.Text = "Load from XML";
            this.loadFromXML.UseVisualStyleBackColor = true;
            this.loadFromXML.Click += new System.EventHandler(this.loadFromXML_Click);
            // 
            // saveToXML
            // 
            this.saveToXML.Location = new System.Drawing.Point(15, 185);
            this.saveToXML.Name = "saveToXML";
            this.saveToXML.Size = new System.Drawing.Size(120, 23);
            this.saveToXML.TabIndex = 3;
            this.saveToXML.Text = "Save to XML";
            this.saveToXML.UseVisualStyleBackColor = true;
            this.saveToXML.Click += new System.EventHandler(this.saveToXML_Click);
            // 
            // loadFromRegister
            // 
            this.loadFromRegister.Location = new System.Drawing.Point(193, 156);
            this.loadFromRegister.Name = "loadFromRegister";
            this.loadFromRegister.Size = new System.Drawing.Size(120, 23);
            this.loadFromRegister.TabIndex = 4;
            this.loadFromRegister.Text = "Load from Register";
            this.loadFromRegister.UseVisualStyleBackColor = true;
            this.loadFromRegister.Click += new System.EventHandler(this.loadFromRegister_Click);
            // 
            // saveToRegister
            // 
            this.saveToRegister.Location = new System.Drawing.Point(193, 186);
            this.saveToRegister.Name = "saveToRegister";
            this.saveToRegister.Size = new System.Drawing.Size(120, 23);
            this.saveToRegister.TabIndex = 5;
            this.saveToRegister.Text = "Save to Register";
            this.saveToRegister.UseVisualStyleBackColor = true;
            this.saveToRegister.Click += new System.EventHandler(this.saveToRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 221);
            this.Controls.Add(this.saveToRegister);
            this.Controls.Add(this.loadFromRegister);
            this.Controls.Add(this.saveToXML);
            this.Controls.Add(this.loadFromXML);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button loadFromXML;
        private System.Windows.Forms.Button saveToXML;
        private System.Windows.Forms.Button loadFromRegister;
        private System.Windows.Forms.Button saveToRegister;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

