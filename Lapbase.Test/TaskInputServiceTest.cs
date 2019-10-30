using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Lapbase.Models;
using System.Linq;
using Lapbase.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Lapbase.Tests
{
    [TestFixture]
    public class TaskInputServiceTest
    {
        DbContextOptionsBuilder<LapbaseNewContext> DbContextOptionsBuilder = new DbContextOptionsBuilder<LapbaseNewContext>();
        DbContextOptions<LapbaseNewContext> options;
        IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfiguration config;

        [SetUp]
        public void Setup()
        {
            options = DbContextOptionsBuilder
                .UseInMemoryDatabase(databaseName: "Test_Database")
                .Options;
        }

        [Test]
        public async Task GetTaskInputByDate_WithNonUsedDate_ReturnsNewTaskInputDto()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskInputService service = new TaskInputService(config, context);

                // Act
                var result = await service.GetTaskInputByDate(new DateTimeOffset(), 2756, 1);

                // Assert
                Assert.That(result.Id, Is.EqualTo(Guid.Empty));
            }
        }

        [Test]
        public async Task GetTaskInputByDate_WithUsedDate_ReturnsExistingTaskInputDto()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskInputService service = new TaskInputService(config, context);
                TaskInput taskInput = context.TaskInput.Add(new TaskInput
                {
                    Id = Guid.NewGuid(),
                    PatientId = 2756,
                    OrganizationCode = 1,
                    DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
                }).Entity;
                context.SaveChanges();

                // Act
                var result = await service.GetTaskInputByDate(new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan()), 2756, 1);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(taskInput.Id));
            }
        }

        [Test]
        public async Task UpdateTaskInput_WithNewTaskInput_ReturnsNewTaskInput()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskInputService service = new TaskInputService(config, context);

                // Act
                var result = await service.UpdateTaskInput(new TaskInputDto
                {
                    Id = Guid.NewGuid(),
                    Weight = 75,
                    DateAssigned = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan())
                }, 1, 1);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.Not.EqualTo(Guid.Empty));
                Assert.That(result.Weight, Is.EqualTo(75));
            }
        }

        [Test]
        public async Task UpdateTaskInput_WithExitingTaskInput_ReturnsUpdatedTaskInput()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskInputService service = new TaskInputService(config, context);
                TaskInput taskInput = context.TaskInput.Add(new TaskInput
                {
                    Id = Guid.NewGuid(),
                    PatientId = 2756,
                    OrganizationCode = 1,
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
                }, 1, 1);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(taskInput.Id));
                Assert.That(result.Weight, Is.EqualTo(75));
            }
        }

        [Test]
        public void GetFoodOfTheMonth_WithNoTaskInputs_ReturnsEmptyGuid()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskInputService service = new TaskInputService(config, context);

                // Act
                var result = service.GetFoodOfTheMonth(2756, 1);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.EqualTo(Guid.Empty));
            }
        }

        [Test]
        public void GetFoodOfTheMonth_WithExistingTaskInputs_ReturnsFoodGuid()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
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
                    PatientId = 2756,
                    OrganizationCode = 1,
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
                var result = service.GetFoodOfTheMonth(2756, 1);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.EqualTo(food.Id));
            }
        }
    }
}