using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expander
{
    internal static class Images
    {
        // This utility method creates bitmaps for all the icons.
        // It uses a utility method called DeserializeFromBase64
        // to decode the Base64 image data.
        public static void CreateBitmaps()
        {
            ExpandedImage = DeserializeFromBase64(_expandedImage);
            CollapsedImage = DeserializeFromBase64(_collapsedImage);
            MenuBtnImage = DeserializeFromBase64(_menuBtnImage);
            MenuMouseOverBtnImage = DeserializeFromBase64(_menuMouseOverBtnImage);
        }

        /// <summary>
        /// The expander image in 16x16px.
        /// </summary>
        public static Image ExpandedImage;

        /// <summary>
        /// The expander image in 16x16px.
        /// </summary>
        public static Image CollapsedImage;

        /// <summary>
        /// The default button menu image in 14x14px.
        /// </summary>
        public static Image MenuBtnImage;

        /// <summary>
        /// The mouseover button menu image in 16x16px.
        /// </summary>
        public static Image MenuMouseOverBtnImage;

        // This utility method cretes a bitmap from 
        // a Base64-encoded string. 
        private static Bitmap DeserializeFromBase64(string data)
        {
            // Decode the string and create a memory stream 
            // on the decoded string data.
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(data));

            // Create a new bitmap from the stream.
            Bitmap b = new Bitmap(stream);

            return b;
        }

        /// <summary>
        /// The expanded image in 16x16px Base64 encoding.
        /// </summary>
        private static readonly string _expandedImage = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/" +
                                                "9hAAAABmJLR0QA/wD/AP+gvaeTAAAAkElEQVQ4Ee2Q" +
                                                "Ow6DQAwFvRGXSJTCZ+OjALfKXeAIKdJwkkibsTAFK0" +
                                                "K2B0ujlf3eNCtyjsQYC3jCNfc76N7AnOISQvggjgZH" +
                                                "lT/jHesP7s4GQQMTqPwYy8A6zWaFsAYrqCTDXcGyOo" +
                                                "nWK6UKrKjiw77IlZ/2H4QS3nCHRS73rSRF7OHldEmc" +
                                                "tyK38MhrH7f1Bf7hhq470T4sAAAAAElFTkSuQmCC";

        /// <summary>
        /// The collapsed image in 16x16px Base64 encoding.
        /// </summary>
        private static readonly string _collapsedImage = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8" +
                                                         "/9hAAAABmJLR0QA/wD/AP+gvaeTAAAAjE" +
                                                         "lEQVQ4Ee2QywmAMBQEc7AEc9AG/ZTgrxd" +
                                                         "LUrCeOAmuoMTgWRTGkH2zT9CY/0n+Aedc" +
                                                         "DVVSehpSbGE7aJ68aE6pgwVysLBCF5XvI" +
                                                         "WIPvmw1464lvbLoiTiA/9pZlkiuJYOyy4" +
                                                         "kwQrQskbmWjMrCyWCCZDmIvPC0ZOJqDEE" +
                                                         "GMxQhePHCLcF3shf655UdyrCQJ362rtoA" +
                                                         "AAAASUVORK5CYII=";

        /// <summary>
        /// The default button menu image in 14x14px Base64 encoding.
        /// </summary>
        private static readonly string _menuBtnImage = "iVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAYAAAAfSC3" +
                                               "RAAAABmJLR0QA/wD/AP+gvaeTAAAAsUlEQVQoFZWSPQ" +
                                               "7CMAyFk4qVSixs5SDsjHAYeoMOSJ3gLvwMCDbuFb4nN" +
                                               "VIHu00rv9h69qemlUNwnpTSRnLaIVoNgCP+ASneMcaH" +
                                               "ilkB3vLQuM6e8kqHoS/ABV83+pDLA3AreURlNQBq/Ba" +
                                               "dh5qyIBjuUIN2qLOQyjLx9G2khcFbatQPWi/CgXTVxo" +
                                               "PMKwGdAPZI/R8LcKeeD8BrnhrX2VP2FuAJoO3Rz3tps" +
                                               "FiAk0v+BzGDXBoAerS1AAAAAElFTkSuQmCC";

        /// <summary>
        /// The mouseover button menu image in 16x16px Base64 encoding.
        /// </summary>
        private static readonly string _menuMouseOverBtnImage = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCA" +
                                                        "YAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeT" +
                                                        "AAAAk0lEQVQ4EbWTUQpAQBCGcQN34AxyBs" +
                                                        "lR3UGeSN7kEJxhfcrUvMxEG83XTv/szL9o" +
                                                        "k+SvJ4TQwQkHtJ99aNpBYrMGZFYB/QAJnY" +
                                                        "vmr1iX0D8U/u4/qjjXMMME1WcPmlaQWKwB" +
                                                        "3kdMVZPOleykWMe9gjP7XYkTxP1GBowgMV" +
                                                        "i2mVVAz0FC56L5K9YtnHBfpsbfHVG9AJbs" +
                                                        "hJ8qYx6uAAAAAElFTkSuQmCC";
    }
}
