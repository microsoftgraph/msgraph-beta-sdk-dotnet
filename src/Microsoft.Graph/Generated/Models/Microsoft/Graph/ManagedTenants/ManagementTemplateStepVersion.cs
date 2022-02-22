using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStepVersion : Entity, IParsable {
        public TemplateAction ConfigurationAction { get; set; }
        public List<ManagementTemplateStepDeployment> Deployments { get; set; }
        public ManagementTemplateStep TemplateStep { get; set; }
        public TemplateAction ValidationAction { get; set; }
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationAction", (o,n) => { (o as ManagementTemplateStepVersion).ConfigurationAction = n.GetObjectValue<TemplateAction>(); } },
                {"deployments", (o,n) => { (o as ManagementTemplateStepVersion).Deployments = n.GetCollectionOfObjectValues<ManagementTemplateStepDeployment>().ToList(); } },
                {"templateStep", (o,n) => { (o as ManagementTemplateStepVersion).TemplateStep = n.GetObjectValue<ManagementTemplateStep>(); } },
                {"validationAction", (o,n) => { (o as ManagementTemplateStepVersion).ValidationAction = n.GetObjectValue<TemplateAction>(); } },
                {"version", (o,n) => { (o as ManagementTemplateStepVersion).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TemplateAction>("configurationAction", ConfigurationAction);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepDeployment>("deployments", Deployments);
            writer.WriteObjectValue<ManagementTemplateStep>("templateStep", TemplateStep);
            writer.WriteObjectValue<TemplateAction>("validationAction", ValidationAction);
            writer.WriteIntValue("version", Version);
        }
    }
}
