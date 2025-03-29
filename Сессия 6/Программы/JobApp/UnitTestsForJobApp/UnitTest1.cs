using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JobApp;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moq;

namespace UnitTestsForJobApp
{
    [TestClass]
    public class AuthFormTests
    {
        [TestMethod]
        public void ToggleSwitchPassword_ShouldChangePasswordVisibility()
        {
            // Arrange
            var form = new AuthForm();
            form.textPassword = new Guna.UI2.WinForms.Guna2TextBox { UseSystemPasswordChar = true };
            form.toggleSwitchPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();

            // Act - включить отображение пароля
            form.toggleSwitchPassword.Checked = true;
            form.toggleSwitchPassword_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsFalse(form.textPassword.UseSystemPasswordChar,
                "Пароль должен отображаться, когда переключатель включен");

            // Act - выключить отображение пароля
            form.toggleSwitchPassword.Checked = false;
            form.toggleSwitchPassword_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.textPassword.UseSystemPasswordChar,
                "Пароль должен скрываться, когда переключатель выключен");
        }

        [TestMethod]
        public void OpenRoleSpecificForm_ShouldReturnCorrectFormTypes()
        {
            // Arrange
            var form = new AuthForm();
            Form openedForm = null;

            // Act & Assert для соискателя
            openedForm = form.TestOpenRoleSpecificForm("Соискатель");
            Assert.IsInstanceOfType(openedForm, typeof(JobSeekerForm),
                "Для роли 'Соискатель' должна открываться JobSeekerForm");

            // Act & Assert для работодателя
            openedForm = form.TestOpenRoleSpecificForm("Работодатель");
            Assert.IsInstanceOfType(openedForm, typeof(EmployerForm),
                "Для роли 'Работодатель' должна открываться EmployerForm");

            // Act & Assert для инспектора
            openedForm = form.TestOpenRoleSpecificForm("Инспектор");
            Assert.IsInstanceOfType(openedForm, typeof(InspectorForm),
                "Для роли 'Инспектор' должна открываться InspectorForm");
        }

        [TestMethod]
        public void FormatFullName_ShouldHandleDifferentNameCombinations()
        {
            // Arrange
            var form = new AccountForm();

            // Act & Assert
            string result1 = form.TestFormatFullName("Иванов", "Иван", "Иванович");
            Assert.AreEqual("Иванов Иван Иванович", result1, "Должно работать с полным ФИО");

            string result2 = form.TestFormatFullName("Петров", "Петр", null);
            Assert.AreEqual("Петров Петр", result2, "Должно работать без отчества");

            string result3 = form.TestFormatFullName(null, "Сергей", null);
            Assert.AreEqual("Сергей", result3, "Должно работать только с именем");

            string result4 = form.TestFormatFullName(null, null, null);
            Assert.AreEqual("ФИО не указано", result4, "Должно обрабатывать все null значения");
        }

        [TestMethod]
        public void SetLabelText_ShouldHandleNullValues()
        {
            // Arrange
            var form = new AccountForm();
            form.labelFIO = new Label();
            form.labelUsername = new Label();
            form.labelPassword = new Label();
            form.labelPhone = new Label();
            form.labelEmail = new Label();

            // Act
            form.TestSetLabelText(null, null, null, null, null);

            // Assert
            Assert.AreEqual("ФИО не указано", form.labelFIO.Text);
            Assert.AreEqual("Не указано", form.labelUsername.Text);
            Assert.AreEqual("Не указан", form.labelPassword.Text);
            Assert.AreEqual("Не указано", form.labelPhone.Text);
            Assert.AreEqual("Не указано", form.labelEmail.Text);
        }

        [TestMethod]
        public void ValidateRequiredFields_ShouldShowMessageWhenEmptyInAddResumeForm()
        {
            // Arrange
            var form = new AddResumeForm();
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "" };
            form.textDol = new Guna.UI2.WinForms.Guna2TextBox { Text = "" };
            bool messageShown = false;

            // Подменяем MessageBox для теста
            form.TestMessageBoxShow = (msg, caption, buttons, icon) => {
                messageShown = true;
                Assert.AreEqual("Пожалуйста, заполните обязательные поля (Название и Желаемая должность)", msg);
                return DialogResult.OK;
            };

            // Act
            form.TestSaveButtonClick();

            // Assert
            Assert.IsTrue(messageShown, "Должно появиться сообщение о необходимости заполнить обязательные поля");
        }

        [TestMethod]
        public void CreateResumeModel_ShouldCorrectlyInitializeProperties()
        {
            // Arrange
            var form = new AddResumeForm();
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "Резюме разработчика" };
            form.textDol = new Guna.UI2.WinForms.Guna2TextBox { Text = "Разработчик C#" };
            form.textSal = new Guna.UI2.WinForms.Guna2TextBox { Text = "100000" };
            form.textEdu = new Guna.UI2.WinForms.Guna2TextBox { Text = "Высшее" };
            form.textSkills = new Guna.UI2.WinForms.Guna2TextBox { Text = "C#, SQL, ASP.NET" };
            form.textGraph = new Guna.UI2.WinForms.Guna2TextBox { Text = "Полный день" };

            // Устанавливаем тестовый CurrentUserId
            AuthForm.CurrentUserId = 123;

            // Act
            var resume = form.TestCreateResumeModel();

            // Assert
            Assert.AreEqual(123, resume.UserId);
            Assert.AreEqual("Резюме разработчика", resume.Title);
            Assert.AreEqual("Разработчик C#", resume.DesiredPosition);
            Assert.AreEqual("100000", resume.DesiredSalary);
            Assert.AreEqual("Высшее", resume.Education);
            Assert.AreEqual("C#, SQL, ASP.NET", resume.ProfessionalSkills);
            Assert.AreEqual("Полный день", resume.WorkSchedule);
            Assert.AreEqual("Рассматривается", resume.Status);
        }

        [TestMethod]
        public void ValidateRequiredFields_ShouldShowMessageWhenEmptyInAddVacancyForm()
        {
            // Arrange
            var form = new AddVacancyForm();
            form.textComName = new Guna.UI2.WinForms.Guna2TextBox { Text = "" };
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "" };
            form.textSpec = new Guna.UI2.WinForms.Guna2TextBox { Text = "" };
            bool messageShown = false;

            // Подменяем MessageBox для теста
            form.TestMessageBoxShow = (msg, caption, buttons, icon) => {
                messageShown = true;
                Assert.AreEqual("Пожалуйста, заполните обязательные поля", msg);
                return DialogResult.OK;
            };

            // Act
            form.TestValidateRequiredFields();

            // Assert
            Assert.IsTrue(messageShown, "Должно появиться сообщение о необходимости заполнить обязательные поля");
        }

        [TestMethod]
        public void CreateModels_ShouldCorrectlyInitializeProperties()
        {
            // Arrange
            var form = new AddVacancyForm();
            // Заполняем тестовые данные
            form.textComName = new Guna.UI2.WinForms.Guna2TextBox { Text = "Тестовая компания" };
            form.textComAddress = new Guna.UI2.WinForms.Guna2TextBox { Text = "ул. Тестовая, 1" };
            form.textComMail = new Guna.UI2.WinForms.Guna2TextBox { Text = "test@test.com" };
            form.textComPhone = new Guna.UI2.WinForms.Guna2TextBox { Text = "+79991112233" };
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "Разработчик C#" };
            form.textSpec = new Guna.UI2.WinForms.Guna2TextBox { Text = "Программирование" };
            form.textOpyt = new Guna.UI2.WinForms.Guna2TextBox { Text = "3 года" };
            form.textGraph = new Guna.UI2.WinForms.Guna2TextBox { Text = "Полный день" };
            form.textSal = new Guna.UI2.WinForms.Guna2TextBox { Text = "100000" };
            form.textObr = new Guna.UI2.WinForms.Guna2TextBox { Text = "Высшее" };

            // Устанавливаем тестовый CurrentUserId
            AuthForm.CurrentUserId = 123;

            // Act
            var company = form.TestCreateCompanyModel();
            var vacancy = form.TestCreateVacancyModel(1); // Передаем тестовый companyId

            // Assert для компании
            Assert.AreEqual("Тестовая компания", company.CompanyName);
            Assert.AreEqual("ул. Тестовая, 1", company.CompanyAddress);
            Assert.AreEqual("test@test.com", company.CompanyEmail);
            Assert.AreEqual("+79991112233", company.CompanyPhone);

            // Assert для вакансии
            Assert.AreEqual(123, vacancy.UserId);
            Assert.AreEqual(1, vacancy.CompanyId);
            Assert.AreEqual("Разработчик C#", vacancy.VacancyTitle);
            Assert.AreEqual("Программирование", vacancy.Specialization);
            Assert.AreEqual("3 года", vacancy.WorkExperience);
            Assert.AreEqual("Полный день", vacancy.WorkSchedule);
            Assert.AreEqual("100000", vacancy.Salary);
            Assert.AreEqual("Высшее", vacancy.Education);
            Assert.AreEqual("Закрыта", vacancy.Status);
        }







        [TestMethod]
        public void AddResumeForm_ShouldFail_WhenMissingRequiredFields() // Этот тест намеренно провалится
        {
            // Arrange
            var form = new AddResumeForm();
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "" }; // Намеренно оставляем обязательное поле пустым
            form.textDol = new Guna.UI2.WinForms.Guna2TextBox { Text = "" }; // Намеренно оставляем обязательное поле пустым
            bool validationPassed = true; // Ожидаем, что валидация НЕ пройдет

            // Act
            try
            {
                form.TestValidateRequiredFields();
                // Если дошли сюда - валидация прошла (чего мы НЕ ожидаем)
            }
            catch
            {
                validationPassed = false; // Валидация не прошла (ожидаемое поведение)
            }

            // Assert - намеренно инвертированная проверка
            Assert.IsTrue(validationPassed, "ТЕСТ ДОЛЖЕН ПРОВАЛИТЬСЯ: Валидация должна была не пройти, но прошла");
        }

        [TestMethod]
        public void AddVacancyForm_ShouldFail_WhenCompanyInsertFails() // Этот тест намеренно провалится
        {
            // Arrange
            var form = new AddVacancyForm();
            form.textComName = new Guna.UI2.WinForms.Guna2TextBox { Text = "Тестовая компания" };
            form.textName = new Guna.UI2.WinForms.Guna2TextBox { Text = "Тестовая вакансия" };
            form.textSpec = new Guna.UI2.WinForms.Guna2TextBox { Text = "Тестовая специализация" };
            bool errorWasHandled = false;

            // Подменяем MessageBox
            form.TestMessageBoxShow = (msg, caption, buttons, icon) => {
                if (msg.Contains("Ошибка")) errorWasHandled = true;
                return DialogResult.OK;
            };

            // Настраиваем провал вставки компании
            form.TestInsertCompany = (company) => throw new Exception("Simulated DB failure");

            // Act
            try
            {
                form.TestSaveCompanyAndVacancy();
                // Если дошли сюда - ошибка не произошла (чего мы НЕ ожидаем)
            }
            catch
            {
                errorWasHandled = true; // Ошибка произошла (ожидаемое поведение)
            }

            // Assert - намеренно инвертированная проверка
            Assert.IsFalse(errorWasHandled, "ТЕСТ ДОЛЖЕН ПРОВАЛИТЬСЯ: Ошибка должна была быть обработана, но не была");
        }
    }

}
