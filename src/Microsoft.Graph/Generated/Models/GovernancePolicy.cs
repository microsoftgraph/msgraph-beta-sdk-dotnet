using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GovernancePolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The decisionMakerCriteria property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<GovernanceCriteria>? DecisionMakerCriteria {
            get { return BackingStore?.Get<List<GovernanceCriteria>?>("decisionMakerCriteria"); }
            set { BackingStore?.Set("decisionMakerCriteria", value); }
        }
#else
        public List<GovernanceCriteria> DecisionMakerCriteria {
            get { return BackingStore?.Get<List<GovernanceCriteria>>("decisionMakerCriteria"); }
            set { BackingStore?.Set("decisionMakerCriteria", value); }
        }
#endif
        /// <summary>The notificationPolicy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public GovernanceNotificationPolicy? NotificationPolicy {
            get { return BackingStore?.Get<GovernanceNotificationPolicy?>("notificationPolicy"); }
            set { BackingStore?.Set("notificationPolicy", value); }
        }
#else
        public GovernanceNotificationPolicy NotificationPolicy {
            get { return BackingStore?.Get<GovernanceNotificationPolicy>("notificationPolicy"); }
            set { BackingStore?.Set("notificationPolicy", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new governancePolicy and sets the default values.
        /// </summary>
        public GovernancePolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GovernancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decisionMakerCriteria", n => { DecisionMakerCriteria = n.GetCollectionOfObjectValues<GovernanceCriteria>(GovernanceCriteria.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notificationPolicy", n => { NotificationPolicy = n.GetObjectValue<GovernanceNotificationPolicy>(GovernanceNotificationPolicy.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GovernanceCriteria>("decisionMakerCriteria", DecisionMakerCriteria);
            writer.WriteObjectValue<GovernanceNotificationPolicy>("notificationPolicy", NotificationPolicy);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
