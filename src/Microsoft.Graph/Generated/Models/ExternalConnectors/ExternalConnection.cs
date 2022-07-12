using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    /// <summary>Provides operations to manage the collection of externalConnection entities.</summary>
    public class ExternalConnection : Entity, IParsable {
        /// <summary>The complianceSettings property</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.ComplianceSettings ComplianceSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.ComplianceSettings>("complianceSettings"); }
            set { BackingStore?.Set("complianceSettings", value); }
        }
        /// <summary>Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. Optional.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration Configuration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
        /// <summary>The Teams App ID. Optional.</summary>
        public string ConnectorId {
            get { return BackingStore?.Get<string>("connectorId"); }
            set { BackingStore?.Set("connectorId", value); }
        }
        /// <summary>Description of the connection displayed in the Microsoft 365 admin center. Optional.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The enabledContentExperiences property</summary>
        public ContentExperienceType? EnabledContentExperiences {
            get { return BackingStore?.Get<ContentExperienceType?>("enabledContentExperiences"); }
            set { BackingStore?.Set("enabledContentExperiences", value); }
        }
        /// <summary>The groups property</summary>
        public List<ExternalGroup> Groups {
            get { return BackingStore?.Get<List<ExternalGroup>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
        /// <summary>The number of items ingested into a connection. This value is refreshed every 15 minutes. If the connection state is draft, then ingestedItemsCount will be null.</summary>
        public long? IngestedItemsCount {
            get { return BackingStore?.Get<long?>("ingestedItemsCount"); }
            set { BackingStore?.Set("ingestedItemsCount", value); }
        }
        /// <summary>The items property</summary>
        public List<ExternalItem> Items {
            get { return BackingStore?.Get<List<ExternalItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
        /// <summary>The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The operations property</summary>
        public List<ConnectionOperation> Operations {
            get { return BackingStore?.Get<List<ConnectionOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>The quota property</summary>
        public ConnectionQuota Quota {
            get { return BackingStore?.Get<ConnectionQuota>("quota"); }
            set { BackingStore?.Set("quota", value); }
        }
        /// <summary>The schema property</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.Schema Schema {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.Schema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
        /// <summary>The settings configuring the search experience for content in this connection, such as the display templates for search results.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings SearchSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings>("searchSettings"); }
            set { BackingStore?.Set("searchSettings", value); }
        }
        /// <summary>Indicates the current state of the connection. Possible values are draft, ready, obsolete, and limitExceeded. Required.</summary>
        public ConnectionState? State {
            get { return BackingStore?.Get<ConnectionState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceSettings", n => { ComplianceSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.ComplianceSettings>(Microsoft.Graph.Beta.Models.ExternalConnectors.ComplianceSettings.CreateFromDiscriminatorValue); } },
                {"configuration", n => { Configuration = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration>(Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration.CreateFromDiscriminatorValue); } },
                {"connectorId", n => { ConnectorId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"enabledContentExperiences", n => { EnabledContentExperiences = n.GetEnumValue<ContentExperienceType>(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<ExternalGroup>(ExternalGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"ingestedItemsCount", n => { IngestedItemsCount = n.GetLongValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<ExternalItem>(ExternalItem.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ConnectionOperation>(ConnectionOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"quota", n => { Quota = n.GetObjectValue<ConnectionQuota>(ConnectionQuota.CreateFromDiscriminatorValue); } },
                {"schema", n => { Schema = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Schema>(Microsoft.Graph.Beta.Models.ExternalConnectors.Schema.CreateFromDiscriminatorValue); } },
                {"searchSettings", n => { SearchSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings>(Microsoft.Graph.Beta.Models.ExternalConnectors.SearchSettings.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<ConnectionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.ComplianceSettings>("complianceSettings", ComplianceSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.Configuration>("configuration", Configuration);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ContentExperienceType>("enabledContentExperiences", EnabledContentExperiences);
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
