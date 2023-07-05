using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class FormsSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isBingImageSearchEnabled property</summary>
        public bool? IsBingImageSearchEnabled {
            get { return BackingStore?.Get<bool?>("isBingImageSearchEnabled"); }
            set { BackingStore?.Set("isBingImageSearchEnabled", value); }
        }
        /// <summary>The isExternalSendFormEnabled property</summary>
        public bool? IsExternalSendFormEnabled {
            get { return BackingStore?.Get<bool?>("isExternalSendFormEnabled"); }
            set { BackingStore?.Set("isExternalSendFormEnabled", value); }
        }
        /// <summary>The isExternalShareCollaborationEnabled property</summary>
        public bool? IsExternalShareCollaborationEnabled {
            get { return BackingStore?.Get<bool?>("isExternalShareCollaborationEnabled"); }
            set { BackingStore?.Set("isExternalShareCollaborationEnabled", value); }
        }
        /// <summary>The isExternalShareResultEnabled property</summary>
        public bool? IsExternalShareResultEnabled {
            get { return BackingStore?.Get<bool?>("isExternalShareResultEnabled"); }
            set { BackingStore?.Set("isExternalShareResultEnabled", value); }
        }
        /// <summary>The isExternalShareTemplateEnabled property</summary>
        public bool? IsExternalShareTemplateEnabled {
            get { return BackingStore?.Get<bool?>("isExternalShareTemplateEnabled"); }
            set { BackingStore?.Set("isExternalShareTemplateEnabled", value); }
        }
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
        /// Instantiates a new FormsSettings and sets the default values.
        /// </summary>
        public FormsSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FormsSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FormsSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isBingImageSearchEnabled", n => { IsBingImageSearchEnabled = n.GetBoolValue(); } },
                {"isExternalSendFormEnabled", n => { IsExternalSendFormEnabled = n.GetBoolValue(); } },
                {"isExternalShareCollaborationEnabled", n => { IsExternalShareCollaborationEnabled = n.GetBoolValue(); } },
                {"isExternalShareResultEnabled", n => { IsExternalShareResultEnabled = n.GetBoolValue(); } },
                {"isExternalShareTemplateEnabled", n => { IsExternalShareTemplateEnabled = n.GetBoolValue(); } },
                {"isInOrgFormsPhishingScanEnabled", n => { IsInOrgFormsPhishingScanEnabled = n.GetBoolValue(); } },
                {"isRecordIdentityByDefaultEnabled", n => { IsRecordIdentityByDefaultEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isBingImageSearchEnabled", IsBingImageSearchEnabled);
            writer.WriteBoolValue("isExternalSendFormEnabled", IsExternalSendFormEnabled);
            writer.WriteBoolValue("isExternalShareCollaborationEnabled", IsExternalShareCollaborationEnabled);
            writer.WriteBoolValue("isExternalShareResultEnabled", IsExternalShareResultEnabled);
            writer.WriteBoolValue("isExternalShareTemplateEnabled", IsExternalShareTemplateEnabled);
            writer.WriteBoolValue("isInOrgFormsPhishingScanEnabled", IsInOrgFormsPhishingScanEnabled);
            writer.WriteBoolValue("isRecordIdentityByDefaultEnabled", IsRecordIdentityByDefaultEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
