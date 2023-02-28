---
title: "alert: updateAlerts"
description: "Update multiple alerts in one request instead of multiple requests."
ms.localizationpriority: medium
author: "preetikr"
ms.prod: "security"
doc_type: apiPageType
---

# alert: updateAlerts

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update multiple alerts in one request instead of multiple requests.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
|Delegated (work or school account) |   SecurityEvents.ReadWrite.All  |
|Delegated (personal Microsoft account) |  Not supported.  |
|Application | SecurityEvents.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /security/alerts/updateAlerts
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {code} |

## Request body

In the request body, provide a JSON object with the following parameters. Each entity must have **id** and **vendorInformation** properties. For details about properties that can be updated, see [update alert](alert-update.md).

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
|value|[alert](../resources/alert.md) collection| Collection of alerts to update. Each entity must have **id**, **vendorInformation**, and other editable properties to be updated.|

## Response

If successful, this method returns `200, OK` response code and [alert](../resources/alert.md) collection object in the response body.

## Examples

The following example shows how to call this API.

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "alert_updatealerts",
   "isCollection": "true"
}-->

```http
POST https://graph.microsoft.com/beta/security/alerts/updateAlerts
Content-type: application/json

{
  "value": [
    {
      "assignedTo": "String",
      "closedDateTime": "String (timestamp)",
      "comments": ["String"],
      "feedback": {"@odata.type": "microsoft.graph.alertFeedback"},
      "id": "String (identifier)",
      "status": {"@odata.type": "microsoft.graph.alertStatus"},
      "tags": ["String"],
      "vendorInformation":
        {
          "provider": "String",
          "vendor": "String"
        }
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var value = new List<Alert>()
{
	new Alert
	{
		AssignedTo = "String",
		ClosedDateTime = DateTimeOffset.Parse("String (timestamp)"),
		Comments = new List<String>()
		{
			"String"
		},
		Feedback = new AlertFeedback
		{
		},
		Id = "String (identifier)",
		Status = new AlertStatus
		{
		},
		Tags = new List<String>()
		{
			"String"
		},
		VendorInformation = new SecurityVendorInformation
		{
			Provider = "String",
			Vendor = "String"
		}
	}
};

await graphClient.Security.Alerts
	.UpdateAlerts(value)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> [!NOTE]
> The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.alert",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "activityGroupName": "activityGroupName-value",
      "assignedTo": "assignedTo-value",
      "azureSubscriptionId": "azureSubscriptionId-value",
      "azureTenantId": "azureTenantId-value",
      "category": "category-value",
      "closedDateTime": "datetime-value"
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "alert: updateAlerts",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->


