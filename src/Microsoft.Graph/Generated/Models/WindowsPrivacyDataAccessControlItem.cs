using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specify access control level per privacy data category</summary>
    public class WindowsPrivacyDataAccessControlItem : Entity, IParsable {
        /// <summary>Determine the access level to specific Windows privacy data category.</summary>
        public WindowsPrivacyDataAccessLevel? AccessLevel {
            get { return BackingStore?.Get<WindowsPrivacyDataAccessLevel?>("accessLevel"); }
            set { BackingStore?.Set("accessLevel", value); }
        }
        /// <summary>The Package Family Name of a Windows app. When set, the access level applies to the specified application.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
        /// <summary>The Package Family Name of a Windows app. When set, the access level applies to the specified application.</summary>
        public string AppPackageFamilyName {
            get { return BackingStore?.Get<string>("appPackageFamilyName"); }
            set { BackingStore?.Set("appPackageFamilyName", value); }
        }
        /// <summary>Windows privacy data category specifier for privacy data access.</summary>
        public WindowsPrivacyDataCategory? DataCategory {
            get { return BackingStore?.Get<WindowsPrivacyDataCategory?>("dataCategory"); }
            set { BackingStore?.Set("dataCategory", value); }
        }
        /// <summary>
        /// Instantiates a new windowsPrivacyDataAccessControlItem and sets the default values.
        /// </summary>
        public WindowsPrivacyDataAccessControlItem() : base() {
            OdataType = "#microsoft.graph.windowsPrivacyDataAccessControlItem";
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
