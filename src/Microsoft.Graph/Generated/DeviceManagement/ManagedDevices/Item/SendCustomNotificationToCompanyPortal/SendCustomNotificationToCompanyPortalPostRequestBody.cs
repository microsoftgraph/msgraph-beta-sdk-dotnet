using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SendCustomNotificationToCompanyPortal {
    /// <summary>Provides operations to call the sendCustomNotificationToCompanyPortal method.</summary>
    public class SendCustomNotificationToCompanyPortalPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The notificationBody property</summary>
        public string NotificationBody {
            get { return BackingStore?.Get<string>("notificationBody"); }
            set { BackingStore?.Set("notificationBody", value); }
        }
        /// <summary>The notificationTitle property</summary>
        public string NotificationTitle {
            get { return BackingStore?.Get<string>("notificationTitle"); }
            set { BackingStore?.Set("notificationTitle", value); }
        }
        /// <summary>
        /// Instantiates a new sendCustomNotificationToCompanyPortalPostRequestBody and sets the default values.
        /// </summary>
        public SendCustomNotificationToCompanyPortalPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SendCustomNotificationToCompanyPortalPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendCustomNotificationToCompanyPortalPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
