namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines the conflict resolution strategy, when more than one Mobile Threat Defense provider is enabled.</summary>
    public enum MobileThreatDefensePartnerPriority {
        /// <summary>Indicates use of Microsoft Defender Endpoint over 3rd party MTD connectors</summary>
        DefenderOverThirdPartyPartner,
        /// <summary>Indicates use of a 3rd party MTD connector over Microsoft Defender Endpoint</summary>
        ThirdPartyPartnerOverDefender,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
