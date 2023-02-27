---
title: "Update groupLifecyclePolicy"
description: "Update the properties of a groupLifecyclePolicygroupLifecyclePolicy resource type object."
author: "psaffaie"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# Update groupLifecyclePolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a groupLifecyclePolicy[groupLifecyclePolicy resource type](../resources/grouplifecyclepolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Directory.ReadWrite.All                     |
| Delegated (personal Microsoft account) | Not supported                               |
| Application                            | Directory.ReadWrite.All                     |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /groupLifecyclePolicies/{id}
```

## Optional request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json          |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property                    | Type   | Description                                                                                                                                                |
| :-------------------------- | :----- | :--------------------------------------------------------------------------------------------------------------------------------------------------------- |
| alternateNotificationEmails | String | List of email address to send notifications for groups without owners. Multiple email address can be defined by separating email address with a semicolon. |
| groupLifetimeInDays         | Int32  | Number of days before a group expires and needs to be renewed. Once renewed, the group expiration is extended by the number of days defined.               |
| managedGroupTypes           | String | The group type for which the expiration policy applies. Possible values are **All**, **Selected** or **None**.                                             |

## Response

If successful, this method returns a `200 OK` response code and updated [groupLifecyclePolicy](../resources/grouplifecyclepolicy.md) object in the response body.

## Example

##### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "update_grouplifecyclepolicy"
}-->

```http
PATCH https://graph.microsoft.com/beta/groupLifecyclePolicies/{id}
Content-type: application/json

{
  "groupLifetimeInDays": 180,
  "managedGroupTypes": "Selected",
  "alternateNotificationEmails": "admin@contoso.com"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var groupLifecyclePolicy = new GroupLifecyclePolicy
{
	GroupLifetimeInDays = 180,
	ManagedGroupTypes = "Selected",
	AlternateNotificationEmails = "admin@contoso.com"
};

await graphClient.GroupLifecyclePolicies["{groupLifecyclePolicy-id}"]
	.Request()
	.UpdateAsync(groupLifecyclePolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

