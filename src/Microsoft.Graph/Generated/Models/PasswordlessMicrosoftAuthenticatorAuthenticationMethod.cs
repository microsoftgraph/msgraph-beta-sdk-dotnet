using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PasswordlessMicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The timestamp when this method was registered to the user.</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Device? Device {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Device?>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Device Device {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Device>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#endif
        /// <summary>The display name of the mobile device as given by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new passwordlessMicrosoftAuthenticatorAuthenticationMethod and sets the default values.
        /// </summary>
        public PasswordlessMicrosoftAuthenticatorAuthenticationMethod() : base() {
            OdataType = "#microsoft.graph.passwordlessMicrosoftAuthenticatorAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PasswordlessMicrosoftAuthenticatorAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordlessMicrosoftAuthenticatorAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", n => { Device = n.GetObjectValue<Microsoft.Graph.Beta.Models.Device>(Microsoft.Graph.Beta.Models.Device.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
