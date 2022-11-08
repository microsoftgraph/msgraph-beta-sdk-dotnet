using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftApplicationDataAccessSettings : Entity, IParsable {
        /// <summary>The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.</summary>
        public string DisabledForGroup {
            get { return BackingStore?.Get<string>("disabledForGroup"); }
            set { BackingStore?.Set("disabledForGroup", value); }
        }
        /// <summary>When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.</summary>
        public bool? IsEnabledForAllMicrosoftApplications {
            get { return BackingStore?.Get<bool?>("isEnabledForAllMicrosoftApplications"); }
            set { BackingStore?.Set("isEnabledForAllMicrosoftApplications", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftApplicationDataAccessSettings and sets the default values.
        /// </summary>
        public MicrosoftApplicationDataAccessSettings() : base() {
            OdataType = "#microsoft.graph.microsoftApplicationDataAccessSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftApplicationDataAccessSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftApplicationDataAccessSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"disabledForGroup", n => { DisabledForGroup = n.GetStringValue(); } },
                {"isEnabledForAllMicrosoftApplications", n => { IsEnabledForAllMicrosoftApplications = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("disabledForGroup", DisabledForGroup);
            writer.WriteBoolValue("isEnabledForAllMicrosoftApplications", IsEnabledForAllMicrosoftApplications);
        }
    }
}
