using ngipf_frontend.Enum;

namespace ngipf_frontend.Helper
{
    public class APIResponse<T>
    {
        public T? result { get; set; }
        public APIResponseStatus apiResponseStatus { get; set; }
        public string Message { get; set; }
    }
}
