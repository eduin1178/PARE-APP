using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
     public class PagedResultBase : ResultBase
    {
        public object Objeto { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int NextPage
        {
            get
            {
                int page = CurrentPage+1;
                if (CurrentPage == 1 && PageCount == 1)
                {
                    page =  1;
                }

                if (CurrentPage == PageCount)
                {
                    page = CurrentPage;
                }

                return page;
            }
        }
        public int PreviousPage
        {
            get
            {
                int page = 1;
                if (CurrentPage == 1)
                {
                    page =  1;
                }

                if (CurrentPage == PageCount && CurrentPage >1)
                {
                    page = CurrentPage -1;
                }

                return page;
            }
        }
        public int PageCount { get; set; }
        public int PageSize { get; set; } = 10;

        public int FirstRowOnPage
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, Count); }
        }

    }
}
