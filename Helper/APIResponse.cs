using ngipf_backend.Enum;

namespace ngipf_backend.Helper
{
    public class APIResponse<T>
    {
        public T? result { get; set; }
        public APIResponseStatus apiResponseStatus { get; set; }
        public string Message { get; set; }
    }
}
