﻿using System;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
