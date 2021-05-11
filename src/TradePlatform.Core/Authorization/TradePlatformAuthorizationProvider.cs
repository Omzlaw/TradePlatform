using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace TradePlatform.Authorization
{
    public class TradePlatformAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Deposits, L("Deposits"));
            context.CreatePermission(PermissionNames.Create_Deposits, L("CreateDeposits"));
            context.CreatePermission(PermissionNames.Update_Deposits, L("UpdateDeposits"));
            context.CreatePermission(PermissionNames.Delete_Deposits, L("DeleteDeposits"));
            context.CreatePermission(PermissionNames.Pages_Countries, L("Countries"));
            context.CreatePermission(PermissionNames.Create_Countries, L("CreateCountries"));
            context.CreatePermission(PermissionNames.Update_Countries, L("UpdateCountries"));
            context.CreatePermission(PermissionNames.Delete_Countries, L("DeleteCountries"));
            context.CreatePermission(PermissionNames.Pages_Documents, L("Documents"));
            context.CreatePermission(PermissionNames.Create_Documents, L("CreateDocuments"));
            context.CreatePermission(PermissionNames.Update_Documents, L("UpdateDocuments"));
            context.CreatePermission(PermissionNames.Delete_Documents, L("DeleteDocuments"));
            context.CreatePermission(PermissionNames.Pages_InvestmentPlans, L("InvestmentPlans"));
            context.CreatePermission(PermissionNames.Create_InvestmentPlans, L("CreateInvestmentPlans"));
            context.CreatePermission(PermissionNames.Update_InvestmentPlans, L("UpdateInvestmentPlans"));
            context.CreatePermission(PermissionNames.Delete_InvestmentPlans, L("DeleteInvestmentPlans"));
            context.CreatePermission(PermissionNames.Pages_MiscellaneousTransactions, L("MiscellaneousTransactions"));
            context.CreatePermission(PermissionNames.Create_MiscellaneousTransactions, L("CreateMiscellaneousTransactions"));
            context.CreatePermission(PermissionNames.Update_MiscellaneousTransactions, L("UpdateMiscellaneousTransactions"));
            context.CreatePermission(PermissionNames.Delete_MiscellaneousTransactions, L("DeleteMiscellaneousTransactions"));
            context.CreatePermission(PermissionNames.Pages_Notifications, L("Notifications"));
            context.CreatePermission(PermissionNames.Create_Notifications, L("CreateNotifications"));
            context.CreatePermission(PermissionNames.Update_Notifications, L("UpdateNotifications"));
            context.CreatePermission(PermissionNames.Delete_Notifications, L("DeleteNotifications"));
            context.CreatePermission(PermissionNames.Pages_Packages, L("Packages"));
            context.CreatePermission(PermissionNames.Create_Packages, L("CreatePackages"));
            context.CreatePermission(PermissionNames.Update_Packages, L("UpdatePackages"));
            context.CreatePermission(PermissionNames.Delete_Packages, L("DeletePackages"));
            context.CreatePermission(PermissionNames.Pages_ProfitLossRecords, L("ProfitLossRecords"));
            context.CreatePermission(PermissionNames.Create_ProfitLossRecords, L("CreateProfitLossRecords"));
            context.CreatePermission(PermissionNames.Update_ProfitLossRecords, L("UpdateProfitLossRecords"));
            context.CreatePermission(PermissionNames.Delete_ProfitLossRecords, L("DeleteProfitLossRecords"));
            context.CreatePermission(PermissionNames.Pages_ReceivingModes, L("ReceivingModes"));
            context.CreatePermission(PermissionNames.Create_ReceivingModes, L("CreateReceivingModes"));
            context.CreatePermission(PermissionNames.Update_ReceivingModes, L("UpdateProfitLossRecords"));
            context.CreatePermission(PermissionNames.Delete_ReceivingModes, L("DeleteProfitLossRecords"));
            context.CreatePermission(PermissionNames.Pages_Referrals, L("Referrals"));
            context.CreatePermission(PermissionNames.Create_Referrals, L("CreateReferrals"));
            context.CreatePermission(PermissionNames.Update_Referrals, L("UpdateReferrals"));
            context.CreatePermission(PermissionNames.Delete_Referrals, L("DeleteReferrals"));
            context.CreatePermission(PermissionNames.Pages_SubscriptionTrades, L("SubscriptionTrades"));
            context.CreatePermission(PermissionNames.Create_SubscriptionTrades, L("CreateSubscriptionTrades"));
            context.CreatePermission(PermissionNames.Update_SubscriptionTrades, L("UpdateSubscriptionTrades"));
            context.CreatePermission(PermissionNames.Delete_SubscriptionTrades, L("DeleteSubscriptionTrades"));
            context.CreatePermission(PermissionNames.Pages_UserProfiles, L("UserProfiles"));
            context.CreatePermission(PermissionNames.Create_UserProfiles, L("CreateUserProfiles"));
            context.CreatePermission(PermissionNames.Update_UserProfiles, L("UpdateUserProfiles"));
            context.CreatePermission(PermissionNames.Delete_UserProfiles, L("DeleteUserProfiles"));
            context.CreatePermission(PermissionNames.Pages_Verifications, L("Verifications"));
            context.CreatePermission(PermissionNames.Create_Verifications, L("CreateVerifications"));
            context.CreatePermission(PermissionNames.Update_Verifications, L("UpdateVerifications"));
            context.CreatePermission(PermissionNames.Delete_Verifications, L("DeleteVerifications"));
            context.CreatePermission(PermissionNames.Pages_WithdrawalInfos, L("WithdrawalInfos"));
            context.CreatePermission(PermissionNames.Create_WithdrawalInfos, L("CreateWithdrawalInfos"));
            context.CreatePermission(PermissionNames.Update_WithdrawalInfos, L("UpdateWithdrawalInfos"));
            context.CreatePermission(PermissionNames.Delete_WithdrawalInfos, L("DeleteWithdrawalInfos"));
            context.CreatePermission(PermissionNames.Pages_Withdrawals, L("Withdrawals"));
            context.CreatePermission(PermissionNames.Create_Withdrawals, L("CreateWithdrawals"));
            context.CreatePermission(PermissionNames.Update_Withdrawals, L("UpdateWithdrawals"));
            context.CreatePermission(PermissionNames.Delete_Withdrawals, L("DeleteWithdrawals"));
            
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TradePlatformConsts.LocalizationSourceName);
        }
    }
}
