using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppleOwnerTypeEnrollmentType : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The enrollmentType property</summary>
        public AppleUserInitiatedEnrollmentType? EnrollmentType {
            get { return BackingStore?.Get<AppleUserInitiatedEnrollmentType?>("enrollmentType"); }
            set { BackingStore?.Set("enrollmentType", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Owner type of device.</summary>
        public ManagedDeviceOwnerType? OwnerType {
            get { return BackingStore?.Get<ManagedDeviceOwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>
        /// Instantiates a new appleOwnerTypeEnrollmentType and sets the default values.
        /// </summary>
        public AppleOwnerTypeEnrollmentType() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.appleOwnerTypeEnrollmentType";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppleOwnerTypeEnrollmentType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppleOwnerTypeEnrollmentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"enrollmentType", n => { EnrollmentType = n.GetEnumValue<AppleUserInitiatedEnrollmentType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AppleUserInitiatedEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("ownerType", OwnerType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
