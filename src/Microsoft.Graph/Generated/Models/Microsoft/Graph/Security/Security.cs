using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Security {
    public class Security : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<Alert> Alerts { get; set; }
        public List<Alert> Alerts_v2 { get; set; }
        /// <summary>Provides tenants capability to launch a simulated and realistic phishing attack and learn from it.</summary>
        public AttackSimulationRoot AttackSimulation { get; set; }
        public List<CloudAppSecurityProfile> CloudAppSecurityProfiles { get; set; }
        public List<DomainSecurityProfile> DomainSecurityProfiles { get; set; }
        public List<FileSecurityProfile> FileSecurityProfiles { get; set; }
        public List<HostSecurityProfile> HostSecurityProfiles { get; set; }
        public List<Incident> Incidents { get; set; }
        public List<IpSecurityProfile> IpSecurityProfiles { get; set; }
        public List<SecurityProviderStatus> ProviderStatus { get; set; }
        public List<ProviderTenantSetting> ProviderTenantSettings { get; set; }
        public List<SecureScoreControlProfile> SecureScoreControlProfiles { get; set; }
        public List<SecureScore> SecureScores { get; set; }
        public List<SecurityAction> SecurityActions { get; set; }
        public List<TiIndicator> TiIndicators { get; set; }
        public List<UserSecurityProfile> UserSecurityProfiles { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"alerts", (o,n) => { (o as Security).Alerts = n.GetCollectionOfObjectValues<Alert>().ToList(); } },
                {"alerts_v2", (o,n) => { (o as Security).Alerts_v2 = n.GetCollectionOfObjectValues<Alert>().ToList(); } },
                {"attackSimulation", (o,n) => { (o as Security).AttackSimulation = n.GetObjectValue<AttackSimulationRoot>(); } },
                {"cloudAppSecurityProfiles", (o,n) => { (o as Security).CloudAppSecurityProfiles = n.GetCollectionOfObjectValues<CloudAppSecurityProfile>().ToList(); } },
                {"domainSecurityProfiles", (o,n) => { (o as Security).DomainSecurityProfiles = n.GetCollectionOfObjectValues<DomainSecurityProfile>().ToList(); } },
                {"fileSecurityProfiles", (o,n) => { (o as Security).FileSecurityProfiles = n.GetCollectionOfObjectValues<FileSecurityProfile>().ToList(); } },
                {"hostSecurityProfiles", (o,n) => { (o as Security).HostSecurityProfiles = n.GetCollectionOfObjectValues<HostSecurityProfile>().ToList(); } },
                {"incidents", (o,n) => { (o as Security).Incidents = n.GetCollectionOfObjectValues<Incident>().ToList(); } },
                {"ipSecurityProfiles", (o,n) => { (o as Security).IpSecurityProfiles = n.GetCollectionOfObjectValues<IpSecurityProfile>().ToList(); } },
                {"providerStatus", (o,n) => { (o as Security).ProviderStatus = n.GetCollectionOfObjectValues<SecurityProviderStatus>().ToList(); } },
                {"providerTenantSettings", (o,n) => { (o as Security).ProviderTenantSettings = n.GetCollectionOfObjectValues<ProviderTenantSetting>().ToList(); } },
                {"secureScoreControlProfiles", (o,n) => { (o as Security).SecureScoreControlProfiles = n.GetCollectionOfObjectValues<SecureScoreControlProfile>().ToList(); } },
                {"secureScores", (o,n) => { (o as Security).SecureScores = n.GetCollectionOfObjectValues<SecureScore>().ToList(); } },
                {"securityActions", (o,n) => { (o as Security).SecurityActions = n.GetCollectionOfObjectValues<SecurityAction>().ToList(); } },
                {"tiIndicators", (o,n) => { (o as Security).TiIndicators = n.GetCollectionOfObjectValues<TiIndicator>().ToList(); } },
                {"userSecurityProfiles", (o,n) => { (o as Security).UserSecurityProfiles = n.GetCollectionOfObjectValues<UserSecurityProfile>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Alert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<Alert>("alerts_v2", Alerts_v2);
            writer.WriteObjectValue<AttackSimulationRoot>("attackSimulation", AttackSimulation);
            writer.WriteCollectionOfObjectValues<CloudAppSecurityProfile>("cloudAppSecurityProfiles", CloudAppSecurityProfiles);
            writer.WriteCollectionOfObjectValues<DomainSecurityProfile>("domainSecurityProfiles", DomainSecurityProfiles);
            writer.WriteCollectionOfObjectValues<FileSecurityProfile>("fileSecurityProfiles", FileSecurityProfiles);
            writer.WriteCollectionOfObjectValues<HostSecurityProfile>("hostSecurityProfiles", HostSecurityProfiles);
            writer.WriteCollectionOfObjectValues<Incident>("incidents", Incidents);
            writer.WriteCollectionOfObjectValues<IpSecurityProfile>("ipSecurityProfiles", IpSecurityProfiles);
            writer.WriteCollectionOfObjectValues<SecurityProviderStatus>("providerStatus", ProviderStatus);
            writer.WriteCollectionOfObjectValues<ProviderTenantSetting>("providerTenantSettings", ProviderTenantSettings);
            writer.WriteCollectionOfObjectValues<SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<SecureScore>("secureScores", SecureScores);
            writer.WriteCollectionOfObjectValues<SecurityAction>("securityActions", SecurityActions);
            writer.WriteCollectionOfObjectValues<TiIndicator>("tiIndicators", TiIndicators);
            writer.WriteCollectionOfObjectValues<UserSecurityProfile>("userSecurityProfiles", UserSecurityProfiles);
        }
    }
}
