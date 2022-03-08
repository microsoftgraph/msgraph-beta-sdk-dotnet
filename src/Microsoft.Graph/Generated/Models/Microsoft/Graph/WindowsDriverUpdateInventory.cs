using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class WindowsDriverUpdateInventory : Entity, IParsable {
        /// <summary>The number of devices for which this driver is applicable.</summary>
        public int? ApplicableDeviceCount { get; set; }
        /// <summary>The approval status for this driver. Possible values are: needsReview, declined, approved, suspended.</summary>
        public DriverApprovalStatus? ApprovalStatus { get; set; }
        /// <summary>The category for this driver. Possible values are: recommended, previouslyApproved, other.</summary>
        public DriverCategory? Category { get; set; }
        /// <summary>The date time when a driver should be deployed if approvalStatus is approved.</summary>
        public DateTimeOffset? DeployDateTime { get; set; }
        /// <summary>The class of the driver.</summary>
        public string DriverClass { get; set; }
        /// <summary>The manufacturer of the driver.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The name of the driver.</summary>
        public string Name { get; set; }
        /// <summary>The release date time of the driver.</summary>
        public DateTimeOffset? ReleaseDateTime { get; set; }
        /// <summary>The version of the driver.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDriverUpdateInventory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateInventory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicableDeviceCount", (o,n) => { (o as WindowsDriverUpdateInventory).ApplicableDeviceCount = n.GetIntValue(); } },
                {"approvalStatus", (o,n) => { (o as WindowsDriverUpdateInventory).ApprovalStatus = n.GetEnumValue<DriverApprovalStatus>(); } },
                {"category", (o,n) => { (o as WindowsDriverUpdateInventory).Category = n.GetEnumValue<DriverCategory>(); } },
                {"deployDateTime", (o,n) => { (o as WindowsDriverUpdateInventory).DeployDateTime = n.GetDateTimeOffsetValue(); } },
                {"driverClass", (o,n) => { (o as WindowsDriverUpdateInventory).DriverClass = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as WindowsDriverUpdateInventory).Manufacturer = n.GetStringValue(); } },
                {"name", (o,n) => { (o as WindowsDriverUpdateInventory).Name = n.GetStringValue(); } },
                {"releaseDateTime", (o,n) => { (o as WindowsDriverUpdateInventory).ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", (o,n) => { (o as WindowsDriverUpdateInventory).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("applicableDeviceCount", ApplicableDeviceCount);
            writer.WriteEnumValue<DriverApprovalStatus>("approvalStatus", ApprovalStatus);
            writer.WriteEnumValue<DriverCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("deployDateTime", DeployDateTime);
            writer.WriteStringValue("driverClass", DriverClass);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
