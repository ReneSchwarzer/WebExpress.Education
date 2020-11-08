﻿using System;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageHome : PageBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHome()
            : base("Überblick")
        {
            HeaderScriptLinks.Add("/Assets/js/Chart.min.js");
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            Content.Content.Add(new ControlText()
            {
                Text = "Willkommen",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
