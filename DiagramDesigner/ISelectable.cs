﻿
namespace DiagramDesigner
{
    // Common interface for items that can be selected
    // on the DesignerCanvas; used by DesignerItem and Connection
    public interface ISelectable
    {
        bool IsSelected { get; set; }
        bool DisableSelection { get; set; }
    }
}
