---
title: "Create accessPackageAssignmentPolicy"
description: "Use this API to create a new accessPackageAssignmentPolicy."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: "apiPageType"
---

# Create accessPackageAssignmentPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

In [Azure AD entitlement management](../resources/entitlementmanagement-overview.md), create a new [accessPackageAssignmentPolicy](../resources/accesspackageassignmentpolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | EntitlementManagement.ReadWrite.All  |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | EntitlementManagement.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identityGovernance/entitlementManagement/accessPackageAssignmentPolicies
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer \{token\}. Required. |
| Content-Type  | application/json. Required.  |

## Request body

In the request body, supply a JSON representation of an [accessPackageAssignmentPolicy](../resources/accesspackageassignmentpolicy.md) object.

## Response

If successful, this method returns a 200-series response code and a new [accessPackageAssignmentPolicy](../resources/accesspackageassignmentpolicy.md) object in the response body.

## Examples

### Example 1: Create a direct assignment policy

A direct assignment policy is useful when access package assignment requests will only be created by an administrator, not by users themselves.

#### Request

The following example shows a request to create an access package assignment policy. In this policy, no users can request, no approval is required, and there are no access reviews.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accesspackageassignmentpolicy_from_accesspackageassignmentpolicies"
}-->

```http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies
Content-type: application/json

{
  "accessPackageId": "56ff43fd-6b05-48df-9634-956a777fce6d",
  "displayName": "direct",
  "description": "direct assignments by administrator",
  "accessReviewSettings": null,
  "requestorSettings": {
    "scopeType": "NoSubjects",
    "acceptRequests": true,
    "allowedRequestors": []
  },
  "requestApprovalSettings": {
    "isApprovalRequired": false,
    "isApprovalRequiredForExtension": false,
    "isRequestorJustificationRequired": false,
    "approvalMode": "NoApproval",
    "approvalStages": []
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackageAssignmentPolicy = new AccessPackageAssignmentPolicy
{
	AccessPackageId = "56ff43fd-6b05-48df-9634-956a777fce6d",
	DisplayName = "direct",
	Description = "direct assignments by administrator",
	AccessReviewSettings = null,
	RequestorSettings = new RequestorSettings
	{
		ScopeType = "NoSubjects",
		AcceptRequests = true,
		AllowedRequestors = new List<UserSet>()
		{
		}
	},
	RequestApprovalSettings = new ApprovalSettings
	{
		IsApprovalRequired = false,
		IsApprovalRequiredForExtension = false,
		IsRequestorJustificationRequired = false,
		ApprovalMode = "NoApproval",
		ApprovalStages = new List<ApprovalStage>()
		{
		}
	}
};

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentPolicies
	.Request()
	.AddAsync(accessPackageAssignmentPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessPackageAssignmentPolicy"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "4c02f928-7752-49aa-8fc8-e286d973a965",
  "accessPackageId": "56ff43fd-6b05-48df-9634-956a777fce6d",
  "displayName": "direct",
  "description": "direct assignments by administrator"
}
```

### Example 2: Create a policy for users from other organizations to request

The following example shows a more complex policy with two-stage approvals and access reviews.

#### Request

The following is an example of the request to create an access package assignment policy. 


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accesspackageassignmentpolicy_from_accesspackageassignmentpolicies_multistage"
}-->

```http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies
Content-type: application/json

{
    "accessPackageId": "string (identifier)",
    "displayName": "Users from connected organizations can request",
    "description": "Allow users from configured connected organizations to request and be approved by their sponsors",
    "canExtend": false,
    "durationInDays": 365,
    "expirationDateTime": null,
    "requestorSettings": {
        "scopeType": "AllExistingConnectedOrganizationSubjects",
        "acceptRequests": true,
        "allowedRequestors": []
    },
    "requestApprovalSettings": {
        "isApprovalRequired": true,
        "isApprovalRequiredForExtension": false,
        "isRequestorJustificationRequired": true,
        "approvalMode": "Serial",
        "approvalStages": [
            {
                "approvalStageTimeOutInDays": 14,
                "isApproverJustificationRequired": true,
                "isEscalationEnabled": true,
                "escalationTimeInMinutes": 11520,
                "primaryApprovers": [
                    {
                        "@odata.type": "#microsoft.graph.groupMembers",
                        "isBackup": true,
                        "id": "string (identifier)",
                        "description": "group for users from connected organizations which have no external sponsor"
                    },
                    {
                        "@odata.type": "#microsoft.graph.externalSponsors",
                        "isBackup": false
                    }
                ],
                "escalationApprovers": [
                    {
                        "@odata.type": "#microsoft.graph.singleUser",
                        "isBackup": true,
                        "id": "string (identifier)",
                        "description": "user if the external sponsor does not respond"
                    }
                ]
            },
            {
                "approvalStageTimeOutInDays": 14,
                "isApproverJustificationRequired": true,
                "isEscalationEnabled": true,
                "escalationTimeInMinutes": 11520,
                "primaryApprovers": [
                    {
                        "@odata.type": "#microsoft.graph.groupMembers",
                        "isBackup": true,
                        "id": "string (identifier)",
                        "description": "group for users from connected organizations which have no internal sponsor"
                    },
                    {
                        "@odata.type": "#microsoft.graph.internalSponsors",
                        "isBackup": false
                    }
                ],
                "escalationApprovers": [
                    {
                        "@odata.type": "#microsoft.graph.singleUser",
                        "isBackup": true,
                        "id": "string (identifier)",
                        "description": "user if the internal sponsor does not respond"
                    }
                ]
            }
        ]
    },
    "accessReviewSettings": {
        "isEnabled": true,
        "recurrenceType": "quarterly",
        "reviewerType": "Self",
        "startDateTime": "2020-04-01T07:59:59.998Z",
        "durationInDays": 25,
        "reviewers": []
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackageAssignmentPolicy = new AccessPackageAssignmentPolicy
{
	AccessPackageId = "string (identifier)",
	DisplayName = "Users from connected organizations can request",
	Description = "Allow users from configured connected organizations to request and be approved by their sponsors",
	CanExtend = false,
	DurationInDays = 365,
	ExpirationDateTime = null,
	RequestorSettings = new RequestorSettings
	{
		ScopeType = "AllExistingConnectedOrganizationSubjects",
		AcceptRequests = true,
		AllowedRequestors = new List<UserSet>()
		{
		}
	},
	RequestApprovalSettings = new ApprovalSettings
	{
		IsApprovalRequired = true,
		IsApprovalRequiredForExtension = false,
		IsRequestorJustificationRequired = true,
		ApprovalMode = "Serial",
		ApprovalStages = new List<ApprovalStage>()
		{
			new ApprovalStage
			{
				ApprovalStageTimeOutInDays = 14,
				IsApproverJustificationRequired = true,
				IsEscalationEnabled = true,
				EscalationTimeInMinutes = 11520,
				PrimaryApprovers = new List<UserSet>()
				{
					new GroupMembers
					{
						IsBackup = true,
						Id = "string (identifier)",
						Description = "group for users from connected organizations which have no external sponsor"
					},
					new ExternalSponsors
					{
						IsBackup = false
					}
				},
				EscalationApprovers = new List<UserSet>()
				{
					new SingleUser
					{
						IsBackup = true,
						Id = "string (identifier)",
						Description = "user if the external sponsor does not respond"
					}
				}
			},
			new ApprovalStage
			{
				ApprovalStageTimeOutInDays = 14,
				IsApproverJustificationRequired = true,
				IsEscalationEnabled = true,
				EscalationTimeInMinutes = 11520,
				PrimaryApprovers = new List<UserSet>()
				{
					new GroupMembers
					{
						IsBackup = true,
						Id = "string (identifier)",
						Description = "group for users from connected organizations which have no internal sponsor"
					},
					new InternalSponsors
					{
						IsBackup = false
					}
				},
				EscalationApprovers = new List<UserSet>()
				{
					new SingleUser
					{
						IsBackup = true,
						Id = "string (identifier)",
						Description = "user if the internal sponsor does not respond"
					}
				}
			}
		}
	},
	AccessReviewSettings = new AssignmentReviewSettings
	{
		IsEnabled = true,
		RecurrenceType = "quarterly",
		ReviewerType = "Self",
		StartDateTime = DateTimeOffset.Parse("2020-04-01T07:59:59.998Z"),
		DurationInDays = 25,
		Reviewers = new List<UserSet>()
		{
		}
	}
};

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentPolicies
	.Request()
	.AddAsync(accessPackageAssignmentPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessPackageAssignmentPolicy"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "4c02f928-7752-49aa-8fc8-e286d973a965",
  "accessPackageId": "string (identifier)",
  "displayName": "Users from connected organizations can request",
  "description": "Allow users from configured connected organizations to request and be approved by their sponsors"
}
```

### Example 3: Create assignment policy with questions

Questions configured in an assignment policy will be asked to requestors in scope of the policy. Their answers will be shown to their approvers. Question IDs are read-only and are included in the response by default.

#### Request

The following example shows a request to create an access package assignment policy. 



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accesspackageassignmentpolicy_from_accesspackageassignmentpolicies_questions"
}-->

```http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies
Content-type: application/json

{
    "accessPackageId": "b2eba9a1-b357-42ee-83a8-336522ed6cbf",
    "displayName": "Users from connected organizations can request",
    "description": "Allow users from configured connected organizations to request and be approved by their sponsors",
    "canExtend": false,
    "durationInDays": 365,
    "expirationDateTime": null,
    "requestorSettings": {
        "scopeType": "AllExistingConnectedOrganizationSubjects",
        "acceptRequests": true
    },
    "requestApprovalSettings": {
        "isApprovalRequired": true,
        "isApprovalRequiredForExtension": false,
        "isRequestorJustificationRequired": true,
        "approvalMode": "SingleStage",
        "approvalStages": [{
                "approvalStageTimeOutInDays": 14,
                "isApproverJustificationRequired": true,
                "isEscalationEnabled": false,
                "escalationTimeInMinutes": 11520,
                "primaryApprovers": [{
                        "@odata.type": "#microsoft.graph.groupMembers",
                        "isBackup": true,
                        "id": "d2dcb9a1-a445-42ee-83a8-476522ed6cbf",
                        "description": "group for users from connected organizations which have no external sponsor"
                    },
                    {
                        "@odata.type": "#microsoft.graph.externalSponsors",
                        "isBackup": false
                    }
                ]
            }
        ]
    },
    "questions": [{
        "isRequired": false,
        "text": {
            "defaultText": "what state are you from?",
            "localizedTexts": [{
                "text": "¿De qué estado eres?",
                "languageCode": "es"
            }]
        },
        "@odata.type": "#microsoft.graph.accessPackageMultipleChoiceQuestion",
        "choices": [{
            "actualValue": "AZ",
            "displayValue": {
                "localizedTexts": [{
                    "text": "Arizona",
                    "languageCode": "es"
                }]
            }
        }, {
            "actualValue": "CA",
            "displayValue": {
                "localizedTexts": [{
                    "text": "California",
                    "languageCode": "es"
                }]
            }
        }, {
            "actualValue": "OH",
            "displayValue": {
                "localizedTexts": [{
                    "text": "Ohio",
                    "languageCode": "es"
                }]
            }
        }],
        "allowsMultipleSelection": false
    }, {
        "isRequired": false,
        "text": {
            "defaultText": "Who is your manager?",
            "localizedTexts": [{
                "text": "por qué necesita acceso a este paquete",
                "languageCode": "es"
            }]
        },
        "@odata.type": "#microsoft.graph.accessPackageTextInputQuestion",
        "isSingleLineQuestion": false
    }]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackageAssignmentPolicy = new AccessPackageAssignmentPolicy
{
	AccessPackageId = "b2eba9a1-b357-42ee-83a8-336522ed6cbf",
	DisplayName = "Users from connected organizations can request",
	Description = "Allow users from configured connected organizations to request and be approved by their sponsors",
	CanExtend = false,
	DurationInDays = 365,
	ExpirationDateTime = null,
	RequestorSettings = new RequestorSettings
	{
		ScopeType = "AllExistingConnectedOrganizationSubjects",
		AcceptRequests = true
	},
	RequestApprovalSettings = new ApprovalSettings
	{
		IsApprovalRequired = true,
		IsApprovalRequiredForExtension = false,
		IsRequestorJustificationRequired = true,
		ApprovalMode = "SingleStage",
		ApprovalStages = new List<ApprovalStage>()
		{
			new ApprovalStage
			{
				ApprovalStageTimeOutInDays = 14,
				IsApproverJustificationRequired = true,
				IsEscalationEnabled = false,
				EscalationTimeInMinutes = 11520,
				PrimaryApprovers = new List<UserSet>()
				{
					new GroupMembers
					{
						IsBackup = true,
						Id = "d2dcb9a1-a445-42ee-83a8-476522ed6cbf",
						Description = "group for users from connected organizations which have no external sponsor"
					},
					new ExternalSponsors
					{
						IsBackup = false
					}
				}
			}
		}
	},
	Questions = new List<AccessPackageQuestion>()
	{
		new AccessPackageMultipleChoiceQuestion
		{
			IsRequired = false,
			Text = new AccessPackageLocalizedContent
			{
				DefaultText = "what state are you from?",
				LocalizedTexts = new List<AccessPackageLocalizedText>()
				{
					new AccessPackageLocalizedText
					{
						Text = "�De qu� estado eres?",
						LanguageCode = "es"
					}
				}
			},
			Choices = new List<AccessPackageAnswerChoice>()
			{
				new AccessPackageAnswerChoice
				{
					ActualValue = "AZ",
					DisplayValue = new AccessPackageLocalizedContent
					{
						LocalizedTexts = new List<AccessPackageLocalizedText>()
						{
							new AccessPackageLocalizedText
							{
								Text = "Arizona",
								LanguageCode = "es"
							}
						}
					}
				},
				new AccessPackageAnswerChoice
				{
					ActualValue = "CA",
					DisplayValue = new AccessPackageLocalizedContent
					{
						LocalizedTexts = new List<AccessPackageLocalizedText>()
						{
							new AccessPackageLocalizedText
							{
								Text = "California",
								LanguageCode = "es"
							}
						}
					}
				},
				new AccessPackageAnswerChoice
				{
					ActualValue = "OH",
					DisplayValue = new AccessPackageLocalizedContent
					{
						LocalizedTexts = new List<AccessPackageLocalizedText>()
						{
							new AccessPackageLocalizedText
							{
								Text = "Ohio",
								LanguageCode = "es"
							}
						}
					}
				}
			},
			AllowsMultipleSelection = false
		},
		new AccessPackageTextInputQuestion
		{
			IsRequired = false,
			Text = new AccessPackageLocalizedContent
			{
				DefaultText = "Who is your manager?",
				LocalizedTexts = new List<AccessPackageLocalizedText>()
				{
					new AccessPackageLocalizedText
					{
						Text = "por qu� necesita acceso a este paquete",
						LanguageCode = "es"
					}
				}
			},
			IsSingleLineQuestion = false
		}
	}
};

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentPolicies
	.Request()
	.AddAsync(accessPackageAssignmentPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessPackageAssignmentPolicy"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "4c02f928-7752-49aa-8fc8-e286d973a965",
  "accessPackageId": "string (identifier)",
  "displayName": "Users from connected organizations can request",
  "description": "Allow users from configured connected organizations to request and be approved by their sponsors",
  "questions": [{
        "id" : "BD3F6B95-458D-4BC8-A9A6-8D4B29F64F3D",
        "isRequired": false,
        "text": {
            "defaultText": "what state are you from?",
            "localizedTexts": [{
                "text": "¿De qué estado eres?",
                "languageCode": "es"
            }]
        },
        "@odata.type": "#microsoft.graph.accessPackageMultipleChoiceQuestion",
        "choices": [{
            "actualValue": "AZ",
            "displayValue": {
                "localizedTexts": [{
                    "text": "Arizona?",
                    "languageCode": "es"
                }]
            }
        }, {
            "actualValue": "CA",
            "displayValue": {
                "localizedTexts": [{
                    "text": "California",
                    "languageCode": "es"
                }]
            }
        }, {
            "actualValue": "OH",
            "displayValue": {
                "localizedTexts": [{
                    "text": "Ohio",
                    "languageCode": "es"
                }]
            }
        }],
        "allowsMultipleSelection": false
    }, {
        "id" : "F652C13C-A660-4E4C-A1E0-CE9FEC6EE57A",
        "isRequired": false,
        "text": {
            "defaultText": "Who is your manager?",
            "localizedTexts": [{
                "text": "por qué necesita acceso a este paquete",
                "languageCode": "es"
            }]
        },
        "@odata.type": "#microsoft.graph.accessPackageTextInputQuestion",
        "isSingleLineQuestion": false
    }]
}
```



### Example 4: Create a policy and specify the stages to trigger pre-defined custom workflow extensions

#### Request

In the following example, the pre-defined **customAccessPackageWorkflowExtension** object is triggered when an access package assigned request is created and when it's granted.  The identifier provided within the **customExtension** field is the **customAccessPackageWorkflowExtension** object's ID.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accesspackageassignmentpolicy_customaccesspackageworkflowextension"
}-->
```msgraph-interactive
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies
Content-type: application/json

{
  "displayName": "extension-policy",
  "description": "test",
  "accessPackageId": "ba5807c7-2aa9-4c8a-907e-4a17ee587500",
  "expiration": {
    "type": "afterDuration",
    "duration": "P365D"
  },
  "canExtend": false,
  "requestApprovalSettings": null,
  "requestorSettings": {
    "acceptRequests": true,
    "scopeType": "AllExistingDirectorySubjects",
    "allowedRequestors": [],
    "isOnBehalfAllowed": false
  },
  "accessReviewSettings": null,
  "questions": [],
  "customExtensionHandlers": [
    {
      "stage": "assignmentRequestCreated",
      "customExtension": {
        "id": "219f57b6-7983-45a1-be01-2c228b7a43f8"
      }
    },
    {
      "stage": "assignmentRequestGranted",
      "customExtension": {
        "id": "219f57b6-7983-45a1-be01-2c228b7a43f8"
      }
    }
  ]
}
```

# [C#](#tab/csharp)
```
Snippet not available
```

 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response. The **customExtensionHandlers** object isn't returned by default. To retrieve this object, use the **GET** method with `$expand`. For more information, see [Retrieve the custom extension handlers for a policy](accesspackageassignmentpolicy-get.md#example-2-retrieve-the-custom-extension-handlers-for-a-policy)

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessPackageAssignmentPolicy"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "d0324cbb-24a2-4edb-acca-fee5384c6a5e",
  "displayName": "extension-policy",
  "description": "test",
  "canExtend": false,
  "durationInDays": 0,
  "expirationDateTime": null,
  "accessPackageId": "ba5807c7-2aa9-4c8a-907e-4a17ee587500",
  "accessReviewSettings": null,
  "questions": [],
  "requestorSettings": {
    "scopeType": "AllExistingDirectorySubjects",
    "acceptRequests": true,
    "allowedRequestors": []
  },
  "requestApprovalSettings": {
    "isApprovalRequired": false,
    "isApprovalRequiredForExtension": false,
    "isRequestorJustificationRequired": false,
    "approvalMode": "NoApproval",
    "approvalStages": []
  }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create accessPackageAssignmentPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


