using System;
using System.Threading;
using NUnit.Framework;
using robot_name;

[TestFixture]
public class RobotNameTest
{
    private Robot robot;

    [SetUp]
    public void Setup()
    {
        robot = new Robot();
    }

    [Test]
    public void Robot_has_a_name()
    {
        StringAssert.IsMatch(@"[A-Z]{2}\d{3}", robot.Name);
    }

    [Test]
    public void Name_is_the_same_each_time()
    {
        Assert.That(robot.Name, Is.EqualTo(robot.Name));
    }

    [Test]
    public void Different_robots_have_different_names()
    {
        Thread.Sleep(5);
        var robot2 = new Robot();
        Console.WriteLine(robot2.Name);
        Console.WriteLine(robot.Name);
        
        Assert.That(robot.Name, Is.Not.EqualTo(robot2.Name));
    }

    [Test]
    public void Can_reset_the_name()
    {
        var originalName = robot.Name;
        robot.Reset();
        Assert.That(robot.Name, Is.Not.EqualTo(originalName));
    }
}