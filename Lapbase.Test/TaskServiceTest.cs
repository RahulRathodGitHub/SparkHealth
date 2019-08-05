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
    public class TaskServiceTest
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
        public async System.Threading.Tasks.Task GetTaskById_WithNonExistingTask_ReturnsNull()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskService service = new TaskService(config, context);
                
                // Act
                var result = await service.GetTaskById(Guid.NewGuid());

                // Assert
                Assert.That(result, Is.Null);
            }
        }

        [Test]
        public async System.Threading.Tasks.Task GetTaskById_WithExistingTask_ReturnsTask()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskService service = new TaskService(config, context);
                Models.Task task = context.Task.Add(new Models.Task
                {
                    Id = Guid.NewGuid(),
                    StartDate = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan()),
                    Repetition = RepetitionType.Weekly,
                    RepetitionInterval = 1,
                    Type = TaskType.FoodIntakeInput,
                    PatientId = 1,
                    AdvisorId = 1
                }).Entity;
                context.SaveChanges();

                // Act
                var result = await service.GetTaskById(task.Id);

                // Assert
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(task.Id));
            }
        }

        [Test]
        public async System.Threading.Tasks.Task CreateTask_InThePast_Fails()
        {
            using (var context = new LapbaseNewContext(options))
            {
                // Arrange
                config = configurationBuilder.Build();
                TaskService service = new TaskService(config, context);

                // Act
                var result = await service.CreateTask(new Models.Task
                {
                    Id = Guid.NewGuid(),
                    StartDate = new DateTimeOffset(1993, 05, 05, 0, 0, 0, new TimeSpan()),
                    Repetition = RepetitionType.Weekly,
                    RepetitionInterval = 1,
                    Type = TaskType.FoodIntakeInput,
                    PatientId = 1,
                    AdvisorId = 1
                });

                // Assert
                Assert.That(result, Is.Null);
                Assert.That(context.Task.Count, Is.EqualTo(0));
            }
        }
    }
}