using System;
using System.Collections.Generic;

namespace MediaLibrary.Model
{
    public abstract class Media
    {
        // public properties
        public UInt64 mediaId { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        // constructor
        public Media()
        {
            genres = new List<string>();
        }

        // public method
        public virtual string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nGenres: {string.Join(", ", genres)}\n";
        }
    }
    // Movie class is derived from Media class - moved to its own cs files
    // Album class is derived from Media class - moved to its own cs files
    // Book class is derived from Media class - moved to its own cs files
}
