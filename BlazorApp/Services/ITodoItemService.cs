﻿using AuthDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Data;

namespace BlazorApp.Services
{
    public interface ITodoItemService
    {
        Task<TodoItemViewModel[]> GetIncompleteItemsAsync(AppUser user);

        Task<Guid> AddItemAsync(TodoItemViewModel newItem, AppUser user);

        Task<bool> MarkDoneAsync(TodoItemViewModel item, AppUser user);
    }
}
