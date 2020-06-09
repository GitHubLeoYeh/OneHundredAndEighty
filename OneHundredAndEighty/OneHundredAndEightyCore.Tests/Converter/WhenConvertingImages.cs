﻿#region Usings

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace OneHundredAndEightyCore.Tests.Converter
{
    public class WhenConvertingImages : ConverterTestBase
    {
        private Bitmap testBitmap = Resources.Resources.EmptyUserIcon;

        private BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            var ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Bmp);
            var image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();

            return image;
        }

        [Test]
        public void BitmapConvertsToBitmapImage()
        {
            Action act = () => { Common.Converter.BitmapToBitmapImage(testBitmap); };

            act.Should().NotThrow();
        }

        [Test]
        public void Base64ConvertsToBitmapImage()
        {
            BitmapImage image;
            Action act = () => { image = Common.Converter.Base64ToBitmapImage(base64ImageString); };

            act.Should().NotThrow();
        }

        [Test]
        public void BitmapImageConvertsToBase64()
        {
            var bitmapImage = BitmapToBitmapImage(testBitmap);

            var base64String = Common.Converter.BitmapImageToBase64(bitmapImage);

            base64String.Should().Be(testBitmapBase64String);
        }
    }
}