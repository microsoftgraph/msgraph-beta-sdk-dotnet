---
title: "accessReviewInstance: applyDecisions"
description: "Apply decisions on an accessReviewInstance."
author: "jyothig123"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# accessReviewInstance: applyDecisions

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Apply review decisions on an [accessReviewInstance](../resources/accessreviewinstance.md) if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is `false` in the review's [accessReviewScheduleSettings](../resources/accessreviewschedulesettings.md).

The status of the accessReviewInstance must be `Completed` to call this method.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /identityGovernance/accessReviews/definitions/{definition-id}/instances/{instance-id}/applyDecisions
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
Do not supply a request body for this method.

## Response
If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "accessreviewinstance_applydecisions"
}
-->
```http
POST https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/04e5c3b2-9db2-40d3-a204-128f4956ae8e/instances/70463350-742e-4909-bfa5-bc23447bd002/applyDecisions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"]
	.ApplyDecisions()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```
