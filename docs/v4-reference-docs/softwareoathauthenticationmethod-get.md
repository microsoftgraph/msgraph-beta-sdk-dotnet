---
title: "Get softwareOathAuthenticationMethod"
description: "Read the properties and relationships of a softwareOathAuthenticationMethod object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get softwareOathAuthenticationMethod
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a user's single [Software OATH token authentication method](../resources/softwareoathauthenticationmethod.md) object and its properties.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Permissions acting on self

|Permission type      | Permissions (from least to most privileged)              |
|:---------------------------------------|:-------------------------|
| Delegated (work or school account)     | UserAuthenticationMethod.Read, UserAuthenticationMethod.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

### Permissions acting on other users

|Permission type      | Permissions (from least to most privileged)              |
|:---------------------------------------|:-------------------------|
| Delegated (work or school account)     | UserAuthenticationMethod.Read.All, UserAuthenticationMethod.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | UserAuthenticationMethod.Read.All, UserAuthenticationMethod.ReadWrite.All |

For delegated scenarios where an admin is acting on another user, the admin needs [one of the following directory roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):
* Global Reader
* Authentication administrator
* Privileged authentication administrator
* Global administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/authentication/softwareOathMethods/{id}
GET /users/{id | userPrincipalName}/authentication/softwareOathMethods/{id}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [softwareOathAuthenticationMethod](../resources/softwareoathauthenticationmethod.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_softwareoathauthenticationmethod"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/authentication/softwareOathMethods/b172893e-893e-b172-3e89-72b13e8972b1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var softwareOathAuthenticationMethod = await graphClient.Me.Authentication.SoftwareOathMethods["{softwareOathAuthenticationMethod-id}"]
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
  "@odata.type": "microsoft.graph.softwareOathAuthenticationMethod"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.softwareOathAuthenticationMethod",
    "id": "b172893e-893e-b172-3e89-72b13e8972b1",
    "secretKey": "String"
  }
}
```

