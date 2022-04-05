using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public class ExternalConnection : Entity, IParsable {
        /// <summary>Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. Optional.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration Configuration { get; set; }
        /// <summary>The Teams App ID. Optional.</summary>
        public string ConnectorId { get; set; }
        /// <summary>Description of the connection displayed in the Microsoft 365 admin center. Optional.</summary>
        public string Description { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ExternalGroup> Groups { get; set; }
        /// <summary>The ingestedItemsCount property</summary>
        public long? IngestedItemsCount { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ExternalItem> Items { get; set; }
        /// <summary>The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.</summary>
        public string Name { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ConnectionOperation> Operations { get; set; }
        /// <summary>The quota property</summary>
        public ConnectionQuota Quota { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.Schema Schema { get; set; }
        /// <summary>The settings configuring the search experience for content in this connection, such as the display templates for search results.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings SearchSettings { get; set; }
        /// <summary>Indicates the current state of the connection. Possible values are: draft, ready, obsolete, limitExceeded, unknownFutureValue.</summary>
        public ConnectionState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configuration", (o,n) => { (o as ExternalConnection).Configuration = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration>(Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration.CreateFromDiscriminatorValue); } },
                {"connectorId", (o,n) => { (o as ExternalConnection).ConnectorId = n.GetStringValue(); } },
                {"description", (o,n) => { (o as ExternalConnection).Description = n.GetStringValue(); } },
                {"groups", (o,n) => { (o as ExternalConnection).Groups = n.GetCollectionOfObjectValues<ExternalGroup>(ExternalGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"ingestedItemsCount", (o,n) => { (o as ExternalConnection).IngestedItemsCount = n.GetLongValue(); } },
                {"items", (o,n) => { (o as ExternalConnection).Items = n.GetCollectionOfObjectValues<ExternalItem>(ExternalItem.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as ExternalConnection).Name = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as ExternalConnection).Operations = n.GetCollectionOfObjectValues<ConnectionOperation>(ConnectionOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"quota", (o,n) => { (o as ExternalConnection).Quota = n.GetObjectValue<ConnectionQuota>(ConnectionQuota.CreateFromDiscriminatorValue); } },
                {"schema", (o,n) => { (o as ExternalConnection).Schema = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Schema>(Microsoft.Graph.Beta.Models.ExternalConnectors.Schema.CreateFromDiscriminatorValue); } },
                {"searchSettings", (o,n) => { (o as ExternalConnection).SearchSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings>(Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as ExternalConnection).State = n.GetEnumValue<ConnectionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration>("configuration", Configuration);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ExternalGroup>("groups", Groups);
            writer.WriteLongValue("ingestedItemsCount", IngestedItemsCount);
            writer.WriteCollectionOfObjectValues<ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<ConnectionQuota>("quota", Quota);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Schema>("schema", Schema);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings>("searchSettings", SearchSettings);
            writer.WriteEnumValue<ConnectionState>("state", State);
        }
    }
}
