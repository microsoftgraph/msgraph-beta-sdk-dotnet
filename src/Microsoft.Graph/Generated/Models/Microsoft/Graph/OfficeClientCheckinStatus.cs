using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OfficeClientCheckinStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of policies delivered to the device as last checkin.</summary>
        public List<string> AppliedPolicies { get; set; }
        /// <summary>Last device check-in time in UTC.</summary>
        public DateTimeOffset? CheckinDateTime { get; set; }
        /// <summary>Device name trying to check-in.</summary>
        public string DeviceName { get; set; }
        /// <summary>Device platform trying to check-in.</summary>
        public string DevicePlatform { get; set; }
        /// <summary>Device platform version trying to check-in.</summary>
        public string DevicePlatformVersion { get; set; }
        /// <summary>Error message if any associated for the last checkin.</summary>
        public string ErrorMessage { get; set; }
        /// <summary>User identifier using the device.</summary>
        public string UserId { get; set; }
        /// <summary>User principal name using the device.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>If the last checkin was successful.</summary>
        public bool? WasSuccessful { get; set; }
        /// <summary>
        /// Instantiates a new officeClientCheckinStatus and sets the default values.
        /// </summary>
        public OfficeClientCheckinStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OfficeClientCheckinStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeClientCheckinStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appliedPolicies", (o,n) => { (o as OfficeClientCheckinStatus).AppliedPolicies = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"checkinDateTime", (o,n) => { (o as OfficeClientCheckinStatus).CheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", (o,n) => { (o as OfficeClientCheckinStatus).DeviceName = n.GetStringValue(); } },
                {"devicePlatform", (o,n) => { (o as OfficeClientCheckinStatus).DevicePlatform = n.GetStringValue(); } },
                {"devicePlatformVersion", (o,n) => { (o as OfficeClientCheckinStatus).DevicePlatformVersion = n.GetStringValue(); } },
                {"errorMessage", (o,n) => { (o as OfficeClientCheckinStatus).ErrorMessage = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as OfficeClientCheckinStatus).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as OfficeClientCheckinStatus).UserPrincipalName = n.GetStringValue(); } },
                {"wasSuccessful", (o,n) => { (o as OfficeClientCheckinStatus).WasSuccessful = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("appliedPolicies", AppliedPolicies);
            writer.WriteDateTimeOffsetValue("checkinDateTime", CheckinDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("devicePlatform", DevicePlatform);
            writer.WriteStringValue("devicePlatformVersion", DevicePlatformVersion);
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteBoolValue("wasSuccessful", WasSuccessful);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
