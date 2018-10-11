namespace Sakila.Models {
    public class LoginViewModel {
        public string Email {get;set;}
        public string Password {get;set;}

        // TODO: remover quando o login antigo for descontinuado
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}