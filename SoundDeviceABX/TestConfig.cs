using System.Collections.Generic;

namespace SoundDeviceABX {
    public class TestConfig {
        public List<string> AudioFiles { get; set; }
        public int Device1 { get; set; }
        public int Device2 { get; set; }
        public bool ShowResults { get; set; }
        public bool RandomVolume { get; set; }
        public float MinVolume { get; set; }
        public bool RandomAB { get; set; }
    }
}
