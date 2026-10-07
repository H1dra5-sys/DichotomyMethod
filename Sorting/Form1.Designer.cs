namespace Sorting {
  partial class theDichotomyMethod {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.aBox = new System.Windows.Forms.TextBox();
      this.bBox = new System.Windows.Forms.TextBox();
      this.eArgBox = new System.Windows.Forms.TextBox();
      this.functionBox = new System.Windows.Forms.TextBox();
      this.functionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label5 = new System.Windows.Forms.Label();
      this.StepBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.AnswerField = new System.Windows.Forms.Label();
      this.Answer = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 338);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 51);
      this.label1.TabIndex = 1;
      this.label1.Text = "f(x) =";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 32);
      this.label2.TabIndex = 2;
      this.label2.Text = "a =";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 122);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 51);
      this.label3.TabIndex = 3;
      this.label3.Text = "b =";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(12, 198);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 51);
      this.label4.TabIndex = 4;
      this.label4.Text = "e =";
      // 
      // aBox
      // 
      this.aBox.Location = new System.Drawing.Point(92, 55);
      this.aBox.Name = "aBox";
      this.aBox.Size = new System.Drawing.Size(152, 20);
      this.aBox.TabIndex = 5;
      // 
      // bBox
      // 
      this.bBox.Location = new System.Drawing.Point(92, 128);
      this.bBox.Name = "bBox";
      this.bBox.Size = new System.Drawing.Size(152, 20);
      this.bBox.TabIndex = 6;
      // 
      // eArgBox
      // 
      this.eArgBox.Location = new System.Drawing.Point(92, 205);
      this.eArgBox.Name = "eArgBox";
      this.eArgBox.Size = new System.Drawing.Size(152, 20);
      this.eArgBox.TabIndex = 7;
      // 
      // functionBox
      // 
      this.functionBox.Location = new System.Drawing.Point(92, 345);
      this.functionBox.Name = "functionBox";
      this.functionBox.Size = new System.Drawing.Size(152, 20);
      this.functionBox.TabIndex = 8;
      // 
      // functionGraph
      // 
      chartArea1.Name = "ChartArea1";
      this.functionGraph.ChartAreas.Add(chartArea1);
      this.functionGraph.Location = new System.Drawing.Point(367, 48);
      this.functionGraph.Name = "functionGraph";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Name = "Series1";
      series1.YValuesPerPoint = 6;
      this.functionGraph.Series.Add(series1);
      this.functionGraph.Size = new System.Drawing.Size(468, 410);
      this.functionGraph.TabIndex = 9;
      this.functionGraph.Text = "functionGraph";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 264);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 51);
      this.label5.TabIndex = 10;
      this.label5.Text = "Шаг =";
      // 
      // StepBox
      // 
      this.StepBox.Location = new System.Drawing.Point(103, 270);
      this.StepBox.Name = "StepBox";
      this.StepBox.Size = new System.Drawing.Size(152, 20);
      this.StepBox.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(361, 463);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(268, 36);
      this.label6.TabIndex = 12;
      this.label6.Text = "Корень уравнения: ";
      // 
      // AnswerField
      // 
      this.AnswerField.AutoSize = true;
      this.AnswerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AnswerField.Location = new System.Drawing.Point(618, 463);
      this.AnswerField.Name = "AnswerField";
      this.AnswerField.Size = new System.Drawing.Size(0, 31);
      this.AnswerField.TabIndex = 13;
      // 
      // Answer
      // 
      this.Answer.AutoSize = true;
      this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Answer.Location = new System.Drawing.Point(618, 463);
      this.Answer.Name = "Answer";
      this.Answer.Size = new System.Drawing.Size(86, 31);
      this.Answer.TabIndex = 14;
      this.Answer.Text = "label7";
      this.Answer.Click += new System.EventHandler(this.Answer_Click);
      // 
      // theDichotomyMethod
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1001, 508);
      this.Controls.Add(this.Answer);
      this.Controls.Add(this.AnswerField);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.StepBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.functionGraph);
      this.Controls.Add(this.functionBox);
      this.Controls.Add(this.eArgBox);
      this.Controls.Add(this.bBox);
      this.Controls.Add(this.aBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "theDichotomyMethod";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox aBox;
    private System.Windows.Forms.TextBox bBox;
    private System.Windows.Forms.TextBox eArgBox;
    private System.Windows.Forms.TextBox functionBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart functionGraph;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox StepBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label AnswerField;
    private System.Windows.Forms.Label Answer;
  }
}