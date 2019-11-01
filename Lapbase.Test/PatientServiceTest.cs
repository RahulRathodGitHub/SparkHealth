using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;

namespace Lapbase.Test
{
    [TestFixture]
    public class PatientServiceTest
    {
        private readonly LapbaseNewContext context;
        private readonly LapbaseContext lapbaseContext;
        private readonly IConfiguration config;
        private readonly DbContextOptions<LapbaseNewContext> options;
        private Patient patient;

        public PatientServiceTest()
        {
            var DbContextOptionsBuilder = new DbContextOptionsBuilder<LapbaseNewContext>();
            options = DbContextOptionsBuilder
                    .UseInMemoryDatabase(databaseName: "Test_Database")
                    .Options;
            var configurationBuilder = new ConfigurationBuilder();
            config = configurationBuilder.Build();
            context = new LapbaseNewContext(options);
            lapbaseContext = new LapbaseContext();
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
        public async Task GetPatientFood_WithNoFoodInDatabase_ReturnsEmptyList()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext,  context);

            // Act
            var result = await service.GetPatientFood();

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetPatientFood_WithFoodInDatabase_ReturnsListOfFood()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext, context);
            var food = context.Food.Add(new Food
            {
                Name = "TestFood",
                CalorieCount = 10,
                Unit = "Chunk"
            }).Entity;
            context.SaveChanges();

            // Act
            var result = await service.GetPatientFood();

            // Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Contains.Item(food));
        }

        [Test]
        public async Task GetPatientExercise_WithNoExerciseInDatabase_ReturnsEmptyList()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext, context);

            // Act
            var result = await service.GetPatientExercise();

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetPatientExercise_WithExercisesInDatabase_ReturnsListOfExercises()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext, context);
            var exercise = context.Exercise.Add(new Exercise
            {
                Name = "TestFood",
                CalorieCount = 10
            }).Entity;
            context.SaveChanges();

            // Act
            var result = await service.GetPatientExercise();

            // Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Contains.Item(exercise));
        }

        [Test]
        public async Task GetPatient_WithNonExistingPatient_ReturnsNull()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext, context);

            // Act
            var result = await service.GetPatient("NonExisting");

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetPatient_WithExistingPatient_ReturnsPatient()
        {
            // Arrange
            var service = new PatientService(config, lapbaseContext, context);

            // Act
            var result = await service.GetPatient("TestUser");

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(patient.Id));
        }
    }
}
