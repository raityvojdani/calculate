using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculate;

/// <summary>
/// Represents the main form of the application.
/// </summary>
public partial class Form1 : Form
{
    private readonly ICalculate _calculate;

    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
        _calculate = new Calculate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Validates the input values.
    /// </summary>
    /// <returns>True if inputs are valid; otherwise, false.</returns>
    private bool ValidateInputs()
    {
        bool isValid = true;

        if (txtNumber1.Value == 0)
        {
            isValid = false;
            MessageBox.Show("عدد اول را وارد کنید  ");
        }
        else if (txtNumber2.Value == 0)
        {
            isValid = false;
            MessageBox.Show("عدد دوم را وارد کنید  ");
        }

        return isValid;
    }

    private void btnMultiple_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            int multiple = _calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Multiple is :{multiple}");
        }
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            try
            {
                int divide = _calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show($"Divide is :{divide}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            int minus = _calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Minus is :{minus}");
        }
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            int plus = _calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Plus is :{plus}");
        }
    }
}
