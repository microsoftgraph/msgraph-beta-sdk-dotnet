using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class RetentionLabelSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The behaviorDuringRetentionPeriod property</summary>
        public Microsoft.Graph.Beta.Models.Security.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.BehaviorDuringRetentionPeriod?>("behaviorDuringRetentionPeriod"); }
            set { BackingStore?.Set("behaviorDuringRetentionPeriod", value); }
        }
        /// <summary>The isContentUpdateAllowed property</summary>
        public bool? IsContentUpdateAllowed {
            get { return BackingStore?.Get<bool?>("isContentUpdateAllowed"); }
            set { BackingStore?.Set("isContentUpdateAllowed", value); }
        }
        /// <summary>The isDeleteAllowed property</summary>
        public bool? IsDeleteAllowed {
            get { return BackingStore?.Get<bool?>("isDeleteAllowed"); }
            set { BackingStore?.Set("isDeleteAllowed", value); }
        }
        /// <summary>The isLabelUpdateAllowed property</summary>
        public bool? IsLabelUpdateAllowed {
            get { return BackingStore?.Get<bool?>("isLabelUpdateAllowed"); }
            set { BackingStore?.Set("isLabelUpdateAllowed", value); }
        }
        /// <summary>The isMetadataUpdateAllowed property</summary>
        public bool? IsMetadataUpdateAllowed {
            get { return BackingStore?.Get<bool?>("isMetadataUpdateAllowed"); }
            set { BackingStore?.Set("isMetadataUpdateAllowed", value); }
        }
        /// <summary>The isRecordLocked property</summary>
        public bool? IsRecordLocked {
            get { return BackingStore?.Get<bool?>("isRecordLocked"); }
            set { BackingStore?.Set("isRecordLocked", value); }
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
        /// Instantiates a new retentionLabelSettings and sets the default values.
        /// </summary>
        public RetentionLabelSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RetentionLabelSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionLabelSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"behaviorDuringRetentionPeriod", n => { BehaviorDuringRetentionPeriod = n.GetEnumValue<BehaviorDuringRetentionPeriod>(); } },
                {"isContentUpdateAllowed", n => { IsContentUpdateAllowed = n.GetBoolValue(); } },
                {"isDeleteAllowed", n => { IsDeleteAllowed = n.GetBoolValue(); } },
                {"isLabelUpdateAllowed", n => { IsLabelUpdateAllowed = n.GetBoolValue(); } },
                {"isMetadataUpdateAllowed", n => { IsMetadataUpdateAllowed = n.GetBoolValue(); } },
                {"isRecordLocked", n => { IsRecordLocked = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BehaviorDuringRetentionPeriod>("behaviorDuringRetentionPeriod", BehaviorDuringRetentionPeriod);
            writer.WriteBoolValue("isContentUpdateAllowed", IsContentUpdateAllowed);
            writer.WriteBoolValue("isDeleteAllowed", IsDeleteAllowed);
            writer.WriteBoolValue("isLabelUpdateAllowed", IsLabelUpdateAllowed);
            writer.WriteBoolValue("isMetadataUpdateAllowed", IsMetadataUpdateAllowed);
            writer.WriteBoolValue("isRecordLocked", IsRecordLocked);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
