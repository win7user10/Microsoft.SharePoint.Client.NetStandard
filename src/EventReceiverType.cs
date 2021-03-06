namespace Microsoft.SharePoint.Client.NetStandard
{
    public enum EventReceiverType
    {
        InvalidReceiver = -1,
        ItemAdding = 1,
        ItemUpdating,
        ItemDeleting,
        ItemCheckingIn,
        ItemCheckingOut,
        ItemUncheckingOut,
        ItemAttachmentAdding,
        ItemAttachmentDeleting,
        ItemFileMoving,
        ItemVersionDeleting = 11,
        FieldAdding = 101,
        FieldUpdating,
        FieldDeleting,
        ListAdding,
        ListDeleting,
        SiteDeleting = 201,
        WebDeleting,
        WebMoving,
        WebAdding,
        GroupAdding = 301,
        GroupUpdating,
        GroupDeleting,
        GroupUserAdding,
        GroupUserDeleting,
        RoleDefinitionAdding,
        RoleDefinitionUpdating,
        RoleDefinitionDeleting,
        RoleAssignmentAdding,
        RoleAssignmentDeleting,
        InheritanceBreaking,
        InheritanceResetting,
        WorkflowStarting = 501,
        ItemAdded = 10001,
        ItemUpdated,
        ItemDeleted,
        ItemCheckedIn,
        ItemCheckedOut,
        ItemUncheckedOut,
        ItemAttachmentAdded,
        ItemAttachmentDeleted,
        ItemFileMoved,
        ItemFileConverted,
        ItemVersionDeleted,
        FieldAdded = 10101,
        FieldUpdated,
        FieldDeleted,
        ListAdded,
        ListDeleted,
        SiteDeleted = 10201,
        WebDeleted,
        WebRestored = 10205,
        WebMoved = 10203,
        WebProvisioned,
        GroupAdded = 10301,
        GroupUpdated,
        GroupDeleted,
        GroupUserAdded,
        GroupUserDeleted,
        RoleDefinitionAdded,
        RoleDefinitionUpdated,
        RoleDefinitionDeleted,
        RoleAssignmentAdded,
        RoleAssignmentDeleted,
        InheritanceBroken,
        InheritanceReset,
        WorkflowStarted = 10501,
        WorkflowPostponed,
        WorkflowCompleted,
        EntityInstanceAdded = 10601,
        EntityInstanceUpdated,
        EntityInstanceDeleted,
        AppInstalled = 10701,
        AppUpgraded,
        AppUninstalling,
        EmailReceived = 20000,
        ContextEvent = 32766
    }
}