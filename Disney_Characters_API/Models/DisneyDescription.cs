using System;
namespace Disney_Characters_API.Models
{
	public class DisneyDescription
	{
        public int _id { get; set; }
        public List<string> Films { get; set; }
        public List<string> ShortFilms { get; set; }
        public List<string> TvShows { get; set; }
        public List<string> VideoGames { get; set; }
        public List<string> ParkAttractions { get; set; }
        public List<string> Allies { get; set; }
        public List<string> Enemies { get; set; }
        public string SourceUrl { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public int __v { get; set; }
    }
}

