using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationProfile : Entity, IParsable {
        /// <summary>The dataProvider property</summary>
        public EducationSynchronizationDataProvider DataProvider { get; set; }
        /// <summary>Name of the configuration profile for syncing identities.</summary>
        public string DisplayName { get; set; }
        /// <summary>All errors associated with this synchronization profile.</summary>
        public List<EducationSynchronizationError> Errors { get; set; }
        /// <summary>The date the profile should be considered expired and cease syncing. Provide the date in YYYY-MM-DD format, following ISO 8601. Maximum value is 18 months from profile creation.  (optional)</summary>
        public Date? ExpirationDate { get; set; }
        /// <summary>Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.</summary>
        public bool? HandleSpecialCharacterConstraint { get; set; }
        /// <summary>The identitySynchronizationConfiguration property</summary>
        public EducationIdentitySynchronizationConfiguration IdentitySynchronizationConfiguration { get; set; }
        /// <summary>License setup configuration.</summary>
        public List<EducationSynchronizationLicenseAssignment> LicensesToAssign { get; set; }
        /// <summary>The synchronization status.</summary>
        public EducationSynchronizationProfileStatus ProfileStatus { get; set; }
        /// <summary>The state of the profile. Possible values are: provisioning, provisioned, provisioningFailed, deleting, deletionFailed.</summary>
        public EducationSynchronizationProfileState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSynchronizationProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataProvider", n => { DataProvider = n.GetObjectValue<EducationSynchronizationDataProvider>(EducationSynchronizationDataProvider.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<EducationSynchronizationError>(EducationSynchronizationError.CreateFromDiscriminatorValue).ToList(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"handleSpecialCharacterConstraint", n => { HandleSpecialCharacterConstraint = n.GetBoolValue(); } },
                {"identitySynchronizationConfiguration", n => { IdentitySynchronizationConfiguration = n.GetObjectValue<EducationIdentitySynchronizationConfiguration>(EducationIdentitySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                {"licensesToAssign", n => { LicensesToAssign = n.GetCollectionOfObjectValues<EducationSynchronizationLicenseAssignment>(EducationSynchronizationLicenseAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"profileStatus", n => { ProfileStatus = n.GetObjectValue<EducationSynchronizationProfileStatus>(EducationSynchronizationProfileStatus.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<EducationSynchronizationProfileState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationDataProvider>("dataProvider", DataProvider);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationError>("errors", Errors);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteBoolValue("handleSpecialCharacterConstraint", HandleSpecialCharacterConstraint);
            writer.WriteObjectValue<EducationIdentitySynchronizationConfiguration>("identitySynchronizationConfiguration", IdentitySynchronizationConfiguration);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationLicenseAssignment>("licensesToAssign", LicensesToAssign);
            writer.WriteObjectValue<EducationSynchronizationProfileStatus>("profileStatus", ProfileStatus);
            writer.WriteEnumValue<EducationSynchronizationProfileState>("state", State);
        }
    }
}
