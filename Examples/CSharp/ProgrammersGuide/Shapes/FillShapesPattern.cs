//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

namespace CSharp.Shapes
{
    public class FillShapesPattern
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Prseetation class that represents the PPTX
            using (Presentation pres = new Presentation())
            {

                //Get the first slide
                ISlide sld = pres.Slides[0];

                //Add autoshape of rectangle type
                IShape shp = sld.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 150, 75, 150);

                //Set the fill type to Pattern
                shp.FillFormat.FillType = FillType.Pattern;

                //Set the pattern style
                shp.FillFormat.PatternFormat.PatternStyle = PatternStyle.Trellis;

                //Set the pattern back and fore colors
                shp.FillFormat.PatternFormat.BackColor.Color = Color.LightGray;
                shp.FillFormat.PatternFormat.ForeColor.Color = Color.Yellow;

                //Write the PPTX file to disk
                pres.Save(dataDir + "RectShpPatt.pptx", SaveFormat.Pptx);
            }
        }
    }
}