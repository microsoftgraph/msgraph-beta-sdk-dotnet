using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class DataSource : Entity, IParsable {
        /// <summary>The user who created the dataSource.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The date and time the dataSource was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The display name of the dataSource. This will be the name of the SharePoint site.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The holdStatus property</summary>
        public DataSourceHoldStatus? HoldStatus {
            get { return BackingStore?.Get<DataSourceHoldStatus?>("holdStatus"); }
            set { BackingStore?.Set("holdStatus", value); }
        }
        /// <summary>
        /// Instantiates a new dataSource and sets the default values.
        /// </summary>
        public DataSource() : base() {
            OdataType = "#microsoft.graph.ediscovery.dataSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.ediscovery.siteSource" => new SiteSource(),
                "#microsoft.graph.ediscovery.unifiedGroupSource" => new UnifiedGroupSource(),
                "#microsoft.graph.ediscovery.userSource" => new UserSource(),
                _ => new DataSource(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"holdStatus", n => { HoldStatus = n.GetEnumValue<DataSourceHoldStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<DataSourceHoldStatus>("holdStatus", HoldStatus);
        }
    }
}
