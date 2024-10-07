using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculate;

public partial class Form1 : Form
{
    ICalculate calculate;
    public Form1()
    {
        InitializeComponent();
        calculate = new Calculate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    

    bool validateInputs()
    {
        bool isValid = true;

        if (txtNumber1.Value == 0)
        {
            isValid = false;
            MessageBox.Show("عدد اول را وارد کنید  ");
        }
        else
        {
            if (txtNumber2.Value == 0)
            {
                isValid = false;
                MessageBox.Show("عدد دوم را وارد کنید  ");
            }
        }

        return isValid;
    }

    private void btnMultiple_Click(object sender, EventArgs e)
    {
        if (validateInputs())
        {
           int multiple= calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Multiple is :{multiple}");
        }
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        if (validateInputs())
        {
           int divide= calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Divide is :{divide}");
        }
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        if (validateInputs())
        {
           int minus= calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Minus is :{minus}");
        }
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        if (validateInputs())
        {
           int plus= calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
            MessageBox.Show($"Plus is :{plus}");
        }

    }
}
