namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum OrganizationalMessagePlacement {
        /// <summary>Indicates the default area for text to be displayed. This is the only valid placement value for the actionCenter and softLanding surfaces</summary>
        Default,
        /// <summary>Indicates the area where the first card is displayed. Only applies to the getStarted surface</summary>
        Card0,
        /// <summary>Indicates the area where the second card is displayed. Only applies to the getStarted surface</summary>
        Card1,
        /// <summary>Indicates the area where the third card is displayed. Only applies to the getStarted surface</summary>
        Card2,
        /// <summary>Indicates the area where the fourth card is displayed. Only applies to the getStarted surface</summary>
        Card3,
        /// <summary>UnknownFutureValue, Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
