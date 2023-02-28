---
title: "List domains"
description: "Get the list of all externalDomainName objects for a samlOrWsFedExternalDomainFederation."
author: "namkedia"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List domains
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the list of all [externalDomainName](../resources/externaldomainname.md) objects for a [samlOrWsFedExternalDomainFederation](../resources/samlorwsfedexternaldomainfederation.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityProvider.Read.All, IdentityProvider.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application|IdentityProvider.Read.All, IdentityProvider.ReadWrite.All|

The work or school account needs to belong to one of the following [Azure Active Directory (Azure AD) roles](/azure/active-directory/roles/permissions-reference):

* Global Administrator
* External Identity Provider Administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /directory/federationConfigurations/microsoft.graph.samlOrWsFedExternalDomainFederation/{samlOrWsFedExternalDomainFederation ID}/domains
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [externalDomainName](../resources/externaldomainname.md) objects in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_externaldomainname"
}
-->

``` http
GET https://graph.microsoft.com/beta/directory/federationConfigurations/microsoft.graph.samlOrWsFedExternalDomainFederation/f1e11a04-0244-4592-99df-b01cfaadce15/domains
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var domains = await graphClient.Directory.FederationConfigurations["{samlOrWsFedExternalDomainFederation-id}"].Domains
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.externalDomainName)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft-ppe.com/beta/$metadata#directory/federationConfigurations/microsoft.graph.samlOrWsFedExternalDomainFederation('f1e11a04-0244-4592-99df-b01cfaadce15')/domains",
    "value": [
        {
            "id": "fabrikam.com"
        },
        {
            "id": "contoso.com"
        }
    ]
}
```
