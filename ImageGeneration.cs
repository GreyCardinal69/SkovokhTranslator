using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Skovokh_Translator
{
    public sealed class ImageGeneration
    {
        private static int GetWidthFromLayerMode( LayerMode mode ) =>
            mode switch
            {
                LayerMode.TenlettersALayer => 200,
                LayerMode.TwentyLettersALayer => 400,
                LayerMode.ThirtyLettersALayer => 650,
                _ => throw new NotImplementedException()
            };

        private static int GetCharCountFromLayerMode ( LayerMode mode ) =>
            mode switch
            {
                LayerMode.TenlettersALayer => 10,
                LayerMode.TwentyLettersALayer => 20,
                LayerMode.ThirtyLettersALayer => 30,
                _ => throw new NotImplementedException()
            };

        public static List<string> GetAllFilesFromFolder ( string root, bool searchSubfolders )
        {
            Queue<string> folders = new();
            List<string> files = new();
            folders.Enqueue( root );
            while (folders.Count != 0)
            {
                string currentFolder = folders.Dequeue();
                try
                {
                    string[] filesInCurrent = System.IO.Directory.GetFiles( currentFolder, "*.*", System.IO.SearchOption.TopDirectoryOnly );
                    files.AddRange( filesInCurrent );
                }
                catch { }
                try
                {
                    if (searchSubfolders)
                    {
                        string[] foldersInCurrent = System.IO.Directory.GetDirectories( currentFolder, "*.*", System.IO.SearchOption.TopDirectoryOnly );
                        foreach (string _current in foldersInCurrent)
                        {
                            folders.Enqueue( _current );
                        }
                    }
                }
                catch { }
            }
            return files;
        }

        public static void CombineImages ( string[] filePaths )
        {
            foreach (var image in GetAllFilesFromFolder( Directory.GetCurrentDirectory() + $@"\img\Step1\", false))
            {
                File.Delete( image );
            }

            List<List<string>> lines = new();

            // sets amount of skovokh letters per horizontal layer.
            int charCount = GetCharCountFromLayerMode( Form1.Instance.ImageType );

            // next lines up to the foreach statement divide the letter array into sets of lines ( for horizontal layers )
            // depending on current LayerMode.
            for (int w = 0; w < 1 + filePaths.Length / charCount; w++)
                lines.Add( new List<string>() );

            if (lines.Count == 0)
                lines.Add( new() );

            int i = 0;
            int index = 0;
            foreach (var item in filePaths)
            {
                if (i < charCount)
                {
                    lines[index].Add( item );
                    i++;
                }
                if (i == charCount)
                {
                    lines[index].Add( Directory.GetCurrentDirectory() + $@"\img\Step0\arrow.png" );
                    index++;
                    i = 0;
                }
            }

            int b = 0;
            foreach (var files in lines)
            {
                // change the location to store the final image.
                string finalImagePath = Directory.GetCurrentDirectory() + $@"\img\Step1\semifinal{b}.png";
                int nIndex = 0;

                // sets image size, according to layer mode. height is always 35 pixels.
                Bitmap finalImage = new( GetWidthFromLayerMode( Form1.Instance.ImageType ), 35 );
                Graphics graphic = Graphics.FromImage( finalImage );

                // changes background to black.
                graphic.Clear( Color.Black );

                int lastWidth = 0;

                foreach (string file in files)
                {
                    // gets the skovokh image.
                    Image img = Image.FromFile( file );
                    if (nIndex == 0)
                    {
                        // 5 pixels to the right from the border, 5 pixels down from top to add spacing
                        graphic.DrawImage( img, new Point( 5, 5 ) );
                        // adds width, best value I found was ( letter width / 2,5) + 5 pixels.
                        lastWidth += ( int ) ( img.Width / 2.5 ) + 5;
                        nIndex++;
                    }
                    else
                    {
                        // places letter at 5 pixels + calculated width from last letter. 5 px from top to add spacing.
                        graphic.DrawImage( img, new Point( lastWidth, 5 ) );
                        lastWidth += ( int ) ( img.Width / 2.5 );
                    }
                    img.Dispose();
                    b++;
                }

                graphic.Dispose();
                // saves temporary horizontal layer to Directory.GetCurrentDirectory() + @"\img\Step1".
                finalImage.Save( finalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg );
                finalImage.Dispose();
            }

            // gets all processed horizontal layers and sends them to be vertically merged.
            DirectoryInfo directory = new( Directory.GetCurrentDirectory() + @"\img\Step1" );
            if (directory != null)
            {
                FileInfo[] files = directory.GetFiles();
                CombineImagesVertical( files );
            }
        }

        public static void CombineImagesVertical ( FileInfo[] files )
        {
            // change the location to store the final image.
            string finalImagePath = Directory.GetCurrentDirectory() + @"\img\Step2\FinalImage.jpg";

            int nIndex = 0;
            int height = 0;

            foreach (FileInfo file in files)
            {
                Image img = Image.FromFile( file.FullName );
                height += img.Height;
                img.Dispose();
            }

            // sets image size, according to layer mode. Horizontal layer height is always 35 pixels.
            // adds 5 pixels to height for spacing.
            Bitmap finalImage = new( GetWidthFromLayerMode( Form1.Instance.ImageType ), height + 5 );
            Graphics graphic = Graphics.FromImage( finalImage );

            // changes background to black.
            graphic.Clear( Color.Black );
            int lastHeight = 0;

            foreach (FileInfo file in files)
            {
                Image img = Image.FromFile( file.FullName );
                if (nIndex == 0)
                {
                    // 5 pixels to the right from the border to add spacing
                    // this time no vertical spacing, since horizontal layers already did that for their letters.
                    graphic.DrawImage( img, new Point( 5, 0 ) );
                    // adds height, unlike horizontal ones there is no need to divide by 2.5
                    // adds current horizontal layer height + 5 pixels for spacing.
                    lastHeight += img.Height + 5;
                    nIndex++;
                }
                else
                {
                    // puts the calculated "lastHeight" height, with 5 pixels to right from border for spacing.
                    graphic.DrawImage( img, new Point( 5, lastHeight ) );
                    lastHeight += img.Height;
                }
                img.Dispose();
            }

            graphic.Dispose();
            // saves the fully compiled / merged image.
            finalImage.Save( finalImagePath, System.Drawing.Imaging.ImageFormat.Jpeg );
            finalImage.Dispose();
        }
    }
}