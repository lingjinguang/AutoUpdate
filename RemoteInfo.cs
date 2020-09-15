using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdate
{
    public class RemoteInfo
    {
        public String ApplicationStart { get; set; }
        public String ApplicationUpdateStart { get; set; }
        public String AppName { get; set; }
        public String MinVersion { get; set; }
        public String ReleaseDate { get; set; }
        public String ReleaseUrl { get; set; }
        public String ReleaseVersion { get; set; }
        public String UpdateMode { get; set; }
        public String VersionDesc { get; set; }
    }
}
