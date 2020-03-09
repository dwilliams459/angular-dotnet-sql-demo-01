namespace timeline_server_dotnet_data
{
    public class SearchCriteria
    {
        public int PageSize { get; set; }
        public int Page { get; set; }

        public SearchCriteria()
        {
            PageSize = 25;
            Page = 0;
        }
    }
}