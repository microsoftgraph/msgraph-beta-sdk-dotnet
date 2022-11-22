using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationIdentityMatchingOptions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appliesTo property</summary>
        public EducationUserRole? AppliesTo {
            get { return BackingStore?.Get<EducationUserRole?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The name of the source property, which should be a field name in the source data. This property is case-sensitive.</summary>
        public string SourcePropertyName {
            get { return BackingStore?.Get<string>("sourcePropertyName"); }
            set { BackingStore?.Set("sourcePropertyName", value); }
        }
        /// <summary>The domain to suffix with the source property to match on the target. If provided as null, the source property will be used to match with the target property.</summary>
        public string TargetDomain {
            get { return BackingStore?.Get<string>("targetDomain"); }
            set { BackingStore?.Set("targetDomain", value); }
        }
        /// <summary>The name of the target property, which should be a valid property in Azure AD. This property is case-sensitive.</summary>
        public string TargetPropertyName {
            get { return BackingStore?.Get<string>("targetPropertyName"); }
            set { BackingStore?.Set("targetPropertyName", value); }
        }
        /// <summary>
        /// Instantiates a new educationIdentityMatchingOptions and sets the default values.
        /// </summary>
        public EducationIdentityMatchingOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EducationIdentityMatchingOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationIdentityMatchingOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appliesTo", n => { AppliesTo = n.GetEnumValue<EducationUserRole>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sourcePropertyName", n => { SourcePropertyName = n.GetStringValue(); } },
                {"targetDomain", n => { TargetDomain = n.GetStringValue(); } },
                {"targetPropertyName", n => { TargetPropertyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EducationUserRole>("appliesTo", AppliesTo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourcePropertyName", SourcePropertyName);
            writer.WriteStringValue("targetDomain", TargetDomain);
            writer.WriteStringValue("targetPropertyName", TargetPropertyName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
