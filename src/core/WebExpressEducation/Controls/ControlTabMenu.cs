﻿using Education.Pages;
using WebExpress.Pages;
using WebExpress.UI.Controls;

namespace Education.Controls
{
    public class ControlTabMenu : ControlTab
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="page">Die zugehörige Seite</param>
        public ControlTabMenu(IPage page)
            : base(page)
        {
            Init();
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        private void Init()
        {
            var root = Page.Uri.Root;

            Layout = TypesLayoutTab.Pill;
            HorizontalAlignment = TypesTabHorizontalAlignment.Center;

            Items.Add(new ControlLink(Page)
            {
                Text = "Home",
                Uri = root,
                Active = (Page is PageHome) ? TypesActive.Active : TypesActive.None,
                Icon = Icon.Home
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Tutorials",
                Uri = root.Append("tutorial"),
                Active = Page is IPageTutorial ? TypesActive.Active : TypesActive.None,
                Icon = Icon.GraduationCap
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Controls",
                Uri = root.Append("control"),
                Active = Page is IPageControl ? TypesActive.Active : TypesActive.None,
                Icon = Icon.Clone
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Html",
                Uri = root.Append("html"),
                Active = Page is IPageHtml  ? TypesActive.Active : TypesActive.None,
                Icon = Icon.Code
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Hilfe",
                Uri = Page.Uri.Root.Append("help"),
                Active = Page is PageHelp ? TypesActive.Active : TypesActive.None,
                Icon = Icon.InfoCircle
            });
        }
    }
}
