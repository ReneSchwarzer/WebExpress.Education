using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public abstract class PageBaseItem : PageBase
    {
        /// <summary>
        /// Aufnahme der Links zu den verschiedenen Elementen
        /// </summary>
        public ControlTab Menu { get; private set; }
        
        /// <summary>
        /// Aufnahme des Namens
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Aufnahme der Beschreibung
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// Aufnahme der Beispiele
        /// </summary>
        public ControlPanelCard Examples { get; private set; }

        /// <summary>
        /// Aufnahme der Eigenschaften
        /// </summary>
        public Dictionary<string, List<Control>> Propertys { get; private set; } = new Dictionary<string, List<Control>>();

        /// <summary>
        /// Aufnahme des Beispielcodes
        /// </summary>
        public string Code { get; protected set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Der Seitenname</param>
        public PageBaseItem(string name)
            : base(name)
        {
            Name = name;
            Examples = new ControlPanelCard(this)
            {
                BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Light),
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
            };
            Menu = new ControlTab(this)
            {
                Layout = TypesLayoutTab.Pill,
                Orientation = TypesNavOrientation.Vertical
            };
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
            var grid = new ControlGrid(this) 
            { 
                Margin = new PropertySpacingMargin(PropertySpacing.Space.Null) 
            };

            var content = new ControlPanel(this);

            content.Content.Add(new ControlText(this)
            {
                Text = Name,
                Format = TypesTextFormat.H1
            });

            content.Content.Add(new ControlText(this)
            { 
                Text = Description,
                Format = TypesTextFormat.Paragraph
            });

            content.Content.Add(new ControlText(this)
            {
                Text = "Beispiele",
                Format = TypesTextFormat.H1
            });

            content.Content.Add(Examples);

            if (Propertys.Count > 0)
            {
                content.Content.Add(new ControlText(this)
                {
                    Text = "Eigenschaften",
                    Format = TypesTextFormat.H1
                });

                foreach (var item in Propertys)
                {
                    content.Content.Add(new ControlText(this)
                    {
                        Text = item.Key,
                        Format = TypesTextFormat.H4
                    });

                    content.Content.Add(new ControlPanelCard(this, item.Value.ToArray())
                    {
                        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Light),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
                    });
                }
            }

            content.Content.Add(new ControlText(this)
            {
                Text = "Code",
                Format = TypesTextFormat.H1
            });

            content.Content.Add(new ControlPanelCard(this, new ControlText(this)
            {
                Text = Code,
                Format = TypesTextFormat.Code,
            })
            {
                BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Light),
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
            });

            grid.Add(0, 2, Menu);
            grid.Add(0, 10, content);
            Main.Content.Add(grid);
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddExample(params Control [] controls)
        {
            Examples.Content.AddRange(controls.ToList());
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="key">Der Name</param>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddProperty(string key, params Control[] controls)
        {
            if (!Propertys.ContainsKey(key))
            {
                Propertys.Add(key, controls.ToList());
            }
        }
    }


}
