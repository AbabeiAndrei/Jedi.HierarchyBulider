using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace Jedi.HierarchyBuilder.Utils.Drawer
{
    public class IconDrawer
    {
        #region Fields

        private readonly IDictionary<int, Image> _images;
        private static readonly StringFormat _stringFormat;
        private Font _drawingFont;

        #endregion

        #region Properties

        public Font DrawingFont
        {
            get
            {
                return _drawingFont;
            }
            set
            {
                _drawingFont = value;
                _images.Clear();
            }
        }

        public Size Size { get; set; }

        public Color BackgroundColor { get; set; }

        public Color ForegroundColor { get; set; }

        public Rectangle Bounds => new Rectangle(Point.Empty, Size);

        #endregion

        #region Constructors

        public IconDrawer()
        {
            _images = new Dictionary<int, Image>();
            DrawingFont = new Font(FontFamily.GenericMonospace, 14f, FontStyle.Regular);
            Size = new Size(32, 32);
            BackgroundColor = Color.Transparent;
            ForegroundColor = Color.Black;
        }

        static IconDrawer()
        {
            _stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        #endregion

        #region Public methods

        public Image DrawNumber(int number)
        {
            if (_images.ContainsKey(number))
                return _images[number];

            var img = new Bitmap(Size.Width, Size.Height);

            using (var gfx = Graphics.FromImage(img))
            {
                gfx.CompositingMode = CompositingMode.SourceOver;
                gfx.CompositingQuality = CompositingQuality.HighQuality;
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var brush = new SolidBrush(BackgroundColor))
                {
                    gfx.FillRectangle(brush, Bounds);
                }

                using(var font = new Font(DrawingFont.FontFamily, DrawingFont.Size - (number.NumberOfDigits() - 1) * 4 ))
                {
                    using (var brush = new SolidBrush(ForegroundColor))
                    {
                        gfx.DrawString(number.ToString(), font, brush, Bounds, _stringFormat);
                    }
                }
            }

            _images.Add(number, img);
            return img;
        }

        #endregion
    }
}
