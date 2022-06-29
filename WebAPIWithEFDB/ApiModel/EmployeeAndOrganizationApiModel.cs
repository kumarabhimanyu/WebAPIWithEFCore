namespace WebAPIWithEFDB.ApiModel
{
    public class EmployeeAndOrganizationApiModel
    {
        public EmployeeApiModel Employee { get; set; }

        public List<OrganizationApiModel> OrganizationList { get; set; }
    }
}
