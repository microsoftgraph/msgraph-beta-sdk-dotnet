using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the groups of devices that will be targeted to receive the organizational message. If a device is part of the excluded group, then it will not receive the message, regardless of the device being part of an included group</summary>
    public class OrganizationalMessageTargeting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The groups that will not receive the message. If a user from an excluded group is part of an included group, it will not receive the message</summary>
        public List<string> ExcludeIds {
            get { return BackingStore?.Get<List<string>>("excludeIds"); }
            set { BackingStore?.Set("excludeIds", value); }
        }
        /// <summary>The groups that will be targeted and receive the message</summary>
        public List<string> IncludeIds {
            get { return BackingStore?.Get<List<string>>("includeIds"); }
            set { BackingStore?.Set("includeIds", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Indicates the type of targeting</summary>
        public OrganizationalMessageTargetingType? TargetingType {
            get { return BackingStore?.Get<OrganizationalMessageTargetingType?>("targetingType"); }
            set { BackingStore?.Set("targetingType", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageTargeting and sets the default values.
        /// </summary>
        public OrganizationalMessageTargeting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageTargeting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageTargeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageTargeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeIds", n => { ExcludeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeIds", n => { IncludeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"targetingType", n => { TargetingType = n.GetEnumValue<OrganizationalMessageTargetingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeIds", ExcludeIds);
            writer.WriteCollectionOfPrimitiveValues<string>("includeIds", IncludeIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OrganizationalMessageTargetingType>("targetingType", TargetingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
