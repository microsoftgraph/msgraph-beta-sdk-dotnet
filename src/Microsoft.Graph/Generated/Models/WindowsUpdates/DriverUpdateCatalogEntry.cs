using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DriverUpdateCatalogEntry : SoftwareUpdateCatalogEntry, IParsable {
        /// <summary>The description of the content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The classification of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriverClass {
            get { return BackingStore?.Get<string?>("driverClass"); }
            set { BackingStore?.Set("driverClass", value); }
        }
#nullable restore
#else
        public string DriverClass {
            get { return BackingStore?.Get<string>("driverClass"); }
            set { BackingStore?.Set("driverClass", value); }
        }
#endif
        /// <summary>The manufacturer of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The provider of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider {
            get { return BackingStore?.Get<string?>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#nullable restore
#else
        public string Provider {
            get { return BackingStore?.Get<string>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#endif
        /// <summary>The setup information file of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SetupInformationFile {
            get { return BackingStore?.Get<string?>("setupInformationFile"); }
            set { BackingStore?.Set("setupInformationFile", value); }
        }
#nullable restore
#else
        public string SetupInformationFile {
            get { return BackingStore?.Get<string>("setupInformationFile"); }
            set { BackingStore?.Set("setupInformationFile", value); }
        }
#endif
        /// <summary>The unique version of the content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>The date and time when a new version of content was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? VersionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("versionDateTime"); }
            set { BackingStore?.Set("versionDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new DriverUpdateCatalogEntry and sets the default values.
        /// </summary>
        public DriverUpdateCatalogEntry() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.driverUpdateCatalogEntry";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DriverUpdateCatalogEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriverUpdateCatalogEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"driverClass", n => { DriverClass = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"setupInformationFile", n => { SetupInformationFile = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"versionDateTime", n => { VersionDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("driverClass", DriverClass);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("setupInformationFile", SetupInformationFile);
            writer.WriteStringValue("version", Version);
            writer.WriteDateTimeOffsetValue("versionDateTime", VersionDateTime);
        }
    }
}
