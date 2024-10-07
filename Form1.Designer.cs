namespace calculate;

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
        label1 = new Label();
        label2 = new Label();
        txtNumber1 = new NumericUpDown();
        txtNumber2 = new NumericUpDown();
        btnPlus = new Button();
        btnMinus = new Button();
        btnMultiple = new Button();
        btnDivide = new Button();
        ((System.ComponentModel.ISupportInitialize)txtNumber1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtNumber2).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(388, 24);
        label1.Name = "label1";
        label1.Size = new Size(57, 18);
        label1.TabIndex = 0;
        label1.Text = "عدد اول";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(386, 68);
        label2.Name = "label2";
        label2.Size = new Size(59, 18);
        label2.TabIndex = 1;
        label2.Text = "عدد دوم";
        // 
        // txtNumber1
        // 
        txtNumber1.Location = new Point(168, 16);
        txtNumber1.Name = "txtNumber1";
        txtNumber1.Size = new Size(150, 26);
        txtNumber1.TabIndex = 2;
        // 
        // txtNumber2
        // 
        txtNumber2.Location = new Point(168, 60);
        txtNumber2.Name = "txtNumber2";
        txtNumber2.Size = new Size(150, 26);
        txtNumber2.TabIndex = 3;
        // 
        // btnPlus
        // 
        btnPlus.Location = new Point(110, 114);
        btnPlus.Name = "btnPlus";
        btnPlus.Size = new Size(68, 28);
        btnPlus.TabIndex = 4;
        btnPlus.Text = "+";
        btnPlus.UseVisualStyleBackColor = true;
        btnPlus.Click += btnPlus_Click;
        // 
        // btnMinus
        // 
        btnMinus.Location = new Point(201, 114);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new Size(68, 28);
        btnMinus.TabIndex = 5;
        btnMinus.Text = "-";
        btnMinus.UseVisualStyleBackColor = true;
        btnMinus.Click += btnMinus_Click;
        // 
        // btnMultiple
        // 
        btnMultiple.Location = new Point(287, 114);
        btnMultiple.Name = "btnMultiple";
        btnMultiple.Size = new Size(68, 28);
        btnMultiple.TabIndex = 6;
        btnMultiple.Text = "*";
        btnMultiple.UseVisualStyleBackColor = true;
        btnMultiple.Click += btnMultiple_Click;
        // 
        // btnDivide
        // 
        btnDivide.Location = new Point(377, 114);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(68, 28);
        btnDivide.TabIndex = 7;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += btnDivide_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(565, 174);
        Controls.Add(btnDivide);
        Controls.Add(btnMultiple);
        Controls.Add(btnMinus);
        Controls.Add(btnPlus);
        Controls.Add(txtNumber2);
        Controls.Add(txtNumber1);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        RightToLeft = RightToLeft.Yes;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ماشین حساب من";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)txtNumber1).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtNumber2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private NumericUpDown txtNumber1;
    private NumericUpDown txtNumber2;
    private Button btnPlus;
    private Button btnMinus;
    private Button btnMultiple;
    private Button btnDivide;
}
