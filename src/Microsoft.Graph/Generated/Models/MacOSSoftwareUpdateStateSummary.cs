using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// MacOS software update state summary for a device and user
    /// </summary>
    public class MacOSSoftwareUpdateStateSummary : Entity, IParsable {
        /// <summary>Human readable name of the software update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Last date time the report for this device and product key was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Product key of the software update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>MacOS Software Update State</summary>
        public MacOSSoftwareUpdateState? State {
            get { return BackingStore?.Get<MacOSSoftwareUpdateState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>MacOS Software Update Category</summary>
        public MacOSSoftwareUpdateCategory? UpdateCategory {
            get { return BackingStore?.Get<MacOSSoftwareUpdateCategory?>("updateCategory"); }
            set { BackingStore?.Set("updateCategory", value); }
        }
        /// <summary>Version of the software update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdateVersion {
            get { return BackingStore?.Get<string?>("updateVersion"); }
            set { BackingStore?.Set("updateVersion", value); }
        }
#nullable restore
#else
        public string UpdateVersion {
            get { return BackingStore?.Get<string>("updateVersion"); }
            set { BackingStore?.Set("updateVersion", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSSoftwareUpdateStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<MacOSSoftwareUpdateState>(); } },
                {"updateCategory", n => { UpdateCategory = n.GetEnumValue<MacOSSoftwareUpdateCategory>(); } },
                {"updateVersion", n => { UpdateVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteEnumValue<MacOSSoftwareUpdateState>("state", State);
            writer.WriteEnumValue<MacOSSoftwareUpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteStringValue("updateVersion", UpdateVersion);
        }
    }
}
