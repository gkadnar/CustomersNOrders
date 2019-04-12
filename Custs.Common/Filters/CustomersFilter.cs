namespace Custs.Common.Filters
{
    public class CustomersFilter
    {
        public CustomersFilter(int pageNumber, int pageSize, string ordering, string searchCustomer)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Ordering = ordering;
            this.SearchCustomer = searchCustomer;
        }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string Ordering { get; set; }

        public string SearchCustomer { get; set; }
    }
}
