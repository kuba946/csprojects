using Management.Models;
using System;
using Xunit;

namespace Tests
{
    public class IssueTests
    {
        [Fact]
        public void IssueDeclaration()
        {
            string name1 = "Zadanie 1";
            DateTime start1 = new DateTime(2022, 5, 23);
            DateTime end1 = new DateTime(2022, 6, 15);
            TimeSpan interval1 = end1 - start1;
            int duration1 = interval1.Days;
            string description1 = "Opis Zadania 1";
            Status status1 = new Status();
            Issue parent1 = null;
            ApplicationUser assignee1 = new ApplicationUser();
            var i1 = new Issue(name1, start1, end1, duration1, description1, status1, parent1, assignee1);
            i1.StatusId = status1.Id;

            string name2 = "Zadanie 2";
            DateTime start2 = new DateTime(2022, 5, 23);
            DateTime end2 = new DateTime(2022, 5, 24);
            TimeSpan interval2 = end2 - start2;
            int duration2 = interval2.Days;
            string description2 = "Opis Zadania 2";
            Status status2 = null;
            Issue parent2 = i1;
            ApplicationUser assignee2 = new ApplicationUser();
            var i2 = new Issue(name2, start2, end2, duration2, description2, status2, parent2, assignee2);
            i2.ParentId = i2.Parent.Id;
            i2.AssigneeId = assignee2.Id;

            string name3 = "Zadanie 3";
            var i3 = new Issue(name3);

            var i4 = new Issue();
            var i5 = i4;

            Assert.Equal(name1, i1.Name);
            Assert.Equal(start1, i1.Start);
            Assert.Equal(end1, i1.End);
            Assert.Equal(duration1, i1.Duration);
            Assert.Equal(description1, i1.Description);
            Assert.Equal(status1, i1.Status);
            Assert.Equal(parent1, i1.Parent);
            Assert.Equal(assignee1, i1.Assignee);
            Assert.Equal(false, i1.isProject);
            Assert.Equal(status1.Id, i1.Status.Id);

            Assert.Equal(name2, i2.Name);
            Assert.Equal(start2, i2.Start);
            Assert.Equal(end2, i2.End);
            Assert.Equal(duration2, i2.Duration);
            Assert.Equal(1, i2.Duration);
            Assert.Equal(description2, i2.Description);
            Assert.Equal(status2, i2.Status);
            Assert.Equal(parent2, i2.Parent);
            Assert.Equal(i1, i2.Parent);
            Assert.Equal(assignee2, i2.Assignee);
            Assert.Equal(true, i2.isProject);
            Assert.Equal(i1.Id, i2.ParentId);
            Assert.Equal(i2.AssigneeId, assignee2.Id);

            Assert.NotSame(i1.Id, i2.Id);

            Assert.Equal(name3, i3.Name);

            Assert.Equal(i4, i5);
        }
    }
}