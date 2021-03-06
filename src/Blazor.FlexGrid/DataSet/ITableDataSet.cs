﻿using Blazor.FlexGrid.Components.Events;

namespace Blazor.FlexGrid.DataSet
{

    /// <summary>
    /// Represents a collection of Items with paging, sorting and inline editation
    /// </summary>
    public interface ITableDataSet : IPageableTableDataSet, ISortableTableDataSet, ISelectableDataSet, IRowEditableDataSet
    {
        GridViewEvents GridViewEvents { get; }
    }
}
