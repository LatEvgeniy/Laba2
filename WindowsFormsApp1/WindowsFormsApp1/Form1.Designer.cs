
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
            this.tbForResult = new System.Windows.Forms.TextBox();
            this.cbShopProperty = new System.Windows.Forms.ComboBox();
            this.lbCarShopsNames = new System.Windows.Forms.ListBox();
            this.btDeleteShop = new System.Windows.Forms.Button();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.btSubEmployee = new System.Windows.Forms.Button();
            this.lbCarShopsProperties = new System.Windows.Forms.ListBox();
            this.btDisplayProperties = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btIncome = new System.Windows.Forms.Button();
            this.btAnnualTax = new System.Windows.Forms.Button();
            this.btCompareShops = new System.Windows.Forms.Button();
            this.cbForCompareSecond = new System.Windows.Forms.ComboBox();
            this.cbForCompareFirst = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRandomFill = new System.Windows.Forms.Button();
            this.btIndexator = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbForIndexator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(10, 155);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(136, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btCreateShop
            // 
            this.btCreateShop.Location = new System.Drawing.Point(10, 178);
            this.btCreateShop.Name = "btCreateShop";
            this.btCreateShop.Size = new System.Drawing.Size(100, 35);
            this.btCreateShop.TabIndex = 2;
            this.btCreateShop.Text = "Створити магазин";
            this.btCreateShop.UseVisualStyleBackColor = true;
            // 
            // btSetProperty
            // 
            this.btSetProperty.Location = new System.Drawing.Point(228, 217);
            this.btSetProperty.Name = "btSetProperty";
            this.btSetProperty.Size = new System.Drawing.Size(119, 35);
            this.btSetProperty.TabIndex = 3;
            this.btSetProperty.Text = "Задати властивість магазину";
            this.btSetProperty.UseVisualStyleBackColor = true;
            // 
            // tbForResult
            // 
            this.tbForResult.Location = new System.Drawing.Point(155, 155);
            this.tbForResult.Name = "tbForResult";
            this.tbForResult.ReadOnly = true;
            this.tbForResult.Size = new System.Drawing.Size(195, 20);
            this.tbForResult.TabIndex = 4;
            // 
            // cbShopProperty
            // 
            this.cbShopProperty.FormattingEnabled = true;
            this.cbShopProperty.Items.AddRange(new object[] {
            "Кількість відділів",
            "Кількість співробітників",
            "Назва магазину",
            "Адреса магазину",
            "Середній дохід магазину за місяць",
            "Загальга заробітня плата співробітника",
            "Загальні витрати на купівлю товарів",
            "Кільікість найменувань"});
            this.cbShopProperty.Location = new System.Drawing.Point(350, 231);
            this.cbShopProperty.Name = "cbShopProperty";
            this.cbShopProperty.Size = new System.Drawing.Size(209, 21);
            this.cbShopProperty.TabIndex = 5;
            // 
            // lbCarShopsNames
            // 
            this.lbCarShopsNames.FormattingEnabled = true;
            this.lbCarShopsNames.Location = new System.Drawing.Point(12, 23);
            this.lbCarShopsNames.Name = "lbCarShopsNames";
            this.lbCarShopsNames.Size = new System.Drawing.Size(152, 108);
            this.lbCarShopsNames.TabIndex = 6;
            // 
            // btDeleteShop
            // 
            this.btDeleteShop.Location = new System.Drawing.Point(10, 217);
            this.btDeleteShop.Name = "btDeleteShop";
            this.btDeleteShop.Size = new System.Drawing.Size(100, 35);
            this.btDeleteShop.TabIndex = 7;
            this.btDeleteShop.Text = "Видалити магазин";
            this.btDeleteShop.UseVisualStyleBackColor = true;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Location = new System.Drawing.Point(10, 257);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(100, 35);
            this.btAddEmployee.TabIndex = 9;
            this.btAddEmployee.Text = "Додати співробітника";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btSubEmployee
            // 
            this.btSubEmployee.Location = new System.Drawing.Point(116, 257);
            this.btSubEmployee.Name = "btSubEmployee";
            this.btSubEmployee.Size = new System.Drawing.Size(108, 35);
            this.btSubEmployee.TabIndex = 10;
            this.btSubEmployee.Text = "Видалити співробітника";
            this.btSubEmployee.UseVisualStyleBackColor = true;
            // 
            // lbCarShopsProperties
            // 
            this.lbCarShopsProperties.FormattingEnabled = true;
            this.lbCarShopsProperties.Location = new System.Drawing.Point(178, 23);
            this.lbCarShopsProperties.Name = "lbCarShopsProperties";
            this.lbCarShopsProperties.Size = new System.Drawing.Size(352, 108);
            this.lbCarShopsProperties.TabIndex = 11;
            // 
            // btDisplayProperties
            // 
            this.btDisplayProperties.Location = new System.Drawing.Point(116, 217);
            this.btDisplayProperties.Name = "btDisplayProperties";
            this.btDisplayProperties.Size = new System.Drawing.Size(108, 35);
            this.btDisplayProperties.TabIndex = 12;
            this.btDisplayProperties.Text = "Відобразити властивості";
            this.btDisplayProperties.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список магазинів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Властивості магазину";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Поле для введення даних";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Виберіть властивість яку хочете змінити";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Відображає порахований результат";
            // 
            // btIncome
            // 
            this.btIncome.Location = new System.Drawing.Point(116, 178);
            this.btIncome.Name = "btIncome";
            this.btIncome.Size = new System.Drawing.Size(108, 34);
            this.btIncome.TabIndex = 18;
            this.btIncome.Text = "Дохід за введену к-сть місяців";
            this.btIncome.UseVisualStyleBackColor = true;
            // 
            // btAnnualTax
            // 
            this.btAnnualTax.Location = new System.Drawing.Point(228, 178);
            this.btAnnualTax.Name = "btAnnualTax";
            this.btAnnualTax.Size = new System.Drawing.Size(119, 35);
            this.btAnnualTax.TabIndex = 19;
            this.btAnnualTax.Text = "Визначення годового податку (17%)";
            this.btAnnualTax.UseVisualStyleBackColor = true;
            // 
            // btCompareShops
            // 
            this.btCompareShops.Location = new System.Drawing.Point(228, 257);
            this.btCompareShops.Name = "btCompareShops";
            this.btCompareShops.Size = new System.Drawing.Size(119, 35);
            this.btCompareShops.TabIndex = 20;
            this.btCompareShops.Text = "Порівняти магазини";
            this.btCompareShops.UseVisualStyleBackColor = true;
            // 
            // cbForCompareSecond
            // 
            this.cbForCompareSecond.FormattingEnabled = true;
            this.cbForCompareSecond.Location = new System.Drawing.Point(453, 272);
            this.cbForCompareSecond.Name = "cbForCompareSecond";
            this.cbForCompareSecond.Size = new System.Drawing.Size(100, 21);
            this.cbForCompareSecond.TabIndex = 21;
            // 
            // cbForCompareFirst
            // 
            this.cbForCompareFirst.FormattingEnabled = true;
            this.cbForCompareFirst.Location = new System.Drawing.Point(350, 272);
            this.cbForCompareFirst.Name = "cbForCompareFirst";
            this.cbForCompareFirst.Size = new System.Drawing.Size(97, 21);
            this.cbForCompareFirst.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Виберіть магазини для порівняння";
            // 
            // btRandomFill
            // 
            this.btRandomFill.Location = new System.Drawing.Point(12, 297);
            this.btRandomFill.Name = "btRandomFill";
            this.btRandomFill.Size = new System.Drawing.Size(163, 34);
            this.btRandomFill.TabIndex = 24;
            this.btRandomFill.Text = "Випадково заповнити місячні показники магазину";
            this.btRandomFill.UseVisualStyleBackColor = true;
            // 
            // btIndexator
            // 
            this.btIndexator.Location = new System.Drawing.Point(181, 298);
            this.btIndexator.Name = "btIndexator";
            this.btIndexator.Size = new System.Drawing.Size(90, 34);
            this.btIndexator.TabIndex = 25;
            this.btIndexator.Text = "Індексатор";
            this.btIndexator.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 295);
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
            this.cbForIndexator.Location = new System.Drawing.Point(279, 311);
            this.cbForIndexator.Name = "cbForIndexator";
            this.cbForIndexator.Size = new System.Drawing.Size(217, 21);
            this.cbForIndexator.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 343);
            this.Controls.Add(this.cbForIndexator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btIndexator);
            this.Controls.Add(this.btRandomFill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbForCompareFirst);
            this.Controls.Add(this.cbForCompareSecond);
            this.Controls.Add(this.btCompareShops);
            this.Controls.Add(this.btAnnualTax);
            this.Controls.Add(this.btIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDisplayProperties);
            this.Controls.Add(this.lbCarShopsProperties);
            this.Controls.Add(this.btSubEmployee);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.btDeleteShop);
            this.Controls.Add(this.lbCarShopsNames);
            this.Controls.Add(this.cbShopProperty);
            this.Controls.Add(this.tbForResult);
            this.Controls.Add(this.btSetProperty);
            this.Controls.Add(this.btCreateShop);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCreateShop;
        private System.Windows.Forms.Button btSetProperty;
        private System.Windows.Forms.TextBox tbForResult;
        private System.Windows.Forms.ComboBox cbShopProperty;
        private System.Windows.Forms.ListBox lbCarShopsNames;
        private System.Windows.Forms.Button btDeleteShop;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Button btSubEmployee;
        private System.Windows.Forms.ListBox lbCarShopsProperties;
        private System.Windows.Forms.Button btDisplayProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btIncome;
        private System.Windows.Forms.Button btAnnualTax;
        private System.Windows.Forms.Button btCompareShops;
        private System.Windows.Forms.ComboBox cbForCompareSecond;
        private System.Windows.Forms.ComboBox cbForCompareFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRandomFill;
        private System.Windows.Forms.Button btIndexator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbForIndexator;
    }
}

