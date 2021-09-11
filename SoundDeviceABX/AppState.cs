using System;
using System.IO;
using Newtonsoft.Json;

namespace SoundDeviceABX {
    public class AppState {
        public static AppState Instance { get; } = LoadAppState();

        private AppState() { }
        public string LastAudioFiles { get; set; }
        public int LastDevice1 { get; set; } = -1;
        public int LastDevice2 { get; set; } = -1;
        public bool LastShowResults { get; set; }
        public bool LastShuffle { get; set; } = true;
        public bool LastRewind { get; set; }
        public bool LastRandomVolume { get; set; } = true;
        public string LastMinVolume { get; set; } = "0.7";

        private static AppState LoadAppState() {
            try {
                var file = Path.Combine(Program.AppData, "appState.json");
                return JsonConvert.DeserializeObject<AppState>(File.ReadAllText(file));
            }
            catch (Exception) {
                return new AppState();
            }
        }

        public static void SaveAppState() {
            try {
                Directory.CreateDirectory(Program.AppData);
                var file = Path.Combine(Program.AppData, "appState.json");
                File.WriteAllText(file, JsonConvert.SerializeObject(Instance));
            }
            catch (Exception) {
                // ignore
            }
        }
    }
}
