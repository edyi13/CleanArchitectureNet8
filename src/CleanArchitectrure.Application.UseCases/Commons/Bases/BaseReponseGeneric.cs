namespace CleanArchitectrure.Application.UseCases.Commons.Bases
{
    public class BaseReponseGeneric<T>
    {
        public bool succcess { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public IEnumerable<BaseError>? Errors { get; set; }
    }
}
