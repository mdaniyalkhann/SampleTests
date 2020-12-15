namespace TestForms
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Test 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Test 3");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Test Child Node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Test Node", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.testLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckBox();
            this.checkedLstBox = new System.Windows.Forms.CheckedListBox();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.testDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testLstBox = new System.Windows.Forms.ListBox();
            this.testlstView = new System.Windows.Forms.ListView();
            this.testMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.testCalendar = new System.Windows.Forms.MonthCalendar();
            this.testNumericDown = new System.Windows.Forms.NumericUpDown();
            this.testProgressBar = new System.Windows.Forms.ProgressBar();
            this.testRadioBtn = new System.Windows.Forms.RadioButton();
            this.testRichBox = new System.Windows.Forms.RichTextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.testPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.testNumericDown)).BeginInit();
            this.testPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(42, 22);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(75, 17);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "Test Label";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(45, 54);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(128, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Test Button";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // testCheckBox
            // 
            this.testCheckBox.AutoSize = true;
            this.testCheckBox.Checked = true;
            this.testCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testCheckBox.Location = new System.Drawing.Point(45, 94);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(128, 21);
            this.testCheckBox.TabIndex = 2;
            this.testCheckBox.Text = "Test Check Box";
            this.testCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkedLstBox
            // 
            this.checkedLstBox.FormattingEnabled = true;
            this.checkedLstBox.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5"});
            this.checkedLstBox.Location = new System.Drawing.Point(45, 143);
            this.checkedLstBox.Name = "checkedLstBox";
            this.checkedLstBox.Size = new System.Drawing.Size(248, 89);
            this.checkedLstBox.TabIndex = 3;
            // 
            // testComboBox
            // 
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5"});
            this.testComboBox.Location = new System.Drawing.Point(45, 249);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(121, 24);
            this.testComboBox.TabIndex = 4;
            // 
            // testDateTimePicker
            // 
            this.testDateTimePicker.Location = new System.Drawing.Point(45, 299);
            this.testDateTimePicker.Name = "testDateTimePicker";
            this.testDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.testDateTimePicker.TabIndex = 5;
            // 
            // testLstBox
            // 
            this.testLstBox.FormattingEnabled = true;
            this.testLstBox.ItemHeight = 16;
            this.testLstBox.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5"});
            this.testLstBox.Location = new System.Drawing.Point(330, 22);
            this.testLstBox.Name = "testLstBox";
            this.testLstBox.Size = new System.Drawing.Size(120, 84);
            this.testLstBox.TabIndex = 6;
            // 
            // testlstView
            // 
            this.testlstView.HideSelection = false;
            this.testlstView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.testlstView.Location = new System.Drawing.Point(330, 143);
            this.testlstView.Name = "testlstView";
            this.testlstView.Size = new System.Drawing.Size(132, 144);
            this.testlstView.TabIndex = 7;
            this.testlstView.UseCompatibleStateImageBehavior = false;
            // 
            // testMaskedTxtBox
            // 
            this.testMaskedTxtBox.Location = new System.Drawing.Point(45, 364);
            this.testMaskedTxtBox.Mask = "(999) 000-0000";
            this.testMaskedTxtBox.Name = "testMaskedTxtBox";
            this.testMaskedTxtBox.Size = new System.Drawing.Size(206, 22);
            this.testMaskedTxtBox.TabIndex = 8;
            // 
            // testCalendar
            // 
            this.testCalendar.Location = new System.Drawing.Point(511, 22);
            this.testCalendar.Name = "testCalendar";
            this.testCalendar.TabIndex = 9;
            // 
            // testNumericDown
            // 
            this.testNumericDown.Location = new System.Drawing.Point(330, 314);
            this.testNumericDown.Name = "testNumericDown";
            this.testNumericDown.Size = new System.Drawing.Size(120, 22);
            this.testNumericDown.TabIndex = 10;
            // 
            // testProgressBar
            // 
            this.testProgressBar.Location = new System.Drawing.Point(511, 249);
            this.testProgressBar.Name = "testProgressBar";
            this.testProgressBar.Size = new System.Drawing.Size(262, 38);
            this.testProgressBar.TabIndex = 11;
            // 
            // testRadioBtn
            // 
            this.testRadioBtn.AutoSize = true;
            this.testRadioBtn.Location = new System.Drawing.Point(511, 314);
            this.testRadioBtn.Name = "testRadioBtn";
            this.testRadioBtn.Size = new System.Drawing.Size(98, 21);
            this.testRadioBtn.TabIndex = 12;
            this.testRadioBtn.TabStop = true;
            this.testRadioBtn.Text = "Test Radio";
            this.testRadioBtn.UseVisualStyleBackColor = true;
            // 
            // testRichBox
            // 
            this.testRichBox.Location = new System.Drawing.Point(330, 357);
            this.testRichBox.Name = "testRichBox";
            this.testRichBox.Size = new System.Drawing.Size(166, 81);
            this.testRichBox.TabIndex = 13;
            this.testRichBox.Text = "Test 1\nTest 2";
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(16, 15);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(246, 22);
            this.testTextBox.TabIndex = 14;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(45, 430);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "textChildNode";
            treeNode1.Text = "Test Child Node";
            treeNode2.Name = "testNode0";
            treeNode2.Text = "Test Node";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(264, 145);
            this.treeView1.TabIndex = 15;
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.testTextBox);
            this.testPanel.Location = new System.Drawing.Point(511, 401);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(346, 97);
            this.testPanel.TabIndex = 16;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.testRichBox);
            this.Controls.Add(this.testRadioBtn);
            this.Controls.Add(this.testProgressBar);
            this.Controls.Add(this.testNumericDown);
            this.Controls.Add(this.testCalendar);
            this.Controls.Add(this.testMaskedTxtBox);
            this.Controls.Add(this.testlstView);
            this.Controls.Add(this.testLstBox);
            this.Controls.Add(this.testDateTimePicker);
            this.Controls.Add(this.testComboBox);
            this.Controls.Add(this.checkedLstBox);
            this.Controls.Add(this.testCheckBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testLabel);
            this.Name = "TestForm";
            this.Text = "Test Form";
            ((System.ComponentModel.ISupportInitialize)(this.testNumericDown)).EndInit();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.CheckBox testCheckBox;
        private System.Windows.Forms.CheckedListBox checkedLstBox;
        private System.Windows.Forms.ComboBox testComboBox;
        private System.Windows.Forms.DateTimePicker testDateTimePicker;
        private System.Windows.Forms.ListBox testLstBox;
        private System.Windows.Forms.ListView testlstView;
        private System.Windows.Forms.MaskedTextBox testMaskedTxtBox;
        private System.Windows.Forms.MonthCalendar testCalendar;
        private System.Windows.Forms.NumericUpDown testNumericDown;
        private System.Windows.Forms.ProgressBar testProgressBar;
        private System.Windows.Forms.RadioButton testRadioBtn;
        private System.Windows.Forms.RichTextBox testRichBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel testPanel;
    }
}

