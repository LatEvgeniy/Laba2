using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<CarShop> carShops = new List<CarShop>();
        Random rand = new Random();      

        public Form1()
        {
            InitializeComponent();
            btCreateShop.Click += CreateShop_Click;
            btSetProperty.Click += SetProperty_Click;
            btDeleteShop.Click += DeleteShop_Click;
            btAddEmployee.Click += AddEmployee_Click;
            btSubEmployee.Click += SubEmployee_Click;
            btDisplayProperties.Click += DisplayProperties_Click;
            btIncome.Click += Income_Click;
            btAnnualTax.Click += AnnualTax_Click;
            btRandomFill.Click += RandomFill_Click;
            btCompareShops.Click += CompareShops_Click;
            btIndexator.Click += Indexator_Click;
        }

        private void Indexator_Click(object sender, EventArgs e) // індексатор для отримання данних в конкретний місяць
        {
            if (lbCarShopsNames.SelectedIndex >= 0 && tbInput.Text != String.Empty) // перевірка на корректність введених даних
            {
                lbCarShopsProperties.Items.Clear();
                switch (cbForIndexator.Text) // вибір параметра з колекції 
                {
                    case "Дохід за місяць": // в залежності від характеристики магазину та номера місяця відображуємо дані
                        try
                        {
                            lbCarShopsProperties.Items.Add($"Дохід за {tbInput.Text}-й місяць = " + carShops[lbCarShopsNames.SelectedIndex].monthIncome[uint.Parse(tbInput.Text) - 1]);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Номер місяця має бути в діапазоні 1..12",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);  // вивід сповіщення якщо введені некоректні дані
                        }                        
                        break;
                    case "Заробітня плата співробітників": // в залежності від характеристики магазину та номера місяця відображуємо дані
                        try
                        {
                            lbCarShopsProperties.Items.Add($"Заробітня плата співробітників за {tbInput.Text}-й місяць = " + carShops[lbCarShopsNames.SelectedIndex].monthSalary[uint.Parse(tbInput.Text) - 1]);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Номер місяця має бути в діапазоні 1..12",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);  // вивід сповіщення якщо введені некоректні дані
                        }
                        break;
                    case "Витрати на товари": // в залежності від характеристики магазину та номера місяця відображуємо дані
                        try
                        {
                            lbCarShopsProperties.Items.Add($"Витрати на товари за {tbInput.Text}-й місяць = " + carShops[lbCarShopsNames.SelectedIndex].monthProductCosts[uint.Parse(tbInput.Text) - 1]);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Номер місяця має бути в діапазоні 1..12",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);  // вивід сповіщення якщо введені некоректні дані
                        }
                        break;
                    default:
                        MessageBox.Show("Не було вибрано властивість магазину",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);  // вивід сповіщення якщо не було вибрано властивість магазину
                        break;
                }
            }
            else
                MessageBox.Show("Не було вибрано параметр для індексатора",
                "Помилка введення даних",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
        }

        private void RandomFill_Click(object sender, EventArgs e) // рандомне заповнення масивів які містят дані по місяцям
        {
            if (lbCarShopsNames.SelectedIndex >= 0) // перевірка чи був вибраний магазин для якого викликається рандомне заповнення
            {
                for (int i = 0; i < carShops[lbCarShopsNames.SelectedIndex].monthIncome.Length; i++)
                {
                    carShops[lbCarShopsNames.SelectedIndex].monthProductCosts[i] = (uint)rand.Next(0, 100);
                    carShops[lbCarShopsNames.SelectedIndex].monthSalary[i] = (uint)rand.Next(0, 100);
                    carShops[lbCarShopsNames.SelectedIndex].monthIncome[i] = (uint)rand.Next(0, 100);
                }
                carShops[lbCarShopsNames.SelectedIndex].UpdateAverage(); // оновлення річних параметрів
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазин 
        }
    
        private void CompareShops_Click(object sender, EventArgs e) // порівняння двух магазинів
        {
            if (cbForCompareFirst.SelectedIndex >= 0 && cbForCompareSecond.SelectedIndex >= 0 && cbForCompareFirst.SelectedIndex != cbForCompareSecond.SelectedIndex)
            {// перевірка чи були вибрані магазини для порівняння та чи різні ці магазини
                lbCarShopsProperties.Items.Clear();
                int compare = carShops[cbForCompareFirst.SelectedIndex].CompareTo(carShops[cbForCompareSecond.SelectedIndex]); // виклик метода для порівняння
                if (compare == -1)
                {// якщо другий магазин кращий то виведення інформації про нього
                   string[] output = carShops[cbForCompareSecond.SelectedIndex].ToString().Split(',');
                    foreach (var item in output)
                    {
                        lbCarShopsProperties.Items.Add(item);
                    }
                }
                else
                {// якщо перший магазин кращий або такий же як другий то виведення інформації про перший магазин
                    string[] output = carShops[cbForCompareFirst.SelectedIndex].ToString().Split(',');
                    foreach (var item in output)
                    {
                        lbCarShopsProperties.Items.Add(item);
                    }
                }
            }
            else
                MessageBox.Show("Не були вибрані магазини для порівяння або вони однакові",
                "Помилка введення даних",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
        }

        private void AnnualTax_Click(object sender, EventArgs e) // обчислення річного податку 17%
        {
            try
            {// виклик метода для обчислення податку та вивід результату 
                tbForResult.Text = carShops[lbCarShopsNames.SelectedIndex].AnnualTax().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Магазин не був обраний",
                "Помилка введення даних",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
            }
        }

        private void Income_Click(object sender, EventArgs e) // визначення середнього доходу за певну кількість місяців
        {
            try
            {
                uint month = uint.Parse(tbInput.Text); // отримуємо кількість місяців 
                tbForResult.Text = carShops[lbCarShopsNames.SelectedIndex].ToCountAverageIncomePer(month).ToString(); // викликаємо метод для обчислення
            }
            catch (Exception)
            {
                MessageBox.Show("Кількість місяців має бути додатнім числом або не був обраний магазин",
                "Помилка введення даних",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини або неправльно введена кількість місяців
            }
        }

        private void DisplayProperties_Click(object sender, EventArgs e) // вивід властивостей магазину
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            {// перевірка чи був обраний магазин
                lbCarShopsProperties.Items.Clear();
                string[] output = carShops[lbCarShopsNames.SelectedIndex].ToString().Split(',');// отримання массиву властивостей магазину
                foreach (var item in output)// построковий вивід властивостей магазину
                {
                    lbCarShopsProperties.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
        }

        private void SubEmployee_Click(object sender, EventArgs e) // звільнення співробітників за допомогою оператора --
        {
            if (lbCarShopsNames.SelectedIndex >= 0)// перевірка чи був обраний магазин
                carShops[lbCarShopsNames.SelectedIndex]--;
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
        }

        private void AddEmployee_Click(object sender, EventArgs e) // додавання кількості співробітників за допомогою оператора ++
        {
            if (lbCarShopsNames.SelectedIndex >= 0)// перевірка чи був обраний магазин
                carShops[lbCarShopsNames.SelectedIndex]++;
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
        }

        private void DeleteShop_Click(object sender, EventArgs e) // видалення магазину
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            {// перевірка чи був обраний магазин
                carShops.RemoveAt(lbCarShopsNames.SelectedIndex);
                cbForCompareFirst.Items.RemoveAt(lbCarShopsNames.SelectedIndex);
                cbForCompareSecond.Items.RemoveAt(lbCarShopsNames.SelectedIndex);
                lbCarShopsNames.Items.RemoveAt(lbCarShopsNames.SelectedIndex);
            }// видалення вибраного магазину з усіх колекцій та масивів де була інформація про нього
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); // вивід сповіщення якщо не було обрано магазини
        }

        private void SetProperty_Click(object sender, EventArgs e) // зміна параметра обраного магазину
        {
            if (lbCarShopsNames.SelectedIndex >= 0 && tbInput.Text != String.Empty)
            {// перевірка чи обраний магазин та перевірка на пустоту текстбокса
                switch (cbShopProperty.Text)//в залежності від обраного параметра магазина спроба змінити цей параметр
                {
                    case "Кількість відділів":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].DepartmentsCount = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса та зміна параметра магазина
                        catch (Exception)
                        {
                            MessageBox.Show("Кількість відділів має бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    case "Кількість співробітників":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].EmployeeCount = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса та зміна параметра магазина
                        catch (Exception)
                        {
                            MessageBox.Show("Кількість співробітників має бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    case "Назва магазину":
                            carShops[lbCarShopsNames.SelectedIndex].Name = tbInput.Text.Trim();
                            lbCarShopsNames.Items[lbCarShopsNames.SelectedIndex] = carShops[lbCarShopsNames.SelectedIndex].Name;
                            cbForCompareFirst.Items[lbCarShopsNames.SelectedIndex] = carShops[lbCarShopsNames.SelectedIndex].Name;
                            cbForCompareSecond.Items[lbCarShopsNames.SelectedIndex] = carShops[lbCarShopsNames.SelectedIndex].Name;
                        break;//зміна імені у всіх масивах
                    case "Адреса магазину":
                            carShops[lbCarShopsNames.SelectedIndex].Adress = tbInput.Text.Trim();
                        break;
                    case "Середній дохід магазину за місяць":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].AverageIncome = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса
                        catch (Exception)
                        {
                            MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    case "Загальга заробітня плата співробітника":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].TotalSalary = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса та зміна параметра магазина
                        catch (Exception)
                        {
                            MessageBox.Show("Загальга заробітня плата співробітника має бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    case "Загальні витрати на купівлю товарів":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].TotalProductCosts = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса та зміна параметра магазина
                        catch (Exception)
                        {
                            MessageBox.Show("Загальні витрати на купівлю товарів мають бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    case "Кільікість найменувань":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].ProductCount = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса
                        catch (Exception)
                        {
                            MessageBox.Show("Кількість найменувань має бути додатнім числом",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        } // вивід сповіщення якщо введені дані некоректні
                        break;
                    default:
                        MessageBox.Show("Не було вибрано властивість магазину",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                }
            }
            else
                MessageBox.Show("Не було вибрано властивість та/або пусте поле введення",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void CreateShop_Click(object sender, EventArgs e) // створення нового магазину
        {
            string name = tbInput.Text.Trim();
            if (tbInput.Text != String.Empty) //Перевірка на пустоту текстбокса
            {
                carShops.Add(new CarShop(name));
                lbCarShopsNames.Items.Add(name);
                cbForCompareFirst.Items.Add(name);
                cbForCompareSecond.Items.Add(name);
            } // додання магазину до усіх колекцій та масивів
            else
                MessageBox.Show("Пусте поле введення",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
        }
    }

    public class CarShop : IComparable<CarShop> // клас автомагазинів
    {
        private uint departmentsCount = 0, employeeCount = 0, productCount = 0; // кільіксть відділів, співробітників та найменувань товарів
        private uint averageIncome = 0, totalSalary = 0, totalProductCosts = 0; // дохід магазину на рік та загальна зп спіробітників і витрати на купівлю товарів
        private string name, adress; // ім'я та адреса магазину
        public uint[] monthIncome = new uint[12]; // помісячний дохід місяця
        public uint[] monthSalary = new uint[12]; // помісячна зп співробітників
        public uint[] monthProductCosts = new uint[12]; // помісячні витрати на купівлю товарів

        public CarShop(string name) => this.Name = name; // конструктор для створення магазину

        public uint DepartmentsCount { get; set; } // геттери та сеттери
        public uint EmployeeCount { get; set; }
        public uint ProductCount { get; set; }
        public uint TotalProductCosts { get; set; }
        public uint AverageIncome { get; set; }
        public uint TotalSalary { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public void UpdateAverage() // метод для оновлення доходу на рік та загальної зп спіробітників і витрати на купівлю товарів при зміні помісячних
        {
            this.AverageIncome = 0; // сброс минулих даних
            this.TotalProductCosts = 0;
            this.TotalSalary = 0;
            for (int i = 0; i < this.monthIncome.Length; i++)
            {
                this.AverageIncome += this.monthIncome[i];
                this.TotalProductCosts += this.monthProductCosts[i];
                this.TotalSalary += this.monthSalary[i];
            }
        }
        public override string ToString()// метод для більш коректного виводу інформації про магазин
        {
            return $"Ім'я: {Name},Адреса: {Adress},Кільіксть відділів: {DepartmentsCount},Кількість співробітників: {EmployeeCount},Середній дохід на місяць: {AverageIncome},Загальна зп співробітників: {TotalSalary},Загальні витрати на купівлю товарів: {TotalProductCosts},Кільіксть найменувать товарів: {ProductCount}";
        }
        public int CompareTo(CarShop second) // реалізація порівняння за допомогою інтерфейса IComparable
        {
            if (this.AverageIncome > second.AverageIncome)
                return 1;
            else
            {
                if (this.AverageIncome < second.AverageIncome)
                    return -1;
                else
                    return 0;
            }
            // 1 - больше
            // -1 - меньше
            // 0 - равны
        }
        public static CarShop operator --(CarShop carShop) // оператор -- для зміни кількості співробітників
        {
            if (carShop.EmployeeCount != 0)
            {
                carShop.EmployeeCount--;
                return carShop;
            }
            else
            {
                MessageBox.Show("Кількість співробітників дорівню нулю, нікого видаляти",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return carShop;
            }
        }
        public static CarShop operator ++(CarShop carShop) // оператор ++ для зміни кількості співробітників
        {
            carShop.EmployeeCount++;
            return carShop;
        }

        public uint ToCountAverageIncomePer(uint monthCount) // метод для підрахунку середнього доходу магазину на місяць
        {
            return AverageIncome / 12 * monthCount;
        }
        public double AnnualTax() // метод для підрахунку суми річного податку
        {
            return this.AverageIncome * 0.17;
        }
    }
}