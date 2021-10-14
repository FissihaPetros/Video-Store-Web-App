using System.Collections.Generic;
using Video_Store_Web_App.Models;

namespace Video_Store_Web_App.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}