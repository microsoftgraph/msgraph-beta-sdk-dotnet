using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Acl : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The accessType property</summary>
        public Microsoft.Graph.Beta.Models.AccessType? AccessType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessType?>("accessType"); }
            set { BackingStore?.Set("accessType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identitySource property</summary>
        public IdentitySourceType? IdentitySource {
            get { return BackingStore?.Get<IdentitySourceType?>("identitySource"); }
            set { BackingStore?.Set("identitySource", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The type property</summary>
        public AclType? Type {
            get { return BackingStore?.Get<AclType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The value property</summary>
        public string Value {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new acl and sets the default values.
        /// </summary>
        public Acl() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.acl";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Acl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Acl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessType", n => { AccessType = n.GetEnumValue<AccessType>(); } },
                {"identitySource", n => { IdentitySource = n.GetEnumValue<IdentitySourceType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<AclType>(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessType>("accessType", AccessType);
            writer.WriteEnumValue<IdentitySourceType>("identitySource", IdentitySource);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AclType>("type", Type);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
