using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserRegistrationMethodSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Total number of users in the tenant.</summary>
        public long? TotalUserCount {
            get { return BackingStore?.Get<long?>(nameof(TotalUserCount)); }
            set { BackingStore?.Set(nameof(TotalUserCount), value); }
        }
        /// <summary>Number of users registered for each authentication method.</summary>
        public List<UserRegistrationMethodCount> UserRegistrationMethodCounts {
            get { return BackingStore?.Get<List<UserRegistrationMethodCount>>(nameof(UserRegistrationMethodCounts)); }
            set { BackingStore?.Set(nameof(UserRegistrationMethodCounts), value); }
        }
        /// <summary>User role type. Possible values are: all, privilegedAdmin, admin, user.</summary>
        public IncludedUserRoles? UserRoles {
            get { return BackingStore?.Get<IncludedUserRoles?>(nameof(UserRoles)); }
            set { BackingStore?.Set(nameof(UserRoles), value); }
        }
        /// <summary>User type. Possible values are: all, member, guest.</summary>
        public IncludedUserTypes? UserTypes {
            get { return BackingStore?.Get<IncludedUserTypes?>(nameof(UserTypes)); }
            set { BackingStore?.Set(nameof(UserTypes), value); }
        }
        /// <summary>
        /// Instantiates a new UserRegistrationMethodSummary and sets the default values.
        /// </summary>
        public UserRegistrationMethodSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationMethodSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationMethodSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationMethodCounts", n => { UserRegistrationMethodCounts = n.GetCollectionOfObjectValues<UserRegistrationMethodCount>(UserRegistrationMethodCount.CreateFromDiscriminatorValue).ToList(); } },
                {"userRoles", n => { UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", n => { UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationMethodCount>("userRegistrationMethodCounts", UserRegistrationMethodCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
