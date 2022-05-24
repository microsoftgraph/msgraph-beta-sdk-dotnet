using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class WindowsHelloForBusinessAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time that this Windows Hello for Business key was registered.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The registered device on which this Windows Hello for Business key resides. Supports $expand. When you get a user&apos;s Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand. For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.</summary>
        public Microsoft.Graph.Beta.Models.Device Device {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Device>(nameof(Device)); }
            set { BackingStore?.Set(nameof(Device), value); }
        }
        /// <summary>The name of the device on which Windows Hello for Business is registered</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Key strength of this Windows Hello for Business key. Possible values are: normal, weak, unknown.</summary>
        public AuthenticationMethodKeyStrength? KeyStrength {
            get { return BackingStore?.Get<AuthenticationMethodKeyStrength?>(nameof(KeyStrength)); }
            set { BackingStore?.Set(nameof(KeyStrength), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsHelloForBusinessAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsHelloForBusinessAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", n => { Device = n.GetObjectValue<Microsoft.Graph.Beta.Models.Device>(Microsoft.Graph.Beta.Models.Device.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"keyStrength", n => { KeyStrength = n.GetEnumValue<AuthenticationMethodKeyStrength>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<AuthenticationMethodKeyStrength>("keyStrength", KeyStrength);
        }
    }
}
