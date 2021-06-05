using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiProtect_ClipSaver
{
    public class WiredConnectionState
    {
        public int? phyRate { get; set; }
    }

    public class Channel
    {
        public int id { get; set; }
        public string videoId { get; set; }
        public string name { get; set; }
        public bool enabled { get; set; }
        public bool isRtspEnabled { get; set; }
        public object rtspAlias { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int fps { get; set; }
        public int bitrate { get; set; }
        public int minBitrate { get; set; }
        public int maxBitrate { get; set; }
        public int minClientAdaptiveBitRate { get; set; }
        public int minMotionAdaptiveBitRate { get; set; }
        public List<int> fpsValues { get; set; }
        public int idrInterval { get; set; }
    }

    public class IspSettings
    {
        public string aeMode { get; set; }
        public string irLedMode { get; set; }
        public int irLedLevel { get; set; }
        public int wdr { get; set; }
        public int icrSensitivity { get; set; }
        public int brightness { get; set; }
        public int contrast { get; set; }
        public int hue { get; set; }
        public int saturation { get; set; }
        public int sharpness { get; set; }
        public int denoise { get; set; }
        public bool isFlippedVertical { get; set; }
        public bool isFlippedHorizontal { get; set; }
        public bool isAutoRotateEnabled { get; set; }
        public bool isLdcEnabled { get; set; }
        public bool is3dnrEnabled { get; set; }
        public bool isExternalIrEnabled { get; set; }
        public bool isAggressiveAntiFlickerEnabled { get; set; }
        public bool isPauseMotionEnabled { get; set; }
        public int dZoomCenterX { get; set; }
        public int dZoomCenterY { get; set; }
        public int dZoomScale { get; set; }
        public int dZoomStreamId { get; set; }
        public int focusPosition { get; set; }
        public int? touchFocusX { get; set; }
        public int? touchFocusY { get; set; }
        public int zoomPosition { get; set; }
        public string focusMode { get; set; }
    }

    public class TalkbackSettings
    {
        public string typeFmt { get; set; }
        public string typeIn { get; set; }
        public string bindAddr { get; set; }
        public int bindPort { get; set; }
        public string filterAddr { get; set; }
        public int? filterPort { get; set; }
        public int channels { get; set; }
        public int samplingRate { get; set; }
        public int bitsPerSample { get; set; }
        public int quality { get; set; }
    }

    public class OsdSettings
    {
        public bool isNameEnabled { get; set; }
        public bool isDateEnabled { get; set; }
        public bool isLogoEnabled { get; set; }
        public bool isDebugEnabled { get; set; }
    }

    public class LedSettings
    {
        public bool isEnabled { get; set; }
        public int blinkRate { get; set; }
    }

    public class SpeakerSettings
    {
        public bool isEnabled { get; set; }
        public bool areSystemSoundsEnabled { get; set; }
        public int volume { get; set; }
    }

    public class RecordingSettings
    {
        public int prePaddingSecs { get; set; }
        public int postPaddingSecs { get; set; }
        public int minMotionEventTrigger { get; set; }
        public int endMotionEventDelay { get; set; }
        public bool suppressIlluminationSurge { get; set; }
        public string mode { get; set; }
        public string geofencing { get; set; }
        public string motionAlgorithm { get; set; }
        public bool enablePirTimelapse { get; set; }
        public bool useNewMotionAlgorithm { get; set; }
    }

    public class SmartDetectSettings
    {
        public List<object> objectTypes { get; set; }
    }

    public class MotionZone
    {
        public string name { get; set; }
        public string color { get; set; }
        public List<List<double>> points { get; set; }
        public int sensitivity { get; set; }
    }

    public class SmartDetectZone
    {
        public string name { get; set; }
        public string color { get; set; }
        public List<List<int>> points { get; set; }
        public int sensitivity { get; set; }
        public List<object> objectTypes { get; set; }
    }

    public class Wifi
    {
        public int? channel { get; set; }
        public int? frequency { get; set; }
        public object linkSpeedMbps { get; set; }
        public int signalQuality { get; set; }
        public int signalStrength { get; set; }
    }

    public class Battery
    {
        public object percentage { get; set; }
        public bool isCharging { get; set; }
        public string sleepState { get; set; }
    }

    public class Video
    {
        public long recordingStart { get; set; }
        public long recordingEnd { get; set; }
        public long recordingStartLQ { get; set; }
        public long recordingEndLQ { get; set; }
        public long timelapseStart { get; set; }
        public long timelapseEnd { get; set; }
        public long timelapseStartLQ { get; set; }
        public long timelapseEndLQ { get; set; }
    }

    public class Storage
    {
        public object used { get; set; }
        public double rate { get; set; }
        public long available { get; set; }
        public bool isRecycling { get; set; }
        public long size { get; set; }
        public string type { get; set; }
        public List<Device> devices { get; set; }
    }

    public class Stats
    {
        public object rxBytes { get; set; }
        public object txBytes { get; set; }
        public Wifi wifi { get; set; }
        public Battery battery { get; set; }
        public Video video { get; set; }
        public Storage storage { get; set; }
        public int wifiQuality { get; set; }
        public int wifiStrength { get; set; }
    }

    public class PrivacyMaskCapability
    {
        public int? maxMasks { get; set; }
        public bool rectangleOnly { get; set; }
    }

    public class Steps
    {
        public object max { get; set; }
        public object min { get; set; }
        public object step { get; set; }
    }

    public class Degrees
    {
        public object max { get; set; }
        public object min { get; set; }
        public object step { get; set; }
    }

    public class Focus
    {
        public Steps steps { get; set; }
        public Degrees degrees { get; set; }
    }

    public class Pan
    {
        public Steps steps { get; set; }
        public Degrees degrees { get; set; }
    }

    public class Tilt
    {
        public Steps steps { get; set; }
        public Degrees degrees { get; set; }
    }

    public class Zoom
    {
        public Steps steps { get; set; }
        public Degrees degrees { get; set; }
    }

    public class Capabilities
    {
        public Focus focus { get; set; }
        public Pan pan { get; set; }
        public Tilt tilt { get; set; }
        public Zoom zoom { get; set; }
    }

    public class FeatureFlags
    {
        public bool canAdjustIrLedLevel { get; set; }
        public bool canMagicZoom { get; set; }
        public bool canOpticalZoom { get; set; }
        public bool canTouchFocus { get; set; }
        public bool hasAccelerometer { get; set; }
        public bool hasAec { get; set; }
        public bool hasBattery { get; set; }
        public bool hasBluetooth { get; set; }
        public bool hasChime { get; set; }
        public bool hasExternalIr { get; set; }
        public bool hasIcrSensitivity { get; set; }
        public bool hasLdc { get; set; }
        public bool hasLedIr { get; set; }
        public bool hasLedStatus { get; set; }
        public bool hasLineIn { get; set; }
        public bool hasMic { get; set; }
        public bool hasPrivacyMask { get; set; }
        public bool hasRtc { get; set; }
        public bool hasSdCard { get; set; }
        public bool hasSpeaker { get; set; }
        public bool hasWifi { get; set; }
        public bool hasHdr { get; set; }
        public bool hasAutoICROnly { get; set; }
        public List<string> videoModes { get; set; }
        public List<object> videoModeMaxFps { get; set; }
        public bool hasMotionZones { get; set; }
        public bool hasLcdScreen { get; set; }
        public List<object> smartDetectTypes { get; set; }
        public List<string> motionAlgorithms { get; set; }
        public PrivacyMaskCapability privacyMaskCapability { get; set; }
        public Capabilities capabilities { get; set; }
        public bool hasSmartDetect { get; set; }
        public bool beta { get; set; }
        public bool dev { get; set; }
    }

    public class PirSettings
    {
        public int pirSensitivity { get; set; }
        public int pirMotionClipLength { get; set; }
        public int timelapseFrameInterval { get; set; }
        public int timelapseTransferInterval { get; set; }
    }

    public class LcdMessage
    {
    }

    public class WifiConnectionState
    {
        public int? channel { get; set; }
        public int? frequency { get; set; }
        public int? phyRate { get; set; }
        public int? signalQuality { get; set; }
        public int? signalStrength { get; set; }
    }

    public class Camera
    {
        public bool isDeleting { get; set; }
        public string mac { get; set; }
        public string host { get; set; }
        public string connectionHost { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public object upSince { get; set; }
        public object lastSeen { get; set; }
        public object connectedSince { get; set; }
        public string state { get; set; }
        public string hardwareRevision { get; set; }
        public string firmwareVersion { get; set; }
        public string firmwareBuild { get; set; }
        public bool isUpdating { get; set; }
        public bool isAdopting { get; set; }
        public bool isAdopted { get; set; }
        public bool isAdoptedByOther { get; set; }
        public bool isProvisioned { get; set; }
        public bool isRebooting { get; set; }
        public bool isSshEnabled { get; set; }
        public bool canAdopt { get; set; }
        public bool isAttemptingToConnect { get; set; }
        public object lastMotion { get; set; }
        public int micVolume { get; set; }
        public bool isMicEnabled { get; set; }
        public bool isRecording { get; set; }
        public bool isMotionDetected { get; set; }
        public int phyRate { get; set; }
        public bool hdrMode { get; set; }
        public string videoMode { get; set; }
        public bool isProbingForWifi { get; set; }
        public object apMac { get; set; }
        public object apRssi { get; set; }
        public object elementInfo { get; set; }
        public int chimeDuration { get; set; }
        public bool isDark { get; set; }
        public object lastRing { get; set; }
        public bool isLiveHeatmapEnabled { get; set; }
        public string anonymousDeviceId { get; set; }
        public WiredConnectionState wiredConnectionState { get; set; }
        public List<Channel> channels { get; set; }
        public IspSettings ispSettings { get; set; }
        public TalkbackSettings talkbackSettings { get; set; }
        public OsdSettings osdSettings { get; set; }
        public LedSettings ledSettings { get; set; }
        public SpeakerSettings speakerSettings { get; set; }
        public RecordingSettings recordingSettings { get; set; }
        public SmartDetectSettings smartDetectSettings { get; set; }
        public object recordingSchedule { get; set; }
        public List<MotionZone> motionZones { get; set; }
        public List<object> privacyZones { get; set; }
        public List<SmartDetectZone> smartDetectZones { get; set; }
        public List<object> smartDetectLines { get; set; }
        public Stats stats { get; set; }
        public FeatureFlags featureFlags { get; set; }
        public PirSettings pirSettings { get; set; }
        public LcdMessage lcdMessage { get; set; }
        public WifiConnectionState wifiConnectionState { get; set; }
        public string id { get; set; }
        public bool isConnected { get; set; }
        public string platform { get; set; }
        public bool hasSpeaker { get; set; }
        public bool hasWifi { get; set; }
        public int audioBitrate { get; set; }
        public bool canManage { get; set; }
        public bool isManaged { get; set; }
        public string modelKey { get; set; }
    }

    public class Flags
    {
    }

    public class Web
    {
        [JsonProperty("liveview.includeGlobal")]
        public bool LiveviewIncludeGlobal { get; set; }
    }

    public class Settings
    {
        public Flags flags { get; set; }
        public Web web { get; set; }
        public List<string> cameraOrder { get; set; }
    }

    public class Location
    {
        public bool isAway { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
    }

    public class CloudAccount
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public object profileImg { get; set; }
        public string user { get; set; }
        public string id { get; set; }
        public string cloudId { get; set; }
        public string name { get; set; }
        public string modelKey { get; set; }
        public object location { get; set; }
    }

    public class User
    {
        public List<string> permissions { get; set; }
        public string lastLoginIp { get; set; }
        public object lastLoginTime { get; set; }
        public bool isOwner { get; set; }
        public bool enableNotifications { get; set; }
        public Settings settings { get; set; }
        public List<string> groups { get; set; }
        public Location location { get; set; }
        public List<object> alertRules { get; set; }
        public string id { get; set; }
        public bool hasAcceptedInvite { get; set; }
        public List<string> allPermissions { get; set; }
        public CloudAccount cloudAccount { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string localUsername { get; set; }
        public string modelKey { get; set; }
    }

    public class Group
    {
        public string name { get; set; }
        public List<string> permissions { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public string id { get; set; }
        public string modelKey { get; set; }
    }

    public class Slot
    {
        public List<string> cameras { get; set; }
        public string cycleMode { get; set; }
        public int cycleInterval { get; set; }
    }

    public class Liveview
    {
        public string name { get; set; }
        public bool isDefault { get; set; }
        public bool isGlobal { get; set; }
        public int layout { get; set; }
        public List<Slot> slots { get; set; }
        public string owner { get; set; }
        public string id { get; set; }
        public string modelKey { get; set; }
    }

    public class Ports
    {
        public int ump { get; set; }
        public int http { get; set; }
        public int https { get; set; }
        public int rtsp { get; set; }
        public int rtsps { get; set; }
        public int rtmp { get; set; }
        public int devicesWss { get; set; }
        public int cameraHttps { get; set; }
        public int cameraTcp { get; set; }
        public int liveWs { get; set; }
        public int liveWss { get; set; }
        public int tcpStreams { get; set; }
        public int playback { get; set; }
        public int emsCLI { get; set; }
        public int emsLiveFLV { get; set; }
        public int cameraEvents { get; set; }
        public int tcpBridge { get; set; }
        public int ucore { get; set; }
        public int discoveryClient { get; set; }
    }

    public class WifiSettings
    {
        public bool useThirdPartyWifi { get; set; }
        public object ssid { get; set; }
        public object password { get; set; }
    }

    public class LocationSettings
    {
        public bool isAway { get; set; }
        public bool isGeofencingEnabled { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
        public int radius { get; set; }
    }

    public class Cpu
    {
        public double averageLoad { get; set; }
        public double temperature { get; set; }
    }

    public class Memory
    {
        public int available { get; set; }
        public int free { get; set; }
        public int total { get; set; }
    }

    public class Device
    {
        public string model { get; set; }
        public long size { get; set; }
        public bool healthy { get; set; }
    }

    public class Tmpfs
    {
        public int available { get; set; }
        public int total { get; set; }
        public int used { get; set; }
        public string path { get; set; }
    }

    public class SystemInfo
    {
        public Cpu cpu { get; set; }
        public Memory memory { get; set; }
        public Storage storage { get; set; }
        public Tmpfs tmpfs { get; set; }
    }

    public class AllMessage
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class DoorbellSettings
    {
        public string defaultMessageText { get; set; }
        public int defaultMessageResetTimeoutMs { get; set; }
        public List<object> customMessages { get; set; }
        public List<AllMessage> allMessages { get; set; }
    }

    public class SmartDetectAgreement
    {
        public string status { get; set; }
        public object lastUpdateAt { get; set; }
    }

    public class Nvr
    {
        public string mac { get; set; }
        public string host { get; set; }
        public string name { get; set; }
        public bool canAutoUpdate { get; set; }
        public bool isStatsGatheringEnabled { get; set; }
        public string timezone { get; set; }
        public string version { get; set; }
        public string firmwareVersion { get; set; }
        public object uiVersion { get; set; }
        public string hardwarePlatform { get; set; }
        public Ports ports { get; set; }
        public long uptime { get; set; }
        public long lastSeen { get; set; }
        public bool isUpdating { get; set; }
        public long lastUpdateAt { get; set; }
        public bool isStation { get; set; }
        public bool enableAutomaticBackups { get; set; }
        public bool enableStatsReporting { get; set; }
        public bool isSshEnabled { get; set; }
        public object errorCode { get; set; }
        public string releaseChannel { get; set; }
        public List<string> hosts { get; set; }
        public bool enableBridgeAutoAdoption { get; set; }
        public string hardwareId { get; set; }
        public string hardwareRevision { get; set; }
        public int hostType { get; set; }
        public string hostShortname { get; set; }
        public bool isHardware { get; set; }
        public string timeFormat { get; set; }
        public object recordingRetentionDurationMs { get; set; }
        public bool enableCrashReporting { get; set; }
        public bool disableAudio { get; set; }
        public string analyticsData { get; set; }
        public string anonymousDeviceId { get; set; }
        public WifiSettings wifiSettings { get; set; }
        public LocationSettings locationSettings { get; set; }
        public FeatureFlags featureFlags { get; set; }
        public SystemInfo systemInfo { get; set; }
        public DoorbellSettings doorbellSettings { get; set; }
        public SmartDetectAgreement smartDetectAgreement { get; set; }
        public string id { get; set; }
        public bool isAway { get; set; }
        public bool isSetup { get; set; }
        public string network { get; set; }
        public string type { get; set; }
        public long upSince { get; set; }
        public bool isRecordingDisabled { get; set; }
        public string modelKey { get; set; }
    }

    public class Bridge
    {
        public string mac { get; set; }
        public string host { get; set; }
        public string connectionHost { get; set; }
        public string type { get; set; }
        public object name { get; set; }
        public object upSince { get; set; }
        public long lastSeen { get; set; }
        public object connectedSince { get; set; }
        public string state { get; set; }
        public string hardwareRevision { get; set; }
        public string firmwareVersion { get; set; }
        public string firmwareBuild { get; set; }
        public bool isUpdating { get; set; }
        public bool isAdopting { get; set; }
        public bool isAdopted { get; set; }
        public bool isAdoptedByOther { get; set; }
        public bool isProvisioned { get; set; }
        public bool isRebooting { get; set; }
        public bool isSshEnabled { get; set; }
        public bool canAdopt { get; set; }
        public bool isAttemptingToConnect { get; set; }
        public WiredConnectionState wiredConnectionState { get; set; }
        public string id { get; set; }
        public bool isConnected { get; set; }
        public string platform { get; set; }
        public string modelKey { get; set; }
    }

    public class BootstrapResponse
    {
        public string authUserId { get; set; }
        public string accessKey { get; set; }
        public List<Camera> cameras { get; set; }
        public List<User> users { get; set; }
        public List<Group> groups { get; set; }
        public List<Liveview> liveviews { get; set; }
        public Nvr nvr { get; set; }
        public List<object> legacyUFVs { get; set; }
        public string lastUpdateId { get; set; }
        public List<object> viewers { get; set; }
        public List<object> lights { get; set; }
        public List<Bridge> bridges { get; set; }
        public List<object> sensors { get; set; }
    }
}
