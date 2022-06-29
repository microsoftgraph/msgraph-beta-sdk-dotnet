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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The user role type to assign to the license. Possible values are: student, teacher, faculty.</summary>
        public EducationUserRole? AppliesTo {
            get { return BackingStore?.Get<EducationUserRole?>(nameof(AppliesTo)); }
            set { BackingStore?.Set(nameof(AppliesTo), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the source property, which should be a field name in the source data. This property is case-sensitive.</summary>
        public string SourcePropertyName {
            get { return BackingStore?.Get<string>(nameof(SourcePropertyName)); }
            set { BackingStore?.Set(nameof(SourcePropertyName), value); }
        }
        /// <summary>The domain to suffix with the source property to match on the target. If provided as null, the source property will be used to match with the target property.</summary>
        public string TargetDomain {
            get { return BackingStore?.Get<string>(nameof(TargetDomain)); }
            set { BackingStore?.Set(nameof(TargetDomain), value); }
        }
        /// <summary>The name of the target property, which should be a valid property in Azure AD. This property is case-sensitive.</summary>
        public string TargetPropertyName {
            get { return BackingStore?.Get<string>(nameof(TargetPropertyName)); }
            set { BackingStore?.Set(nameof(TargetPropertyName), value); }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"sourcePropertyName", n => { SourcePropertyName = n.GetStringValue(); } },
                {"targetDomain", n => { TargetDomain = n.GetStringValue(); } },
                {"targetPropertyName", n => { TargetPropertyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EducationUserRole>("appliesTo", AppliesTo);
            writer.WriteStringValue("sourcePropertyName", SourcePropertyName);
            writer.WriteStringValue("targetDomain", TargetDomain);
            writer.WriteStringValue("targetPropertyName", TargetPropertyName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
