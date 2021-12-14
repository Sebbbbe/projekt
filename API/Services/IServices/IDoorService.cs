﻿using API.Models;
using System.Threading.Tasks;

namespace API.Services.IServices
{
    public interface IDoorService
    {
        Task<List<Output>> FindEntriesByDoor(string name);

        Task<List<Output>> FindEntriesByCode(string name);
    }
}