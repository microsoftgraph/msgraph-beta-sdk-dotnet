using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingCapability : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Indicates whether anonymous users dialout is allowed in a meeting.</summary>
        public bool? AllowAnonymousUsersToDialOut {
            get { return BackingStore?.Get<bool?>(nameof(AllowAnonymousUsersToDialOut)); }
            set { BackingStore?.Set(nameof(AllowAnonymousUsersToDialOut), value); }
        }
        /// <summary>Indicates whether anonymous users are allowed to start a meeting.</summary>
        public bool? AllowAnonymousUsersToStartMeeting {
            get { return BackingStore?.Get<bool?>(nameof(AllowAnonymousUsersToStartMeeting)); }
            set { BackingStore?.Set(nameof(AllowAnonymousUsersToStartMeeting), value); }
        }
        /// <summary>Possible values are: everyoneInCompany, everyone.</summary>
        public AutoAdmittedUsersType? AutoAdmittedUsers {
            get { return BackingStore?.Get<AutoAdmittedUsersType?>(nameof(AutoAdmittedUsers)); }
            set { BackingStore?.Set(nameof(AutoAdmittedUsers), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new meetingCapability and sets the default values.
        /// </summary>
        public MeetingCapability() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingCapability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingCapability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowAnonymousUsersToDialOut", n => { AllowAnonymousUsersToDialOut = n.GetBoolValue(); } },
                {"allowAnonymousUsersToStartMeeting", n => { AllowAnonymousUsersToStartMeeting = n.GetBoolValue(); } },
                {"autoAdmittedUsers", n => { AutoAdmittedUsers = n.GetEnumValue<AutoAdmittedUsersType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAnonymousUsersToDialOut", AllowAnonymousUsersToDialOut);
            writer.WriteBoolValue("allowAnonymousUsersToStartMeeting", AllowAnonymousUsersToStartMeeting);
            writer.WriteEnumValue<AutoAdmittedUsersType>("autoAdmittedUsers", AutoAdmittedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
