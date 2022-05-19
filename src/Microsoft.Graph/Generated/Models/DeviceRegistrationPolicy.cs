using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceRegistrationPolicy singleton.</summary>
    public class DeviceRegistrationPolicy : Entity, IParsable {
        /// <summary>Specifies the authorization policy for controlling registration of new devices using Azure AD Join within your organization. Required. For more information, see What is a device identity?.</summary>
        public AzureAdJoinPolicy AzureADJoin {
            get { return BackingStore?.Get<AzureAdJoinPolicy>(nameof(AzureADJoin)); }
            set { BackingStore?.Set(nameof(AzureADJoin), value); }
        }
        /// <summary>Specifies the authorization policy for controlling registration of new devices using Azure AD registered within your organization. Required. For more information, see What is a device identity?.</summary>
        public AzureADRegistrationPolicy AzureADRegistration {
            get { return BackingStore?.Get<AzureADRegistrationPolicy>(nameof(AzureADRegistration)); }
            set { BackingStore?.Set(nameof(AzureADRegistration), value); }
        }
        /// <summary>The description of the device registration policy. It is always set to Tenant-wide policy that manages intial provisioning controls using quota restrictions, additional authentication and authorization checks. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The name of the device registration policy. It is always set to Device Registration Policy. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Specifies the authentication policy for a user to complete registration using Azure AD Join or Azure AD registered within your organization. The possible values are: 0 (meaning notRequired), 1 (meaning required), and 2 (meaning unknownFutureValue). The default value is 0.</summary>
        public Microsoft.Graph.Beta.Models.MultiFactorAuthConfiguration? MultiFactorAuthConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MultiFactorAuthConfiguration?>(nameof(MultiFactorAuthConfiguration)); }
            set { BackingStore?.Set(nameof(MultiFactorAuthConfiguration), value); }
        }
        /// <summary>Specifies the maximum number of devices that a user can have within your organization before blocking new device registrations. The default value is set to 50. If this property is not specified during the policy update operation, it is automatically reset to 0 to indicate that users are not allowed to join any devices.</summary>
        public int? UserDeviceQuota {
            get { return BackingStore?.Get<int?>(nameof(UserDeviceQuota)); }
            set { BackingStore?.Set(nameof(UserDeviceQuota), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceRegistrationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceRegistrationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureADJoin", n => { AzureADJoin = n.GetObjectValue<AzureAdJoinPolicy>(AzureAdJoinPolicy.CreateFromDiscriminatorValue); } },
                {"azureADRegistration", n => { AzureADRegistration = n.GetObjectValue<AzureADRegistrationPolicy>(AzureADRegistrationPolicy.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"multiFactorAuthConfiguration", n => { MultiFactorAuthConfiguration = n.GetEnumValue<MultiFactorAuthConfiguration>(); } },
                {"userDeviceQuota", n => { UserDeviceQuota = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AzureAdJoinPolicy>("azureADJoin", AzureADJoin);
            writer.WriteObjectValue<AzureADRegistrationPolicy>("azureADRegistration", AzureADRegistration);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<MultiFactorAuthConfiguration>("multiFactorAuthConfiguration", MultiFactorAuthConfiguration);
            writer.WriteIntValue("userDeviceQuota", UserDeviceQuota);
        }
    }
}
