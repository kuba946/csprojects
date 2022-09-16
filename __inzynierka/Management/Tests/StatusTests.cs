using Management.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class StatusTests
    {
        [Fact]
        public void StatusObject()
        {
            Issue project = new Issue("projekt", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), null, new ApplicationUser());
            Issue issue = new Issue("zadanie", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), project, new ApplicationUser());
            IEnumerable<Issue>? Issues = new List<Issue>() { project, issue };
            string name = "Nazwa statusu";

            Status status = new Status(name);
            status.Issues = Issues;

            Assert.Equal(name, status.Name);
            Assert.Equal(Issues, status.Issues);
        }
    }
}