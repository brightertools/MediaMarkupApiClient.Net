using System.Threading.Tasks;
using MediaMarkup.Api.Models;

namespace MediaMarkup.Api
{
    public interface IApprovals
    {
        /// <summary>
        /// Gets the list of approvals for the specified parameters, <see cref="ApprovalListRequestParameters"/>
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns><see cref="ApprovalListResult"/></returns>
        Task<ApprovalListResult> GetList(ApprovalListRequestParameters parameters);

        /// <summary>
        /// Upload file to create a new Approval
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="approvalCreateParameters"></param>
        /// <returns></returns>
        Task<ApprovalCreateResult> Create(string filePath, ApprovalCreateParameters approvalCreateParameters);

        /// <summary>
        /// Upload file to create a new Approval
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="fileContent"></param>
        /// <param name="approvalCreateParameters"></param>
        /// <returns></returns>
        Task<ApprovalCreateResult> Create(string filename, byte[] fileContent, ApprovalCreateParameters approvalCreateParameters);

        /// <summary>
        /// Updates an approval with all the specified paramaters
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task Update(ApprovalUpdateParameters parameters);

        /// <summary>
        /// Updates the Approval OwnerUserId
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task UpdateOwnerUserId(ApprovalUpdateOwnerUserIdParameters parameters);

        /// <summary>
        /// Updates the Approval Name / Description
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task UpdateName(ApprovalUpdateNameParameters parameters);

        /// <summary>
        /// Updates the Approval Active/Enabled property
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task SetActive(ApprovalSetActiveParameters parameters);

        /// <summary>
        /// Create new version, adding a file to an existing approval
        /// </summary>
        /// <param name="filePath">Full path to file (must include a support extension)</param>
        /// <param name="parameters">Approval Create Version Parameters see <see cref="ApprovalCreateVersionParameters"/></param>
        /// <returns><see cref="ApprovalCreateVersionResult"/></returns>
        Task<ApprovalCreateVersionResult> CreateVersion(string filePath, ApprovalCreateVersionParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">Filename (must include a support extension)</param>
        /// <param name="fileContent">File content as byte array</param>
        /// <param name="parameters">Approval Create Version Parameters see <see cref="ApprovalCreateVersionParameters"/></param>
        /// <returns><see cref="ApprovalCreateVersionResult"/></returns>
        Task<ApprovalCreateVersionResult> CreateVersion(string filename, byte[] fileContent, ApprovalCreateVersionParameters parameters);

        /// <summary>
        /// Creates the personal url for the specified user, approvalId & version (specify compare approval id and vesion to view comparison)
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns><see cref="PersonalUrlCreateResult"/></returns>
        Task<PersonalUrlCreateResult> CreatePersonalUrl(PersonalUrlCreateParameters parameters);

        /// <summary>
        /// Deletes the specified approval.
        /// All approval data is permanently deleted. This cannot be undone.
        /// Users are not deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(string id);
    }
}