using NUnit.Framework;
using CoreTestingTechniques.Services;
[TestFixture] public class StringTests{[Test] public void Greeting(){Assert.That(new StudentService().GetGreeting("John"),Is.EqualTo("Hello John"));}}