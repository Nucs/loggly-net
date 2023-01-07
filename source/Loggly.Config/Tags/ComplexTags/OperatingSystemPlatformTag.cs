#if !NETSTANDARD1_5
using System;

namespace Loggly {
    public class OperatingSystemPlatformTag : ComplexTag {
        public override string InputValue {
            get { return Environment.OSVersion.Platform.ToString(); }
        }
    }
}
#endif