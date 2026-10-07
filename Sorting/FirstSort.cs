using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting {
  public partial class FirstSort : Form {

    public FirstSort() {
      InitializeComponent();
    }

    private void NumberForSortFirstInput_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      int number = (int)NumberForSortFirstInput.Rows[0].Cells[0].Value;
    }

    private void AnswerField_TextChanged(object sender, EventArgs e) {
      }

    private void NumberForSortFirstInput_DataError(object sender, DataGridViewDataErrorEventArgs e) {
      e.ThrowException = false;

      MessageBox.Show("Введите корректное число!");
    }

    private void рассчитатьОтветToolStripMenuItem_Click(object sender, EventArgs e) {
      AnswerField.Text = "25";
      MessageBox.Show("Клик сработал!");
    }
  }
}