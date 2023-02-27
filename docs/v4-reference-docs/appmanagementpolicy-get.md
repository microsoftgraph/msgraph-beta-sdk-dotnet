---
title: "Get appManagementPolicy"
description: "Get an application management policy."
ms.localizationpriority: medium
author: "madansr7"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Get appManagementPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties of an [appManagementPolicy](../resources/appManagementPolicy.md) object.

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
GET /policies/appManagementPolicies/{id}
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a single [appManagementPolicy](../resources/appManagementPolicy.md) object in the response body.

## Examples

### Request

The following is an example of the request.  From the response, the app management policy defines the following restrictions for application and service principal objects:

- Blocks creating of new passwords after 2019-10-19 at 10:37 AM UTC time.
- Limits password secrets for apps created after 2019-10-19 at 10:37 AM UTC time to less than 4 days, 12 hours, 30 minutes and 5 seconds.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_appManagementPolicy"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/appManagementPolicies/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var appManagementPolicy = await graphClient.Policies.AppManagementPolicies["{appManagementPolicy-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.appManagementPolicy"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
   "@odata.context": "https://graph.microsoft.com/beta/$metadata#policies/appManagementPolicies",
   "value": [
      {
         "id": "db9d4b58-3488-4da4-9994-49773c454e33",
         "displayName": "Custom app management policy",
         "description": "Custom policy that enforces app management restrictions on specific applications and service principals.",
         "isEnabled": false,
         "restrictions": {
            "passwordCredentials": [
               {
                  "restrictionType": "passwordAddition",
                  "maxLifetime": null,
                  "restrictForAppsCreatedAfterDateTime": "2019-10-19T10:37:00Z"
               },
               {
                  "restrictionType": "passwordLifetime",
                  "maxLifetime": "P4DT12H30M5S",
                  "restrictForAppsCreatedAfterDateTime": "2017-10-19T10:37:00Z"
               },
               {
                  "restrictionType": "symmetricKeyAddition",
                  "maxLifetime": null,
                  "restrictForAppsCreatedAfterDateTime": "2021-10-19T10:37:00Z"
               },
               {
                  "restrictionType": "symmetricKeyLifetime",
                  "maxLifetime": "P4D",
                  "restrictForAppsCreatedAfterDateTime": "2014-10-19T10:37:00Z"
               }
            ],
            "keyCredentials": [
               {
                  "restrictionType": "asymmetricKeyLifetime",
                  "maxLifetime": "P90D",
                  "restrictForAppsCreatedAfterDateTime": "2014-10-19T10:37:00Z"
               }
            ]
         }
      }
   ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "get appManagementPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
