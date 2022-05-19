using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specify access control level per privacy data category</summary>
    public class WindowsPrivacyDataAccessControlItem : Entity, IParsable {
        /// <summary>This indicates an access level for the privacy data category to which the specified application will be given to. Possible values are: notConfigured, forceAllow, forceDeny, userInControl.</summary>
        public WindowsPrivacyDataAccessLevel? AccessLevel {
            get { return BackingStore?.Get<WindowsPrivacyDataAccessLevel?>(nameof(AccessLevel)); }
            set { BackingStore?.Set(nameof(AccessLevel), value); }
        }
        /// <summary>The Package Family Name of a Windows app. When set, the access level applies to the specified application.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>The Package Family Name of a Windows app. When set, the access level applies to the specified application.</summary>
        public string AppPackageFamilyName {
            get { return BackingStore?.Get<string>(nameof(AppPackageFamilyName)); }
            set { BackingStore?.Set(nameof(AppPackageFamilyName), value); }
        }
        /// <summary>This indicates a privacy data category to which the specific access control will apply. Possible values are: notConfigured, accountInfo, appsRunInBackground, calendar, callHistory, camera, contacts, diagnosticsInfo, email, location, messaging, microphone, motion, notifications, phone, radios, tasks, syncWithDevices, trustedDevices.</summary>
        public WindowsPrivacyDataCategory? DataCategory {
            get { return BackingStore?.Get<WindowsPrivacyDataCategory?>(nameof(DataCategory)); }
            set { BackingStore?.Set(nameof(DataCategory), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPrivacyDataAccessControlItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPrivacyDataAccessControlItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessLevel", n => { AccessLevel = n.GetEnumValue<WindowsPrivacyDataAccessLevel>(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appPackageFamilyName", n => { AppPackageFamilyName = n.GetStringValue(); } },
                {"dataCategory", n => { DataCategory = n.GetEnumValue<WindowsPrivacyDataCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsPrivacyDataAccessLevel>("accessLevel", AccessLevel);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appPackageFamilyName", AppPackageFamilyName);
            writer.WriteEnumValue<WindowsPrivacyDataCategory>("dataCategory", DataCategory);
        }
    }
}
