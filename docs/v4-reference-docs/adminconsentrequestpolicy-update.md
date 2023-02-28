---
title: "Update adminConsentRequestPolicy"
description: "Update the properties of an adminConsentRequestPolicy object."
author: "psignoret"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update adminConsentRequestPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [adminConsentRequestPolicy](../resources/adminconsentrequestpolicy.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.ConsentRequest, Directory.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.ReadWrite.ConsentRequest, Directory.ReadWrite.All|

When calling on behalf of a user, the user needs to belong to the [Global Administrator](/azure/active-directory/roles/permissions-reference) directory role.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PUT /policies/adminConsentRequestPolicy 
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [adminConsentRequestPolicy](../resources/adminconsentrequestpolicy.md) object.

The following table shows the properties that are required when you update the [adminConsentRequestPolicy](../resources/adminconsentrequestpolicy.md).

|Property|Type|Description|
|:---|:---|:---|
|isEnabled|Boolean|Specifies whether the admin consent request feature is enabled or disabled.|
|notifyReviewers|Boolean|Specifies whether reviewers will receive notifications.|
|remindersEnabled|Boolean|Specifies whether reviewers will receive reminder emails.|
|requestDurationInDays|Int32|Specifies the duration the request is active before it automatically expires if no decision is applied.|
|reviewers|[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|The list of reviewers for the admin consent.|



## Response

If successful, this method returns a `204 No content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_adminconsentrequestpolicy"
}
-->
``` http
PUT https://graph.microsoft.com/beta/policies/adminConsentRequestPolicy 
Content-Type: application/json

{
  "isEnabled": true,
  "notifyReviewers": true,
  "remindersEnabled": true,
  "requestDurationInDays": 5,
  "reviewers": [
    {
      "query": "/users/b6879be8-fb87-4482-a72e-18445d2b5c54",
      "queryType": "MicrosoftGraph"
    },
    {
      "query": "/users/b3427cc5-bf69-4dcd-95f7-ed1eb432f5e9",
      "queryType": "MicrosoftGraph"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var adminConsentRequestPolicy = new AdminConsentRequestPolicy
{
	IsEnabled = true,
	NotifyReviewers = true,
	RemindersEnabled = true,
	RequestDurationInDays = 5,
	Reviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "/users/b6879be8-fb87-4482-a72e-18445d2b5c54",
			QueryType = "MicrosoftGraph"
		},
		new AccessReviewReviewerScope
		{
			Query = "/users/b3427cc5-bf69-4dcd-95f7-ed1eb432f5e9",
			QueryType = "MicrosoftGraph"
		}
	}
};

await graphClient.Policies.AdminConsentRequestPolicy
	.Request()
	.PutAsync(adminConsentRequestPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
Content-Type: text/plain
```
