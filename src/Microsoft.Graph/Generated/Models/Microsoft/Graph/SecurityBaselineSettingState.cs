using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SecurityBaselineSettingState : Entity, IParsable {
        /// <summary>The policies that contribute to this setting instance</summary>
        public List<SecurityBaselineContributingPolicy> ContributingPolicies { get; set; }
        /// <summary>The error code if the setting is in error state</summary>
        public string ErrorCode { get; set; }
        /// <summary>The setting category id which this setting belongs to</summary>
        public string SettingCategoryId { get; set; }
        /// <summary>The setting category name which this setting belongs to</summary>
        public string SettingCategoryName { get; set; }
        /// <summary>The setting id guid</summary>
        public string SettingId { get; set; }
        /// <summary>The setting name that is being reported</summary>
        public string SettingName { get; set; }
        /// <summary>The policies that contribute to this setting instance</summary>
        public List<SettingSource> SourcePolicies { get; set; }
        /// <summary>The compliance state of the security baseline setting</summary>
        public SecurityBaselineComplianceState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityBaselineSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contributingPolicies", (o,n) => { (o as SecurityBaselineSettingState).ContributingPolicies = n.GetCollectionOfObjectValues<SecurityBaselineContributingPolicy>(SecurityBaselineContributingPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"errorCode", (o,n) => { (o as SecurityBaselineSettingState).ErrorCode = n.GetStringValue(); } },
                {"settingCategoryId", (o,n) => { (o as SecurityBaselineSettingState).SettingCategoryId = n.GetStringValue(); } },
                {"settingCategoryName", (o,n) => { (o as SecurityBaselineSettingState).SettingCategoryName = n.GetStringValue(); } },
                {"settingId", (o,n) => { (o as SecurityBaselineSettingState).SettingId = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as SecurityBaselineSettingState).SettingName = n.GetStringValue(); } },
                {"sourcePolicies", (o,n) => { (o as SecurityBaselineSettingState).SourcePolicies = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue).ToList(); } },
                {"state", (o,n) => { (o as SecurityBaselineSettingState).State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SecurityBaselineContributingPolicy>("contributingPolicies", ContributingPolicies);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("settingCategoryId", SettingCategoryId);
            writer.WriteStringValue("settingCategoryName", SettingCategoryName);
            writer.WriteStringValue("settingId", SettingId);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<SettingSource>("sourcePolicies", SourcePolicies);
            writer.WriteEnumValue<SecurityBaselineComplianceState>("state", State);
        }
    }
}
