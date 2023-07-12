namespace InternshipProject.Middleware {
    public class ErrorObject {
        public string Message { get; set; } = null!;
        public int Code { get; set; }
        public string ContentType { get; set; } = null!;
    }
}
