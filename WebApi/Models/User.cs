using WebApi.Models.Base;

namespace WebApi.Models;

    public class User: Model
    {
        public string? Name {get; set;}

        public string? LastName {get; set;}

        public string? Address {get; set;}

        public string? PhoneNumber {get; set;}

        public string? Email {get; set;}

        public virtual IList<Loan>? Loans { get; set;} = default!;

    }