// <auto-generated/>
using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationContextClassReferences;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrength;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.Evaluate;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.NamedLocations;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.Policies;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.Templates;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Identity.ConditionalAccess {
    /// <summary>
    /// Builds and executes requests for operations under \identity\conditionalAccess
    /// </summary>
    public class ConditionalAccessRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the authenticationContextClassReferences property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public AuthenticationContextClassReferencesRequestBuilder AuthenticationContextClassReferences
        {
            get => new AuthenticationContextClassReferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationStrength property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public AuthenticationStrengthRequestBuilder AuthenticationStrength
        {
            get => new AuthenticationStrengthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationStrengths property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public AuthenticationStrengthsRequestBuilder AuthenticationStrengths
        {
            get => new AuthenticationStrengthsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the evaluate method.</summary>
        public EvaluateRequestBuilder Evaluate
        {
            get => new EvaluateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the namedLocations property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public NamedLocationsRequestBuilder NamedLocations
        {
            get => new NamedLocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the policies property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public PoliciesRequestBuilder Policies
        {
            get => new PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the templates property of the microsoft.graph.conditionalAccessRoot entity.</summary>
        public TemplatesRequestBuilder Templates
        {
            get => new TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConditionalAccessRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/conditionalAccess", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConditionalAccessRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/conditionalAccess", rawUrl)
        {
        }
    }
}
