---
title: "Create appManagementPolicy"
description: "Create an application management policy."
ms.localizationpriority: medium
author: "madansr7"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Create appManagementPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create an [appManagementPolicy](../resources/appManagementPolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                                |
| :------------------------------------- | :--------------------------------------------------------- |
| Delegated (work or school account)     | Policy.ReadWrite.ApplicationConfiguration |
| Delegated (personal Microsoft account) | Not supported.                                             |
| Application                            | Policy.ReadWrite.ApplicationConfiguration |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /policies/appManagementPolicies
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, provide a JSON representation of an [appManagementPolicy](../resources/appManagementPolicy.md).

## Response

If successful, this method returns a `201 Created` response code with the new [appManagementPolicy ](../resources/appmanagementpolicy.md) object in the response payload.

## Examples

### Request

The following is an example of the request. This request created an app management policy with the following settings:

- Enables the policy.
- Blocks creating of new passwords for applications and service principals created on or after 2019-10-19 at 10:37 AM UTC time.
- Enforces lifetime on password secrets and key credentials for applications created on or after 2014-10-19 at 10:37 AM UTC time.
- Limits password secrets for apps and service principals created after 2019-10-19 at 10:37 AM UTC time to less than 4 days, 12 hours, 30 minutes and 5 seconds.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_appManagementPolicy"
}-->

```http
POST https://graph.microsoft.com/beta/policies/appManagementPolicies

{
    "displayName": "Credential management policy",
    "description": "Cred policy sample",
    "isEnabled": true,
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
                  "restrictForAppsCreatedAfterDateTime": "2014-10-19T10:37:00Z"
               },
               {
                  "restrictionType": "symmetricKeyAddition",
                  "maxLifetime": null,
                  "restrictForAppsCreatedAfterDateTime": "2019-10-19T10:37:00Z"
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

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var appManagementPolicy = new AppManagementPolicy
{
	DisplayName = "Credential management policy",
	Description = "Cred policy sample",
	IsEnabled = true,
	Restrictions = new AppManagementConfiguration
	{
		PasswordCredentials = new List<PasswordCredentialConfiguration>()
		{
			new PasswordCredentialConfiguration
			{
				RestrictionType = AppCredentialRestrictionType.PasswordAddition,
				MaxLifetime = null,
				RestrictForAppsCreatedAfterDateTime = DateTimeOffset.Parse("2019-10-19T10:37:00Z")
			},
			new PasswordCredentialConfiguration
			{
				RestrictionType = AppCredentialRestrictionType.PasswordLifetime,
				MaxLifetime = new Duration("P4DT12H30M5S"),
				RestrictForAppsCreatedAfterDateTime = DateTimeOffset.Parse("2014-10-19T10:37:00Z")
			},
			new PasswordCredentialConfiguration
			{
				RestrictionType = AppCredentialRestrictionType.SymmetricKeyAddition,
				MaxLifetime = null,
				RestrictForAppsCreatedAfterDateTime = DateTimeOffset.Parse("2019-10-19T10:37:00Z")
			},
			new PasswordCredentialConfiguration
			{
				RestrictionType = AppCredentialRestrictionType.SymmetricKeyLifetime,
				MaxLifetime = new Duration("P4D"),
				RestrictForAppsCreatedAfterDateTime = DateTimeOffset.Parse("2014-10-19T10:37:00Z")
			}
		},
		KeyCredentials = new List<KeyCredentialConfiguration>()
		{
			new KeyCredentialConfiguration
			{
				RestrictionType = AppKeyCredentialRestrictionType.AsymmetricKeyLifetime,
				MaxLifetime = new Duration("P90D"),
				RestrictForAppsCreatedAfterDateTime = DateTimeOffset.Parse("2014-10-19T10:37:00Z")
			}
		}
	}
};

await graphClient.Policies.AppManagementPolicies
	.Request()
	.AddAsync(appManagementPolicy);

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
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#policies/appManagementPolicies/$entity",
    "id": "a4ab1ed9-46bb-4bef-88d4-86fd6398dd5d",
    "displayName": "credential management policy",
    "description": "Lorem ipsum",
    "isEnabled": true,
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
                "restrictForAppsCreatedAfterDateTime": "2018-10-19T10:37:00Z"
            }
        ]
    }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "create appManagementPolicies",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
