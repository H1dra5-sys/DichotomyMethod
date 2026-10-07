namespace Sorting {
  partial class SortingFunctions {
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.выборСортировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.пузырьковаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вставкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.шейкернаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.быстраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборСортировокToolStripMenuItem,
            this.очиститьРезультатыToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // выборСортировокToolStripMenuItem
      // 
      this.выборСортировокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пузырьковаяToolStripMenuItem,
            this.вставкамиToolStripMenuItem,
            this.шейкернаяToolStripMenuItem,
            this.быстраяToolStripMenuItem,
            this.bOGOToolStripMenuItem});
      this.выборСортировокToolStripMenuItem.Name = "выборСортировокToolStripMenuItem";
      this.выборСортировокToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
      this.выборСортировокToolStripMenuItem.Text = "Выбор сортировок";
      // 
      // пузырьковаяToolStripMenuItem
      // 
      this.пузырьковаяToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
      this.пузырьковаяToolStripMenuItem.Name = "пузырьковаяToolStripMenuItem";
      this.пузырьковаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.пузырьковаяToolStripMenuItem.Text = "Пузырьковая";
      this.пузырьковаяToolStripMenuItem.Click += new System.EventHandler(this.CreateNewSortMenuForPuzirkovaya);
      // 
      // вставкамиToolStripMenuItem
      // 
      this.вставкамиToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
      this.вставкамиToolStripMenuItem.Name = "вставкамиToolStripMenuItem";
      this.вставкамиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.вставкамиToolStripMenuItem.Text = "Вставками";
      // 
      // шейкернаяToolStripMenuItem
      // 
      this.шейкернаяToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
      this.шейкернаяToolStripMenuItem.Name = "шейкернаяToolStripMenuItem";
      this.шейкернаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.шейкернаяToolStripMenuItem.Text = "Шейкерная";
      // 
      // быстраяToolStripMenuItem
      // 
      this.быстраяToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
      this.быстраяToolStripMenuItem.Name = "быстраяToolStripMenuItem";
      this.быстраяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.быстраяToolStripMenuItem.Text = "Быстрая";
      // 
      // bOGOToolStripMenuItem
      // 
      this.bOGOToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
      this.bOGOToolStripMenuItem.Name = "bOGOToolStripMenuItem";
      this.bOGOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.bOGOToolStripMenuItem.Text = "BOGO";
      // 
      // очиститьРезультатыToolStripMenuItem
      // 
      this.очиститьРезультатыToolStripMenuItem.Name = "очиститьРезультатыToolStripMenuItem";
      this.очиститьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
      this.очиститьРезультатыToolStripMenuItem.Text = "Очистить результаты";
      // 
      // SortingFunctions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "SortingFunctions";
      this.Text = "SortingFunctions";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem выборСортировокToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem пузырьковаяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вставкамиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem шейкернаяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem быстраяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bOGOToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьРезультатыToolStripMenuItem;
  }
}