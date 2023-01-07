﻿using Loggly.Config;
using Loggly.Transports.Syslog;
using NUnit.Framework;

namespace Loggly.Tests.Loggly.Transports.SyslogTransports; 

public class SyslogTransportBaseFixture : Fixture {
    [SetUp]
    public void Setup() {
        LogglyConfig.Instance.TagConfig.Tags.Add(new SimpleTag { Value = "myTag" });
        LogglyConfig.Instance.CustomerToken = "MyLogglyToken";
    }

    [Test]
    public void SyslogContentWhenNoTags() {
        LogglyConfig.Instance.TagConfig.Tags.Clear();

        var transport = new SyslogTcpTransport();
        var logglyMessage = new LogglyMessage();

        logglyMessage.Content = "myContent";

        var syslog = transport.ConstructSyslog(logglyMessage);

        Assert.AreEqual("[MyLogglyToken@41058] myContent", syslog.Text);
    }

    [Test]
    public void SyslogContentWithTags() {
        LogglyConfig.Instance.CustomerToken = "MyLogglyToken";

        var transport = new SyslogTcpTransport();
        var logglyMessage = new LogglyMessage();

        logglyMessage.Content = "myContent";

        var syslog = transport.ConstructSyslog(logglyMessage);

        Assert.AreEqual("[MyLogglyToken@41058 tag=\"myTag\"] myContent", syslog.Text);
    }
}