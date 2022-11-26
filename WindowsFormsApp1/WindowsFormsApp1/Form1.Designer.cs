
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCreateShop = new System.Windows.Forms.Button();
            this.btSetProperty = new System.Windows.Forms.Button();
            this.cbShopProperty = new System.Windows.Forms.ComboBox();
            this.lbCarShopsNames = new System.Windows.Forms.ListBox();
            this.btDeleteShop = new System.Windows.Forms.Button();
            this.lbCarShopsProperties = new System.Windows.Forms.ListBox();
            this.btDisplayProperties = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCompareShops = new System.Windows.Forms.Button();
            this.cbForCompareSecond = new System.Windows.Forms.ComboBox();
            this.cbForCompareFirst = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRandomFill = new System.Windows.Forms.Button();
            this.btIndexator = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbForIndexator = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDeleteAllWorkers = new System.Windows.Forms.Button();
            this.btOutPutWorkers = new System.Windows.Forms.Button();
            this.btOutPutCars = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDeleteWorkerByIPN = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btDeleteWorkerByIPN = new System.Windows.Forms.Button();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.btAddWorker = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbWorkerINN = new System.Windows.Forms.TextBox();
            this.tbWorkerDayOfBirth = new System.Windows.Forms.TextBox();
            this.cbWorkerPosition = new System.Windows.Forms.ComboBox();
            this.tbWorkerSalary = new System.Windows.Forms.TextBox();
            this.tbWorkerLastName = new System.Windows.Forms.TextBox();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.cbWorkerEducation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCarsForSell = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbCarsForSell = new System.Windows.Forms.ComboBox();
            this.btSellCar = new System.Windows.Forms.Button();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCarsCount = new System.Windows.Forms.TextBox();
            this.btAddCars = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCarPriceForClient = new System.Windows.Forms.TextBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.tbCarPriceForShop = new System.Windows.Forms.TextBox();
            this.cbCarBrand = new System.Windows.Forms.ComboBox();
            this.btInputInformationFromFile = new System.Windows.Forms.Button();
            this.btOutputInformationInFile = new System.Windows.Forms.Button();
            this.rbCarsOutputInFile = new System.Windows.Forms.RadioButton();
            this.rbWorkersOutputInFile = new System.Windows.Forms.RadioButton();
            this.rbOnlyShopOutputInFile = new System.Windows.Forms.RadioButton();
            this.rbWholeShopOutputInFile = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.rbCarsInputFromFile = new System.Windows.Forms.RadioButton();
            this.rbWorkersInputFromFile = new System.Windows.Forms.RadioButton();
            this.rbOnlyShopInputFromFile = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.rbWholeShopInputFromFile = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(0, 170);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(136, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btCreateShop
            // 
            this.btCreateShop.Location = new System.Drawing.Point(-1, 193);
            this.btCreateShop.Name = "btCreateShop";
            this.btCreateShop.Size = new System.Drawing.Size(100, 35);
            this.btCreateShop.TabIndex = 2;
            this.btCreateShop.Text = "Створити магазин";
            this.btCreateShop.UseVisualStyleBackColor = true;
            // 
            // btSetProperty
            // 
            this.btSetProperty.Location = new System.Drawing.Point(105, 192);
            this.btSetProperty.Name = "btSetProperty";
            this.btSetProperty.Size = new System.Drawing.Size(122, 35);
            this.btSetProperty.TabIndex = 3;
            this.btSetProperty.Text = "Задати властивість магазину";
            this.btSetProperty.UseVisualStyleBackColor = true;
            // 
            // cbShopProperty
            // 
            this.cbShopProperty.FormattingEnabled = true;
            this.cbShopProperty.Items.AddRange(new object[] {
            "Назва магазину",
            "Адреса магазину",
            "Середній дохід магазину за місяць",
            "Загальга заробітня плата співробітника",
            "Загальні витрати на купівлю товарів",
            "Кільікість найменувань",
            "Каса магазину"});
            this.cbShopProperty.Location = new System.Drawing.Point(236, 205);
            this.cbShopProperty.Name = "cbShopProperty";
            this.cbShopProperty.Size = new System.Drawing.Size(209, 21);
            this.cbShopProperty.TabIndex = 5;
            // 
            // lbCarShopsNames
            // 
            this.lbCarShopsNames.FormattingEnabled = true;
            this.lbCarShopsNames.Location = new System.Drawing.Point(1, 38);
            this.lbCarShopsNames.Name = "lbCarShopsNames";
            this.lbCarShopsNames.Size = new System.Drawing.Size(152, 108);
            this.lbCarShopsNames.TabIndex = 6;
            // 
            // btDeleteShop
            // 
            this.btDeleteShop.Location = new System.Drawing.Point(-1, 232);
            this.btDeleteShop.Name = "btDeleteShop";
            this.btDeleteShop.Size = new System.Drawing.Size(100, 35);
            this.btDeleteShop.TabIndex = 7;
            this.btDeleteShop.Text = "Видалити магазин";
            this.btDeleteShop.UseVisualStyleBackColor = true;
            // 
            // lbCarShopsProperties
            // 
            this.lbCarShopsProperties.FormattingEnabled = true;
            this.lbCarShopsProperties.Location = new System.Drawing.Point(167, 38);
            this.lbCarShopsProperties.Name = "lbCarShopsProperties";
            this.lbCarShopsProperties.Size = new System.Drawing.Size(264, 108);
            this.lbCarShopsProperties.TabIndex = 11;
            // 
            // btDisplayProperties
            // 
            this.btDisplayProperties.Location = new System.Drawing.Point(-1, 272);
            this.btDisplayProperties.Name = "btDisplayProperties";
            this.btDisplayProperties.Size = new System.Drawing.Size(100, 35);
            this.btDisplayProperties.TabIndex = 12;
            this.btDisplayProperties.Text = "Відобразити властивості";
            this.btDisplayProperties.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список магазинів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Властивості магазину";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Поле для введення даних";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Виберіть властивість яку хочете змінити";
            // 
            // btCompareShops
            // 
            this.btCompareShops.Location = new System.Drawing.Point(105, 231);
            this.btCompareShops.Name = "btCompareShops";
            this.btCompareShops.Size = new System.Drawing.Size(122, 35);
            this.btCompareShops.TabIndex = 20;
            this.btCompareShops.Text = "Порівняти магазини";
            this.btCompareShops.UseVisualStyleBackColor = true;
            // 
            // cbForCompareSecond
            // 
            this.cbForCompareSecond.FormattingEnabled = true;
            this.cbForCompareSecond.Location = new System.Drawing.Point(339, 245);
            this.cbForCompareSecond.Name = "cbForCompareSecond";
            this.cbForCompareSecond.Size = new System.Drawing.Size(100, 21);
            this.cbForCompareSecond.TabIndex = 21;
            // 
            // cbForCompareFirst
            // 
            this.cbForCompareFirst.FormattingEnabled = true;
            this.cbForCompareFirst.Location = new System.Drawing.Point(236, 245);
            this.cbForCompareFirst.Name = "cbForCompareFirst";
            this.cbForCompareFirst.Size = new System.Drawing.Size(97, 21);
            this.cbForCompareFirst.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Виберіть магазини для порівняння";
            // 
            // btRandomFill
            // 
            this.btRandomFill.Location = new System.Drawing.Point(0, 309);
            this.btRandomFill.Name = "btRandomFill";
            this.btRandomFill.Size = new System.Drawing.Size(163, 34);
            this.btRandomFill.TabIndex = 24;
            this.btRandomFill.Text = "Випадково заповнити місячні показники магазину";
            this.btRandomFill.UseVisualStyleBackColor = true;
            // 
            // btIndexator
            // 
            this.btIndexator.Location = new System.Drawing.Point(105, 272);
            this.btIndexator.Name = "btIndexator";
            this.btIndexator.Size = new System.Drawing.Size(122, 36);
            this.btIndexator.TabIndex = 25;
            this.btIndexator.Text = "Індексатор";
            this.btIndexator.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Виберіть характеристику для індексатора";
            // 
            // cbForIndexator
            // 
            this.cbForIndexator.FormattingEnabled = true;
            this.cbForIndexator.Items.AddRange(new object[] {
            "Дохід за місяць",
            "Заробітня плата співробітників",
            "Витрати на товари"});
            this.cbForIndexator.Location = new System.Drawing.Point(236, 286);
            this.cbForIndexator.Name = "cbForIndexator";
            this.cbForIndexator.Size = new System.Drawing.Size(209, 21);
            this.cbForIndexator.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeleteAllWorkers);
            this.groupBox1.Controls.Add(this.btOutPutWorkers);
            this.groupBox1.Controls.Add(this.btOutPutCars);
            this.groupBox1.Controls.Add(this.cbForIndexator);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btIndexator);
            this.groupBox1.Controls.Add(this.btRandomFill);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbForCompareFirst);
            this.groupBox1.Controls.Add(this.cbForCompareSecond);
            this.groupBox1.Controls.Add(this.btCompareShops);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btDisplayProperties);
            this.groupBox1.Controls.Add(this.lbCarShopsProperties);
            this.groupBox1.Controls.Add(this.btDeleteShop);
            this.groupBox1.Controls.Add(this.lbCarShopsNames);
            this.groupBox1.Controls.Add(this.cbShopProperty);
            this.groupBox1.Controls.Add(this.btSetProperty);
            this.groupBox1.Controls.Add(this.btCreateShop);
            this.groupBox1.Controls.Add(this.tbInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 349);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbCarShops";
            // 
            // btDeleteAllWorkers
            // 
            this.btDeleteAllWorkers.Location = new System.Drawing.Point(325, 308);
            this.btDeleteAllWorkers.Name = "btDeleteAllWorkers";
            this.btDeleteAllWorkers.Size = new System.Drawing.Size(91, 34);
            this.btDeleteAllWorkers.TabIndex = 30;
            this.btDeleteAllWorkers.Text = "Видалити всіх співробітників";
            this.btDeleteAllWorkers.UseVisualStyleBackColor = true;
            // 
            // btOutPutWorkers
            // 
            this.btOutPutWorkers.Location = new System.Drawing.Point(241, 309);
            this.btOutPutWorkers.Name = "btOutPutWorkers";
            this.btOutPutWorkers.Size = new System.Drawing.Size(78, 34);
            this.btOutPutWorkers.TabIndex = 29;
            this.btOutPutWorkers.Text = "Відобразити робітників";
            this.btOutPutWorkers.UseVisualStyleBackColor = true;
            // 
            // btOutPutCars
            // 
            this.btOutPutCars.Location = new System.Drawing.Point(167, 309);
            this.btOutPutCars.Name = "btOutPutCars";
            this.btOutPutCars.Size = new System.Drawing.Size(71, 34);
            this.btOutPutCars.TabIndex = 28;
            this.btOutPutCars.Text = "Відобразити машини";
            this.btOutPutCars.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDeleteWorkerByIPN);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.btDeleteWorkerByIPN);
            this.groupBox2.Controls.Add(this.lbWorkers);
            this.groupBox2.Controls.Add(this.btAddWorker);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbWorkerINN);
            this.groupBox2.Controls.Add(this.tbWorkerDayOfBirth);
            this.groupBox2.Controls.Add(this.cbWorkerPosition);
            this.groupBox2.Controls.Add(this.tbWorkerSalary);
            this.groupBox2.Controls.Add(this.tbWorkerLastName);
            this.groupBox2.Controls.Add(this.tbWorkerName);
            this.groupBox2.Controls.Add(this.cbWorkerEducation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(470, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 202);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gbWorkers";
            // 
            // tbDeleteWorkerByIPN
            // 
            this.tbDeleteWorkerByIPN.Location = new System.Drawing.Point(285, 175);
            this.tbDeleteWorkerByIPN.Name = "tbDeleteWorkerByIPN";
            this.tbDeleteWorkerByIPN.Size = new System.Drawing.Size(197, 20);
            this.tbDeleteWorkerByIPN.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(285, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Введіть ІПН для видалення робітника";
            // 
            // btDeleteWorkerByIPN
            // 
            this.btDeleteWorkerByIPN.Location = new System.Drawing.Point(176, 160);
            this.btDeleteWorkerByIPN.Name = "btDeleteWorkerByIPN";
            this.btDeleteWorkerByIPN.Size = new System.Drawing.Size(103, 35);
            this.btDeleteWorkerByIPN.TabIndex = 30;
            this.btDeleteWorkerByIPN.Text = "Видалити робітника по ІПН";
            this.btDeleteWorkerByIPN.UseVisualStyleBackColor = true;
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.Location = new System.Drawing.Point(329, 13);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(161, 134);
            this.lbWorkers.TabIndex = 55;
            // 
            // btAddWorker
            // 
            this.btAddWorker.Location = new System.Drawing.Point(10, 161);
            this.btAddWorker.Name = "btAddWorker";
            this.btAddWorker.Size = new System.Drawing.Size(163, 35);
            this.btAddWorker.TabIndex = 28;
            this.btAddWorker.Text = "Додати співробітника";
            this.btAddWorker.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Введіть дату народження";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Виберіть посаду";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Виберіть освіту";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Введіть зарплату (8 000 - 60 000)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Введіть індивідуальний податковий номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Введіть прізвище";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Введіть ім\'я";
            // 
            // tbWorkerINN
            // 
            this.tbWorkerINN.Location = new System.Drawing.Point(102, 54);
            this.tbWorkerINN.Name = "tbWorkerINN";
            this.tbWorkerINN.Size = new System.Drawing.Size(138, 20);
            this.tbWorkerINN.TabIndex = 35;
            // 
            // tbWorkerDayOfBirth
            // 
            this.tbWorkerDayOfBirth.Location = new System.Drawing.Point(191, 137);
            this.tbWorkerDayOfBirth.Name = "tbWorkerDayOfBirth";
            this.tbWorkerDayOfBirth.Size = new System.Drawing.Size(88, 20);
            this.tbWorkerDayOfBirth.TabIndex = 34;
            // 
            // cbWorkerPosition
            // 
            this.cbWorkerPosition.FormattingEnabled = true;
            this.cbWorkerPosition.Items.AddRange(new object[] {
            "Директор",
            "HR",
            "Старший продавець",
            "Продавець",
            "Охоронець"});
            this.cbWorkerPosition.Location = new System.Drawing.Point(102, 136);
            this.cbWorkerPosition.Name = "cbWorkerPosition";
            this.cbWorkerPosition.Size = new System.Drawing.Size(87, 21);
            this.cbWorkerPosition.TabIndex = 32;
            // 
            // tbWorkerSalary
            // 
            this.tbWorkerSalary.Location = new System.Drawing.Point(102, 94);
            this.tbWorkerSalary.Name = "tbWorkerSalary";
            this.tbWorkerSalary.Size = new System.Drawing.Size(138, 20);
            this.tbWorkerSalary.TabIndex = 31;
            // 
            // tbWorkerLastName
            // 
            this.tbWorkerLastName.Location = new System.Drawing.Point(8, 94);
            this.tbWorkerLastName.Name = "tbWorkerLastName";
            this.tbWorkerLastName.Size = new System.Drawing.Size(88, 20);
            this.tbWorkerLastName.TabIndex = 30;
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(8, 54);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(88, 20);
            this.tbWorkerName.TabIndex = 28;
            // 
            // cbWorkerEducation
            // 
            this.cbWorkerEducation.FormattingEnabled = true;
            this.cbWorkerEducation.Items.AddRange(new object[] {
            "Немає",
            "Технічна",
            "Гуманітарна",
            "Фінансова",
            "Правова"});
            this.cbWorkerEducation.Location = new System.Drawing.Point(9, 136);
            this.cbWorkerEducation.Name = "cbWorkerEducation";
            this.cbWorkerEducation.Size = new System.Drawing.Size(87, 21);
            this.cbWorkerEducation.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "його властивостсі та виберіть магазин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Для створення робітника задайте всі";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCarsForSell);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cbCarsForSell);
            this.groupBox3.Controls.Add(this.btSellCar);
            this.groupBox3.Controls.Add(this.lbCars);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbCarsCount);
            this.groupBox3.Controls.Add(this.btAddCars);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbCarPriceForClient);
            this.groupBox3.Controls.Add(this.tbCarName);
            this.groupBox3.Controls.Add(this.tbCarPriceForShop);
            this.groupBox3.Controls.Add(this.cbCarBrand);
            this.groupBox3.Location = new System.Drawing.Point(470, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 148);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "gbCars";
            // 
            // tbCarsForSell
            // 
            this.tbCarsForSell.Location = new System.Drawing.Point(259, 88);
            this.tbCarsForSell.Name = "tbCarsForSell";
            this.tbCarsForSell.Size = new System.Drawing.Size(107, 20);
            this.tbCarsForSell.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(259, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Введіть назву";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(259, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Виберіть марку авто";
            // 
            // cbCarsForSell
            // 
            this.cbCarsForSell.ForeColor = System.Drawing.Color.Black;
            this.cbCarsForSell.FormattingEnabled = true;
            this.cbCarsForSell.Items.AddRange(new object[] {
            "BMW",
            "Citroen",
            "Lexus",
            "Mazda",
            "Opel",
            "Porsche",
            "Renault",
            "Skoda",
            "Suzuki",
            "Tesla"});
            this.cbCarsForSell.Location = new System.Drawing.Point(259, 127);
            this.cbCarsForSell.Name = "cbCarsForSell";
            this.cbCarsForSell.Size = new System.Drawing.Size(110, 21);
            this.cbCarsForSell.TabIndex = 56;
            // 
            // btSellCar
            // 
            this.btSellCar.Location = new System.Drawing.Point(372, 104);
            this.btSellCar.Name = "btSellCar";
            this.btSellCar.Size = new System.Drawing.Size(124, 32);
            this.btSellCar.TabIndex = 55;
            this.btSellCar.Text = "Продати машину";
            this.btSellCar.UseVisualStyleBackColor = true;
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(294, 16);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(196, 56);
            this.lbCars.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Введіть кількість авто";
            // 
            // tbCarsCount
            // 
            this.tbCarsCount.Location = new System.Drawing.Point(12, 107);
            this.tbCarsCount.Name = "tbCarsCount";
            this.tbCarsCount.Size = new System.Drawing.Size(88, 20);
            this.tbCarsCount.TabIndex = 53;
            // 
            // btAddCars
            // 
            this.btAddCars.Location = new System.Drawing.Point(116, 104);
            this.btAddCars.Name = "btAddCars";
            this.btAddCars.Size = new System.Drawing.Size(124, 32);
            this.btAddCars.TabIndex = 42;
            this.btAddCars.Text = "Додати машини";
            this.btAddCars.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(104, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Виберіть марку авто";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(158, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Введіть ціну для клієнтів";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Введіть ціну для магазину";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Введіть назву";
            // 
            // tbCarPriceForClient
            // 
            this.tbCarPriceForClient.Location = new System.Drawing.Point(157, 68);
            this.tbCarPriceForClient.Name = "tbCarPriceForClient";
            this.tbCarPriceForClient.Size = new System.Drawing.Size(96, 20);
            this.tbCarPriceForClient.TabIndex = 47;
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(12, 32);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(88, 20);
            this.tbCarName.TabIndex = 45;
            // 
            // tbCarPriceForShop
            // 
            this.tbCarPriceForShop.Location = new System.Drawing.Point(12, 68);
            this.tbCarPriceForShop.Name = "tbCarPriceForShop";
            this.tbCarPriceForShop.Size = new System.Drawing.Size(136, 20);
            this.tbCarPriceForShop.TabIndex = 44;
            // 
            // cbCarBrand
            // 
            this.cbCarBrand.ForeColor = System.Drawing.Color.Black;
            this.cbCarBrand.FormattingEnabled = true;
            this.cbCarBrand.Items.AddRange(new object[] {
            "BMW",
            "Citroen",
            "Lexus",
            "Mazda",
            "Opel",
            "Porsche",
            "Renault",
            "Skoda",
            "Suzuki",
            "Tesla"});
            this.cbCarBrand.Location = new System.Drawing.Point(105, 32);
            this.cbCarBrand.Name = "cbCarBrand";
            this.cbCarBrand.Size = new System.Drawing.Size(110, 21);
            this.cbCarBrand.TabIndex = 42;
            // 
            // btInputInformationFromFile
            // 
            this.btInputInformationFromFile.Location = new System.Drawing.Point(223, 46);
            this.btInputInformationFromFile.Name = "btInputInformationFromFile";
            this.btInputInformationFromFile.Size = new System.Drawing.Size(75, 22);
            this.btInputInformationFromFile.TabIndex = 31;
            this.btInputInformationFromFile.Text = "Ввести";
            this.btInputInformationFromFile.UseVisualStyleBackColor = true;
            // 
            // btOutputInformationInFile
            // 
            this.btOutputInformationInFile.Location = new System.Drawing.Point(202, 48);
            this.btOutputInformationInFile.Name = "btOutputInformationInFile";
            this.btOutputInformationInFile.Size = new System.Drawing.Size(81, 22);
            this.btOutputInformationInFile.TabIndex = 32;
            this.btOutputInformationInFile.Text = "Вивести";
            this.btOutputInformationInFile.UseVisualStyleBackColor = true;
            // 
            // rbCarsOutputInFile
            // 
            this.rbCarsOutputInFile.AutoSize = true;
            this.rbCarsOutputInFile.Location = new System.Drawing.Point(6, 0);
            this.rbCarsOutputInFile.Name = "rbCarsOutputInFile";
            this.rbCarsOutputInFile.Size = new System.Drawing.Size(202, 17);
            this.rbCarsOutputInFile.TabIndex = 41;
            this.rbCarsOutputInFile.TabStop = true;
            this.rbCarsOutputInFile.Text = "Вивід інформації о машинах у файл";
            this.rbCarsOutputInFile.UseVisualStyleBackColor = true;
            // 
            // rbWorkersOutputInFile
            // 
            this.rbWorkersOutputInFile.AutoSize = true;
            this.rbWorkersOutputInFile.Location = new System.Drawing.Point(6, 18);
            this.rbWorkersOutputInFile.Name = "rbWorkersOutputInFile";
            this.rbWorkersOutputInFile.Size = new System.Drawing.Size(211, 17);
            this.rbWorkersOutputInFile.TabIndex = 42;
            this.rbWorkersOutputInFile.TabStop = true;
            this.rbWorkersOutputInFile.Text = "Вивід інформації о робітниках у файл";
            this.rbWorkersOutputInFile.UseVisualStyleBackColor = true;
            // 
            // rbOnlyShopOutputInFile
            // 
            this.rbOnlyShopOutputInFile.AutoSize = true;
            this.rbOnlyShopOutputInFile.Location = new System.Drawing.Point(6, 38);
            this.rbOnlyShopOutputInFile.Name = "rbOnlyShopOutputInFile";
            this.rbOnlyShopOutputInFile.Size = new System.Drawing.Size(14, 13);
            this.rbOnlyShopOutputInFile.TabIndex = 43;
            this.rbOnlyShopOutputInFile.TabStop = true;
            this.rbOnlyShopOutputInFile.UseVisualStyleBackColor = true;
            // 
            // rbWholeShopOutputInFile
            // 
            this.rbWholeShopOutputInFile.AutoSize = true;
            this.rbWholeShopOutputInFile.Location = new System.Drawing.Point(6, 71);
            this.rbWholeShopOutputInFile.Name = "rbWholeShopOutputInFile";
            this.rbWholeShopOutputInFile.Size = new System.Drawing.Size(228, 17);
            this.rbWholeShopOutputInFile.TabIndex = 44;
            this.rbWholeShopOutputInFile.TabStop = true;
            this.rbWholeShopOutputInFile.Text = "Вивід всієї інформації о магазині у файл";
            this.rbWholeShopOutputInFile.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.rbWholeShopOutputInFile);
            this.groupBox4.Controls.Add(this.rbOnlyShopOutputInFile);
            this.groupBox4.Controls.Add(this.btOutputInformationInFile);
            this.groupBox4.Controls.Add(this.rbWorkersOutputInFile);
            this.groupBox4.Controls.Add(this.rbCarsOutputInFile);
            this.groupBox4.Location = new System.Drawing.Point(7, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 93);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 38);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(171, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Вивід інформації о магазині без ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(166, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "співробітників та машин у файл";
            // 
            // rbCarsInputFromFile
            // 
            this.rbCarsInputFromFile.AutoSize = true;
            this.rbCarsInputFromFile.Location = new System.Drawing.Point(4, 2);
            this.rbCarsInputFromFile.Name = "rbCarsInputFromFile";
            this.rbCarsInputFromFile.Size = new System.Drawing.Size(230, 17);
            this.rbCarsInputFromFile.TabIndex = 47;
            this.rbCarsInputFromFile.TabStop = true;
            this.rbCarsInputFromFile.Text = "Введення інформації о машинах з файлу";
            this.rbCarsInputFromFile.UseVisualStyleBackColor = true;
            // 
            // rbWorkersInputFromFile
            // 
            this.rbWorkersInputFromFile.AutoSize = true;
            this.rbWorkersInputFromFile.Location = new System.Drawing.Point(4, 25);
            this.rbWorkersInputFromFile.Name = "rbWorkersInputFromFile";
            this.rbWorkersInputFromFile.Size = new System.Drawing.Size(239, 17);
            this.rbWorkersInputFromFile.TabIndex = 47;
            this.rbWorkersInputFromFile.TabStop = true;
            this.rbWorkersInputFromFile.Text = "Введення інформації о робітниках з файлу";
            this.rbWorkersInputFromFile.UseVisualStyleBackColor = true;
            // 
            // rbOnlyShopInputFromFile
            // 
            this.rbOnlyShopInputFromFile.AutoSize = true;
            this.rbOnlyShopInputFromFile.Location = new System.Drawing.Point(4, 48);
            this.rbOnlyShopInputFromFile.Name = "rbOnlyShopInputFromFile";
            this.rbOnlyShopInputFromFile.Size = new System.Drawing.Size(14, 13);
            this.rbOnlyShopInputFromFile.TabIndex = 47;
            this.rbOnlyShopInputFromFile.TabStop = true;
            this.rbOnlyShopInputFromFile.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(193, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Введення інформації о магазині без ";
            // 
            // rbWholeShopInputFromFile
            // 
            this.rbWholeShopInputFromFile.AutoSize = true;
            this.rbWholeShopInputFromFile.Location = new System.Drawing.Point(4, 74);
            this.rbWholeShopInputFromFile.Name = "rbWholeShopInputFromFile";
            this.rbWholeShopInputFromFile.Size = new System.Drawing.Size(256, 17);
            this.rbWholeShopInputFromFile.TabIndex = 47;
            this.rbWholeShopInputFromFile.TabStop = true;
            this.rbWholeShopInputFromFile.Text = "Введення всієї інформації о магазині з файлу";
            this.rbWholeShopInputFromFile.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 58);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(172, 13);
            this.label27.TabIndex = 47;
            this.label27.Text = "співробітників та машин з файлу";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.rbWholeShopInputFromFile);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.rbOnlyShopInputFromFile);
            this.groupBox5.Controls.Add(this.rbWorkersInputFromFile);
            this.groupBox5.Controls.Add(this.rbCarsInputFromFile);
            this.groupBox5.Controls.Add(this.btInputInformationFromFile);
            this.groupBox5.Location = new System.Drawing.Point(301, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 93);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 478);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCreateShop;
        private System.Windows.Forms.Button btSetProperty;
        private System.Windows.Forms.ComboBox cbShopProperty;
        private System.Windows.Forms.ListBox lbCarShopsNames;
        private System.Windows.Forms.Button btDeleteShop;
        private System.Windows.Forms.ListBox lbCarShopsProperties;
        private System.Windows.Forms.Button btDisplayProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCompareShops;
        private System.Windows.Forms.ComboBox cbForCompareSecond;
        private System.Windows.Forms.ComboBox cbForCompareFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRandomFill;
        private System.Windows.Forms.Button btIndexator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbForIndexator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbWorkerEducation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbWorkerINN;
        private System.Windows.Forms.TextBox tbWorkerDayOfBirth;
        private System.Windows.Forms.ComboBox cbWorkerPosition;
        private System.Windows.Forms.TextBox tbWorkerSalary;
        private System.Windows.Forms.TextBox tbWorkerLastName;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Button btAddWorker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCarPriceForClient;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbCarPriceForShop;
        private System.Windows.Forms.ComboBox cbCarBrand;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCarsCount;
        private System.Windows.Forms.Button btAddCars;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox lbCars;
        private System.Windows.Forms.Button btOutPutWorkers;
        private System.Windows.Forms.Button btOutPutCars;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Button btInputInformationFromFile;
        private System.Windows.Forms.Button btOutputInformationInFile;
        private System.Windows.Forms.TextBox tbDeleteWorkerByIPN;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btDeleteWorkerByIPN;
        private System.Windows.Forms.Button btDeleteAllWorkers;
        private System.Windows.Forms.TextBox tbCarsForSell;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbCarsForSell;
        private System.Windows.Forms.Button btSellCar;
        private System.Windows.Forms.RadioButton rbCarsOutputInFile;
        private System.Windows.Forms.RadioButton rbWorkersOutputInFile;
        private System.Windows.Forms.RadioButton rbOnlyShopOutputInFile;
        private System.Windows.Forms.RadioButton rbWholeShopOutputInFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton rbCarsInputFromFile;
        private System.Windows.Forms.RadioButton rbWorkersInputFromFile;
        private System.Windows.Forms.RadioButton rbOnlyShopInputFromFile;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RadioButton rbWholeShopInputFromFile;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

