using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeClientCheckinStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appliedPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AppliedPolicies {
            get { return BackingStore?.Get<List<string>?>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#nullable restore
#else
        public List<string> AppliedPolicies {
            get { return BackingStore?.Get<List<string>>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The checkinDateTime property</summary>
        public DateTimeOffset? CheckinDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("checkinDateTime"); }
            set { BackingStore?.Set("checkinDateTime", value); }
        }
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The devicePlatform property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePlatform {
            get { return BackingStore?.Get<string?>("devicePlatform"); }
            set { BackingStore?.Set("devicePlatform", value); }
        }
#nullable restore
#else
        public string DevicePlatform {
            get { return BackingStore?.Get<string>("devicePlatform"); }
            set { BackingStore?.Set("devicePlatform", value); }
        }
#endif
        /// <summary>The devicePlatformVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePlatformVersion {
            get { return BackingStore?.Get<string?>("devicePlatformVersion"); }
            set { BackingStore?.Set("devicePlatformVersion", value); }
        }
#nullable restore
#else
        public string DevicePlatformVersion {
            get { return BackingStore?.Get<string>("devicePlatformVersion"); }
            set { BackingStore?.Set("devicePlatformVersion", value); }
        }
#endif
        /// <summary>The errorMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage {
            get { return BackingStore?.Get<string?>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#nullable restore
#else
        public string ErrorMessage {
            get { return BackingStore?.Get<string>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
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
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The userPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The wasSuccessful property</summary>
        public bool? WasSuccessful {
            get { return BackingStore?.Get<bool?>("wasSuccessful"); }
            set { BackingStore?.Set("wasSuccessful", value); }
        }
        /// <summary>
        /// Instantiates a new officeClientCheckinStatus and sets the default values.
        /// </summary>
        public OfficeClientCheckinStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OfficeClientCheckinStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeClientCheckinStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appliedPolicies", n => { AppliedPolicies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"checkinDateTime", n => { CheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"devicePlatform", n => { DevicePlatform = n.GetStringValue(); } },
                {"devicePlatformVersion", n => { DevicePlatformVersion = n.GetStringValue(); } },
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"wasSuccessful", n => { WasSuccessful = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("appliedPolicies", AppliedPolicies);
            writer.WriteDateTimeOffsetValue("checkinDateTime", CheckinDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("devicePlatform", DevicePlatform);
            writer.WriteStringValue("devicePlatformVersion", DevicePlatformVersion);
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteBoolValue("wasSuccessful", WasSuccessful);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
