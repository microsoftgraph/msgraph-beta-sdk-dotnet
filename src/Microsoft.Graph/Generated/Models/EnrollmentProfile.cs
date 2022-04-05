using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EnrollmentProfile : Entity, IParsable {
        /// <summary>Configuration endpoint url to use for Enrollment</summary>
        public string ConfigurationEndpointUrl { get; set; }
        /// <summary>Description of the profile</summary>
        public string Description { get; set; }
        /// <summary>Name of the profile</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates to authenticate with Apple Setup Assistant instead of Company Portal.</summary>
        public bool? EnableAuthenticationViaCompanyPortal { get; set; }
        /// <summary>Indicates that Company Portal is required on setup assistant enrolled devices</summary>
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }
        /// <summary>Indicates if the profile requires user authentication</summary>
        public bool? RequiresUserAuthentication { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationEndpointUrl", (o,n) => { (o as EnrollmentProfile).ConfigurationEndpointUrl = n.GetStringValue(); } },
                {"description", (o,n) => { (o as EnrollmentProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as EnrollmentProfile).DisplayName = n.GetStringValue(); } },
                {"enableAuthenticationViaCompanyPortal", (o,n) => { (o as EnrollmentProfile).EnableAuthenticationViaCompanyPortal = n.GetBoolValue(); } },
                {"requireCompanyPortalOnSetupAssistantEnrolledDevices", (o,n) => { (o as EnrollmentProfile).RequireCompanyPortalOnSetupAssistantEnrolledDevices = n.GetBoolValue(); } },
                {"requiresUserAuthentication", (o,n) => { (o as EnrollmentProfile).RequiresUserAuthentication = n.GetBoolValue(); } },
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
