using ArticleProject.Core;
using ArticleProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArticleProject.Pages
{
    public class AllUsersModel : PageModel
    {
        private readonly IDataHelper<Core.Author> dataHelper;
        public int NoOfItem;

        public AllUsersModel(IDataHelper<Core.Author> dataHelper)
        {
            this.dataHelper = dataHelper;
            NoOfItem = 6;
            ListOfAuthor = new List<Core.Author>();
        }


        public List<Core.Author> ListOfAuthor { get; set; }


        public void OnGet(string LoadState, string search, int id)
        {
            if (LoadState == null || LoadState == "All")
            {
                GetAllAuthers();

            }


            else if (LoadState == "Search")
            {
                SearchData(search);

            }
            else if (LoadState == "Next")
            {
                GetNextData(id);
            }
            else if (LoadState == "Prev")
            {
                GetNextData(id - NoOfItem);
            }

        }



        private void GetAllAuthers()
        {
            ListOfAuthor = dataHelper.GetAllData().Take(NoOfItem).ToList();
        }


        private void SearchData(string SearchItem)
        {
            ListOfAuthor = dataHelper.Search(SearchItem);
        }
        private void GetNextData(int id)
        {
            ListOfAuthor = dataHelper.GetAllData().Where(x => x.Id > id).Take(NoOfItem).ToList();
        }


    }
}
