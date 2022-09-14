using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class NotificationChannel : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The notificationChannelType property</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannelType? NotificationChannelType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.NotificationChannelType?>("notificationChannelType"); }
            set { BackingStore?.Set("notificationChannelType", value); }
        }
        /// <summary>The notificationReceivers property</summary>
        public List<NotificationReceiver> NotificationReceivers {
            get { return BackingStore?.Get<List<NotificationReceiver>>("notificationReceivers"); }
            set { BackingStore?.Set("notificationReceivers", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The receivers property</summary>
        public List<string> Receivers {
            get { return BackingStore?.Get<List<string>>("receivers"); }
            set { BackingStore?.Set("receivers", value); }
        }
        /// <summary>
        /// Instantiates a new notificationChannel and sets the default values.
        /// </summary>
        public NotificationChannel() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceManagement.notificationChannel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
