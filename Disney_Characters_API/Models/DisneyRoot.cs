using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Disney_Characters_API.Models
{
	public class DisneyRoot
	{
        public Info Info { get; set; }
        public List<DisneyDescription> Data { get; set; }
    }
}

