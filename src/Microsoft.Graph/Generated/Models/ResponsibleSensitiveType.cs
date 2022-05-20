using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ResponsibleSensitiveType : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The id property</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The publisherName property</summary>
        public string PublisherName {
            get { return BackingStore?.Get<string>(nameof(PublisherName)); }
            set { BackingStore?.Set(nameof(PublisherName), value); }
        }
        /// <summary>The rulePackageId property</summary>
        public string RulePackageId {
            get { return BackingStore?.Get<string>(nameof(RulePackageId)); }
            set { BackingStore?.Set(nameof(RulePackageId), value); }
        }
        /// <summary>The rulePackageType property</summary>
        public string RulePackageType {
            get { return BackingStore?.Get<string>(nameof(RulePackageType)); }
            set { BackingStore?.Set(nameof(RulePackageType), value); }
        }
        /// <summary>
        /// Instantiates a new responsibleSensitiveType and sets the default values.
        /// </summary>
        public ResponsibleSensitiveType() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ResponsibleSensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResponsibleSensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"rulePackageId", n => { RulePackageId = n.GetStringValue(); } },
                {"rulePackageType", n => { RulePackageType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("rulePackageId", RulePackageId);
            writer.WriteStringValue("rulePackageType", RulePackageType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
