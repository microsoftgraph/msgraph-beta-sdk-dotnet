using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EnrollmentProfile : Entity, IParsable {
        /// <summary>Configuration endpoint url to use for Enrollment</summary>
        public string ConfigurationEndpointUrl {
            get { return BackingStore?.Get<string>("configurationEndpointUrl"); }
            set { BackingStore?.Set("configurationEndpointUrl", value); }
        }
        /// <summary>Description of the profile</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Name of the profile</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Indicates to authenticate with Apple Setup Assistant instead of Company Portal.</summary>
        public bool? EnableAuthenticationViaCompanyPortal {
            get { return BackingStore?.Get<bool?>("enableAuthenticationViaCompanyPortal"); }
            set { BackingStore?.Set("enableAuthenticationViaCompanyPortal", value); }
        }
        /// <summary>Indicates that Company Portal is required on setup assistant enrolled devices</summary>
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices {
            get { return BackingStore?.Get<bool?>("requireCompanyPortalOnSetupAssistantEnrolledDevices"); }
            set { BackingStore?.Set("requireCompanyPortalOnSetupAssistantEnrolledDevices", value); }
        }
        /// <summary>Indicates if the profile requires user authentication</summary>
        public bool? RequiresUserAuthentication {
            get { return BackingStore?.Get<bool?>("requiresUserAuthentication"); }
            set { BackingStore?.Set("requiresUserAuthentication", value); }
        }
        /// <summary>
        /// Instantiates a new enrollmentProfile and sets the default values.
        /// </summary>
        public EnrollmentProfile() : base() {
            Type = "#microsoft.graph.enrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.depEnrollmentBaseProfile" => new DepEnrollmentBaseProfile(),
                "#microsoft.graph.depEnrollmentProfile" => new DepEnrollmentProfile(),
                _ => new EnrollmentProfile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationEndpointUrl", n => { ConfigurationEndpointUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enableAuthenticationViaCompanyPortal", n => { EnableAuthenticationViaCompanyPortal = n.GetBoolValue(); } },
                {"requireCompanyPortalOnSetupAssistantEnrolledDevices", n => { RequireCompanyPortalOnSetupAssistantEnrolledDevices = n.GetBoolValue(); } },
                {"requiresUserAuthentication", n => { RequiresUserAuthentication = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("configurationEndpointUrl", ConfigurationEndpointUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enableAuthenticationViaCompanyPortal", EnableAuthenticationViaCompanyPortal);
            writer.WriteBoolValue("requireCompanyPortalOnSetupAssistantEnrolledDevices", RequireCompanyPortalOnSetupAssistantEnrolledDevices);
            writer.WriteBoolValue("requiresUserAuthentication", RequiresUserAuthentication);
        }
    }
}
