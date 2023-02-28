---
title: "Update rule"
description: "Change writable properties on a messageRule object and save the changes."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Update rule

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Change writable properties on a [messageRule](../resources/messagerule.md) object and save the changes.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | MailboxSettings.ReadWrite    |
|Delegated (personal Microsoft account) | MailboxSettings.ReadWrite    |
|Application | MailboxSettings.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/mailFolders/inbox/messagerules/{id}
PATCH /users/{id | userPrincipalName}/mailFolders/inbox/messagerules/{id}
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}. Required. |


## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will 
maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
| actions | [messageRuleActions](../resources/messageruleactions.md) | Actions to be taken on a message when the corresponding conditions are fulfilled. |
| conditions | [messageRulePredicates](../resources/messagerulepredicates.md) | Conditions that when fulfilled, will trigger the corresponding actions for that rule. |
| displayName | String | The display name of the rule. |
| exceptions | [messageRulePredicates](../resources/messagerulepredicates.md) | Exception conditions for the rule. |
| isEnabled | Boolean | Indicates whether the rule is enabled to be applied to messages. |
| isReadOnly | Boolean | Indicates if the rule is read-only and cannot be modified or deleted by the rules REST API. |
| sequence | Int32 | Indicates the order in which the rule is executed, among other rules. |


## Response
If successful, this method returns a `200 OK` response code and updated [messageRule](../resources/messagerule.md) object in the response body.
## Example
##### Request
The following example changes the name of the rule, and the actions to be taken for that rule in the 
[example](messagerule-get.md#example) in [Get rule](messagerule-get.md), from forwarding to an address to marking its importance as high. 

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_messagerule",
  "sampleKeys": ["AQAAAJ5dZqA="]
}-->
```http
PATCH https://graph.microsoft.com/beta/me/mailfolders/inbox/messagerules('AQAAAJ5dZqA=')
Content-type: application/json

{
    "displayName": "Important from partner",
    "actions": {
        "markImportance": "high"
     }
} 
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var messageRule = new MessageRule
{
	DisplayName = "Important from partner",
	Actions = new MessageRuleActions
	{
		MarkImportance = Importance.High
	}
};

await graphClient.Me.MailFolders["{mailFolder-id}"].MessageRules["{messageRule-id}"]
	.Request()
	.UpdateAsync(messageRule);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

