using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestForms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            testButton.ForeColor = Color.Crimson;
            testComboBox.ForeColor = Color.Crimson;
            testlstView.ForeColor = Color.Crimson;

            testRichBox.Text = @"Dynamic Test Rich Box";
            testLabel.Text = @"Dynamic Test Label";
            testTextBox.Text = @"Dynamic Test Box";
            testPanel.Text = @"Test Panel";
            testMaskedTxtBox.Text = @"(111) 111-1111";

            testCheckBox.Checked = false;
            testRadioBtn.Checked = true;

            testCalendar.MaxDate = new DateTime(2020, 7, 9);
            testCalendar.MinDate = new DateTime(2020, 1, 9);
            testDateTimePicker.MaxDate = new DateTime(2021, 7, 9);
            testDateTimePicker.MinDate = new DateTime(2021, 1, 9);

            testComboBox.SelectedIndex = 3;
            checkedLstBox.SelectedIndex = 4;
            testLstBox.SelectedIndex = 2;
            testNumericDown.DecimalPlaces = 0;
            testNumericDown.Value = 20;
            testProgressBar.Minimum = 0;
            testProgressBar.Maximum = 100;
            testProgressBar.Value = 20;
        }
    }
}
