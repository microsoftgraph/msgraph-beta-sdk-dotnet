using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class NotificationChannel : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of the notification channel. The possible values are: portal, email, phoneCall, sms, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannelType? NotificationChannelType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannelType?>("notificationChannelType"); }
            set { BackingStore?.Set("notificationChannelType", value); }
        }
        /// <summary>Information about the notification receivers, such as locale and contact information. For example, en-us for locale and serena.davis@contoso.com for contact information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationReceiver>? NotificationReceivers {
            get { return BackingStore?.Get<List<NotificationReceiver>?>("notificationReceivers"); }
            set { BackingStore?.Set("notificationReceivers", value); }
        }
#nullable restore
#else
        public List<NotificationReceiver> NotificationReceivers {
            get { return BackingStore?.Get<List<NotificationReceiver>>("notificationReceivers"); }
            set { BackingStore?.Set("notificationReceivers", value); }
        }
#endif
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
        /// <summary>The contact information about the notification receivers, such as email addresses. For portal notifications, receivers can be left blank. For email notifications, receivers consists of email addresses such as serena.davis@contoso.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Receivers {
            get { return BackingStore?.Get<List<string>?>("receivers"); }
            set { BackingStore?.Set("receivers", value); }
        }
#nullable restore
#else
        public List<string> Receivers {
            get { return BackingStore?.Get<List<string>>("receivers"); }
            set { BackingStore?.Set("receivers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new notificationChannel and sets the default values.
        /// </summary>
        public NotificationChannel() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NotificationChannel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotificationChannel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"notificationChannelType", n => { NotificationChannelType = n.GetEnumValue<NotificationChannelType>(); } },
                {"notificationReceivers", n => { NotificationReceivers = n.GetCollectionOfObjectValues<NotificationReceiver>(NotificationReceiver.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"receivers", n => { Receivers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<NotificationChannelType>("notificationChannelType", NotificationChannelType);
            writer.WriteCollectionOfObjectValues<NotificationReceiver>("notificationReceivers", NotificationReceivers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("receivers", Receivers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
