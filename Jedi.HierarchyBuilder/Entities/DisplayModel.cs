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
        ExtendedGridDisplay,
        Default = ListView,
    }

    public enum FrontendTheme
    {
        None = 0,
        DarkBlueTheme = 1,
        // Currently not supported
        OrangeTheme,
        //Others to be added in the future
    }

    public abstract class AbstractDisplayModel
    {
        [DefaultValue(ViewDisplayType.Default)]
        public virtual ViewDisplayType? ViewDisplay { get; set; } = null;

        [DefaultValue(true)]
        public virtual bool ShowNewFlag { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowProgress { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowDescription { get; set; } = true;

        [DefaultValue(true)]
        public virtual bool ShowDuration { get; set; } = true;

        [DefaultValue(FrontendTheme.DarkBlueTheme)]
        public virtual FrontendTheme? Theme { get; set; }
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
