namespace LONE.Models
{
    public class AddRequestViewModel
    {
        public string SubjectFirstName { get; set; }

        public string SubjectLastName { get; set; }

        public string? SubjectAltFirstName { get; set; }

        public string? SubjectAltLastName { get; set; }

        public string SubjectDateofBirth { get; set; }

        public string? SubjectDateOfDeath { get; set; }

        public string? SubjectCountryOfBirth { get; set; }

        public string? UserTitle { get; set; }

        public string? UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserEmailAddress { get; set; }

        public string UserRetypeEmailAddress { get; set; }

        public string UserAddressLine1 { get; set; }

        public string? UserAddressLine2 { get; set; }

        public string UserTownOrCity { get; set; }

        public string? UserCounty { get; set; }

        public string UserPostcode { get; set; }

        public string UserCountry { get; set; }

    }
}