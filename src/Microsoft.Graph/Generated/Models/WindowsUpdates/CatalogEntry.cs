using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class CatalogEntry : Entity, IParsable {
        /// <summary>The date on which the content is no longer available to deploy using the service. Read-only.</summary>
        public DateTimeOffset? DeployableUntilDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deployableUntilDateTime"); }
            set { BackingStore?.Set("deployableUntilDateTime", value); }
        }
        /// <summary>The display name of the content. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The release date for the content. Read-only.</summary>
        public DateTimeOffset? ReleaseDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new catalogEntry and sets the default values.
        /// </summary>
        public CatalogEntry() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.catalogEntry";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CatalogEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsUpdates.featureUpdateCatalogEntry" => new FeatureUpdateCatalogEntry(),
                "#microsoft.graph.windowsUpdates.qualityUpdateCatalogEntry" => new QualityUpdateCatalogEntry(),
                "#microsoft.graph.windowsUpdates.softwareUpdateCatalogEntry" => new SoftwareUpdateCatalogEntry(),
                _ => new CatalogEntry(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deployableUntilDateTime", n => { DeployableUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("deployableUntilDateTime", DeployableUntilDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
        }
    }
}
