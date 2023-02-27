---
title: "Delete authenticationContextClassReference"
description: "Delete an authenticationContextClassReference object."
author: "bakerCaleb"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Delete authenticationContextClassReference
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an [authenticationContextClassReference](../resources/authenticationcontextclassreference.md) object that's not published or used by a conditional access policy.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.Read.ConditionalAccess               |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Policy.Read.ConditionalAccess               |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /identity/conditionalAccess/authenticationContextClassReferences/{authenticationContextClassReferenceId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_authenticationcontextclassreference"
}
-->
``` http
DELETE https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationContextClassReferences/c1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Identity.ConditionalAccess.AuthenticationContextClassReferences["{authenticationContextClassReference-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

