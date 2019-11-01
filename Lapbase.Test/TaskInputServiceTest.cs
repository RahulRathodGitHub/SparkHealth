using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Lapbase.Test
{
    [TestFixture]
    public class TaskInputServiceTest
    {
        private readonly LapbaseNewContext context;
        private readonly IConfiguration config;
        private readonly DbContextOptions<LapbaseNewContext> options;
        private Patient patient;

        public TaskInputServiceTest()
        {
            var DbContextOptionsBuilder = new DbContextOptionsBuilder<LapbaseNewContext>();
            options = DbContextOptionsBuilder
                    .UseInMemoryDatabase(databaseName: "Test_Database")
                    .Options;
            var configurationBuilder = new ConfigurationBuilder();
            config = configurationBuilder.Build();
            context = new LapbaseNewContext(options);

        }

        [SetUp]
        public void SetupPatient()
        {
            patient = context.Patient.Add(new Patient
            {
                PatientCode = int.MaxValue,
                OrganisationCode = int.MaxValue,
                Username = "TestUser",
                WhenCreated = DateTimeOffset.UtcNow,
                ValidFrom = DateTimeOffset.UtcNow,
                ValidTo = DateTimeOffset.UtcNow.AddDays(15),
                Deleted = false
            }).Entity;
            context.SaveChanges();
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetTaskInputByDate_WithNonUsedDate_ReturnsNewTaskInputDto()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);

            // Act
            var result = await service.GetTaskInputByDate(new DateTimeOffset(), patient.Username);

            // Assert
            Assert.That(result.Id, Is.EqualTo(Guid.Empty));
        }

        [Test]
        public async Task GetTaskInputByDate_WithUsedDate_ReturnsExistingTaskInputDto()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);
            TaskInput taskInput = context.TaskInput.Add(new TaskInput
            {
                Id = Guid.NewGuid(),
                PatientId = patient.PatientCode,
                OrganizationCode = patient.OrganisationCode,
                DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
            }).Entity;
            context.SaveChanges();

            // Act
            var result = await service.GetTaskInputByDate(new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan()), patient.Username);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(taskInput.Id));
        }

        [Test]
        public async Task UpdateTaskInput_WithNewTaskInput_ReturnsNewTaskInput()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);

            // Act
            var result = await service.UpdateTaskInput(new TaskInputDto
            {
                Id = Guid.NewGuid(),
                Weight = 75,
                DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
            }, patient.Username);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty));
            Assert.That(result.Weight, Is.EqualTo(75));
        }

        [Test]
        public async Task UpdateTaskInput_WithExitingTaskInput_ReturnsUpdatedTaskInput()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);
            TaskInput taskInput = context.TaskInput.Add(new TaskInput
            {
                Id = Guid.NewGuid(),
                PatientId = patient.PatientCode,
                OrganizationCode = patient.OrganisationCode,
                Weight = 60,
                DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
            }).Entity;
            context.SaveChanges();

            // Act
            var result = await service.UpdateTaskInput(new TaskInputDto
            {
                Id = taskInput.Id,
                Weight = 75,
                DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
            }, patient.Username);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(taskInput.Id));
            Assert.That(result.Weight, Is.EqualTo(75));
        }

        [Test]
        public void GetFoodOfTheMonth_WithNoTaskInputs_ReturnsEmptyGuid()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);

            // Act
            var result = service.GetFoodOfTheMonth(patient.Username);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(Guid.Empty));
        }

        [Test]
        public void GetFoodOfTheMonth_WithExistingTaskInputs_ReturnsFoodGuid()
        {
            // Arrange
            TaskInputService service = new TaskInputService(config, context);
            var food = context.Food.Add(new Food
            {
                Id = Guid.NewGuid(),
                CalorieCount = 70,
                Name = "TestFood",
                Unit = "Piece"
            }).Entity;
            context.SaveChanges();
            context.TaskInput.Add(new TaskInput
            {
                Id = Guid.NewGuid(),
                PatientId = patient.PatientCode,
                OrganizationCode = patient.OrganisationCode,
                Weight = 60,
                Foods = food.Id.ToString(),
                FoodQuantities = "3",
                MealTimes = "1",
                Exercises = "",
                ExerciseReps = "",
                DateAssigned = DateTimeOffset.UtcNow.AddDays(-10)
            });
            context.SaveChanges();

            // Act
            var result = service.GetFoodOfTheMonth(patient.Username);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(food.Id));
        }
    }
}