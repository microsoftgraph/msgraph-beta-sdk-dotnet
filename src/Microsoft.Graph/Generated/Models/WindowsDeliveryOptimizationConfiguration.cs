using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsDeliveryOptimizationConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specifies number of seconds to delay an HTTP source in a background download that is allowed to use peer-to-peer. Valid values 0 to 4294967295</summary>
        public long? BackgroundDownloadFromHttpDelayInSeconds {
            get { return BackingStore?.Get<long?>(nameof(BackgroundDownloadFromHttpDelayInSeconds)); }
            set { BackingStore?.Set(nameof(BackgroundDownloadFromHttpDelayInSeconds), value); }
        }
        /// <summary>Specifies foreground and background bandwidth usage using percentages, absolutes, or hours.</summary>
        public DeliveryOptimizationBandwidth BandwidthMode {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidth>(nameof(BandwidthMode)); }
            set { BackingStore?.Set(nameof(BandwidthMode), value); }
        }
        /// <summary>Specifies number of seconds to delay a fall back from cache servers to an HTTP source for a background download. Valid values 0 to 2592000.</summary>
        public int? CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds {
            get { return BackingStore?.Get<int?>(nameof(CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds)); }
            set { BackingStore?.Set(nameof(CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds), value); }
        }
        /// <summary>Specifies number of seconds to delay a fall back from cache servers to an HTTP source for a foreground download. Valid values 0 to 2592000.​</summary>
        public int? CacheServerForegroundDownloadFallbackToHttpDelayInSeconds {
            get { return BackingStore?.Get<int?>(nameof(CacheServerForegroundDownloadFallbackToHttpDelayInSeconds)); }
            set { BackingStore?.Set(nameof(CacheServerForegroundDownloadFallbackToHttpDelayInSeconds), value); }
        }
        /// <summary>Specifies cache servers host names.</summary>
        public List<string> CacheServerHostNames {
            get { return BackingStore?.Get<List<string>>(nameof(CacheServerHostNames)); }
            set { BackingStore?.Set(nameof(CacheServerHostNames), value); }
        }
        /// <summary>Specifies the download method that delivery optimization can use to manage network bandwidth consumption for large content distribution scenarios. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode {
            get { return BackingStore?.Get<WindowsDeliveryOptimizationMode?>(nameof(DeliveryOptimizationMode)); }
            set { BackingStore?.Set(nameof(DeliveryOptimizationMode), value); }
        }
        /// <summary>Specifies number of seconds to delay an HTTP source in a foreground download that is allowed to use peer-to-peer (0-86400). Valid values 0 to 86400</summary>
        public long? ForegroundDownloadFromHttpDelayInSeconds {
            get { return BackingStore?.Get<long?>(nameof(ForegroundDownloadFromHttpDelayInSeconds)); }
            set { BackingStore?.Set(nameof(ForegroundDownloadFromHttpDelayInSeconds), value); }
        }
        /// <summary>Specifies to restrict peer selection to a specfic source.</summary>
        public DeliveryOptimizationGroupIdSource GroupIdSource {
            get { return BackingStore?.Get<DeliveryOptimizationGroupIdSource>(nameof(GroupIdSource)); }
            set { BackingStore?.Set(nameof(GroupIdSource), value); }
        }
        /// <summary>Specifies the maximum time in days that each file is held in the Delivery Optimization cache after downloading successfully (0-3650). Valid values 0 to 3650</summary>
        public int? MaximumCacheAgeInDays {
            get { return BackingStore?.Get<int?>(nameof(MaximumCacheAgeInDays)); }
            set { BackingStore?.Set(nameof(MaximumCacheAgeInDays), value); }
        }
        /// <summary>Specifies the maximum cache size that Delivery Optimization either as a percentage or in GB.</summary>
        public DeliveryOptimizationMaxCacheSize MaximumCacheSize {
            get { return BackingStore?.Get<DeliveryOptimizationMaxCacheSize>(nameof(MaximumCacheSize)); }
            set { BackingStore?.Set(nameof(MaximumCacheSize), value); }
        }
        /// <summary>Specifies the minimum battery percentage to allow the device to upload data (0-100). Valid values 0 to 100</summary>
        public int? MinimumBatteryPercentageAllowedToUpload {
            get { return BackingStore?.Get<int?>(nameof(MinimumBatteryPercentageAllowedToUpload)); }
            set { BackingStore?.Set(nameof(MinimumBatteryPercentageAllowedToUpload), value); }
        }
        /// <summary>Specifies the minimum disk size in GB to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumDiskSizeAllowedToPeerInGigabytes {
            get { return BackingStore?.Get<int?>(nameof(MinimumDiskSizeAllowedToPeerInGigabytes)); }
            set { BackingStore?.Set(nameof(MinimumDiskSizeAllowedToPeerInGigabytes), value); }
        }
        /// <summary>Specifies the minimum content file size in MB enabled to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumFileSizeToCacheInMegabytes {
            get { return BackingStore?.Get<int?>(nameof(MinimumFileSizeToCacheInMegabytes)); }
            set { BackingStore?.Set(nameof(MinimumFileSizeToCacheInMegabytes), value); }
        }
        /// <summary>Specifies the minimum RAM size in GB to use Peer Caching (1-100000). Valid values 1 to 100000</summary>
        public int? MinimumRamAllowedToPeerInGigabytes {
            get { return BackingStore?.Get<int?>(nameof(MinimumRamAllowedToPeerInGigabytes)); }
            set { BackingStore?.Set(nameof(MinimumRamAllowedToPeerInGigabytes), value); }
        }
        /// <summary>Specifies the drive that Delivery Optimization should use for its cache.</summary>
        public string ModifyCacheLocation {
            get { return BackingStore?.Get<string>(nameof(ModifyCacheLocation)); }
            set { BackingStore?.Set(nameof(ModifyCacheLocation), value); }
        }
        /// <summary>Specifies to restrict peer selection via selected option.</summary>
        public DeliveryOptimizationRestrictPeerSelectionByOptions? RestrictPeerSelectionBy {
            get { return BackingStore?.Get<DeliveryOptimizationRestrictPeerSelectionByOptions?>(nameof(RestrictPeerSelectionBy)); }
            set { BackingStore?.Set(nameof(RestrictPeerSelectionBy), value); }
        }
        /// <summary>Specifies whether the device is allowed to participate in Peer Caching while connected via VPN to the domain network.</summary>
        public Enablement? VpnPeerCaching {
            get { return BackingStore?.Get<Enablement?>(nameof(VpnPeerCaching)); }
            set { BackingStore?.Set(nameof(VpnPeerCaching), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDeliveryOptimizationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDeliveryOptimizationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"backgroundDownloadFromHttpDelayInSeconds", n => { BackgroundDownloadFromHttpDelayInSeconds = n.GetLongValue(); } },
                {"bandwidthMode", n => { BandwidthMode = n.GetObjectValue<DeliveryOptimizationBandwidth>(DeliveryOptimizationBandwidth.CreateFromDiscriminatorValue); } },
                {"cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds", n => { CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds = n.GetIntValue(); } },
                {"cacheServerForegroundDownloadFallbackToHttpDelayInSeconds", n => { CacheServerForegroundDownloadFallbackToHttpDelayInSeconds = n.GetIntValue(); } },
                {"cacheServerHostNames", n => { CacheServerHostNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"foregroundDownloadFromHttpDelayInSeconds", n => { ForegroundDownloadFromHttpDelayInSeconds = n.GetLongValue(); } },
                {"groupIdSource", n => { GroupIdSource = n.GetObjectValue<DeliveryOptimizationGroupIdSource>(DeliveryOptimizationGroupIdSource.CreateFromDiscriminatorValue); } },
                {"maximumCacheAgeInDays", n => { MaximumCacheAgeInDays = n.GetIntValue(); } },
                {"maximumCacheSize", n => { MaximumCacheSize = n.GetObjectValue<DeliveryOptimizationMaxCacheSize>(DeliveryOptimizationMaxCacheSize.CreateFromDiscriminatorValue); } },
                {"minimumBatteryPercentageAllowedToUpload", n => { MinimumBatteryPercentageAllowedToUpload = n.GetIntValue(); } },
                {"minimumDiskSizeAllowedToPeerInGigabytes", n => { MinimumDiskSizeAllowedToPeerInGigabytes = n.GetIntValue(); } },
                {"minimumFileSizeToCacheInMegabytes", n => { MinimumFileSizeToCacheInMegabytes = n.GetIntValue(); } },
                {"minimumRamAllowedToPeerInGigabytes", n => { MinimumRamAllowedToPeerInGigabytes = n.GetIntValue(); } },
                {"modifyCacheLocation", n => { ModifyCacheLocation = n.GetStringValue(); } },
                {"restrictPeerSelectionBy", n => { RestrictPeerSelectionBy = n.GetEnumValue<DeliveryOptimizationRestrictPeerSelectionByOptions>(); } },
                {"vpnPeerCaching", n => { VpnPeerCaching = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("backgroundDownloadFromHttpDelayInSeconds", BackgroundDownloadFromHttpDelayInSeconds);
            writer.WriteObjectValue<DeliveryOptimizationBandwidth>("bandwidthMode", BandwidthMode);
            writer.WriteIntValue("cacheServerBackgroundDownloadFallbackToHttpDelayInSeconds", CacheServerBackgroundDownloadFallbackToHttpDelayInSeconds);
            writer.WriteIntValue("cacheServerForegroundDownloadFallbackToHttpDelayInSeconds", CacheServerForegroundDownloadFallbackToHttpDelayInSeconds);
            writer.WriteCollectionOfPrimitiveValues<string>("cacheServerHostNames", CacheServerHostNames);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteLongValue("foregroundDownloadFromHttpDelayInSeconds", ForegroundDownloadFromHttpDelayInSeconds);
            writer.WriteObjectValue<DeliveryOptimizationGroupIdSource>("groupIdSource", GroupIdSource);
            writer.WriteIntValue("maximumCacheAgeInDays", MaximumCacheAgeInDays);
            writer.WriteObjectValue<DeliveryOptimizationMaxCacheSize>("maximumCacheSize", MaximumCacheSize);
            writer.WriteIntValue("minimumBatteryPercentageAllowedToUpload", MinimumBatteryPercentageAllowedToUpload);
            writer.WriteIntValue("minimumDiskSizeAllowedToPeerInGigabytes", MinimumDiskSizeAllowedToPeerInGigabytes);
            writer.WriteIntValue("minimumFileSizeToCacheInMegabytes", MinimumFileSizeToCacheInMegabytes);
            writer.WriteIntValue("minimumRamAllowedToPeerInGigabytes", MinimumRamAllowedToPeerInGigabytes);
            writer.WriteStringValue("modifyCacheLocation", ModifyCacheLocation);
            writer.WriteEnumValue<DeliveryOptimizationRestrictPeerSelectionByOptions>("restrictPeerSelectionBy", RestrictPeerSelectionBy);
            writer.WriteEnumValue<Enablement>("vpnPeerCaching", VpnPeerCaching);
        }
    }
}
