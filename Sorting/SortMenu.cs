using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting {
  public partial class SortMenu : Form {
    public SortMenu() {
      InitializeComponent();
    }

    private void SortMenu_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      SortingFunctions teleportButton = new SortingFunctions();
      this.Hide();
      teleportButton.Show();
    }

    private void button2_Click(object sender, EventArgs e) {
      theDichotomyMethod teleportButton2 = new theDichotomyMethod();
      this.Hide();
      teleportButton2.Show();
    }
  }
}
