using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOONS;
using System;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void CreateJobObject()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        }


        //Tests start here
        // Test 1
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id, 1);
            Assert.AreEqual((job1.Id), (job2.Id - 1));
        }

        // Test 2
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string actualNameOutput = job3.Name;
            string expectedNameOutput = "Product tester";
            string actualEmployerOutput = job3.EmployerName.Value;
            string expectedEmployerOutput = "ACME";
            string actualLocationOutput = job3.EmployerLocation.Value;
            string expectedLocationOutput = "Desert";
            string actualPositionOutput = job3.JobType.Value;
            string expectedPositionOutput = "Quality Control";
            string actualCoreOutput = job3.JobCoreCompetency.Value;
            string expectedCoreOutput = "Persistence";
            int actualIdOutput = job3.Id;
            int expectedIdOutput = 7;

            Assert.AreEqual(expectedNameOutput, actualNameOutput);
            Assert.AreEqual(expectedEmployerOutput, actualEmployerOutput);
            Assert.AreEqual(expectedLocationOutput, actualLocationOutput);
            Assert.AreEqual(expectedPositionOutput, actualPositionOutput);
            Assert.AreEqual(expectedCoreOutput, actualCoreOutput);
            Assert.AreEqual(expectedIdOutput, actualIdOutput);
        }

        // Test 3
        [TestMethod]
        public void TestJobsForEquality()
        {
            bool actualOutput = job3.Equals(job4);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // Test 4
        [TestMethod]
        public void TestJobsToStringLineSpacing()
        {
            string expectedOutputBeginning = "\n";
            string actualOutputBeginning = job1.ToString().Substring(0, 1);
            string expectedOutputEnding = "\n";
            string actualOutputEnding = job1.ToString().Substring(job1.ToString().Length - 1, 1);

            Assert.AreEqual(expectedOutputBeginning, actualOutputBeginning);
            Assert.AreEqual(expectedOutputEnding, actualOutputEnding);
        }
        // Test 5
        [TestMethod]
        public void TestJobsToStringLabelDataOwnLine()
        {
            // part 1 & 3contains all labels and each label is on its own line
            bool expectedOutput1 = true;
            bool actualOutput1 = job3.ToString().Contains("\nID: ") && job3.ToString().Contains("\nName: ") && job3.ToString().Contains("\nEmployer: ") && job3.ToString().Contains("\nLocation: ") && job3.ToString().Contains("\nPosition Type: ") && job3.ToString().Contains("\nCore Competency: ");
            Assert.AreEqual(expectedOutput1, actualOutput1);

            // part 2 contains data in correct sequence
            bool expectedOutput2 = true;
            bool actualOutput2 = job3.ToString().IndexOf("ID: ") < job3.ToString().IndexOf(job3.Name)
                && job3.ToString().IndexOf(job3.Name) < job3.ToString().IndexOf("Employer: ")
                && job3.ToString().IndexOf("Employer: ") < job3.ToString().IndexOf(job3.EmployerName.Value)
                && job3.ToString().IndexOf(job3.EmployerName.Value) < job3.ToString().IndexOf("Location: ")
                && job3.ToString().IndexOf("Location: ") < job3.ToString().IndexOf(job3.EmployerLocation.Value)
                && job3.ToString().IndexOf(job3.EmployerLocation.Value) < job3.ToString().IndexOf("Position Type: ")
                && job3.ToString().IndexOf("Position Type: ") < job3.ToString().IndexOf(job3.JobType.Value)
                && job3.ToString().IndexOf(job3.JobType.Value) < job3.ToString().IndexOf("Core Competency: ")
                && job3.ToString().IndexOf("Core Competency: ") < job3.ToString().IndexOf(job3.JobCoreCompetency.Value);
            Assert.AreEqual(expectedOutput2, actualOutput2);
        }

        // Test 6
        [TestMethod]
        public void TestJobsToStringAlertEmpty()
        {
            Job job5 = new Job("", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            job5.ToString();
            string actualOutput = job5.EmployerName.Value;
            string expectedOutput = "Data not available";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // Test 7
        [TestMethod]
        public void TestJobsToStringOnlyIdOops()
        {

            string actualOutput = job1.ToString();
            string expectedOutput = "\nOOPS! This job does not seem to exist.\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
