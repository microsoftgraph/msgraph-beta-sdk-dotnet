using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.SendCustomNotificationToCompanyPortal {
    /// <summary>Provides operations to call the sendCustomNotificationToCompanyPortal method.</summary>
    public class SendCustomNotificationToCompanyPortalRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupsToNotify property</summary>
        public List<string> GroupsToNotify { get; set; }
        /// <summary>The notificationBody property</summary>
        public string NotificationBody { get; set; }
        /// <summary>The notificationTitle property</summary>
        public string NotificationTitle { get; set; }
        /// <summary>
        /// Instantiates a new sendCustomNotificationToCompanyPortalRequestBody and sets the default values.
        /// </summary>
        public SendCustomNotificationToCompanyPortalRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendCustomNotificationToCompanyPortalRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendCustomNotificationToCompanyPortalRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupsToNotify", n => { GroupsToNotify = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("groupsToNotify", GroupsToNotify);
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
