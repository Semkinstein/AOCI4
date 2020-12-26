namespace AOCI1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.buttonBinarized = new System.Windows.Forms.Button();
            this.buttonShapes = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.buttonColorBinarization = new System.Windows.Forms.Button();
            this.trackBarColor = new System.Windows.Forms.TrackBar();
            this.trackBarDelta = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelta)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(627, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(506, 41);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(115, 45);
            this.trackBarThreshold.TabIndex = 4;
            this.trackBarThreshold.Value = 80;
            // 
            // buttonBinarized
            // 
            this.buttonBinarized.Location = new System.Drawing.Point(506, 74);
            this.buttonBinarized.Name = "buttonBinarized";
            this.buttonBinarized.Size = new System.Drawing.Size(115, 23);
            this.buttonBinarized.TabIndex = 5;
            this.buttonBinarized.Text = "Binarization";
            this.buttonBinarized.UseVisualStyleBackColor = true;
            this.buttonBinarized.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBinarized_MouseClick);
            // 
            // buttonShapes
            // 
            this.buttonShapes.Location = new System.Drawing.Point(506, 132);
            this.buttonShapes.Name = "buttonShapes";
            this.buttonShapes.Size = new System.Drawing.Size(115, 23);
            this.buttonShapes.TabIndex = 6;
            this.buttonShapes.Text = "Shapes";
            this.buttonShapes.UseVisualStyleBackColor = true;
            this.buttonShapes.Click += new System.EventHandler(this.buttonShapes_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(624, 516);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 7;
            // 
            // buttonColorBinarization
            // 
            this.buttonColorBinarization.Location = new System.Drawing.Point(506, 103);
            this.buttonColorBinarization.Name = "buttonColorBinarization";
            this.buttonColorBinarization.Size = new System.Drawing.Size(115, 23);
            this.buttonColorBinarization.TabIndex = 8;
            this.buttonColorBinarization.Text = "Color binarization";
            this.buttonColorBinarization.UseVisualStyleBackColor = true;
            this.buttonColorBinarization.Click += new System.EventHandler(this.buttonColorBinarization_Click);
            // 
            // trackBarColor
            // 
            this.trackBarColor.Location = new System.Drawing.Point(506, 162);
            this.trackBarColor.Maximum = 255;
            this.trackBarColor.Name = "trackBarColor";
            this.trackBarColor.Size = new System.Drawing.Size(115, 45);
            this.trackBarColor.TabIndex = 9;
            this.trackBarColor.Value = 30;
            // 
            // trackBarDelta
            // 
            this.trackBarDelta.Location = new System.Drawing.Point(506, 213);
            this.trackBarDelta.Maximum = 50;
            this.trackBarDelta.Name = "trackBarDelta";
            this.trackBarDelta.Size = new System.Drawing.Size(115, 45);
            this.trackBarDelta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Delta";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(506, 265);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 13;
            this.textBoxArea.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minimum Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarDelta);
            this.Controls.Add(this.trackBarColor);
            this.Controls.Add(this.buttonColorBinarization);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonShapes);
            this.Controls.Add(this.buttonBinarized);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Button buttonBinarized;
        private System.Windows.Forms.Button buttonShapes;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonColorBinarization;
        private System.Windows.Forms.TrackBar trackBarColor;
        private System.Windows.Forms.TrackBar trackBarDelta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label3;
    }
}

