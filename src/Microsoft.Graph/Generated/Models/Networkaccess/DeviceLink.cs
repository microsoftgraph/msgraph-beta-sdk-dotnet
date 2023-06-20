using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class DeviceLink : Entity, IParsable {
        /// <summary>The bandwidthCapacityInMbps property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.BandwidthCapacityInMbps? BandwidthCapacityInMbps {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.BandwidthCapacityInMbps?>("bandwidthCapacityInMbps"); }
            set { BackingStore?.Set("bandwidthCapacityInMbps", value); }
        }
        /// <summary>The bgpConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration? BgpConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration?>("bgpConfiguration"); }
            set { BackingStore?.Set("bgpConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration BgpConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration>("bgpConfiguration"); }
            set { BackingStore?.Set("bgpConfiguration", value); }
        }
#endif
        /// <summary>The deviceVendor property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.DeviceVendor? DeviceVendor {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.DeviceVendor?>("deviceVendor"); }
            set { BackingStore?.Set("deviceVendor", value); }
        }
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The redundancyConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration? RedundancyConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration?>("redundancyConfiguration"); }
            set { BackingStore?.Set("redundancyConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration RedundancyConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration>("redundancyConfiguration"); }
            set { BackingStore?.Set("redundancyConfiguration", value); }
        }
#endif
        /// <summary>The tunnelConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration? TunnelConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration?>("tunnelConfiguration"); }
            set { BackingStore?.Set("tunnelConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration TunnelConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration>("tunnelConfiguration"); }
            set { BackingStore?.Set("tunnelConfiguration", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceLink CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceLink();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bandwidthCapacityInMbps", n => { BandwidthCapacityInMbps = n.GetEnumValue<BandwidthCapacityInMbps>(); } },
                {"bgpConfiguration", n => { BgpConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration>(Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration.CreateFromDiscriminatorValue); } },
                {"deviceVendor", n => { DeviceVendor = n.GetEnumValue<DeviceVendor>(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"redundancyConfiguration", n => { RedundancyConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration>(Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration.CreateFromDiscriminatorValue); } },
                {"tunnelConfiguration", n => { TunnelConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration>(Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<BandwidthCapacityInMbps>("bandwidthCapacityInMbps", BandwidthCapacityInMbps);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.BgpConfiguration>("bgpConfiguration", BgpConfiguration);
            writer.WriteEnumValue<DeviceVendor>("deviceVendor", DeviceVendor);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.RedundancyConfiguration>("redundancyConfiguration", RedundancyConfiguration);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TunnelConfiguration>("tunnelConfiguration", TunnelConfiguration);
        }
    }
}
