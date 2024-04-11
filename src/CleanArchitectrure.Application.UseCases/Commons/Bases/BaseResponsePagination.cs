namespace CleanArchitectrure.Application.UseCases.Commons.Bases
{
    public class BaseResponsePagination<T>: BaseReponseGeneric<T>
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
    }
}
