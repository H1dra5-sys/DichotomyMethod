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
  public partial class SortingFunctions : Form {
    public SortingFunctions() {
      InitializeComponent();
    }

    private void CreateNewSortMenuForPuzirkovaya(object sender, EventArgs e) {
      FirstSort Puzireok = new FirstSort();
      Puzireok.Show();
    }
  }
}
