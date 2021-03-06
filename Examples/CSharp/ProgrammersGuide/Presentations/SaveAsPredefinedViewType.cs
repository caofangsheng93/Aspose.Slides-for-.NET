﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

using Aspose.Slides;

namespace CSharp.ProgrammersGuide.Presentations
{
    class SaveAsPredefinedViewType
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Presentations();

            // Opening the presentation file
            Presentation presentation = new Presentation();

            //Setting view type 
            presentation.ViewProperties.LastView = ViewType.SlideMasterView;

            //Saving presentation
            presentation.Save(dataDir + "SetViewType.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}
