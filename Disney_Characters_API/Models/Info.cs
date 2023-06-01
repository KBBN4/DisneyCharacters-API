using System;
namespace Disney_Characters_API.Models
{
	public class Info
	{
        public int Count { get; set; }
        public int TotalPages { get; set; }
        public string? PreviousPage { get; set; }
        public string? NextPage { get; set; }
    }
}

