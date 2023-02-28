---
title: "Get tenantAppManagementPolicy"
description: "Read the default tenant policy that applies to applications and service principals objects."
ms.localizationpriority: medium
author: "madansr7"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Get tenantAppManagementPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties of a [tenantAppManagementPolicy](../resources/tenantAppManagementPolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                                |
| :------------------------------------- | :--------------------------------------------------------- |
| Delegated (work or school account)     | Policy.Read.All, Policy.ReadWrite.ApplicationConfiguration |
| Delegated (personal Microsoft account) | Not supported.                                             |
| Application                            | Policy.Read.All, Policy.ReadWrite.ApplicationConfiguration |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /policies/defaultAppManagementPolicy
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and the requested [defaultAppManagementPolicy](../resources/tenantAppManagementPolicy.md) object in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_tenantAppManagementPolicy"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/defaultAppManagementPolicy
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantAppManagementPolicy = await graphClient.Policies.DefaultAppManagementPolicy
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response that shows the default tenant app management policy.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.tenantAppManagementPolicy"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#policies/defaultAppManagementPolicy/$entity",
    "@odata.id": "https://graph.microsoft.com/v2/927c6607-8060-4f4a-a5f8-34964ac78d70/defaultAppManagementPolicy/00000000-0000-0000-0000-000000000000",
    "id": "00000000-0000-0000-0000-000000000000",
    "displayName": "Default app management tenant policy",
    "description": "Default tenant policy that enforces app management restrictions on applications and service principals. To apply policy to targeted resources, create a new policy under appManagementPolicies collection.",
    "isEnabled": false,
    "applicationRestrictions": {
        "passwordCredentials": [],
        "keyCredentials":[]
    },
    "servicePrincipalRestrictions": {
        "passwordCredentials": [],
        "keyCredentials":[]
    }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get tenantAppManagementPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
