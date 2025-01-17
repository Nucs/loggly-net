﻿using System.Collections.Generic;
using System.Linq;
using Loggly.Config;
using NUnit.Framework;

namespace Loggly.Tests.Loggly.Config; 

public class TagConfigurationFixture : Fixture {
    /// <summary>
    /// https://www.loggly.com/docs/tags/
    /// </summary>
    [Test]
    public void Conform() {
        var tags = new List<ITag>();

        tags.Add("legalTag");
        tags.Add("_my_little.pony");
        tags.Add("-us");
        tags.Add("apache$");

        var output = tags.ToLegalStrings();

        Assert.AreEqual("legalTag", output.ElementAt(0));
        Assert.AreEqual("z_my_little.pony", output.ElementAt(1));
        Assert.AreEqual("z-us", output.ElementAt(2));
        Assert.AreEqual("apache_", output.ElementAt(3));
    }
}