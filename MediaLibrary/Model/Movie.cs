﻿using System;

namespace MediaLibrary.Model
{
    public class Movie : Media
    {
        public string director { get; set; }
        public TimeSpan runningTime { get; set; }

        public override string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nDirector: {director}\nRun time: {runningTime}\nGenres: {string.Join(", ", genres)}\n";
        }
    }
}