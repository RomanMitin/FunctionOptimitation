namespace FunctionOptimitation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.AtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.W1textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.W2textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aTextBox2 = new System.Windows.Forms.TextBox();
            this.bTextBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FuncChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxStepTextBox = new System.Windows.Forms.TextBox();
            this.EpsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ParamTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ParamTextBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MinValTextBox = new System.Windows.Forms.TextBox();
            this.MinCoordTextBox = new System.Windows.Forms.TextBox();
            this.IterNumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FuncChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "F(x) = ";
            // 
            // AtextBox
            // 
            this.AtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtextBox.Location = new System.Drawing.Point(61, 29);
            this.AtextBox.Name = "AtextBox";
            this.AtextBox.Size = new System.Drawing.Size(45, 26);
            this.AtextBox.TabIndex = 1;
            this.AtextBox.Text = "2";
            this.AtextBox.Validated += new System.EventHandler(this.AtextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Sin( ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Cos( ";
            // 
            // W1textBox
            // 
            this.W1textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W1textBox.Location = new System.Drawing.Point(160, 30);
            this.W1textBox.Name = "W1textBox";
            this.W1textBox.Size = new System.Drawing.Size(35, 26);
            this.W1textBox.TabIndex = 4;
            this.W1textBox.Text = "3.0";
            this.W1textBox.Validated += new System.EventHandler(this.W1textBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "* x ) + ";
            // 
            // BtextBox
            // 
            this.BtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtextBox.Location = new System.Drawing.Point(245, 30);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(50, 26);
            this.BtextBox.TabIndex = 6;
            this.BtextBox.Text = "3";
            this.BtextBox.Validated += new System.EventHandler(this.BtextBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "* x )";
            // 
            // W2textBox
            // 
            this.W2textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W2textBox.Location = new System.Drawing.Point(349, 29);
            this.W2textBox.Name = "W2textBox";
            this.W2textBox.Size = new System.Drawing.Size(35, 26);
            this.W2textBox.TabIndex = 7;
            this.W2textBox.Text = "5.0";
            this.W2textBox.Validated += new System.EventHandler(this.W2textBox_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "a = ";
            // 
            // aTextBox2
            // 
            this.aTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBox2.Location = new System.Drawing.Point(54, 73);
            this.aTextBox2.Name = "aTextBox2";
            this.aTextBox2.Size = new System.Drawing.Size(45, 26);
            this.aTextBox2.TabIndex = 10;
            this.aTextBox2.Text = "0.0";
            this.aTextBox2.Validated += new System.EventHandler(this.aTextBox2_Validated);
            // 
            // bTextBox2
            // 
            this.bTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBox2.Location = new System.Drawing.Point(54, 103);
            this.bTextBox2.Name = "bTextBox2";
            this.bTextBox2.Size = new System.Drawing.Size(45, 26);
            this.bTextBox2.TabIndex = 12;
            this.bTextBox2.Text = "8";
            this.bTextBox2.Validated += new System.EventHandler(this.bTextBox2_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "b = ";
            // 
            // FuncChart
            // 
            chartArea1.Name = "ChartArea1";
            this.FuncChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FuncChart.Legends.Add(legend1);
            this.FuncChart.Location = new System.Drawing.Point(279, 76);
            this.FuncChart.Name = "FuncChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.FuncChart.Series.Add(series1);
            this.FuncChart.Size = new System.Drawing.Size(737, 343);
            this.FuncChart.TabIndex = 13;
            this.FuncChart.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(16, 159);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 35);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Max step = ";
            // 
            // MaxStepTextBox
            // 
            this.MaxStepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxStepTextBox.Location = new System.Drawing.Point(195, 70);
            this.MaxStepTextBox.Name = "MaxStepTextBox";
            this.MaxStepTextBox.Size = new System.Drawing.Size(78, 26);
            this.MaxStepTextBox.TabIndex = 16;
            this.MaxStepTextBox.Text = "100";
            this.MaxStepTextBox.Validated += new System.EventHandler(this.MaxStepTextBox_Validated);
            // 
            // EpsTextBox
            // 
            this.EpsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpsTextBox.Location = new System.Drawing.Point(195, 106);
            this.EpsTextBox.Name = "EpsTextBox";
            this.EpsTextBox.Size = new System.Drawing.Size(78, 26);
            this.EpsTextBox.TabIndex = 18;
            this.EpsTextBox.Text = "0.001";
            this.EpsTextBox.Validated += new System.EventHandler(this.EpsTextBox_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Epsilon = ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(192, 62);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(184, 36);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scanning";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "No param in this metod";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ParamTextBox);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(184, 36);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Piyavski";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ParamTextBox
            // 
            this.ParamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParamTextBox.Location = new System.Drawing.Point(35, 0);
            this.ParamTextBox.Name = "ParamTextBox";
            this.ParamTextBox.Size = new System.Drawing.Size(82, 26);
            this.ParamTextBox.TabIndex = 21;
            this.ParamTextBox.Text = "10";
            this.ParamTextBox.Validated += new System.EventHandler(this.ParamTextBox_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "m = ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ParamTextBox2);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(184, 36);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Strongin";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ParamTextBox2
            // 
            this.ParamTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParamTextBox2.Location = new System.Drawing.Point(32, 3);
            this.ParamTextBox2.Name = "ParamTextBox2";
            this.ParamTextBox2.Size = new System.Drawing.Size(82, 26);
            this.ParamTextBox2.TabIndex = 1;
            this.ParamTextBox2.Text = "2";
            this.ParamTextBox2.Validated += new System.EventHandler(this.ParamTextBox2_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "r = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Choose metod:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Found min value = ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Found min coordinate = ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Number of iteration = ";
            // 
            // MinValTextBox
            // 
            this.MinValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinValTextBox.Location = new System.Drawing.Point(189, 322);
            this.MinValTextBox.Name = "MinValTextBox";
            this.MinValTextBox.ReadOnly = true;
            this.MinValTextBox.Size = new System.Drawing.Size(84, 26);
            this.MinValTextBox.TabIndex = 23;
            // 
            // MinCoordTextBox
            // 
            this.MinCoordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinCoordTextBox.Location = new System.Drawing.Point(189, 354);
            this.MinCoordTextBox.Name = "MinCoordTextBox";
            this.MinCoordTextBox.ReadOnly = true;
            this.MinCoordTextBox.Size = new System.Drawing.Size(84, 26);
            this.MinCoordTextBox.TabIndex = 24;
            // 
            // IterNumTextBox
            // 
            this.IterNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterNumTextBox.Location = new System.Drawing.Point(189, 386);
            this.IterNumTextBox.Name = "IterNumTextBox";
            this.IterNumTextBox.ReadOnly = true;
            this.IterNumTextBox.Size = new System.Drawing.Size(84, 26);
            this.IterNumTextBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.IterNumTextBox);
            this.Controls.Add(this.MinCoordTextBox);
            this.Controls.Add(this.MinValTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.EpsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MaxStepTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FuncChart);
            this.Controls.Add(this.bTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.W2textBox);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.W1textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GlobalOptimitation";
            ((System.ComponentModel.ISupportInitialize)(this.FuncChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox W1textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox W2textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aTextBox2;
        private System.Windows.Forms.TextBox bTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart FuncChart;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxStepTextBox;
        private System.Windows.Forms.TextBox EpsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ParamTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox ParamTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MinValTextBox;
        private System.Windows.Forms.TextBox MinCoordTextBox;
        private System.Windows.Forms.TextBox IterNumTextBox;
    }
}

