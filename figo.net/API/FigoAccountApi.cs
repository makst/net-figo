using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figo.API
{
    public class FigoAccountApi
    {

        public FigoAccountApi()
        {

        }

        #region Accounts
        /// <summary>
        /// All accounts the user has granted your App access to
        /// </summary>
        /// <returns>List of accounts</returns>
        public async Task<IList<FigoAccount>> GetAccounts()
        {
            var response = await this.DoRequest<FigoAccount.FigoAccountsResponse>("/rest/accounts");
            return response == null ? null : response.Accounts;
        }

        /// <summary>
        /// Returns the account with the specified ID
        /// </summary>
        /// <param name="accountId">figo ID for the account to be retrieved</param>
        /// <returns>Account or null</returns>
        public async Task<FigoAccount> GetAccount(String accountId)
        {
            return await this.DoRequest<FigoAccount>("/rest/accounts/" + accountId);
        }

        /// <summary>
        /// Modify an account
        /// </summary>
        /// <param name="account">the modified account to be saved</param>
        /// <returns>Account object for the updated account returned by server</returns>
        public async Task<FigoAccount> UpdateAccount(FigoAccount account)
        {
            return await this.DoRequest<FigoAccount>("/rest/accounts/" + account.AccountId, "PUT", account);
        }

        /// <summary>
        /// Remove an account
        /// </summary>
        /// <param name="account">account to be removed</param>
        public async Task<bool> RemoveAccount(FigoAccount account)
        {
            return await RemoveAccount(account.AccountId);
        }

        /// <summary>
        /// Remove an account
        /// </summary>
        /// <param name="account">ID of the account to be removed</param>
        public async Task<bool> RemoveAccount(String accountId)
        {
            await this.DoRequest("/rest/accounts/" + accountId, "DELETE");
            return true;
        }

        /// <summary>
        /// Returns the balance details of the account with the specified ID
        /// </summary>
        /// <param name="accountId">figo ID for the account whose balance is to be retrieved</param>
        /// <returns>Account balance or null</returns>
        public async Task<FigoAccountBalance> GetAccountBalance(String accountId)
        {
            return await this.DoRequest<FigoAccountBalance>("/rest/accounts/" + accountId + "/balance");
        }

        /// <summary>
        /// Returns the balance details of the specified account
        /// </summary>
        /// <param name="account">Account whose balance is to be retrieved</param>
        /// <returns>Account balance or null</returns>
	    public async Task<FigoAccountBalance> GetAccountBalance(FigoAccount account)
        {
            return await GetAccountBalance(account.AccountId);
        }

        /// <summary>
        /// Modify balance or account limits
        /// </summary>
        /// <param name="accountId">ID of the account to be modified</param>
        /// <param name="accountBalance">modified AccountBalance object to be saved</param>
        /// <returns>AccountBalance object for the updated account as returned by the server</returns>
        public async Task<FigoAccountBalance> UpdateAccountBalance(String accountId, FigoAccountBalance accountBalance)
        {
            return await this.DoRequest<FigoAccountBalance>("/rest/accounts/" + accountId + "/balance", "PUT", accountBalance);
        }

        /// <summary>
        /// Modify balance or account limits
        /// </summary>
        /// <param name="account">the account to be modified</param>
        /// <param name="accountBalance">modified AccountBalance object to be saved</param>
        /// <returns>AccountBalance object for the updated account as returned by the server</returns>
        public async Task<FigoAccountBalance> UpdateAccountBalance(FigoAccount account, FigoAccountBalance accountBalance)
        {
            return await UpdateAccountBalance(account.AccountId, accountBalance);
        }
        #endregion

    }
}
