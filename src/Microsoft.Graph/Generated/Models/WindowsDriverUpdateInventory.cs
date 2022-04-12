using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceCount", n => { ApplicableDeviceCount = n.GetIntValue(); } },
                {"approvalStatus", n => { ApprovalStatus = n.GetEnumValue<DriverApprovalStatus>(); } },
                {"category", n => { Category = n.GetEnumValue<DriverCategory>(); } },
                {"deployDateTime", n => { DeployDateTime = n.GetDateTimeOffsetValue(); } },
                {"driverClass", n => { DriverClass = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
