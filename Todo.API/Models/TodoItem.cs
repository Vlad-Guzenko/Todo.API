﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.API.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsCompleted { get; set; }
    }
}
