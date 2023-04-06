using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceRegistrationPolicy : Entity, IParsable {
        /// <summary>Specifies the authorization policy for controlling registration of new devices using Azure AD Join within your organization. Required. For more information, see What is a device identity?.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AzureAdJoinPolicy? AzureADJoin {
            get { return BackingStore?.Get<AzureAdJoinPolicy?>("azureADJoin"); }
            set { BackingStore?.Set("azureADJoin", value); }
        }
#nullable restore
#else
        public AzureAdJoinPolicy AzureADJoin {
            get { return BackingStore?.Get<AzureAdJoinPolicy>("azureADJoin"); }
            set { BackingStore?.Set("azureADJoin", value); }
        }
#endif
        /// <summary>Specifies the authorization policy for controlling registration of new devices using Azure AD registered within your organization. Required. For more information, see What is a device identity?.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AzureADRegistrationPolicy? AzureADRegistration {
            get { return BackingStore?.Get<AzureADRegistrationPolicy?>("azureADRegistration"); }
            set { BackingStore?.Set("azureADRegistration", value); }
        }
#nullable restore
#else
        public AzureADRegistrationPolicy AzureADRegistration {
            get { return BackingStore?.Get<AzureADRegistrationPolicy>("azureADRegistration"); }
            set { BackingStore?.Set("azureADRegistration", value); }
        }
#endif
        /// <summary>The description of the device registration policy. It is always set to Tenant-wide policy that manages intial provisioning controls using quota restrictions, additional authentication and authorization checks. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of the device registration policy. It is always set to Device Registration Policy. Read-only.</summary>
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
        /// <summary>The multiFactorAuthConfiguration property</summary>
        public Microsoft.Graph.Beta.Models.MultiFactorAuthConfiguration? MultiFactorAuthConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MultiFactorAuthConfiguration?>("multiFactorAuthConfiguration"); }
            set { BackingStore?.Set("multiFactorAuthConfiguration", value); }
        }
        /// <summary>Specifies the maximum number of devices that a user can have within your organization before blocking new device registrations. The default value is set to 50. If this property is not specified during the policy update operation, it is automatically reset to 0 to indicate that users are not allowed to join any devices.</summary>
        public int? UserDeviceQuota {
            get { return BackingStore?.Get<int?>("userDeviceQuota"); }
            set { BackingStore?.Set("userDeviceQuota", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
