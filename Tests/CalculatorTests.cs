using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator, "Calculator is created");
            Assert.IsTrue(4 == calculator.Add(2, 2), "2 + 2 = 4");
            Assert.IsTrue(4000000000 == calculator.Add(2000000000, 2000000000), "2G + 2G = 4");
            Assert.IsTrue(0 == calculator.Add(2, -2), "2 + (-2) = 0");
            Assert.IsTrue(0 == calculator.Add(-2, 2), "-2 + 2 = 0");
            Assert.IsTrue(-4 == calculator.Add(-2, -2), "-2 + (-2) = 0");
            Assert.IsTrue(4000000000 == calculator.Add(3000000000, 1000000000), "3G + 1G = 4");
            Assert.IsTrue(4000000000 == calculator.Add(1000000000, 3000000000), "1G + 3G = 4");
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator, "Calculator is created");

            Assert.IsTrue(-3 == calculator.Subtract(2, 5), "2 - 5 = -3"); //Unimportant
            Assert.IsTrue(4 == calculator.Subtract(2, -2), "2 - (-2) = 0"); //Unimportant
            Assert.IsTrue(-4 == calculator.Subtract(-2, 2), "-2 - 2 = -4"); //Unimportant

            Assert.IsTrue(-5000000000 == calculator.Subtract(2000000000, 7000000000), "2G - 7G = -5G");
            Assert.IsTrue(2000000000 == calculator.Subtract(5000000000, 3000000000), "5G - 3G = 2G");
            Assert.IsTrue(0 == calculator.Subtract(-2, -2), "-2 - (-2) = 0");
            Assert.IsTrue(7000000000 == calculator.Subtract(1000000000, -6000000000), "1G - (-6G) = 7G");
            Assert.IsTrue(-5000000000 == calculator.Subtract(-2000000000, 3000000000), "-2G - 3G = -5G");
        }

        [TestMethod()]
        public void DivTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator, "Calculator is created");

            //Спадкування виключень не враховується, очікується виключення
            //лише зазначеного типу
            var ex = Assert.ThrowsException<DivideByZeroException>(() =>
            {
                calculator.Div(0, 0); 
            });
            //збереження виключення (ех) дозволяє перевірити його на певні параметри
            Assert.IsTrue(ex.Message.Length > 0, "Non empty message in exception");
            //Перевіряємо, що у повідомленні є назва параметру 'y'
            string paramName = "'y'"; // назва параметра, яку ми шукаємо
            Assert.IsTrue(ex.Message.Contains(paramName), $"Message should mention parameter '{paramName}'");
            //завершення без виключення - використання ефекту того, що
            //виключення у методі саме по собі провалить тест
            Assert.IsNotNull(calculator.Div(2, 0), "Виключення");
        }
    }
}

/* Курсовий проект по .NET 
 * Ідея - використання комплексу вивченого матеріалу
 * C# - WF/WPF
 * DB - ADO.NET
 * Системне, мережеве програмування, управління проєктами
 * 
 * Очікуєтся десктоп-програма (з віконним інтерфейсом),
 * яка працює з базою даних та мережею. 
 * Системне програмування - багатопоточність/багатозадачність + синхронізація.
 * 
 * Д.З. Створити репозиторій, у файлі Readme зазначити назву проєкту,
 * його короткий опис та технічне завдання (коротко, бажано по галузях - 
 * що буде по мережі, що у БД, що по системі). 
 */ 