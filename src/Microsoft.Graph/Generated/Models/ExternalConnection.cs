using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of activityStatistics entities.
    /// </summary>
    public class ExternalConnection : Entity, IParsable {
        /// <summary>The configuration property</summary>
        public Microsoft.Graph.Beta.Models.Configuration Configuration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Configuration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The groups property</summary>
        public List<ExternalGroup> Groups {
            get { return BackingStore?.Get<List<ExternalGroup>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
        /// <summary>The items property</summary>
        public List<ExternalItem> Items {
            get { return BackingStore?.Get<List<ExternalItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The operations property</summary>
        public List<ConnectionOperation> Operations {
            get { return BackingStore?.Get<List<ConnectionOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>The schema property</summary>
        public Microsoft.Graph.Beta.Models.Schema Schema {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Schema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
        /// <summary>The state property</summary>
        public ConnectionState? State {
            get { return BackingStore?.Get<ConnectionState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<Microsoft.Graph.Beta.Models.Configuration>(Microsoft.Graph.Beta.Models.Configuration.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<ExternalGroup>(ExternalGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<ExternalItem>(ExternalItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ConnectionOperation>(ConnectionOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schema", n => { Schema = n.GetObjectValue<Microsoft.Graph.Beta.Models.Schema>(Microsoft.Graph.Beta.Models.Schema.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<ConnectionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Configuration>("configuration", Configuration);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ExternalGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Schema>("schema", Schema);
        }
    }
}
