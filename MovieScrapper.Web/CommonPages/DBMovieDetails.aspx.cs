﻿using System;

namespace MovieScrapper.CommonPages
{
    public partial class DBMovieDetails : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected string BuildPosterUrl(string path)
        {
            return "http://image.tmdb.org/t/p/w300" + path;
        }

        protected string BuildBackUrl()
        {

            string backUrl = Request.QueryString["back"];
            return backUrl;
        }

        protected string BuildImdbUrl(string movieId)
        {
            return "http://www.imdb.com/title/" + movieId;
        }
    }
}