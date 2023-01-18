using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The security baseline compliance state of a setting for a device
    /// </summary>
    public class SecurityBaselineSettingState : Entity, IParsable {
        /// <summary>The policies that contribute to this setting instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SecurityBaselineContributingPolicy>? ContributingPolicies {
            get { return BackingStore?.Get<List<SecurityBaselineContributingPolicy>?>("contributingPolicies"); }
            set { BackingStore?.Set("contributingPolicies", value); }
        }
#else
        public List<SecurityBaselineContributingPolicy> ContributingPolicies {
            get { return BackingStore?.Get<List<SecurityBaselineContributingPolicy>>("contributingPolicies"); }
            set { BackingStore?.Set("contributingPolicies", value); }
        }
#endif
        /// <summary>The error code if the setting is in error state</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ErrorCode {
            get { return BackingStore?.Get<string?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#else
        public string ErrorCode {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#endif
        /// <summary>The setting category id which this setting belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SettingCategoryId {
            get { return BackingStore?.Get<string?>("settingCategoryId"); }
            set { BackingStore?.Set("settingCategoryId", value); }
        }
#else
        public string SettingCategoryId {
            get { return BackingStore?.Get<string>("settingCategoryId"); }
            set { BackingStore?.Set("settingCategoryId", value); }
        }
#endif
        /// <summary>The setting category name which this setting belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SettingCategoryName {
            get { return BackingStore?.Get<string?>("settingCategoryName"); }
            set { BackingStore?.Set("settingCategoryName", value); }
        }
#else
        public string SettingCategoryName {
            get { return BackingStore?.Get<string>("settingCategoryName"); }
            set { BackingStore?.Set("settingCategoryName", value); }
        }
#endif
        /// <summary>The setting id guid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SettingId {
            get { return BackingStore?.Get<string?>("settingId"); }
            set { BackingStore?.Set("settingId", value); }
        }
#else
        public string SettingId {
            get { return BackingStore?.Get<string>("settingId"); }
            set { BackingStore?.Set("settingId", value); }
        }
#endif
        /// <summary>The setting name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SettingName {
            get { return BackingStore?.Get<string?>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#else
        public string SettingName {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#endif
        /// <summary>The policies that contribute to this setting instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SettingSource>? SourcePolicies {
            get { return BackingStore?.Get<List<SettingSource>?>("sourcePolicies"); }
            set { BackingStore?.Set("sourcePolicies", value); }
        }
#else
        public List<SettingSource> SourcePolicies {
            get { return BackingStore?.Get<List<SettingSource>>("sourcePolicies"); }
            set { BackingStore?.Set("sourcePolicies", value); }
        }
#endif
        /// <summary>Security Baseline Compliance State</summary>
        public SecurityBaselineComplianceState? State {
            get { return BackingStore?.Get<SecurityBaselineComplianceState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contributingPolicies", n => { ContributingPolicies = n.GetCollectionOfObjectValues<SecurityBaselineContributingPolicy>(SecurityBaselineContributingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"settingCategoryId", n => { SettingCategoryId = n.GetStringValue(); } },
                {"settingCategoryName", n => { SettingCategoryName = n.GetStringValue(); } },
                {"settingId", n => { SettingId = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"sourcePolicies", n => { SourcePolicies = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
