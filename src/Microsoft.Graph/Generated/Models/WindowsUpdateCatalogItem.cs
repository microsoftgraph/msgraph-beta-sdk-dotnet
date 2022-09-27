using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsUpdateCatalogItem : Entity, IParsable {
        /// <summary>The display name for the catalog item.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The last supported date for a catalog item</summary>
        public DateTimeOffset? EndOfSupportDate {
            get { return BackingStore?.Get<DateTimeOffset?>("endOfSupportDate"); }
            set { BackingStore?.Set("endOfSupportDate", value); }
        }
        /// <summary>The date the catalog item was released</summary>
        public DateTimeOffset? ReleaseDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsUpdateCatalogItem and sets the default values.
        /// </summary>
        public WindowsUpdateCatalogItem() : base() {
            OdataType = "#microsoft.graph.windowsUpdateCatalogItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateCatalogItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsFeatureUpdateCatalogItem" => new WindowsFeatureUpdateCatalogItem(),
                "#microsoft.graph.windowsQualityUpdateCatalogItem" => new WindowsQualityUpdateCatalogItem(),
                _ => new WindowsUpdateCatalogItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endOfSupportDate", n => { EndOfSupportDate = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endOfSupportDate", EndOfSupportDate);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
        }
    }
}
