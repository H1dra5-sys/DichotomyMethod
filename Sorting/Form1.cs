using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting {
  public partial class theDichotomyMethod : Form {
    public theDichotomyMethod() {
      InitializeComponent();
    }

    private void Answer_Click(object sender, EventArgs e) {

    }

    double a, b, originalA, originalB, eArg, x, y, step, half, Fa, Fb, Fhalf, fakeEArg;
    string formulaReplace, formula, format;
    int iterations, maxIterations, decimalPlaces;
    NCalc.Expression expression;
    bool divisionByZero;

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
      aBox.Clear();
      bBox.Clear();
      eArgBox.Clear();
      StepBox.Clear();
      Answer.Text = "";
      functionBox.Clear();

    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
      Answer.Text = "";
      maxIterations = 1000;
      divisionByZero = false;


      if (!double.TryParse(aBox.Text, out a) || !double.TryParse(bBox.Text, out b) || !double.TryParse(eArgBox.Text, out eArg) || !double.TryParse(StepBox.Text, out step)) {
        MessageBox.Show("Введите коректные числа");
        aBox.Clear();
        bBox.Clear();
        eArgBox.Clear();
        StepBox.Clear();
        return;
      }

      if (a > b) {
        MessageBox.Show("Ваше минимальное значение a превышает максимальное, чтобы график построился измените числа");
        return;
      }

      ///Присваиваю Оригинальным значения A и B, чтобы в будущем построение графика не руинилось
      originalA = a;
      originalB = b;
      fakeEArg = eArg;

      functionGraph.Series[0].Points.Clear();
      functionGraph.ChartAreas[0].AxisX.Minimum = a;
      functionGraph.ChartAreas[0].AxisX.Maximum = b;
      formula = functionBox.Text;
      formulaReplace = formula.Replace("x", "[x]");

      expression = new NCalc.Expression(formulaReplace);
      expression.Parameters["x"] = a;
      Fa = Convert.ToDouble(expression.Evaluate());

      expression.Parameters["x"] = b;
      Fb = Convert.ToDouble(expression.Evaluate());

      if (double.IsNaN(Fa) || double.IsInfinity(Fa) || double.IsNaN(Fb) || double.IsInfinity(Fb)) {
        MessageBox.Show("У вас значения функции в точке a или b недопустимы, измените a и b");
      }

      if (Fa == 0) {
        Answer.Text = a.ToString();
      } else if (Fb == 0) {
        Answer.Text = b.ToString();
      } else if (Fa * Fb > 0) {
        MessageBox.Show("Чтобы метод дихотомии работал надо чтоб f(a)*f(b) было меньше 0, введите другие значения");
      } else {
        half = (a + b) / 2;
        while (Math.Abs(b - a) >= fakeEArg && maxIterations > iterations) {
          half = (a + b) / 2;
          expression.Parameters["x"] = half;
          Fhalf = Convert.ToDouble(expression.Evaluate());

          if (double.IsNaN(Fhalf) || double.IsInfinity(Fhalf)) {
            MessageBox.Show("Функция не определена внутри интервала. Метод дихотомии не применим.");
            return;
          }
          if (Fhalf == 0) {
            break;
          }

          if (Fa * Fhalf < 0) {
            b = half;
            Fb = Fhalf;
          } else if (Fb * Fhalf < 0) {
            a = half;
            Fa = Fhalf;
          }
          ++iterations;
        }
      }

      decimalPlaces = (int)Math.Ceiling(-Math.Log10(eArg));
      if (decimalPlaces < 0) {
        decimalPlaces = 0;
      }

      if (decimalPlaces > 15) {
        decimalPlaces = 15; 
      }
      Answer.Text = half.ToString("F" + decimalPlaces);

      if (iterations >= maxIterations) {
        MessageBox.Show("Превышено максимальное количество итераций. Возможно, корень не найден или точность слишком высокая.");
      }

      for (x = originalA; x <= originalB;x += step) {
        expression = new NCalc.Expression(formulaReplace);
        expression.Parameters["x"] = x;
        y = Convert.ToDouble(expression.Evaluate());

        if (double.IsNaN(y) || double.IsInfinity(y)) {
          divisionByZero = true;
          continue;
        }
        functionGraph.Series[0].Points.AddXY(x, y);
      }
      if (divisionByZero == true) {
        MessageBox.Show("Вы поделили на 0 и теперь ваш график не правильно построился, старайтесь не подбирать такие значения, при которых будет происходить деление на 0");
      }
      functionGraph.ChartAreas[0].RecalculateAxesScale();
    }
  }
}
