using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ManagedDeviceOverview : Entity, IParsable {
        /// <summary>Distribution of Exchange Access State in Intune</summary>
        public DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary { get; set; }
        /// <summary>Device operating system summary.</summary>
        public DeviceOperatingSystemSummary DeviceOperatingSystemSummary { get; set; }
        /// <summary>The number of devices enrolled in both MDM and EAS</summary>
        public int? DualEnrolledDeviceCount { get; set; }
        /// <summary>Total enrolled device count. Does not include PC devices managed via Intune PC Agent</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>Last modified date time of device overview</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
        public ManagedDeviceModelsAndManufacturers ManagedDeviceModelsAndManufacturers { get; set; }
        /// <summary>The number of devices enrolled in MDM</summary>
        public int? MdmEnrolledCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceExchangeAccessStateSummary", (o,n) => { (o as ManagedDeviceOverview).DeviceExchangeAccessStateSummary = n.GetObjectValue<DeviceExchangeAccessStateSummary>(); } },
                {"deviceOperatingSystemSummary", (o,n) => { (o as ManagedDeviceOverview).DeviceOperatingSystemSummary = n.GetObjectValue<DeviceOperatingSystemSummary>(); } },
                {"dualEnrolledDeviceCount", (o,n) => { (o as ManagedDeviceOverview).DualEnrolledDeviceCount = n.GetIntValue(); } },
                {"enrolledDeviceCount", (o,n) => { (o as ManagedDeviceOverview).EnrolledDeviceCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedDeviceOverview).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceModelsAndManufacturers", (o,n) => { (o as ManagedDeviceOverview).ManagedDeviceModelsAndManufacturers = n.GetObjectValue<ManagedDeviceModelsAndManufacturers>(); } },
                {"mdmEnrolledCount", (o,n) => { (o as ManagedDeviceOverview).MdmEnrolledCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary", DeviceExchangeAccessStateSummary);
            writer.WriteObjectValue<DeviceOperatingSystemSummary>("deviceOperatingSystemSummary", DeviceOperatingSystemSummary);
            writer.WriteIntValue("dualEnrolledDeviceCount", DualEnrolledDeviceCount);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<ManagedDeviceModelsAndManufacturers>("managedDeviceModelsAndManufacturers", ManagedDeviceModelsAndManufacturers);
            writer.WriteIntValue("mdmEnrolledCount", MdmEnrolledCount);
        }
    }
}
