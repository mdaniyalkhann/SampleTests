using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Shouldly;
using TestForms;

namespace TestNinja.Tests
{
    [TestFixture, ExcludeFromCodeCoverage, Category("AUT Tool Version 1.2.5.0")]
    public class TestFormTests
    {
        private const string MethodNameInitialize = "Initialize";
        private PrivateType _privateType;
        private CultureInfo _currentCulture;
        private PrivateObject _privateObject;
        private TestForm _testObject;
        private List<IDisposable> _disposableObjects;
        private IList<IStructuralComparable> _methodInvocationsList;
        private Label _testLabel;
        private Button _testButton;
        private CheckBox _testCheckBox;
        private CheckedListBox _checkedLstBox;
        private ComboBox _testComboBox;
        private DateTimePicker _testDateTimePicker;
        private ListBox _testLstBox;
        private ListView _testlstView;
        private MaskedTextBox _testMaskedTxtBox;
        private MonthCalendar _testCalendar;
        private NumericUpDown _testNumericDown;
        private ProgressBar _testProgressBar;
        private RadioButton _testRadioBtn;
        private RichTextBox _testRichBox;
        private TextBox _testTextBox;
        private TreeView _treeView1;
        private Panel _testPanel;

        [OneTimeSetUp]
        public void OneTimeInitialize()
        {
            _currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            _disposableObjects = new List<IDisposable>();
        }

        [SetUp]
        public void Initialize()
        {
            _methodInvocationsList = new List<IStructuralComparable>();
            _testObject = new TestForm();
            _privateType = new PrivateType(typeof(TestForm));
            _privateObject = new PrivateObject(
                _testObject,
                _privateType);
            _privateObject.SetField(
                "testLabel",
                _testLabel = new Label { Name = "_testLabel" });
            _disposableObjects.Add(_testLabel);
            _privateObject.SetField(
                "testButton",
                _testButton = new Button { Name = "_testButton" });
            _disposableObjects.Add(_testButton);
            _privateObject.SetField(
                "testCheckBox",
                _testCheckBox = new CheckBox { Name = "_testCheckBox" });
            _disposableObjects.Add(_testCheckBox);
            _checkedLstBox = (CheckedListBox)_privateObject.GetField("checkedLstBox");
            _testComboBox = (ComboBox)_privateObject.GetField("testComboBox");
            _testLstBox = (ListBox)_privateObject.GetField("testLstBox");
            _testlstView = (ListView)_privateObject.GetField("testlstView");
            _disposableObjects.Add(_checkedLstBox);
            _disposableObjects.Add(_testComboBox);
            _privateObject.SetField(
                "testDateTimePicker",
                _testDateTimePicker = new DateTimePicker { Name = "_testDateTimePicker" });
            _disposableObjects.Add(_testDateTimePicker);
            _disposableObjects.Add(_testLstBox);
            _disposableObjects.Add(_testlstView);
            _privateObject.SetField(
                "testMaskedTxtBox",
                _testMaskedTxtBox = new MaskedTextBox { Name = "_testMaskedTxtBox" });
            _disposableObjects.Add(_testMaskedTxtBox);
            _privateObject.SetField(
                "testCalendar",
                _testCalendar = new MonthCalendar { Name = "_testCalendar" });
            _disposableObjects.Add(_testCalendar);
            _privateObject.SetField(
                "testNumericDown",
                _testNumericDown = new NumericUpDown { Name = "_testNumericDown" });
            _disposableObjects.Add(_testNumericDown);
            _privateObject.SetField(
                "testProgressBar",
                _testProgressBar = new ProgressBar { Name = "_testProgressBar" });
            _disposableObjects.Add(_testProgressBar);
            _privateObject.SetField(
                "testRadioBtn",
                _testRadioBtn = new RadioButton { Name = "_testRadioBtn" });
            _disposableObjects.Add(_testRadioBtn);
            _privateObject.SetField(
                "testRichBox",
                _testRichBox = new RichTextBox { Name = "_testRichBox" });
            _disposableObjects.Add(_testRichBox);
            _privateObject.SetField(
                "testTextBox",
                _testTextBox = new TextBox { Name = "_testTextBox" });
            _disposableObjects.Add(_testTextBox);
            _privateObject.SetField(
                "treeView1",
                _treeView1 = new TreeView { Name = "_treeView1" });
            _disposableObjects.Add(_treeView1);
            _privateObject.SetField(
                "testPanel",
                _testPanel = new Panel { Name = "_testPanel" });
            _disposableObjects.Add(_testPanel);
        }

        [TearDown]
        public void CleanUp()
        {
            _testObject?.Dispose();
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {
            Thread.CurrentThread.CurrentCulture = _currentCulture;
            _disposableObjects.ForEach(o => o?.Dispose());
        }

        [Test]
        public void Initialize_WhenCalled_VerifyInvocations()
        {
            // Arrange, Act
            _privateObject.Invoke(MethodNameInitialize);

            // Assert
            this.ShouldSatisfyAllConditions(
                () => _testMaskedTxtBox.Lines.ShouldHaveSingleItem(),
                () => _testMaskedTxtBox.Lines.Length.ShouldBe(1),
                () => _testTextBox.Lines.ShouldHaveSingleItem(),
                () => _testTextBox.Lines.Length.ShouldBe(1));
            this.ShouldSatisfyAllConditions(
                () => _testLabel.Text.ShouldBe("Dynamic Test Label"),
                () => _testButton.ForeColor.Name.ShouldBe("Crimson"),
                () => _testDateTimePicker.MaxDate.ToString(CultureInfo.InvariantCulture).ShouldBe("07/09/2021 00:00:00"),
                () => _testDateTimePicker.MinDate.ToString(CultureInfo.InvariantCulture).ShouldBe("01/09/2021 00:00:00"),
                () => _testDateTimePicker.Value.ToString(CultureInfo.InvariantCulture).ShouldBe("01/09/2021 00:00:00"),
                () => _testMaskedTxtBox.Text.ShouldBe("(111) 111-1111"),
                () => _testCalendar.MaxDate.ToString(CultureInfo.InvariantCulture).ShouldBe("07/09/2020 00:00:00"),
                () => _testCalendar.MinDate.ToString(CultureInfo.InvariantCulture).ShouldBe("01/09/2020 00:00:00"),
                () => _testNumericDown.Text.ShouldBe("20"),
                () => _testNumericDown.Value.ShouldBe(20),
                () => _testProgressBar.Value.ShouldBe(20),
                () => _testRichBox.Text.ShouldBe("Dynamic Test Rich Box"),
                () => _testTextBox.Text.ShouldBe("Dynamic Test Box"),
                () => _testPanel.Text.ShouldBe("Test Panel"));
        }

        private static bool CheckParameter(string argument)
        {
            var testName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            var arguments = testName.Substring(testName.IndexOf("(", StringComparison.InvariantCultureIgnoreCase) + 1);
            return arguments.StartsWith(argument);
        }

        private static void ShouldContain(IEnumerable<IStructuralComparable> collection, params object[] param)
        {
            var method = typeof(Tuple).GetMethods().FirstOrDefault(x=> x.GetParameters().Length == param.Length);
            var genericMethod = method?.MakeGenericMethod(param.Select(x=> x?.GetType() ?? typeof(string)).ToArray());
            collection.ShouldContain(genericMethod?.Invoke(null, param));
        }
    }
}
