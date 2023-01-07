#if !NETSTANDARD1_5
using System;

namespace Loggly {
    public class OperatingSystemVersionTag : ComplexTag {
        public override string InputValue {
            get { return Environment.OSVersion.VersionString; }
        }
    }
}
#endif