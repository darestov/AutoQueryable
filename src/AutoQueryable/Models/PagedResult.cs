﻿using System.Collections.Generic;

namespace AutoQueryable.Models
{
    public class PagedResult<T> : IPagedResult<T>
    {
        public ICollection<T> Result { get; set; }
        public string NextLink { get; set; }
        public int RowCount { get; set; }
        public int TotalCount { get; set; }

    }
    public interface IPagedResult<T>
    {
        ICollection<T> Result { get; set; }
        string NextLink { get; set; }
        int RowCount { get; set; }
        int TotalCount { get; set; }
    }
}