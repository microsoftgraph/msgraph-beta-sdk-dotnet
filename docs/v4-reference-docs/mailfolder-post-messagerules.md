---
title: "Create rule"
description: "Create a messageRule object by specifying a set of conditions and actions. "
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create rule

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a [messageRule](../resources/messagerule.md) object by specifying a set of conditions and actions. 

Outlook carries out those actions if an incoming message in the user's Inbox meets the specified conditions.

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
POST /me/mailFolders/inbox/messagerules
POST /users/{id | userPrincipalName}/mailFolders/inbox/messagerules
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |


## Request body
In the request body, supply the parameters that are applicable to your rule. The following are body parameters that are typically used 
when creating rules. You can specify any other writable **messageRule** properties as appropriate in the request body.

| Parameter       | Type|Description|
|:--------|:-------|:----------|
|actions|[messageRuleActions](../resources/messageruleactions.md)|Actions to be taken on a message when the corresponding conditions, if any, are fulfilled. Required.|
|conditions|[messageRulePredicates](../resources/messagerulepredicates.md)|Conditions that when fulfilled, will trigger the corresponding actions for that rule. Optional.|
|displayName| String  | The display name of the rule. Required.|
|exceptions| [messageRulePredicates](../resources/messagerulepredicates.md)| Represents exception conditions for the rule. Optional. |
|isEnabled | Boolean | Indicates whether the rule is enabled to be applied to messages. Optional. |
|sequence| Int32 | Indicates the order in which the rule is executed, among other rules. Required.|

## Response
If successful, this method returns `201 Created` response code and a **messageRule** object in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_messagerule_from_mailfolder"
}-->
```http
POST https://graph.microsoft.com/beta/me/mailFolders/inbox/messagerules
Content-type: application/json

{      
    "displayName": "From partner",      
    "sequence": 2,      
    "isEnabled": true,          
    "conditions": {
        "senderContains": [
          "adele"       
        ]
     },
     "actions": {
        "forwardTo": [
          {
             "emailAddress": {
                "name": "Alex Wilbur",
                "address": "AlexW@contoso.onmicrosoft.com"
              }
           }
        ],
        "stopProcessingRules": true
     }    
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var messageRule = new MessageRule
{
	DisplayName = "From partner",
	Sequence = 2,
	IsEnabled = true,
	Conditions = new MessageRulePredicates
	{
		SenderContains = new List<String>()
		{
			"adele"
		}
	},
	Actions = new MessageRuleActions
	{
		ForwardTo = new List<Recipient>()
		{
			new Recipient
			{
				EmailAddress = new EmailAddress
				{
					Name = "Alex Wilbur",
					Address = "AlexW@contoso.onmicrosoft.com"
				}
			}
		},
		StopProcessingRules = true
	}
};

await graphClient.Me.MailFolders["{mailFolder-id}"].MessageRules
	.Request()
	.AddAsync(messageRule);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

