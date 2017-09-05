﻿using System;

namespace MovieScrapper.Entities.Interfaces
{
    interface IGameProperties
    {
        int Id { get; set; }
        DateTime StopGameDate { get; set; }
        DateTime StartGameDate { get; set; }
    }
}
