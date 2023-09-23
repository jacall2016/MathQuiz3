namespace MathQuiz
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel=new Label();
            label1=new Label();
            plusLeftLabel=new Label();
            label2=new Label();
            plusRightLabel=new Label();
            label4=new Label();
            sum=new NumericUpDown();
            difference=new NumericUpDown();
            label3=new Label();
            minusRightLabel=new Label();
            label6=new Label();
            minusLeftLabel=new Label();
            product=new NumericUpDown();
            label5=new Label();
            timesRightLabel=new Label();
            label8=new Label();
            timesLeftLabel=new Label();
            quotient=new NumericUpDown();
            label10=new Label();
            dividedRightLabel=new Label();
            label12=new Label();
            dividedLeftLabel=new Label();
            contextMenuStrip1=new ContextMenuStrip(components);
            startButton=new Button();
            date=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            timer2=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle=BorderStyle.FixedSingle;
            timeLabel.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location=new Point(259, 19);
            timeLabel.Name="timeLabel";
            timeLabel.Size=new Size(200, 30);
            timeLabel.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(127, 12);
            label1.Name="label1";
            label1.Size=new Size(126, 37);
            label1.TabIndex=1;
            label1.Text="Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Location=new Point(34, 67);
            plusLeftLabel.Name="plusLeftLabel";
            plusLeftLabel.Size=new Size(60, 50);
            plusLeftLabel.TabIndex=2;
            plusLeftLabel.Text="?";
            plusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location=new Point(115, 67);
            label2.Name="label2";
            label2.Size=new Size(60, 50);
            label2.TabIndex=3;
            label2.Text="+";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Location=new Point(204, 67);
            plusRightLabel.Name="plusRightLabel";
            plusRightLabel.Size=new Size(60, 50);
            plusRightLabel.TabIndex=4;
            plusRightLabel.Text="?";
            plusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location=new Point(293, 67);
            label4.Name="label4";
            label4.Size=new Size(60, 50);
            label4.TabIndex=5;
            label4.Text="=";
            label4.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location=new Point(359, 63);
            sum.Name="sum";
            sum.Size=new Size(100, 47);
            sum.TabIndex=1;
            sum.ValueChanged+=sum_ValueChanged;
            sum.Enter+=answer_Enter;
            // 
            // difference
            // 
            difference.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location=new Point(359, 116);
            difference.Name="difference";
            difference.Size=new Size(100, 47);
            difference.TabIndex=2;
            difference.ValueChanged+=difference_ValueChanged;
            difference.Enter+=answer_Enter;
            // 
            // label3
            // 
            label3.Location=new Point(293, 120);
            label3.Name="label3";
            label3.Size=new Size(60, 50);
            label3.TabIndex=10;
            label3.Text="=";
            label3.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Location=new Point(204, 120);
            minusRightLabel.Name="minusRightLabel";
            minusRightLabel.Size=new Size(60, 50);
            minusRightLabel.TabIndex=9;
            minusRightLabel.Text="?";
            minusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location=new Point(115, 120);
            label6.Name="label6";
            label6.Size=new Size(60, 50);
            label6.TabIndex=8;
            label6.Text="-";
            label6.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Location=new Point(34, 120);
            minusLeftLabel.Name="minusLeftLabel";
            minusLeftLabel.Size=new Size(60, 50);
            minusLeftLabel.TabIndex=7;
            minusLeftLabel.Text="?";
            minusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location=new Point(359, 169);
            product.Name="product";
            product.Size=new Size(100, 47);
            product.TabIndex=3;
            product.ValueChanged+=product_ValueChanged;
            product.Enter+=answer_Enter;
            // 
            // label5
            // 
            label5.Location=new Point(293, 173);
            label5.Name="label5";
            label5.Size=new Size(60, 50);
            label5.TabIndex=15;
            label5.Text="=";
            label5.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Location=new Point(204, 173);
            timesRightLabel.Name="timesRightLabel";
            timesRightLabel.Size=new Size(60, 50);
            timesRightLabel.TabIndex=14;
            timesRightLabel.Text="?";
            timesRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location=new Point(115, 173);
            label8.Name="label8";
            label8.Size=new Size(60, 50);
            label8.TabIndex=13;
            label8.Text="×";
            label8.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Location=new Point(34, 173);
            timesLeftLabel.Name="timesLeftLabel";
            timesLeftLabel.Size=new Size(60, 50);
            timesLeftLabel.TabIndex=12;
            timesLeftLabel.Text="?";
            timesLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location=new Point(359, 222);
            quotient.Name="quotient";
            quotient.Size=new Size(100, 47);
            quotient.TabIndex=4;
            quotient.ValueChanged+=quotient_ValueChanged;
            quotient.Enter+=answer_Enter;
            // 
            // label10
            // 
            label10.Location=new Point(293, 226);
            label10.Name="label10";
            label10.Size=new Size(60, 50);
            label10.TabIndex=20;
            label10.Text="=";
            label10.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Location=new Point(204, 226);
            dividedRightLabel.Name="dividedRightLabel";
            dividedRightLabel.Size=new Size(60, 50);
            dividedRightLabel.TabIndex=19;
            dividedRightLabel.Text="?";
            dividedRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Location=new Point(115, 226);
            label12.Name="label12";
            label12.Size=new Size(60, 50);
            label12.TabIndex=18;
            label12.Text="÷";
            label12.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Location=new Point(34, 226);
            dividedLeftLabel.Name="dividedLeftLabel";
            dividedLeftLabel.Size=new Size(60, 50);
            dividedLeftLabel.TabIndex=17;
            dividedLeftLabel.Text="?";
            dividedLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(20, 20);
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // startButton
            // 
            startButton.AutoSize=true;
            startButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location=new Point(293, 289);
            startButton.Name="startButton";
            startButton.Size=new Size(166, 42);
            startButton.TabIndex=0;
            startButton.Text="Start the quiz";
            startButton.UseVisualStyleBackColor=true;
            startButton.Click+=startButton_Click;
            // 
            // date
            // 
            date.AutoSize=true;
            date.Location=new Point(54, 304);
            date.Name="date";
            date.Size=new Size(106, 20);
            date.TabIndex=21;
            date.Text="dd month yyyy";
            date.Click+=date_Click;
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick+=timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(482, 353);
            Controls.Add(date);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label10);
            Controls.Add(dividedRightLabel);
            Controls.Add(label12);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label5);
            Controls.Add(timesRightLabel);
            Controls.Add(label8);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(label6);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="Form1";
            Text="James Call + Math Quiz";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label3;
        private Label minusRightLabel;
        private Label label6;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label label5;
        private Label timesRightLabel;
        private Label label8;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label label10;
        private Label dividedRightLabel;
        private Label label12;
        private Label dividedLeftLabel;
        private ContextMenuStrip contextMenuStrip1;
        private Button startButton;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}