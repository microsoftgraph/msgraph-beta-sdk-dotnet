using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SignInActivity : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The last non-interactive sign-in date for a specific user. You can use this field to calculate the last time a client attempted to sign into the directory the directory on behalf of a user. Because some users may use clients to access tenant resources rather than signing into your tenant directly, you can use the non-interactive sign-in date to along with lastSignInDateTime to identify inactive users. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is: &apos;2014-01-01T00:00:00Z&apos;. Azure AD maintains non-interactive sign-ins going back to May 2020. For more information about using the value of this property, see Manage inactive user accounts in Azure AD.</summary>
        public DateTimeOffset? LastNonInteractiveSignInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastNonInteractiveSignInDateTime"); }
            set { BackingStore?.Set("lastNonInteractiveSignInDateTime", value); }
        }
        /// <summary>Request identifier of the last non-interactive sign-in performed by this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastNonInteractiveSignInRequestId {
            get { return BackingStore?.Get<string?>("lastNonInteractiveSignInRequestId"); }
            set { BackingStore?.Set("lastNonInteractiveSignInRequestId", value); }
        }
#nullable restore
#else
        public string LastNonInteractiveSignInRequestId {
            get { return BackingStore?.Get<string>("lastNonInteractiveSignInRequestId"); }
            set { BackingStore?.Set("lastNonInteractiveSignInRequestId", value); }
        }
#endif
        /// <summary>The last interactive sign-in date and time for a specific user. You can use this field to calculate the last time a user attempted to sign into the directory the directory with an interactive authentication method. This field can be used to build reports, such as inactive users. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is: &apos;2014-01-01T00:00:00Z&apos;. Azure AD maintains interactive sign-ins going back to April 2020. For more information about using the value of this property, see Manage inactive user accounts in Azure AD.</summary>
        public DateTimeOffset? LastSignInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSignInDateTime"); }
            set { BackingStore?.Set("lastSignInDateTime", value); }
        }
        /// <summary>Request identifier of the last interactive sign-in performed by this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastSignInRequestId {
            get { return BackingStore?.Get<string?>("lastSignInRequestId"); }
            set { BackingStore?.Set("lastSignInRequestId", value); }
        }
#nullable restore
#else
        public string LastSignInRequestId {
            get { return BackingStore?.Get<string>("lastSignInRequestId"); }
            set { BackingStore?.Set("lastSignInRequestId", value); }
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
        /// <summary>
        /// Instantiates a new signInActivity and sets the default values.
        /// </summary>
        public SignInActivity() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SignInActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignInActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lastNonInteractiveSignInDateTime", n => { LastNonInteractiveSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastNonInteractiveSignInRequestId", n => { LastNonInteractiveSignInRequestId = n.GetStringValue(); } },
                {"lastSignInDateTime", n => { LastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSignInRequestId", n => { LastSignInRequestId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastNonInteractiveSignInDateTime", LastNonInteractiveSignInDateTime);
            writer.WriteStringValue("lastNonInteractiveSignInRequestId", LastNonInteractiveSignInRequestId);
            writer.WriteDateTimeOffsetValue("lastSignInDateTime", LastSignInDateTime);
            writer.WriteStringValue("lastSignInRequestId", LastSignInRequestId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
