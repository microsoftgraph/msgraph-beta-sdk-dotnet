using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UnifiedRoleManagementPolicyRuleTarget : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The caller for the policy rule target. Allowed values are: None, Admin, EndUser.</summary>
        public string Caller { get; set; }
        /// <summary>The list of settings which are enforced and cannot be overridden by child scopes. Use All for all settings.</summary>
        public List<string> EnforcedSettings { get; set; }
        /// <summary>The list of settings which can be inherited by child scopes. Use All for all settings.</summary>
        public List<string> InheritableSettings { get; set; }
        /// <summary>The level for the policy rule target. Allowed values are: Eligibility, Assignment.</summary>
        public string Level { get; set; }
        /// <summary>The operations for policy rule target. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.</summary>
        public List<string> Operations { get; set; }
        public List<DirectoryObject> TargetObjects { get; set; }
        /// <summary>
        /// Instantiates a new unifiedRoleManagementPolicyRuleTarget and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyRuleTarget() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"caller", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).Caller = n.GetStringValue(); } },
                {"enforcedSettings", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).EnforcedSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inheritableSettings", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).InheritableSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"level", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).Level = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).Operations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"targetObjects", (o,n) => { (o as UnifiedRoleManagementPolicyRuleTarget).TargetObjects = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("caller", Caller);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSettings", EnforcedSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("inheritableSettings", InheritableSettings);
            writer.WriteStringValue("level", Level);
            writer.WriteCollectionOfPrimitiveValues<string>("operations", Operations);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("targetObjects", TargetObjects);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
