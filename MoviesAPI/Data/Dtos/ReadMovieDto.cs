﻿namespace MoviesAPI.Data.Dtos;

public class ReadMovieDto
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public DateTime QueryTime { get; set; } = DateTime.Now;
}