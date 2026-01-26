namespace VirtCam
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            textBox1 = new TextBox();
            button3 = new Button();
            imageBox2 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(4, 2);
            button1.Name = "button1";
            button1.Size = new Size(55, 50);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 2);
            button2.Name = "button2";
            button2.Size = new Size(55, 50);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 55);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Видеоустройтсво";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(4, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Фильтр";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(193, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 23);
            comboBox2.TabIndex = 5;
            // 
            // imageBox1
            // 
            imageBox1.Location = new Point(826, 12);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(359, 255);
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 336);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(126, 2);
            button3.Name = "button3";
            button3.Size = new Size(55, 50);
            button3.TabIndex = 7;
            button3.Text = "Init";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // imageBox2
            // 
            imageBox2.Location = new Point(826, 318);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(359, 255);
            imageBox2.TabIndex = 8;
            imageBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 585);
            Controls.Add(imageBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(imageBox1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "VideoAfterFilter";
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private TextBox textBox1;
        private Button button3;
        private Emgu.CV.UI.ImageBox imageBox2;
    }
}
