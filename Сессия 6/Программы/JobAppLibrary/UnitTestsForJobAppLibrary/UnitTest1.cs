using JobAppLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace UnitTestsForJobAppLibrary
{
    [TestClass]
    public class SupabaseStatisticsServiceTests
    {
        private SupabaseStatisticsService _service;

        [TestInitialize]
        public async Task Initialize()
        {
            _service = new SupabaseStatisticsService();
            await _service.Initialize();
        }

        [TestMethod]
        public async Task Test1_Initialize_ShouldConnectToSupabase()
        {
            // Act
            await _service.Initialize();

            // Assert
            Assert.IsNotNull(_service, "Service should be initialized");
        }

        [TestMethod]
        public async Task Test2_GetStatistics_ShouldReturnValidStatisticsObject()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsNotNull(stats, "Statistics object should not be null");
            Assert.IsInstanceOfType(stats, typeof(Statistics), "Should return Statistics type");
        }

        [TestMethod]
        public async Task Test3_VacanciesCount_ShouldBeNonNegative()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsTrue(stats.VacanciesCount >= 0, "Vacancies count should not be negative");
        }

        [TestMethod]
        public async Task Test4_ResumesCount_ShouldBeNonNegative()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsTrue(stats.ResumesCount >= 0, "Resumes count should not be negative");
        }

        [TestMethod]
        public async Task Test5_UsersCount_ShouldBeNonNegative()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsTrue(stats.UsersCount >= 0, "Users count should not be negative");
        }

        [TestMethod]
        public async Task Test6_InvitationsCount_ShouldBeNonNegative()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsTrue(stats.InvitationsCount >= 0, "Invitations count should not be negative");
        }

        [TestMethod]
        public async Task Test7_ResponsesCount_ShouldBeNonNegative()
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert
            Assert.IsTrue(stats.ResponsesCount >= 0, "Responses count should not be negative");
        }

        [TestMethod]
        public async Task Test8_DisplayStatistics_ShouldNotThrowExceptions()
        {
            // Act & Assert
            try
            {
                await _service.DisplayStatistics();
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception, but got: {ex.Message}");
            }
        }

        [TestMethod]
        public async Task Test9_FailingTest_StatisticsShouldBeNull() // This test will fail
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert - this is intentionally wrong
            Assert.IsNull(stats, "This test should fail as stats should not be null");
        }

        [TestMethod]
        public async Task Test10_FailingTest_VacanciesCountShouldBeNegative() // This test will fail
        {
            // Act
            var stats = await _service.GetStatistics();

            // Assert - this is intentionally wrong
            Assert.IsTrue(stats.VacanciesCount < 0, "This test should fail as count should not be negative");
        }
    }
}
