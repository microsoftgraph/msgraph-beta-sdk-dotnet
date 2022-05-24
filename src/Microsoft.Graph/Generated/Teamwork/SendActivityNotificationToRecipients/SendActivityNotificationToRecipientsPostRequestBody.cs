using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Teamwork.SendActivityNotificationToRecipients {
    /// <summary>Provides operations to call the sendActivityNotificationToRecipients method.</summary>
    public class SendActivityNotificationToRecipientsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The activityType property</summary>
        public string ActivityType {
            get { return BackingStore?.Get<string>(nameof(ActivityType)); }
            set { BackingStore?.Set(nameof(ActivityType), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The chainId property</summary>
        public long? ChainId {
            get { return BackingStore?.Get<long?>(nameof(ChainId)); }
            set { BackingStore?.Set(nameof(ChainId), value); }
        }
        /// <summary>The previewText property</summary>
        public ItemBody PreviewText {
            get { return BackingStore?.Get<ItemBody>(nameof(PreviewText)); }
            set { BackingStore?.Set(nameof(PreviewText), value); }
        }
        /// <summary>The recipients property</summary>
        public List<TeamworkNotificationRecipient> Recipients {
            get { return BackingStore?.Get<List<TeamworkNotificationRecipient>>(nameof(Recipients)); }
            set { BackingStore?.Set(nameof(Recipients), value); }
        }
        /// <summary>The teamsAppId property</summary>
        public string TeamsAppId {
            get { return BackingStore?.Get<string>(nameof(TeamsAppId)); }
            set { BackingStore?.Set(nameof(TeamsAppId), value); }
        }
        /// <summary>The templateParameters property</summary>
        public List<Microsoft.Graph.Beta.Models.KeyValuePair> TemplateParameters {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>>(nameof(TemplateParameters)); }
            set { BackingStore?.Set(nameof(TemplateParameters), value); }
        }
        /// <summary>The topic property</summary>
        public TeamworkActivityTopic Topic {
            get { return BackingStore?.Get<TeamworkActivityTopic>(nameof(Topic)); }
            set { BackingStore?.Set(nameof(Topic), value); }
        }
        /// <summary>
        /// Instantiates a new sendActivityNotificationToRecipientsPostRequestBody and sets the default values.
        /// </summary>
        public SendActivityNotificationToRecipientsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendActivityNotificationToRecipientsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendActivityNotificationToRecipientsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"chainId", n => { ChainId = n.GetLongValue(); } },
                {"previewText", n => { PreviewText = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<TeamworkNotificationRecipient>(TeamworkNotificationRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"templateParameters", n => { TemplateParameters = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>(Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"topic", n => { Topic = n.GetObjectValue<TeamworkActivityTopic>(TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteCollectionOfObjectValues<TeamworkNotificationRecipient>("recipients", Recipients);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
