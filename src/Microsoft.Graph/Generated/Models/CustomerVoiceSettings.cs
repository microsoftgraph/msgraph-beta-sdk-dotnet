using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomerVoiceSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isInOrgFormsPhishingScanEnabled property</summary>
        public bool? IsInOrgFormsPhishingScanEnabled {
            get { return BackingStore?.Get<bool?>("isInOrgFormsPhishingScanEnabled"); }
            set { BackingStore?.Set("isInOrgFormsPhishingScanEnabled", value); }
        }
        /// <summary>The isRecordIdentityByDefaultEnabled property</summary>
        public bool? IsRecordIdentityByDefaultEnabled {
            get { return BackingStore?.Get<bool?>("isRecordIdentityByDefaultEnabled"); }
            set { BackingStore?.Set("isRecordIdentityByDefaultEnabled", value); }
        }
        /// <summary>The isRestrictedSurveyAccessEnabled property</summary>
        public bool? IsRestrictedSurveyAccessEnabled {
            get { return BackingStore?.Get<bool?>("isRestrictedSurveyAccessEnabled"); }
            set { BackingStore?.Set("isRestrictedSurveyAccessEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CustomerVoiceSettings and sets the default values.
        /// </summary>
        public CustomerVoiceSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomerVoiceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerVoiceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isInOrgFormsPhishingScanEnabled", n => { IsInOrgFormsPhishingScanEnabled = n.GetBoolValue(); } },
                {"isRecordIdentityByDefaultEnabled", n => { IsRecordIdentityByDefaultEnabled = n.GetBoolValue(); } },
                {"isRestrictedSurveyAccessEnabled", n => { IsRestrictedSurveyAccessEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isInOrgFormsPhishingScanEnabled", IsInOrgFormsPhishingScanEnabled);
            writer.WriteBoolValue("isRecordIdentityByDefaultEnabled", IsRecordIdentityByDefaultEnabled);
            writer.WriteBoolValue("isRestrictedSurveyAccessEnabled", IsRestrictedSurveyAccessEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
