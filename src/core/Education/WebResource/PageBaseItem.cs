using System.Collections.Generic;
using System.Linq;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    public abstract class PageBaseItem : PageBase
    {
        public abstract class Item
        {
            /// <summary>
            /// Die Steuerelemente
            /// </summary>
            public List<Control> Controls { get; set; }

            /// <summary>
            /// Der Beschreibungstext
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// Der Hinweistext
            /// </summary>
            public string Callout { get; set; }

            /// <summary>
            /// Der Besispielcode
            /// </summary>
            public string Code { get; set; }

        }
        public class PropertyItem : Item { };
        public class ContentItem : Item { };


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
        public Dictionary<string, Item> Items { get; private set; } = new Dictionary<string, Item>();

        /// <summary>
        /// Aufnahme des Beispielcodes
        /// </summary>
        public string Code { get; protected set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageBaseItem()
        {
            //Name = name;
            Examples = new ControlPanelCard()
            {
                BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
            };

        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            var content = new ControlPanel()
            {
            };

            content.Content.Add(new ControlText()
            {
                Text = Description,
                Format = TypeFormatText.Paragraph
            });

            content.Content.Add(new ControlText()
            {
                Text = "Beispiele",
                Format = TypeFormatText.H3
            });

            content.Content.Add(Examples);

            content.Content.Add(new ControlText()
            {
                Text = "Code",
                Format = TypeFormatText.H3
            });

            content.Content.Add(new ControlPanelCard(new ControlText()
            {
                Text = Code,
                Format = TypeFormatText.Code,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
            })
            {
                BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
            });

            var propertys = Items.Where(x => x.Value is PropertyItem);

            if (propertys.Count() > 0)
            {
                content.Content.Add(new ControlText()
                {
                    Text = "Eigenschaften",
                    Format = TypeFormatText.H3
                });

                foreach (var item in propertys)
                {
                    content.Content.Add(new ControlText()
                    {
                        Text = item.Key,
                        Format = TypeFormatText.H4
                    });

                    content.Content.Add(new ControlText()
                    {
                        Text = item.Value.Description,
                        Format = TypeFormatText.Paragraph
                    });

                    if (!string.IsNullOrWhiteSpace(item.Value.Callout))
                    {
                        content.Content.Add(new ControlPanelCallout(new ControlText() { Text = item.Value.Callout })
                        {
                            Color = new PropertyColorCallout(TypeColorCallout.Info),
                            Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                        });
                    }

                    content.Content.Add(new ControlPanelCard(item.Value.Controls.ToArray())
                    {
                        BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
                    });

                    content.Content.Add(new ControlText()
                    {
                        Text = item.Value.Code,
                        Format = TypeFormatText.Code
                    });
                }
            }

            var contentItem = Items.Where(x => x.Value is ContentItem);

            if (contentItem.Count() > 0)
            {
                content.Content.Add(new ControlText()
                {
                    Text = "Untergeordnete Elemente",
                    Format = TypeFormatText.H3
                });

                foreach (var item in contentItem)
                {
                    content.Content.Add(new ControlText()
                    {
                        Text = item.Key,
                        Format = TypeFormatText.H4
                    });

                    content.Content.Add(new ControlText()
                    {
                        Text = item.Value.Description,
                        Format = TypeFormatText.Paragraph
                    });

                    if (!string.IsNullOrWhiteSpace(item.Value.Callout))
                    {
                        content.Content.Add(new ControlPanelCallout(new ControlText() { Text = item.Value.Callout })
                        {
                            Color = new PropertyColorCallout(TypeColorCallout.Info),
                            Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                        });
                    }

                    content.Content.Add(new ControlPanelCard(item.Value.Controls.ToArray())
                    {
                        BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Two)
                    });

                    content.Content.Add(new ControlText()
                    {
                        Text = item.Value.Code,
                        Format = TypeFormatText.Code
                    });
                }
            }

            Content.Primary.Add(content);
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddExample(params Control[] controls)
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
            if (!Items.ContainsKey(key))
            {
                Items.Add(key, new PropertyItem() { Controls = controls.ToList() });
            }
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="key">Der Name</param>
        /// <param name="description">Eine Beschreibung</param>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddProperty(string key, string description, params Control[] controls)
        {
            if (!Items.ContainsKey(key))
            {
                Items.Add(key, new PropertyItem() { Controls = controls.ToList(), Description = description });
            }
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="key">Der Name</param>
        /// <param name="description">Eine Beschreibung</param>
        /// <param name="code">Der Beispielcode</param>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddProperty(string key, string description, string code, params Control[] controls)
        {
            if (!Items.ContainsKey(key))
            {
                Items.Add(key, new PropertyItem() { Controls = controls.ToList(), Description = description, Code = code });
            }
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="key">Der Name</param>
        /// <param name="description">Eine Beschreibung</param>
        /// <param name="callout">Der Hinweistext</param>
        /// <param name="code">Der Beispielcode</param>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddProperty(string key, string description, string callout, string code, params Control[] controls)
        {
            if (!Items.ContainsKey(key))
            {
                Items.Add(key, new PropertyItem()
                {
                    Controls = controls.ToList(),
                    Description = description,
                    Callout = callout,
                    Code = code
                });
            }
        }

        /// <summary>
        /// Fügt eine Eigenschaft hinzu
        /// </summary>
        /// <param name="key">Der Name</param>
        /// <param name="description">Eine Beschreibung</param>
        /// <param name="code">Der Beispielcode</param>
        /// <param name="controls">Die Steuerlemente</param>
        protected void AddContent(string key, string description, string code, params Control[] controls)
        {
            if (!Items.ContainsKey(key))
            {
                Items.Add(key, new ContentItem() { Controls = controls.ToList(), Description = description, Code = code });
            }
        }
    }


}
