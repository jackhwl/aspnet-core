using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage) 
        {
            TotalItemCount= totalItemCount;
            TotalPageCount= pageSize;
            CurrentPage= currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double) pageSize);
        }
    }
}
