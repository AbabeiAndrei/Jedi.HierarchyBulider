using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public enum ViewDisplayType
    {
        None = 0,
        ListView,
        SimpleGridDisplay,
        ExtendedGridDisplay
    }

    public enum FrontendTheme
    {
        DarkBlueTheme = 1
    }

    public abstract class AbstractDisplayModel
    {
        [DefaultValue(ViewDisplayType.ListView)]
        public virtual ViewDisplayType ViewDisplay { get; set; } = ViewDisplayType.ListView;

        [DefaultValue(true)]
        public virtual bool ShowNewFlag { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowProgress { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowDescription { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowGenericInfo { get; set; } = true;

        [DefaultValue(FrontendTheme.DarkBlueTheme)]
        public virtual FrontendTheme? Theme { get; set; } = FrontendTheme.DarkBlueTheme;
    }

    public class ChildDisplayModel : AbstractDisplayModel { }

    public class MasterDisplayModel : AbstractDisplayModel
    {
        [DefaultValue(true)]
        public virtual bool ShowFilter { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowNavigationWidget { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowSupportWidget { get; set; } = true;
    }
}
