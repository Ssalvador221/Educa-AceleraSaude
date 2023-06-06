namespace Acelera_Saude.Models
{
    public class FirebaseError
    {
        public class FirebaseErro
        {
            public Error Error { get; set; }
        }


        public class Error
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public List<Error> Errors { get; set; }

        }
    }
}
