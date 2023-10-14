namespace cypherapp
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
            label1 = new Label();
            label2 = new Label();
            encbutton = new Button();
            label3 = new Label();
            label4 = new Label();
            dectextbox = new TextBox();
            decbutton = new Button();
            enctextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "ENCRYPT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 225);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "DECRYPT";
            // 
            // encbutton
            // 
            encbutton.Location = new Point(299, 139);
            encbutton.Name = "encbutton";
            encbutton.Size = new Size(75, 23);
            encbutton.TabIndex = 3;
            encbutton.Text = "ENCRYPT";
            encbutton.UseVisualStyleBackColor = true;
            encbutton.Click += encbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 66);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 294);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Enter text";
            // 
            // dectextbox
            // 
            dectextbox.Location = new Point(234, 253);
            dectextbox.Multiline = true;
            dectextbox.Name = "dectextbox";
            dectextbox.Size = new Size(225, 87);
            dectextbox.TabIndex = 6;
            // 
            // decbutton
            // 
            decbutton.Location = new Point(299, 356);
            decbutton.Name = "decbutton";
            decbutton.Size = new Size(75, 23);
            decbutton.TabIndex = 7;
            decbutton.Text = "Decrypt";
            decbutton.UseVisualStyleBackColor = true;
            decbutton.Click += decbutton_Click;
            // 
            // enctextbox
            // 
            enctextbox.Location = new Point(234, 27);
            enctextbox.Multiline = true;
            enctextbox.Name = "enctextbox";
            enctextbox.Size = new Size(225, 87);
            enctextbox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 391);
            Controls.Add(enctextbox);
            Controls.Add(decbutton);
            Controls.Add(dectextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(encbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button encbutton;
        private Label label3;
        private Label label4;
        private TextBox dectextbox;
        private Button decbutton;
        private TextBox enctextbox;
    }
}