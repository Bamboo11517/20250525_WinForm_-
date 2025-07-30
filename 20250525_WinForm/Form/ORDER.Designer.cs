namespace _20250525_WinForm
{
    partial class ORDER
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
            grpDel = new GroupBox();
            txtDelTel = new TextBox();
            txtDelAdd = new TextBox();
            txtDelPos = new TextBox();
            txtDelName = new TextBox();
            labDelTel = new Label();
            labDelPos = new Label();
            labDelAdd = new Label();
            label5 = new Label();
            labDelName = new Label();
            grpBill = new GroupBox();
            txtBillTel = new TextBox();
            txtBillAdd = new TextBox();
            txtBillPos = new TextBox();
            txtBillName = new TextBox();
            labBillTel = new Label();
            labBillPos = new Label();
            labBillAdd = new Label();
            label9 = new Label();
            labBillName = new Label();
            grpBillType = new GroupBox();
            cbxBillType = new ComboBox();
            grpOrder = new GroupBox();
            label25 = new Label();
            lblOrderCntCol2 = new Label();
            nudeItem10 = new NumericUpDown();
            cbxItem10 = new ComboBox();
            nudeItem9 = new NumericUpDown();
            cbxItem9 = new ComboBox();
            nudeItem8 = new NumericUpDown();
            cbxItem8 = new ComboBox();
            nudeItem7 = new NumericUpDown();
            cbxItem7 = new ComboBox();
            nudeItem6 = new NumericUpDown();
            cbxItem6 = new ComboBox();
            label24 = new Label();
            labItem10 = new Label();
            labItem9 = new Label();
            labItem8 = new Label();
            labItem7 = new Label();
            labItem6 = new Label();
            nudeItem5 = new NumericUpDown();
            cbxItem5 = new ComboBox();
            labItem5 = new Label();
            nudeItem4 = new NumericUpDown();
            cbxItem4 = new ComboBox();
            labItem4 = new Label();
            nudeItem3 = new NumericUpDown();
            cbxItem3 = new ComboBox();
            labItem3 = new Label();
            nudeItem2 = new NumericUpDown();
            cbxItem2 = new ComboBox();
            labItem2 = new Label();
            nudeItem1 = new NumericUpDown();
            cbxItem1 = new ComboBox();
            labItem1 = new Label();
            label14 = new Label();
            labOrderCntColumn1 = new Label();
            labItemColumn1 = new Label();
            grpDeadLine = new GroupBox();
            dtpDeadLine = new DateTimePicker();
            btnKakutei = new Button();
            grpDel.SuspendLayout();
            grpBill.SuspendLayout();
            grpBillType.SuspendLayout();
            grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudeItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem1).BeginInit();
            grpDeadLine.SuspendLayout();
            SuspendLayout();
            // 
            // grpDel
            // 
            grpDel.Controls.Add(txtDelTel);
            grpDel.Controls.Add(txtDelAdd);
            grpDel.Controls.Add(txtDelPos);
            grpDel.Controls.Add(txtDelName);
            grpDel.Controls.Add(labDelTel);
            grpDel.Controls.Add(labDelPos);
            grpDel.Controls.Add(labDelAdd);
            grpDel.Controls.Add(label5);
            grpDel.Controls.Add(labDelName);
            grpDel.Location = new Point(34, 33);
            grpDel.Margin = new Padding(2);
            grpDel.Name = "grpDel";
            grpDel.Padding = new Padding(2);
            grpDel.Size = new Size(304, 226);
            grpDel.TabIndex = 1;
            grpDel.TabStop = false;
            grpDel.Text = "届け先情報[必須]";
            grpDel.Enter += grpDel_Enter;
            // 
            // txtDelTel
            // 
            txtDelTel.Location = new Point(39, 194);
            txtDelTel.Margin = new Padding(2);
            txtDelTel.Name = "txtDelTel";
            txtDelTel.Size = new Size(229, 23);
            txtDelTel.TabIndex = 10;
            txtDelTel.TextChanged += txtDelTel_TextChanged;
            // 
            // txtDelAdd
            // 
            txtDelAdd.Location = new Point(39, 140);
            txtDelAdd.Margin = new Padding(2);
            txtDelAdd.Name = "txtDelAdd";
            txtDelAdd.Size = new Size(229, 23);
            txtDelAdd.TabIndex = 8;
            txtDelAdd.TextChanged += txtDelAdd_TextChanged;
            // 
            // txtDelPos
            // 
            txtDelPos.ImeMode = ImeMode.Disable;
            txtDelPos.Location = new Point(39, 93);
            txtDelPos.Margin = new Padding(2);
            txtDelPos.Name = "txtDelPos";
            txtDelPos.Size = new Size(229, 23);
            txtDelPos.TabIndex = 5;
            txtDelPos.TextChanged += txtDelPos_TextChanged;
            txtDelPos.KeyPress += NumericalInputControl;
            // 
            // txtDelName
            // 
            txtDelName.Location = new Point(39, 45);
            txtDelName.Margin = new Padding(2);
            txtDelName.Name = "txtDelName";
            txtDelName.Size = new Size(229, 23);
            txtDelName.TabIndex = 3;
            txtDelName.TextChanged += txtDelName_TextChanged;
            // 
            // labDelTel
            // 
            labDelTel.AutoSize = true;
            labDelTel.Location = new Point(31, 169);
            labDelTel.Margin = new Padding(2, 0, 2, 0);
            labDelTel.Name = "labDelTel";
            labDelTel.Size = new Size(55, 15);
            labDelTel.TabIndex = 9;
            labDelTel.Text = "電話番号";
            // 
            // labDelPos
            // 
            labDelPos.AutoSize = true;
            labDelPos.Location = new Point(31, 71);
            labDelPos.Margin = new Padding(2, 0, 2, 0);
            labDelPos.Name = "labDelPos";
            labDelPos.Size = new Size(55, 15);
            labDelPos.TabIndex = 4;
            labDelPos.Text = "郵便番号";
            labDelPos.Click += label3_Click;
            // 
            // labDelAdd
            // 
            labDelAdd.AutoSize = true;
            labDelAdd.Location = new Point(31, 118);
            labDelAdd.Margin = new Padding(2, 0, 2, 0);
            labDelAdd.Name = "labDelAdd";
            labDelAdd.Size = new Size(31, 15);
            labDelAdd.TabIndex = 6;
            labDelAdd.Text = "住所";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 44);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 0;
            // 
            // labDelName
            // 
            labDelName.AutoSize = true;
            labDelName.Location = new Point(31, 26);
            labDelName.Margin = new Padding(2, 0, 2, 0);
            labDelName.Name = "labDelName";
            labDelName.Size = new Size(31, 15);
            labDelName.TabIndex = 2;
            labDelName.Text = "宛名";
            // 
            // grpBill
            // 
            grpBill.Controls.Add(txtBillTel);
            grpBill.Controls.Add(txtBillAdd);
            grpBill.Controls.Add(txtBillPos);
            grpBill.Controls.Add(txtBillName);
            grpBill.Controls.Add(labBillTel);
            grpBill.Controls.Add(labBillPos);
            grpBill.Controls.Add(labBillAdd);
            grpBill.Controls.Add(label9);
            grpBill.Controls.Add(labBillName);
            grpBill.Enabled = false;
            grpBill.Location = new Point(359, 33);
            grpBill.Margin = new Padding(2);
            grpBill.Name = "grpBill";
            grpBill.Padding = new Padding(2);
            grpBill.Size = new Size(304, 226);
            grpBill.TabIndex = 11;
            grpBill.TabStop = false;
            grpBill.Text = "請求先情報";
            grpBill.Enter += grpBill_Enter;
            // 
            // txtBillTel
            // 
            txtBillTel.Location = new Point(39, 194);
            txtBillTel.Margin = new Padding(2);
            txtBillTel.Name = "txtBillTel";
            txtBillTel.Size = new Size(229, 23);
            txtBillTel.TabIndex = 20;
            txtBillTel.TextChanged += txtBillTel_TextChanged;
            // 
            // txtBillAdd
            // 
            txtBillAdd.Location = new Point(39, 140);
            txtBillAdd.Margin = new Padding(2);
            txtBillAdd.Name = "txtBillAdd";
            txtBillAdd.Size = new Size(229, 23);
            txtBillAdd.TabIndex = 18;
            txtBillAdd.TextChanged += txtBillAdd_TextChanged;
            // 
            // txtBillPos
            // 
            txtBillPos.Location = new Point(39, 93);
            txtBillPos.Margin = new Padding(2);
            txtBillPos.Name = "txtBillPos";
            txtBillPos.Size = new Size(229, 23);
            txtBillPos.TabIndex = 15;
            txtBillPos.TextChanged += txtBillPos_TextChanged;
            // 
            // txtBillName
            // 
            txtBillName.Location = new Point(39, 45);
            txtBillName.Margin = new Padding(2);
            txtBillName.Name = "txtBillName";
            txtBillName.Size = new Size(229, 23);
            txtBillName.TabIndex = 13;
            txtBillName.TextChanged += txtBillName_TextChanged;
            // 
            // labBillTel
            // 
            labBillTel.AutoSize = true;
            labBillTel.Location = new Point(31, 169);
            labBillTel.Margin = new Padding(2, 0, 2, 0);
            labBillTel.Name = "labBillTel";
            labBillTel.Size = new Size(55, 15);
            labBillTel.TabIndex = 19;
            labBillTel.Text = "電話番号";
            // 
            // labBillPos
            // 
            labBillPos.AutoSize = true;
            labBillPos.Location = new Point(31, 71);
            labBillPos.Margin = new Padding(2, 0, 2, 0);
            labBillPos.Name = "labBillPos";
            labBillPos.Size = new Size(55, 15);
            labBillPos.TabIndex = 14;
            labBillPos.Text = "郵便番号";
            // 
            // labBillAdd
            // 
            labBillAdd.AutoSize = true;
            labBillAdd.Location = new Point(31, 118);
            labBillAdd.Margin = new Padding(2, 0, 2, 0);
            labBillAdd.Name = "labBillAdd";
            labBillAdd.Size = new Size(31, 15);
            labBillAdd.TabIndex = 16;
            labBillAdd.Text = "住所";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(125, 44);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 0;
            // 
            // labBillName
            // 
            labBillName.AutoSize = true;
            labBillName.Location = new Point(31, 26);
            labBillName.Margin = new Padding(2, 0, 2, 0);
            labBillName.Name = "labBillName";
            labBillName.Size = new Size(31, 15);
            labBillName.TabIndex = 12;
            labBillName.Text = "宛名";
            // 
            // grpBillType
            // 
            grpBillType.Controls.Add(cbxBillType);
            grpBillType.Location = new Point(34, 279);
            grpBillType.Margin = new Padding(2);
            grpBillType.Name = "grpBillType";
            grpBillType.Padding = new Padding(2);
            grpBillType.Size = new Size(304, 60);
            grpBillType.TabIndex = 21;
            grpBillType.TabStop = false;
            grpBillType.Text = "請求先区分";
            grpBillType.Enter += grpBillType_Enter;
            // 
            // cbxBillType
            // 
            cbxBillType.FormattingEnabled = true;
            cbxBillType.Items.AddRange(new object[] { "届け先と同じ", "指定する" });
            cbxBillType.Location = new Point(71, 25);
            cbxBillType.Name = "cbxBillType";
            cbxBillType.Size = new Size(162, 23);
            cbxBillType.TabIndex = 0;
            cbxBillType.SelectedIndexChanged += cbxBillType_SelectedIndexChanged;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(label25);
            grpOrder.Controls.Add(lblOrderCntCol2);
            grpOrder.Controls.Add(nudeItem10);
            grpOrder.Controls.Add(cbxItem10);
            grpOrder.Controls.Add(nudeItem9);
            grpOrder.Controls.Add(cbxItem9);
            grpOrder.Controls.Add(nudeItem8);
            grpOrder.Controls.Add(cbxItem8);
            grpOrder.Controls.Add(nudeItem7);
            grpOrder.Controls.Add(cbxItem7);
            grpOrder.Controls.Add(nudeItem6);
            grpOrder.Controls.Add(cbxItem6);
            grpOrder.Controls.Add(label24);
            grpOrder.Controls.Add(labItem10);
            grpOrder.Controls.Add(labItem9);
            grpOrder.Controls.Add(labItem8);
            grpOrder.Controls.Add(labItem7);
            grpOrder.Controls.Add(labItem6);
            grpOrder.Controls.Add(nudeItem5);
            grpOrder.Controls.Add(cbxItem5);
            grpOrder.Controls.Add(labItem5);
            grpOrder.Controls.Add(nudeItem4);
            grpOrder.Controls.Add(cbxItem4);
            grpOrder.Controls.Add(labItem4);
            grpOrder.Controls.Add(nudeItem3);
            grpOrder.Controls.Add(cbxItem3);
            grpOrder.Controls.Add(labItem3);
            grpOrder.Controls.Add(nudeItem2);
            grpOrder.Controls.Add(cbxItem2);
            grpOrder.Controls.Add(labItem2);
            grpOrder.Controls.Add(nudeItem1);
            grpOrder.Controls.Add(cbxItem1);
            grpOrder.Controls.Add(labItem1);
            grpOrder.Controls.Add(label14);
            grpOrder.Controls.Add(labOrderCntColumn1);
            grpOrder.Controls.Add(labItemColumn1);
            grpOrder.Location = new Point(34, 357);
            grpOrder.Margin = new Padding(2);
            grpOrder.Name = "grpOrder";
            grpOrder.Padding = new Padding(2);
            grpOrder.Size = new Size(629, 237);
            grpOrder.TabIndex = 26;
            grpOrder.TabStop = false;
            grpOrder.Text = "注文情報[必須]";
            grpOrder.Enter += grbOrder_Enter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(540, 30);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(43, 15);
            label25.TabIndex = 45;
            label25.Text = "注文数";
            // 
            // lblOrderCntCol2
            // 
            lblOrderCntCol2.AutoSize = true;
            lblOrderCntCol2.Location = new Point(421, 30);
            lblOrderCntCol2.Margin = new Padding(2, 0, 2, 0);
            lblOrderCntCol2.Name = "lblOrderCntCol2";
            lblOrderCntCol2.Size = new Size(31, 15);
            lblOrderCntCol2.TabIndex = 44;
            lblOrderCntCol2.Text = "商品";
            lblOrderCntCol2.Click += label26_Click;
            // 
            // nudeItem10
            // 
            nudeItem10.Location = new Point(521, 195);
            nudeItem10.Margin = new Padding(2);
            nudeItem10.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem10.Name = "nudeItem10";
            nudeItem10.Size = new Size(85, 23);
            nudeItem10.TabIndex = 60;
            // 
            // cbxItem10
            // 
            cbxItem10.FormattingEnabled = true;
            cbxItem10.Location = new Point(350, 193);
            cbxItem10.Margin = new Padding(2);
            cbxItem10.Name = "cbxItem10";
            cbxItem10.Size = new Size(162, 23);
            cbxItem10.TabIndex = 59;
            // 
            // nudeItem9
            // 
            nudeItem9.Location = new Point(521, 159);
            nudeItem9.Margin = new Padding(2);
            nudeItem9.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem9.Name = "nudeItem9";
            nudeItem9.Size = new Size(85, 23);
            nudeItem9.TabIndex = 57;
            // 
            // cbxItem9
            // 
            cbxItem9.FormattingEnabled = true;
            cbxItem9.Location = new Point(350, 158);
            cbxItem9.Margin = new Padding(2);
            cbxItem9.Name = "cbxItem9";
            cbxItem9.Size = new Size(162, 23);
            cbxItem9.TabIndex = 56;
            // 
            // nudeItem8
            // 
            nudeItem8.Location = new Point(521, 124);
            nudeItem8.Margin = new Padding(2);
            nudeItem8.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem8.Name = "nudeItem8";
            nudeItem8.Size = new Size(85, 23);
            nudeItem8.TabIndex = 54;
            // 
            // cbxItem8
            // 
            cbxItem8.FormattingEnabled = true;
            cbxItem8.Location = new Point(349, 124);
            cbxItem8.Margin = new Padding(2);
            cbxItem8.Name = "cbxItem8";
            cbxItem8.Size = new Size(162, 23);
            cbxItem8.TabIndex = 53;
            // 
            // nudeItem7
            // 
            nudeItem7.Location = new Point(521, 92);
            nudeItem7.Margin = new Padding(2);
            nudeItem7.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem7.Name = "nudeItem7";
            nudeItem7.Size = new Size(85, 23);
            nudeItem7.TabIndex = 51;
            // 
            // cbxItem7
            // 
            cbxItem7.FormattingEnabled = true;
            cbxItem7.Location = new Point(351, 91);
            cbxItem7.Margin = new Padding(2);
            cbxItem7.Name = "cbxItem7";
            cbxItem7.Size = new Size(162, 23);
            cbxItem7.TabIndex = 50;
            // 
            // nudeItem6
            // 
            nudeItem6.Location = new Point(521, 61);
            nudeItem6.Margin = new Padding(2);
            nudeItem6.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem6.Name = "nudeItem6";
            nudeItem6.Size = new Size(85, 23);
            nudeItem6.TabIndex = 48;
            nudeItem6.ValueChanged += nudeItem6_ValueChanged;
            // 
            // cbxItem6
            // 
            cbxItem6.FormattingEnabled = true;
            cbxItem6.Location = new Point(350, 59);
            cbxItem6.Margin = new Padding(2);
            cbxItem6.Name = "cbxItem6";
            cbxItem6.Size = new Size(162, 23);
            cbxItem6.TabIndex = 47;
            cbxItem6.SelectedIndexChanged += cbxItem6_SelectedIndexChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(545, 96);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(0, 15);
            label24.TabIndex = 36;
            // 
            // labItem10
            // 
            labItem10.AutoSize = true;
            labItem10.Location = new Point(326, 193);
            labItem10.Margin = new Padding(2, 0, 2, 0);
            labItem10.Name = "labItem10";
            labItem10.Size = new Size(19, 15);
            labItem10.TabIndex = 58;
            labItem10.Text = "⑩";
            // 
            // labItem9
            // 
            labItem9.AutoSize = true;
            labItem9.Location = new Point(326, 158);
            labItem9.Margin = new Padding(2, 0, 2, 0);
            labItem9.Name = "labItem9";
            labItem9.Size = new Size(19, 15);
            labItem9.TabIndex = 55;
            labItem9.Text = "⑨";
            // 
            // labItem8
            // 
            labItem8.AutoSize = true;
            labItem8.Location = new Point(326, 123);
            labItem8.Margin = new Padding(2, 0, 2, 0);
            labItem8.Name = "labItem8";
            labItem8.Size = new Size(19, 15);
            labItem8.TabIndex = 52;
            labItem8.Text = "⑧";
            // 
            // labItem7
            // 
            labItem7.AutoSize = true;
            labItem7.Location = new Point(327, 91);
            labItem7.Margin = new Padding(2, 0, 2, 0);
            labItem7.Name = "labItem7";
            labItem7.Size = new Size(19, 15);
            labItem7.TabIndex = 49;
            labItem7.Text = "⑦";
            // 
            // labItem6
            // 
            labItem6.AutoSize = true;
            labItem6.Location = new Point(326, 59);
            labItem6.Margin = new Padding(2, 0, 2, 0);
            labItem6.Name = "labItem6";
            labItem6.Size = new Size(19, 15);
            labItem6.TabIndex = 46;
            labItem6.Text = "⑥";
            // 
            // nudeItem5
            // 
            nudeItem5.Location = new Point(209, 194);
            nudeItem5.Margin = new Padding(2);
            nudeItem5.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem5.Name = "nudeItem5";
            nudeItem5.Size = new Size(85, 23);
            nudeItem5.TabIndex = 43;
            // 
            // cbxItem5
            // 
            cbxItem5.FormattingEnabled = true;
            cbxItem5.Location = new Point(38, 193);
            cbxItem5.Margin = new Padding(2);
            cbxItem5.Name = "cbxItem5";
            cbxItem5.Size = new Size(162, 23);
            cbxItem5.TabIndex = 42;
            // 
            // labItem5
            // 
            labItem5.AutoSize = true;
            labItem5.Location = new Point(14, 195);
            labItem5.Margin = new Padding(2, 0, 2, 0);
            labItem5.Name = "labItem5";
            labItem5.Size = new Size(19, 15);
            labItem5.TabIndex = 41;
            labItem5.Text = "⑤";
            // 
            // nudeItem4
            // 
            nudeItem4.Location = new Point(209, 159);
            nudeItem4.Margin = new Padding(2);
            nudeItem4.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem4.Name = "nudeItem4";
            nudeItem4.Size = new Size(85, 23);
            nudeItem4.TabIndex = 40;
            // 
            // cbxItem4
            // 
            cbxItem4.FormattingEnabled = true;
            cbxItem4.Location = new Point(38, 157);
            cbxItem4.Margin = new Padding(2);
            cbxItem4.Name = "cbxItem4";
            cbxItem4.Size = new Size(162, 23);
            cbxItem4.TabIndex = 39;
            // 
            // labItem4
            // 
            labItem4.AutoSize = true;
            labItem4.Location = new Point(14, 159);
            labItem4.Margin = new Padding(2, 0, 2, 0);
            labItem4.Name = "labItem4";
            labItem4.Size = new Size(19, 15);
            labItem4.TabIndex = 38;
            labItem4.Text = "④";
            // 
            // nudeItem3
            // 
            nudeItem3.Location = new Point(209, 123);
            nudeItem3.Margin = new Padding(2);
            nudeItem3.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem3.Name = "nudeItem3";
            nudeItem3.Size = new Size(85, 23);
            nudeItem3.TabIndex = 37;
            // 
            // cbxItem3
            // 
            cbxItem3.FormattingEnabled = true;
            cbxItem3.Location = new Point(38, 122);
            cbxItem3.Margin = new Padding(2);
            cbxItem3.Name = "cbxItem3";
            cbxItem3.Size = new Size(162, 23);
            cbxItem3.TabIndex = 36;
            // 
            // labItem3
            // 
            labItem3.AutoSize = true;
            labItem3.Location = new Point(14, 124);
            labItem3.Margin = new Padding(2, 0, 2, 0);
            labItem3.Name = "labItem3";
            labItem3.Size = new Size(19, 15);
            labItem3.TabIndex = 35;
            labItem3.Text = "③";
            // 
            // nudeItem2
            // 
            nudeItem2.Location = new Point(209, 91);
            nudeItem2.Margin = new Padding(2);
            nudeItem2.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem2.Name = "nudeItem2";
            nudeItem2.Size = new Size(85, 23);
            nudeItem2.TabIndex = 34;
            // 
            // cbxItem2
            // 
            cbxItem2.FormattingEnabled = true;
            cbxItem2.Location = new Point(39, 90);
            cbxItem2.Margin = new Padding(2);
            cbxItem2.Name = "cbxItem2";
            cbxItem2.Size = new Size(162, 23);
            cbxItem2.TabIndex = 33;
            cbxItem2.SelectedIndexChanged += cbxItem2_SelectedIndexChanged;
            // 
            // labItem2
            // 
            labItem2.AutoSize = true;
            labItem2.Location = new Point(15, 92);
            labItem2.Margin = new Padding(2, 0, 2, 0);
            labItem2.Name = "labItem2";
            labItem2.Size = new Size(19, 15);
            labItem2.TabIndex = 32;
            labItem2.Text = "②";
            // 
            // nudeItem1
            // 
            nudeItem1.Location = new Point(209, 60);
            nudeItem1.Margin = new Padding(2);
            nudeItem1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudeItem1.Name = "nudeItem1";
            nudeItem1.Size = new Size(85, 23);
            nudeItem1.TabIndex = 31;
            nudeItem1.ValueChanged += nudeItem1_ValueChanged;
            // 
            // cbxItem1
            // 
            cbxItem1.FormattingEnabled = true;
            cbxItem1.Location = new Point(38, 59);
            cbxItem1.Margin = new Padding(2);
            cbxItem1.Name = "cbxItem1";
            cbxItem1.Size = new Size(162, 23);
            cbxItem1.TabIndex = 30;
            cbxItem1.SelectedIndexChanged += cbxItem1_SelectedIndexChanged;
            // 
            // labItem1
            // 
            labItem1.AutoSize = true;
            labItem1.Location = new Point(14, 61);
            labItem1.Margin = new Padding(2, 0, 2, 0);
            labItem1.Name = "labItem1";
            labItem1.Size = new Size(19, 15);
            labItem1.TabIndex = 29;
            labItem1.Text = "①";
            labItem1.Click += label16_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(233, 95);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 3;
            // 
            // labOrderCntColumn1
            // 
            labOrderCntColumn1.AutoSize = true;
            labOrderCntColumn1.Location = new Point(223, 30);
            labOrderCntColumn1.Margin = new Padding(2, 0, 2, 0);
            labOrderCntColumn1.Name = "labOrderCntColumn1";
            labOrderCntColumn1.Size = new Size(43, 15);
            labOrderCntColumn1.TabIndex = 28;
            labOrderCntColumn1.Text = "注文数";
            // 
            // labItemColumn1
            // 
            labItemColumn1.AutoSize = true;
            labItemColumn1.Location = new Point(104, 30);
            labItemColumn1.Margin = new Padding(2, 0, 2, 0);
            labItemColumn1.Name = "labItemColumn1";
            labItemColumn1.Size = new Size(31, 15);
            labItemColumn1.TabIndex = 27;
            labItemColumn1.Text = "商品";
            labItemColumn1.Click += label11_Click;
            // 
            // grpDeadLine
            // 
            grpDeadLine.Controls.Add(dtpDeadLine);
            grpDeadLine.Location = new Point(359, 279);
            grpDeadLine.Margin = new Padding(2);
            grpDeadLine.Name = "grpDeadLine";
            grpDeadLine.Padding = new Padding(2);
            grpDeadLine.Size = new Size(304, 60);
            grpDeadLine.TabIndex = 24;
            grpDeadLine.TabStop = false;
            grpDeadLine.Text = "希望納期";
            grpDeadLine.Enter += grpDeadLine_Enter;
            // 
            // dtpDeadLine
            // 
            dtpDeadLine.CustomFormat = "yyyy/MM/dd";
            dtpDeadLine.Location = new Point(39, 25);
            dtpDeadLine.Margin = new Padding(2);
            dtpDeadLine.Name = "dtpDeadLine";
            dtpDeadLine.Size = new Size(177, 23);
            dtpDeadLine.TabIndex = 25;
            dtpDeadLine.ValueChanged += dtpDeadLine_ValueChanged;
            // 
            // btnKakutei
            // 
            btnKakutei.Font = new Font("Yu Gothic UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnKakutei.Location = new Point(243, 605);
            btnKakutei.Margin = new Padding(2);
            btnKakutei.Name = "btnKakutei";
            btnKakutei.Size = new Size(229, 62);
            btnKakutei.TabIndex = 61;
            btnKakutei.Text = "注文確定";
            btnKakutei.UseVisualStyleBackColor = true;
            btnKakutei.Click += btnKakutei_Click;
            // 
            // ORDER
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(700, 699);
            Controls.Add(btnKakutei);
            Controls.Add(grpDeadLine);
            Controls.Add(grpOrder);
            Controls.Add(grpBillType);
            Controls.Add(grpBill);
            Controls.Add(grpDel);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "ORDER";
            Text = "商品購入画面";
            Load += Order_Load;
            grpDel.ResumeLayout(false);
            grpDel.PerformLayout();
            grpBill.ResumeLayout(false);
            grpBill.PerformLayout();
            grpBillType.ResumeLayout(false);
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudeItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudeItem1).EndInit();
            grpDeadLine.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpDel;
        private Label labDelTel;
        private Label labDelPos;
        private Label labDelAdd;
        private Label label5;
        private Label labDelName;
        private TextBox txtDelAdd;
        private TextBox txtDelPos;
        private TextBox txtDelName;
        private GroupBox grpBill;
        private TextBox txtBillAdd;
        private TextBox txtBillPos;
        private TextBox txtBillName;
        private Label labBillTel;
        private Label labBillPos;
        private Label labBillAdd;
        private Label label9;
        private Label labBillName;
        private GroupBox grpBillType;
        private GroupBox grpOrder;
        private GroupBox grpDeadLine;
        private DateTimePicker dtpDeadLine;
        private ComboBox cbxItem1;
        private Label labItem1;
        private Label label14;
        private Label labOrderCntColumn1;
        private Label labItemColumn1;
        private NumericUpDown nudeItem1;
        private NumericUpDown nudeItem5;
        private ComboBox cbxItem5;
        private Label labItem5;
        private NumericUpDown nudeItem4;
        private ComboBox cbxItem4;
        private Label labItem4;
        private NumericUpDown nudeItem3;
        private ComboBox cbxItem3;
        private Label labItem3;
        private NumericUpDown nudeItem2;
        private ComboBox cbxItem2;
        private Label labItem2;
        private Label labItem10;
        private Label labItem9;
        private Label labItem8;
        private Label labItem7;
        private Label labItem6;
        private Label label25;
        private Label lblOrderCntCol2;
        private NumericUpDown nudeItem10;
        private ComboBox cbxItem10;
        private NumericUpDown nudeItem9;
        private ComboBox cbxItem9;
        private NumericUpDown nudeItem8;
        private ComboBox cbxItem8;
        private NumericUpDown nudeItem7;
        private ComboBox cbxItem7;
        private NumericUpDown nudeItem6;
        private ComboBox cbxItem6;
        private Label label24;
        private Button btnKakutei;
        private TextBox txtBillTel;
        private ComboBox cbxBillType;
        private TextBox txtDelTel;
    }
}
