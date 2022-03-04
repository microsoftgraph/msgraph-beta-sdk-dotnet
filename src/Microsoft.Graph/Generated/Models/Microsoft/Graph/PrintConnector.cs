using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrintConnector : Entity, IParsable {
        /// <summary>The connector's version.</summary>
        public string AppVersion { get; set; }
        /// <summary>The connector's device health.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealth DeviceHealth { get; set; }
        /// <summary>The name of the connector.</summary>
        public string DisplayName { get; set; }
        /// <summary>The connector machine's hostname.</summary>
        public string FullyQualifiedDomainName { get; set; }
        /// <summary>The physical and/or organizational location of the connector.</summary>
        public PrinterLocation Location { get; set; }
        public string Name { get; set; }
        /// <summary>The connector machine's operating system version.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>The DateTimeOffset when the connector was registered.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appVersion", (o,n) => { (o as PrintConnector).AppVersion = n.GetStringValue(); } },
                {"deviceHealth", (o,n) => { (o as PrintConnector).DeviceHealth = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealth>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealth.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as PrintConnector).DisplayName = n.GetStringValue(); } },
                {"fullyQualifiedDomainName", (o,n) => { (o as PrintConnector).FullyQualifiedDomainName = n.GetStringValue(); } },
                {"location", (o,n) => { (o as PrintConnector).Location = n.GetObjectValue<PrinterLocation>(PrinterLocation.CreateFromDiscriminatorValue); } },
                {"name", (o,n) => { (o as PrintConnector).Name = n.GetStringValue(); } },
                {"operatingSystem", (o,n) => { (o as PrintConnector).OperatingSystem = n.GetStringValue(); } },
                {"registeredDateTime", (o,n) => { (o as PrintConnector).RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealth>("deviceHealth", DeviceHealth);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fullyQualifiedDomainName", FullyQualifiedDomainName);
            writer.WriteObjectValue<PrinterLocation>("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
        }
    }
}
