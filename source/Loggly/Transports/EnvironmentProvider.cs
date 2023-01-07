using System;
using System.Diagnostics;

namespace Loggly; 

class EnvironmentProvider : IEnvironmentProvider {
    private readonly int _processId;
    private readonly string _machineName;

    public EnvironmentProvider() {
        _processId = Process.GetCurrentProcess().Id;
        _machineName = Environment.MachineName;
    }

    public int ProcessId => _processId;

    public string MachineName => _machineName;
}