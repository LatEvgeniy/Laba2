using System;
using System.Collections.Generic;
using System.IO;
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
        List<Car> cars = new List<Car>();
        Dictionary<string, Worker> workers = new Dictionary<string, Worker>();
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory("ShopData");
            btCreateShop.Click += CreateShop_Click;
            btSetProperty.Click += SetProperty_Click;
            btDeleteShop.Click += DeleteShop_Click;
            btDisplayProperties.Click += DisplayProperties_Click;
            btRandomFill.Click += RandomFill_Click;
            btCompareShops.Click += CompareShops_Click;
            btAddWorker.Click += AddWorker_Click;
            btAddCars.Click += AddCars_Click;
            btOutPutCars.Click += OutPutCars_Click;
            btOutPutWorkers.Click += OutPutWorkers_Click;
            btInputInformationFromFile.Click += InputInformationFromFile;
            btOutputInformationInFile.Click += OutputInformationInFile;
            btDeleteWorkerByIPN.Click += DeleteWorkerByIPN_Click;
            btDeleteAllWorkers.Click += BtDeleteAllWorkers_Click;
            btSellCar.Click += SellCar_Click;
        }

        private void SellCar_Click(object sender, EventArgs e) // для продажу авто
        {
            if (lbCarShopsNames.SelectedIndex >= 0 && cbCarsForSell.SelectedIndex >= 0)
            { // перевірка чи вибраний магазин та чи вибрана марка авто
                if (carShops[lbCarShopsNames.SelectedIndex].cars.Count != 0)
                { // перевірка чи є у магазина автомобілі
                    int forCheck = 0; // для перевірки чи є в магазину введена машина
                    for (int i = 0; i < carShops[lbCarShopsNames.SelectedIndex].cars.Count; i++)
                    {
                        Car carForSale = new Car(tbCarsForSell.Text, 
                            cbCarsForSell.Text, 
                            carShops[lbCarShopsNames.SelectedIndex].cars[i].PriceForClient, 
                            carShops[lbCarShopsNames.SelectedIndex].cars[i].PriceForShop);
                        // створення машини для перевірки чи є такая машина в машазині
                        if (carShops[lbCarShopsNames.SelectedIndex].cars[i].IsEqual(carForSale))
                        { // якщо є - видаляємо та збільшуємо кількість грошей у магазині
                            carShops[lbCarShopsNames.SelectedIndex].MoneyCount +=
                                carShops[lbCarShopsNames.SelectedIndex].cars[i].PriceForClient;
                            carShops[lbCarShopsNames.SelectedIndex].cars.Remove(
                                carShops[lbCarShopsNames.SelectedIndex].cars[i]);
                            return;
                        }
                        forCheck++;    
                    }
                    if (forCheck == carShops[lbCarShopsNames.SelectedIndex].cars.Count)
                        MessageBox.Show("У магазина немає такої машини",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("У магазина немає машин",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void BtDeleteAllWorkers_Click(object sender, EventArgs e) // видалити всіх робітників магазину
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            { // перевірка чи був обраний магазин
                if (carShops[lbCarShopsNames.SelectedIndex].EmployeeCount != 0)
                { // якщо є робітники - видаляємо всіх
                    carShops[lbCarShopsNames.SelectedIndex].workers.Clear();
                    workers.Clear();
                }
                else
                    MessageBox.Show("У магазина немає робітників",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void DeleteWorkerByIPN_Click(object sender, EventArgs e)  // видалення робітника по ІПН
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            { // перевірка чи був обраний магазин
                try
                { // для сповіщення якщо буде помилка
                    if (carShops[lbCarShopsNames.SelectedIndex].EmployeeCount != 0)
                    { // перевірка чи є робітники
                        if (carShops[lbCarShopsNames.SelectedIndex].workers.ContainsKey(tbDeleteWorkerByIPN.Text))
                        { // якщо є робітник з введеним ІПН - видаляємо його
                            carShops[lbCarShopsNames.SelectedIndex].workers.Remove(tbDeleteWorkerByIPN.Text);
                            workers.Remove(tbDeleteWorkerByIPN.Text);
                        }
                        else
                            MessageBox.Show("Немає робітника з таким ідентифікаціонним " +
                                "податковим номером в обраному магазині",
                                "Помилка введення даних",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }                        
                    else
                        MessageBox.Show("У магазина немає робітників",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Немає робітника з таким ідентифікаціонним податковим номером",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
           
        private void OutputInformationInFile(object sender, EventArgs e) // виведення інформації у файл
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save shop information";
            saveFileDialog1.ShowDialog();
            // створення параметрів діалогового вікна

            if (saveFileDialog1.FileName != "")
            { // перевірка чи обраний файл      
                var filePath = saveFileDialog1.FileName;
                if (!(rbCarsOutputInFile.Checked ||
                    rbWorkersOutputInFile.Checked ||
                    rbOnlyShopOutputInFile.Checked ||
                    rbWholeShopOutputInFile.Checked))
                { // перевірка чи вибрані що виводити
                    MessageBox.Show("Не було вибрано що виводити",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                // перевірки чи який radio button вибраний 
                if (rbCarsOutputInFile.Checked)
                {
                    if (lbCarShopsNames.SelectedIndex >= 0)
                    { // перевірка чи обраний магазин
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            for (int i = 0; i < carShops[lbCarShopsNames.SelectedIndex].СarCount; i++)
                            { // виведення у файл
                                string[] output = carShops[lbCarShopsNames.SelectedIndex].cars[i].ToString().Split(',');
                                foreach (var item in output)// построковий вивід властивостей магазину
                                {
                                    file.WriteLine(item);
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Не був вибраний магазин",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (rbWorkersOutputInFile.Checked)
                {
                    if (lbCarShopsNames.SelectedIndex >= 0)
                    { // перевірка чи обраний магазин
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            foreach (var worker in carShops[lbCarShopsNames.SelectedIndex].workers)// построковий вивід властивостей магазину
                            { // виведення у файл інформації
                                foreach (var output in carShops[lbCarShopsNames.SelectedIndex].workers[worker.Key].ToString().Split(','))
                                    file.WriteLine(output);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Не був вибраний магазин",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (rbOnlyShopOutputInFile.Checked)
                {
                    if (lbCarShopsNames.SelectedIndex >= 0)
                    { // перевірка чи був обраний магазин
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            string[] output = carShops[lbCarShopsNames.SelectedIndex].ToString().Split(',');
                            foreach (var item in output)// построковий вивід властивостей магазину
                            { // виведення інформації у файл
                                file.WriteLine(item);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Не був вибраний магазин",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (rbWholeShopOutputInFile.Checked)
                {
                    if (lbCarShopsNames.SelectedIndex >= 0)
                    { // перевірка чи був обраний магазин
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            string[] output = carShops[lbCarShopsNames.SelectedIndex].ToString().Split(',');
                            foreach (var item in output)// построковий вивід властивостей магазину
                            {
                                file.WriteLine(item);
                            }
                            for (int i = 0; i < carShops[lbCarShopsNames.SelectedIndex].СarCount; i++)
                            {
                                output = carShops[lbCarShopsNames.SelectedIndex].cars[i].ToString().Split(',');
                                foreach (var item in output)// построковий вивід властивостей магазину
                                {
                                    file.WriteLine(item);
                                }
                            }
                            foreach (var worker in carShops[lbCarShopsNames.SelectedIndex].workers)// построковий вивід властивостей магазину
                            {
                                foreach (var outPut in carShops[lbCarShopsNames.SelectedIndex].workers[worker.Key].ToString().Split(','))
                                    file.WriteLine(outPut);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Не був вибраний магазин",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void InputInformationFromFile(object sender, EventArgs e)  // введення інформації з файлу
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            { // щоб не забути закрити файл
                openFileDialog.InitialDirectory = "ShopData\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                // встановлення параметрів діалогового вікна

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // чи був успішно відкритий файл
                    var filePath = openFileDialog.FileName;
                    if (!(rbCarsInputFromFile.Checked ||
                        rbWorkersInputFromFile.Checked ||
                        rbOnlyShopInputFromFile.Checked ||
                        rbWholeShopInputFromFile.Checked))
                    { // чи було обрано що вводити
                        MessageBox.Show("Не було вибрано що вводити",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    // перевірки що було вибрано для введення
                    if (rbCarsInputFromFile.Checked)
                    {
                        if (lbCarShopsNames.SelectedIndex >= 0)
                        { // чи був обраний магазин
                            try
                            { // у разі якщо буде помилка
                                using (var file = new StreamReader(filePath))
                                { // щоб не забути закрити файл
                                    for (int i = 0; i < File.ReadAllLines(filePath).Length / 4; i++)
                                    { // потстрокове читання з файлу
                                        string name = file.ReadLine();
                                        string brand = file.ReadLine();
                                        string priceForClient = file.ReadLine();
                                        string priceForShop = file.ReadLine();
                                        name = name.Split(':')[1]; // отримання параметрів кожної машини
                                        brand = brand.Split(':')[1];
                                        priceForClient = priceForClient.Split(':')[1];
                                        priceForShop = priceForShop.Split(':')[1];
                                        carShops[lbCarShopsNames.SelectedIndex].AddSeveralCars(
                                            name.Trim(),
                                            brand.Trim(),
                                            uint.Parse(priceForClient.Trim()),
                                            uint.Parse(priceForShop.Trim()),
                                            1); // створення нової машини у магазині
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Помилка при читанні з файла",
                                 "Помилка введення даних",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Не був вибраний магазин",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    if (rbWorkersInputFromFile.Checked)
                    {
                        if (lbCarShopsNames.SelectedIndex >= 0)
                        { // чи був обраний магазин
                            try
                            { // у разі помилки при читанні
                                Dictionary<string, Worker> workersInput = new Dictionary<string, Worker>();  // тимчасовий словник для введення
                                using (var file = new StreamReader(filePath))
                                { // щоб не забути закрити файл
                                    for (int i = 0; i < File.ReadAllLines(filePath).Length / 7; i++)
                                    { // построкове читання з файлу
                                        string firstName = file.ReadLine();
                                        string lastName = file.ReadLine();
                                        string education = file.ReadLine();
                                        string position = file.ReadLine();
                                        string salary = file.ReadLine();
                                        string individualTaxpayerNumber = file.ReadLine();
                                        string dateOfBirth = file.ReadLine();
                                        firstName = firstName.Split(':')[1]; // отримання параметрів рабітника
                                        lastName = lastName.Split(':')[1];
                                        education = education.Split(':')[1];
                                        position = position.Split(':')[1];
                                        salary = salary.Split(':')[1];
                                        individualTaxpayerNumber = individualTaxpayerNumber.Split(':')[1];
                                        dateOfBirth = dateOfBirth.Split(':')[1];
                                        uint uintSalary;
                                        individualTaxpayerNumber = individualTaxpayerNumber.Trim();
                                        try
                                        { // перевірка на корректність отриманих данних
                                            if (uint.Parse(salary) >= 8000 && uint.Parse(salary) <= 60000)
                                                uintSalary = uint.Parse(salary);
                                            else
                                            {
                                                MessageBox.Show("Зарплата робітника має будти від 8 000 до 60 000",
                                                    "Помилка введення даних",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                                            "Помилка введення даних",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                            return;
                                        } // вивід сповіщення якщо введені дані некоректні
                                        try
                                        { // перевірка на правильність отриманого ІПН
                                            long temp = uint.Parse(individualTaxpayerNumber);
                                            int iterator = 0;
                                            while (temp > 0)
                                            {
                                                iterator++;
                                                temp /= 10;
                                            }
                                            if (iterator != 10)
                                            {
                                                MessageBox.Show("Індивідуальний податковий номер має складатись з 10 цифр",
                                                                                   "Помилка введення даних",
                                                                                    MessageBoxButtons.OK,
                                                                                   MessageBoxIcon.Error);
                                                return;
                                            }

                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Індивідуальний податковий номер має складатись з 10 цифр",
                                            "Помилка введення даних",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                            return;
                                        } // вивід сповіщення якщо введені дані некоректні
                                        foreach (var worker in carShops[lbCarShopsNames.SelectedIndex].workers)
                                        { // перевірка на унікальність ІПН
                                            if (individualTaxpayerNumber == worker.Key)
                                            {
                                                MessageBox.Show("Однаковий індивідуальний податковий номер",
                                                                    "Помилка введення даних",
                                                                     MessageBoxButtons.OK,
                                                                     MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                        workersInput.Add(individualTaxpayerNumber, new Worker(firstName.Trim(),
                                            lastName.Trim(),
                                            education.Trim(),
                                            dateOfBirth.Trim(),
                                            position.Trim(),
                                            uintSalary,
                                            individualTaxpayerNumber));
                                        carShops[lbCarShopsNames.SelectedIndex].AddWorker(workersInput[individualTaxpayerNumber]);
                                        // додавання робітника
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Помилка при читанні з файла",
                                    "Помилка введення даних",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Не був вибраний магазин",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    if (rbOnlyShopInputFromFile.Checked)
                    {
                        try
                        {  // сповіщення у разі помилки
                            using (var file = new StreamReader(filePath))
                            { // щоб не забути закрити файл
                                for (int i = 0; i < File.ReadAllLines(filePath).Length / 8; i++)
                                { // построкове читання з файлу
                                    string name = file.ReadLine();
                                    string adress = file.ReadLine();
                                    string employeeCount = file.ReadLine();
                                    string averageIncome = file.ReadLine();
                                    string totalSalary = file.ReadLine();
                                    string totalProductCosts = file.ReadLine();
                                    string productCount = file.ReadLine();
                                    string moneyCount = file.ReadLine();
                                    name = name.Split(':')[1]; // отримання даних магазину
                                    adress = adress.Split(':')[1];
                                    employeeCount = employeeCount.Split(':')[1];
                                    averageIncome = averageIncome.Split(':')[1];
                                    totalSalary = totalSalary.Split(':')[1];
                                    totalProductCosts = totalProductCosts.Split(':')[1];
                                    productCount = productCount.Split(':')[1];
                                    moneyCount = moneyCount.Split(':')[1];
                                    name = name.Trim();
                                    carShops.Add(new CarShop(name)); // створення нового магазину
                                    carShops[carShops.Count - 1].Adress = adress.Trim();
                                    carShops[carShops.Count - 1].AverageIncome = uint.Parse(averageIncome);
                                    carShops[carShops.Count - 1].TotalSalary = uint.Parse(totalSalary);
                                    carShops[carShops.Count - 1].TotalProductCosts = uint.Parse(totalProductCosts);
                                    carShops[carShops.Count - 1].ProductCount = uint.Parse(productCount);
                                    carShops[carShops.Count - 1].MoneyCount = uint.Parse(moneyCount);
                                    lbCarShopsNames.Items.Add(name);
                                    cbForCompareFirst.Items.Add(name);
                                    cbForCompareSecond.Items.Add(name);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Помилка при читанні з файла",
                                        "Помилка введення даних",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                        }
                    }
                    if (rbWholeShopInputFromFile.Checked)
                    {
                        try
                        { // сповіщення у разі помилки
                            Dictionary<string, Worker> workersInput = new Dictionary<string, Worker>(); // тимчасовий словник
                            using (var file = new StreamReader(filePath))
                            { // щоб не забути закрити файл
                                string name = file.ReadLine(); // построкове читання з файлу
                                string adress = file.ReadLine();
                                string employeeCount = file.ReadLine();
                                string averageIncome = file.ReadLine();
                                string totalSalary = file.ReadLine();
                                string totalProductCosts = file.ReadLine();
                                string productCount = file.ReadLine();
                                string moneyCount = file.ReadLine();
                                name = name.Split(':')[1]; // отримання параметрів магазину
                                adress = adress.Split(':')[1];
                                employeeCount = employeeCount.Split(':')[1];
                                averageIncome = averageIncome.Split(':')[1];
                                totalSalary = totalSalary.Split(':')[1];
                                totalProductCosts = totalProductCosts.Split(':')[1];
                                productCount = productCount.Split(':')[1];
                                moneyCount = moneyCount.Split(':')[1];
                                name = name.Trim();
                                carShops.Add(new CarShop(name)); // створення нового магазину
                                carShops[carShops.Count - 1].Adress = adress.Trim();
                                carShops[carShops.Count - 1].AverageIncome = uint.Parse(averageIncome);
                                carShops[carShops.Count - 1].TotalSalary = uint.Parse(totalSalary);
                                carShops[carShops.Count - 1].TotalProductCosts = uint.Parse(totalProductCosts);
                                carShops[carShops.Count - 1].ProductCount = uint.Parse(productCount);
                                carShops[carShops.Count - 1].MoneyCount = uint.Parse(moneyCount);
                                lbCarShopsNames.Items.Add(name);
                                cbForCompareFirst.Items.Add(name);
                                cbForCompareSecond.Items.Add(name);
                                string carsAndWorkers = file.ReadToEnd(); // читання інформації про робітників та машини магазину
                                List<string> carsNames = new List<string>(); // тимчасові массиви для зчитаних данних
                                List<string> carsBrand = new List<string>();
                                List<string> carsPriceForClient = new List<string>();
                                List<string> carsPriceForShops = new List<string>();
                                List<string> workersFirstNames = new List<string>();
                                List<string> workersLastNames = new List<string>();
                                List<string> workersEducation = new List<string>();
                                List<string> workersPosition = new List<string>();
                                List<string> workersSalary = new List<string>();
                                List<string> workersIndividualTaxpayerNumber = new List<string>();
                                List<string> workersDateOfBirth = new List<string>();
                                string[] stringarray = carsAndWorkers.Split('\n'); // построкове розбиття інф про робітників та мишини
                                for (int i = 0; i < stringarray.Length; i++)
                                {  // "сортування" інформації про робітників та машини
                                    if (stringarray[i].Contains("Назва:"))
                                    {
                                        carsNames.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Бренд:"))
                                    {
                                        carsBrand.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Ціна для клієнтів:"))
                                    {
                                        carsPriceForClient.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Ціна для магазину:"))
                                    {
                                        carsPriceForShops.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Ім'я:"))
                                    {
                                        workersFirstNames.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Прізвище:"))
                                    {
                                        workersLastNames.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Освіта:"))
                                    {
                                        workersEducation.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Посада:"))
                                    {
                                        workersPosition.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Зарплата:"))
                                    {
                                        workersSalary.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("ІПН:"))
                                    {
                                        workersIndividualTaxpayerNumber.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                    if (stringarray[i].Contains("Дата народження:"))
                                    {
                                        workersDateOfBirth.Add(stringarray[i].Split(':')[1].Trim());
                                    }
                                }
                                for (int i = 0; i < carsNames.Count; i++)
                                { // додавання до магазину машин
                                    carShops[carShops.Count - 1].AddSeveralCars(
                                            carsNames[i],
                                            carsBrand[i],
                                            uint.Parse(carsPriceForClient[i]),
                                            uint.Parse(carsPriceForShops[i]),
                                            1);
                                }
                                for (int i = 0; i < workersFirstNames.Count; i++)
                                { // додавання до магазину робітників 
                                    workersInput.Add(workersIndividualTaxpayerNumber[i], new Worker(workersFirstNames[i],
                                           workersLastNames[i],
                                           workersEducation[i],
                                           workersDateOfBirth[i],
                                           workersPosition[i],
                                           uint.Parse(workersSalary[i]),
                                           workersIndividualTaxpayerNumber[i]));
                                    carShops[carShops.Count - 1].AddWorker(workersInput[workersIndividualTaxpayerNumber[i]]);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Помилка при читанні з файла",
                                        "Помилка введення даних",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void OutPutWorkers_Click(object sender, EventArgs e) // для виведення інформації про робітників у listbox
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            {// перевірка чи був обраний магазин
                if (carShops[lbCarShopsNames.SelectedIndex].EmployeeCount > 0)
                { // чи є робітники
                    lbWorkers.Items.Clear(); // очищення попередньої інформації
                    foreach (var worker in carShops[lbCarShopsNames.SelectedIndex].workers)// построковий вивід властивостей магазину
                    {
                        string[] output = carShops[lbCarShopsNames.SelectedIndex].workers[worker.Key].ToString().Split(',');
                        foreach (var item in output)// построковий вивід властивостей магазину
                        {
                            lbWorkers.Items.Add(item);
                        }
                    }
                }
                else
                    MessageBox.Show("У магазина немає робітників",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void OutPutCars_Click(object sender, EventArgs e) // для виведення інформації про машини у listbox
        {
            if (lbCarShopsNames.SelectedIndex >= 0)
            {// перевірка чи був обраний магазин
                if (carShops[lbCarShopsNames.SelectedIndex].СarCount > 0)
                { // чи є машини у магазині 
                    lbCars.Items.Clear(); // очищення попередньої інформації
                    for (int i = 0; i < carShops[lbCarShopsNames.SelectedIndex].СarCount; i++)
                    {
                        string[] output = carShops[lbCarShopsNames.SelectedIndex].cars[i].ToString().Split(',');
                        foreach (var item in output)// построковий вивід властивостей магазину
                        {
                            lbCars.Items.Add(item);
                        }
                    }                   
                }
                else
                    MessageBox.Show("У магазина немає машин",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не був вибраний магазин",
                "Помилка введення даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void AddCars_Click(object sender, EventArgs e) // щоб додати машини у магазин
        {
            if (tbCarName.Text != String.Empty &&
                tbCarPriceForClient.Text != String.Empty &&
                tbCarPriceForShop.Text != String.Empty &&
                tbCarsCount.Text != String.Empty &&
                cbCarBrand.Text != String.Empty &&
                lbCarShopsNames.SelectedIndex >= 0) //Перевірка на пустоту полів для введення
            {               
                string name, brand;
                uint priceForClient, priceForShop, carsCount;
                name = tbCarName.Text.Trim();  // читання параметрів з текстбокса
                try
                {
                    carsCount = uint.Parse(tbCarsCount.Text.Trim());
                }// спроба читання параметра з текстбокса
                catch (Exception)
                {
                    MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                } // вивід сповіщення якщо введені дані некоректні
                try
                {
                    priceForClient = uint.Parse(tbCarPriceForClient.Text.Trim());
                }// спроба читання параметра з текстбокса
                catch (Exception)
                {
                    MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                } // вивід сповіщення якщо введені дані некоректні
                try
                {
                    priceForShop = uint.Parse(tbCarPriceForShop.Text.Trim());
                }// спроба читання параметра з текстбокса
                catch (Exception)
                {
                    MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                } // вивід сповіщення якщо введені дані некоректні
                switch (cbCarBrand.Text)
                { // читання данних з комбо боксу
                    case "BMW":
                        brand = "BMW";
                        break;
                    case "Citroen":
                        brand = "Citroen";
                        break;
                    case "Lexus":
                        brand = "Lexus";
                        break;
                    case "Mazda":
                        brand = "Mazda";
                        break;
                    case "Opel":
                        brand = "Opel";
                        break;
                    case "Porsche":
                        brand = "Porsche";
                        break;
                    case "Renault":
                        brand = "Renault";
                        break;
                    case "Skoda":
                        brand = "Skoda";
                        break;
                    case "Suzuki":
                        brand = "Suzuki";
                        break;
                    case "Tesla":
                        brand = "Tesla";
                        break;
                    default:
                        MessageBox.Show("Не було вибрано властивість магазину",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                }
                if (priceForClient>priceForShop) // щоб ціна машиги для клінта була більша за ціну для магазину
                    carShops[lbCarShopsNames.SelectedIndex].AddSeveralCars(name, brand, priceForClient, priceForShop, carsCount);
                else
                    MessageBox.Show("Ціна для клієнта має бути більша за ціну для магазину",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // вивід сповіщення якщо щось не було задано
            } // додання магазину до усіх колекцій та масивів
            else
                MessageBox.Show("Не були задані усі поля та/або не вибран магазин",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // вивід сповіщення якщо щось не було задано
        }

        private void AddWorker_Click(object sender, EventArgs e) // щоб додати робітника у магазин
        {
            if (tbWorkerSalary.Text != String.Empty &&
                tbWorkerDayOfBirth.Text != String.Empty &&
                tbWorkerINN.Text != String.Empty &&
                tbWorkerLastName.Text != String.Empty &&
                tbWorkerName.Text != String.Empty &&
                cbWorkerEducation.SelectedIndex >= 0 &&
                cbWorkerPosition.SelectedIndex >= 0 &&
                lbCarShopsNames.SelectedIndex >= 0) //Перевірка чи вибрані усі параметри
            {
                string dayOfBirth = tbWorkerDayOfBirth.Text, inn, lastName = tbWorkerLastName.Text;
                string name = tbWorkerName.Text, education, position;
                uint salary;
                try
                { // перевірка введених данних
                    if (uint.Parse(tbWorkerSalary.Text) >= 8000 && uint.Parse(tbWorkerSalary.Text) <= 60000)
                        salary = uint.Parse(tbWorkerSalary.Text);
                    else
                    {
                        MessageBox.Show("Зарплата робітника має будти від 8 000 до 60 000",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Середній дохід магазину за місяць має бути додатнім числом",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                } // вивід сповіщення якщо введені дані некоректні
                try
                { // перевірка чи ІПН має 10 цифр
                    long temp = uint.Parse(tbWorkerINN.Text);
                    long forINN = temp;
                    int i = 0;
                    while (temp > 0)
                    {
                        i++;
                        temp /= 10;
                    }
                    if (i == 10)
                        inn = forINN.ToString();
                    else
                    {
                        MessageBox.Show("Індивідуальний податковий номер має складатись з 10 цифр",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Індивідуальний податковий номер має складатись з 10 цифр",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    return;
                } // вивід сповіщення якщо введені дані некоректні
                switch (cbWorkerEducation.Text)
                { // читання параметра робітника з комбо боксу
                    case "Немає":
                        education = "Немає";
                        break;
                    case "Технічна":
                        education = "Технічна";
                        break;
                    case "Гуманітарна":
                        education = "Гуманітарна";
                        break;
                    case "Фінансова":
                        education = "Фінансова";
                        break;
                    case "Правова":
                        education = "Правова";
                        break;                   
                    default:
                        MessageBox.Show("Не була обрана освіта робітника",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                }
                switch (cbWorkerPosition.Text)
                { // читання параметра робітника з комбо боксу
                    case "Директор":
                        position = "Директор";
                        break;
                    case "HR":
                        position = "HR";
                        break;
                    case "Старший продавець":
                        position = "Старший продавець";
                        break;
                    case "Продавець":
                        position = "Продавець";
                        break;
                    case "Охоронець":
                        position = "Охоронець";
                        break;                 
                    default:
                        MessageBox.Show("Не була обрана посада робітника",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                }
                foreach (var worker in carShops[lbCarShopsNames.SelectedIndex].workers)
                { 
                    if (inn == worker.Key)
                    { // перевірка на унікальність ІПН
                        MessageBox.Show("Однаковий індивідуальний податковий номер",
                                            "Помилка введення даних",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        return;
                    }     
                }
                workers.Add(inn, new Worker(name, lastName, education, dayOfBirth, position, salary, inn));
                carShops[lbCarShopsNames.SelectedIndex].AddWorker(workers[inn]);  // додавання робітника до магазину        
            }
            else
                MessageBox.Show("Не були задані усі поля та/або не вибран магазин",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // вивід сповіщення якщо щось не було задано
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
                    case "Каса магазину":
                        try
                        {
                            carShops[lbCarShopsNames.SelectedIndex].MoneyCount = uint.Parse(tbInput.Text);
                        }// спроба читання параметра з текстбокса
                        catch (Exception)
                        {
                            MessageBox.Show("Каса магазину має бути додатнім числом",
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

        public class Car
        {
            private string brand = string.Empty, name = string.Empty, controlType = string.Empty, fuelType = string.Empty; // марка, назва, тип керування, тип палива
            private double engineVolume = 0, fuelConsumption = 0; // об'єм двигуна, споживання у літрах
            private uint priceForClient = 0, priceForShop = 0; // ціна машини для клієнта та для магазина

            public Car(string name, string brand, uint priceForClient, uint priceForShop)// конструктор для створення машини
            {
                this.Name = name;
                this.Brand = brand;
                this.PriceForClient = priceForClient;
                this.PriceForShop = priceForShop;
            }

            public double EngineVolume
            {
                get => this.engineVolume;
                set => this.engineVolume = value;
            } // геттери та сеттери
            public double FuelConsumption
            {
                get => this.fuelConsumption;
                set => this.fuelConsumption = value;
            }
            public uint PriceForClient
            {
                get => this.priceForClient;
                set => this.priceForClient = value;
            }
            public uint PriceForShop
            {
                get => this.priceForShop;
                set => this.priceForShop = value;
            }
            public string Brand
            {
                get => this.brand;
                set => this.brand = value;
            }
            public string Name
            {
                get => this.name;
                set => this.name = value;
            }
            public string ControlType
            {
                get => this.controlType;
                set => this.controlType = value;
            }
            public string FuelType
            {
                get => this.fuelType;
                set => this.fuelType = value;
            }

            public override string ToString()
            {
                return $"Назва: {Name}," +
                    $"Бренд: {Brand}," +
                    $"Ціна для клієнтів: {PriceForClient}," +
                    $"Ціна для магазину: {PriceForShop}";
            }
            
            public bool IsEqual(Car otherCar)
            {
                if (this.Name == otherCar.Name && this.Brand == otherCar.Brand)
                    return true;
                else
                    return false;
            }
        }
        public class Worker
        {
            private string firstName, lastName, education; // ім'я, прізвище, освіта
            private string dateOfBirth, position, individualTaxpayerNumber; // дата народження, посада, індивідуальний податковий номер
            private uint salary; // заробітня плата

            public Worker(string name, string lastName, string education, string dateOfBirth, string position, uint salary, string individualTaxpayerNumber)
            {
                this.FirstName = name;
                this.LastName = lastName;
                this.Education = education;
                this.Position = position;
                this.Salary = salary;
                this.IndividualTaxpayerNumber = individualTaxpayerNumber;
                this.DateOfBirth = dateOfBirth;
            }  // конструктор для створення робітника

            public string FirstName { get; set; } // геттери та сеттери
            public string LastName { get; set; }
            public string Education { get; set; }
            public string DateOfBirth { get; set; }
            public string IndividualTaxpayerNumber { get; set; }
            public string Position { get; set; }
            public uint Salary { get; set; }

            public override string ToString()
            {
                return $"Ім'я: {FirstName}," +
                    $"Прізвище: {LastName}," +
                    $"Освіта: {Education}," +
                    $"Посада: {Position}," +
                    $"Зарплата: {Salary}," +
                    $"ІПН: {IndividualTaxpayerNumber}," +
                    $"Дата народження: {DateOfBirth}";
            }
        }
        public class CarShop : IComparable<CarShop> // клас автомагазинів
        {
            public List<Car> cars = new List<Car>();
            public Dictionary<string, Worker> workers = new Dictionary<string, Worker>();
            private uint carCount = 0, employeeCount = 0, productCount = 0; // кільіксть машин, співробітників та найменувань товарів
            private uint averageIncome = 0, totalSalary = 0, totalProductCosts = 0; // дохід магазину на рік та загальна зп спіробітників і витрати на купівлю товарів
            private uint moneyCount;
            private string name, adress; // ім'я та адреса магазину
            public uint[] monthIncome = new uint[12]; // помісячний дохід місяця
            public uint[] monthSalary = new uint[12]; // помісячна зп співробітників
            public uint[] monthProductCosts = new uint[12]; // помісячні витрати на купівлю товарів

            public CarShop(string name) => this.Name = name; // конструктор для створення магазину

            public uint СarCount { get => (uint)cars.Count; }// геттери та сеттери
            public uint EmployeeCount { get => (uint)workers.Count; }
            public uint ProductCount { get; set; }
            public uint TotalProductCosts { get; set; }
            public uint AverageIncome { get; set; }
            public uint TotalSalary { get; set; }
            public uint MoneyCount { get; set; }
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
                return $"Ім'я: {Name},Адреса: {Adress}," +
                    $"Кількість співробітників: {EmployeeCount}," +
                    $"Середній дохід на місяць: {AverageIncome}," +
                    $"Загальна зп співробітників: {TotalSalary}," +
                    $"Загальні витрати на купівлю товарів: {TotalProductCosts}," +
                    $"Кільіксть найменувать товарів: {ProductCount}," +
                    $"Каса магазину: {MoneyCount}";
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
            public void AddWorker(Worker person)
            {
                this.workers.Add(person.IndividualTaxpayerNumber, person);
            }
            public void AddSeveralCars(string name, string brand, uint priceForClient, uint priceForShop, uint carsCount)
            {
                if ((carsCount * priceForShop) <= this.MoneyCount)
                {
                    for (int i = 0; i < carsCount; i++)
                    {
                        this.cars.Add(new Car(name, brand, priceForClient, priceForShop));
                        this.MoneyCount -= priceForShop;
                    }

                }
                else
                {
                    MessageBox.Show("У магазина недостатньо грошей для закупки партії автомобілів",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // вивід сповіщення якщо щось не було задано
                }
            }
        }
    }   
}