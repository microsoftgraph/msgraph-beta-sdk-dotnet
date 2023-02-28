---
title: "Get authenticationContextClassReference"
description: "Retrieve the properties and relationships of a authenticationContextClassReference object."
ms.localizationpriority: medium
author: "bakerCaleb"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get authenticationContextClassReference

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a [authenticationContextClassReference](../resources/authenticationcontextclassreference.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)                                       |
|:--------------------------------------|:----------------------------------------------------------------------------------|
|Delegated (work or school account)     | Policy.Read.ConditionalAccess |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Policy.Read.ConditionalAccess |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /identity/conditionalAccess/authenticationContextClassReferences/{id}
```
## Optional query parameters

This method does not support OData query parameters.

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token} |

## Response

If successful, this method returns a `200 OK` response code and an [authenticationContextClassReference](../resources/authenticationcontextclassreference.md) object in the response body.

## Examples

### Request

The following is an example of the request.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_identity_conditionalAccess_authenticationContextClassReferences",
  "sampleKeys": ["c1"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationContextClassReferences/c1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationContextClassReference = await graphClient.Identity.ConditionalAccess.AuthenticationContextClassReferences["{authenticationContextClassReference-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability. All the properties will be returned from an actual call.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.authenticationContextClassReference"
} -->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#conditionalAccess/authenticationContextClassReferences/$entity",
    "id": "c1",
    "displayName": "Contoso medium",
    "description": "Medium protection level defined for Contoso policy",
    "isAvailable": false
}

```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get authenticationContextClassReference",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
