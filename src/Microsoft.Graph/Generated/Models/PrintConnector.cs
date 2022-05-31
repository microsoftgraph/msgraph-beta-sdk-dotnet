using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class PrintConnector : Entity, IParsable {
        /// <summary>The connector&apos;s version.</summary>
        public string AppVersion {
            get { return BackingStore?.Get<string>(nameof(AppVersion)); }
            set { BackingStore?.Set(nameof(AppVersion), value); }
        }
        /// <summary>The connector&apos;s device health.</summary>
        public Microsoft.Graph.Beta.Models.DeviceHealth DeviceHealth {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceHealth>(nameof(DeviceHealth)); }
            set { BackingStore?.Set(nameof(DeviceHealth), value); }
        }
        /// <summary>The name of the connector.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The connector machine&apos;s hostname.</summary>
        public string FullyQualifiedDomainName {
            get { return BackingStore?.Get<string>(nameof(FullyQualifiedDomainName)); }
            set { BackingStore?.Set(nameof(FullyQualifiedDomainName), value); }
        }
        /// <summary>The physical and/or organizational location of the connector.</summary>
        public PrinterLocation Location {
            get { return BackingStore?.Get<PrinterLocation>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The connector machine&apos;s operating system version.</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>(nameof(OperatingSystem)); }
            set { BackingStore?.Set(nameof(OperatingSystem), value); }
        }
        /// <summary>The DateTimeOffset when the connector was registered.</summary>
        public DateTimeOffset? RegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RegisteredDateTime)); }
            set { BackingStore?.Set(nameof(RegisteredDateTime), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"deviceHealth", n => { DeviceHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceHealth>(Microsoft.Graph.Beta.Models.DeviceHealth.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fullyQualifiedDomainName", n => { FullyQualifiedDomainName = n.GetStringValue(); } },
                {"location", n => { Location = n.GetObjectValue<PrinterLocation>(PrinterLocation.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceHealth>("deviceHealth", DeviceHealth);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fullyQualifiedDomainName", FullyQualifiedDomainName);
            writer.WriteObjectValue<PrinterLocation>("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
        }
    }
}
