using System;
using NUnit.Framework;

namespace Loggly.Tests.Config.ComplexTags; 

public class HostnameTagFixture : Fixture {
    [Test]
    public void FormattedValue() {
        var tag = new HostnameTag();
        tag.Formatter = "machine={0}";
        Assert.That(tag.Value.StartsWith("machine"));
        Assert.That(tag.Value.EndsWith(Environment.MachineName));
    }
}