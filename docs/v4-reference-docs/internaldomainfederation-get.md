---
title: "Get internalDomainFederation"
description: "Read the properties and relationships of an internalDomainFederation object."
author: "rahul-nagraj"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get internalDomainFederation
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [internalDomainFederation](../resources/internaldomainfederation.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Domain.Read.All, Domain.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|Domain.Read.All, Domain.ReadWrite.All|

The calling user must be assigned one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference):

- Security Administrator
- External Identity Provider Administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /domains/{domainsId}/federationConfiguration/{internalDomainFederationId}
```

## Optional query parameters
This method does not support OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [internalDomainFederation](../resources/internaldomainfederation.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_internaldomainfederation",
  "sampleKeys": ["contoso.com", "6601d14b-d113-8f64-fda2-9b5ddda18ecc"]
}
-->
``` http
GET https://graph.microsoft.com/beta/domains/contoso.com/federationConfiguration/6601d14b-d113-8f64-fda2-9b5ddda18ecc
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var internalDomainFederation = await graphClient.Domains["{domain-id}"].FederationConfiguration["{internalDomainFederation-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.internalDomainFederation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.internalDomainFederation",
    "id": "6601d14b-d113-8f64-fda2-9b5ddda18ecc",
    "displayName": "Contoso",
    "issuerUri": "http://contoso.com/adfs/services/trust",
    "metadataExchangeUri": "https://sts.contoso.com/adfs/services/trust/mex",
    "signingCertificate": "MIIE3jCCAsagAwIBAgIQQcyDaZz3MI",
    "passiveSignInUri": "https://sts.contoso.com/adfs/ls",
    "preferredAuthenticationProtocol": "wsFed",
    "activeSignInUri": "https://sts.contoso.com/adfs/services/trust/2005/usernamemixed",
    "signOutUri": "https://sts.contoso.com/adfs/ls",
    "promptLoginBehavior": "nativeSupport",
    "isSignedAuthenticationRequestRequired": true,
    "nextSigningCertificate": "MIIE3jCCAsagAwIBAgIQQcyDaZz3MI",
    "signingCertificateUpdateStatus": {
        "certificateUpdateResult": "Success",
        "lastRunDateTime": "2021-08-25T07:44:46.2616778Z"
    },
    "federatedIdpMfaBehavior": "rejectMfaByFederatedIdp"
  }
}
```

