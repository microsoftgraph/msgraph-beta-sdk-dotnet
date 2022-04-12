using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedDeviceOverview : Entity, IParsable {
        /// <summary>Distribution of Exchange Access State in Intune</summary>
        public Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary { get; set; }
        /// <summary>Device operating system summary.</summary>
        public Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary DeviceOperatingSystemSummary { get; set; }
        /// <summary>The number of devices enrolled in both MDM and EAS</summary>
        public int? DualEnrolledDeviceCount { get; set; }
        /// <summary>Total enrolled device count. Does not include PC devices managed via Intune PC Agent</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>Last modified date time of device overview</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers ManagedDeviceModelsAndManufacturers { get; set; }
        /// <summary>The number of devices enrolled in MDM</summary>
        public int? MdmEnrolledCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceExchangeAccessStateSummary", n => { DeviceExchangeAccessStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary>(Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceOperatingSystemSummary", n => { DeviceOperatingSystemSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary>(Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary.CreateFromDiscriminatorValue); } },
                {"dualEnrolledDeviceCount", n => { DualEnrolledDeviceCount = n.GetIntValue(); } },
                {"enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceModelsAndManufacturers", n => { ManagedDeviceModelsAndManufacturers = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers>(Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers.CreateFromDiscriminatorValue); } },
                {"mdmEnrolledCount", n => { MdmEnrolledCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary", DeviceExchangeAccessStateSummary);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary", DeviceOperatingSystemSummary);
            writer.WriteIntValue("dualEnrolledDeviceCount", DualEnrolledDeviceCount);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers>("managedDeviceModelsAndManufacturers", ManagedDeviceModelsAndManufacturers);
            writer.WriteIntValue("mdmEnrolledCount", MdmEnrolledCount);
        }
    }
}
