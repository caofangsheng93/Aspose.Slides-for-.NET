﻿'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Imports System.IO
Imports Aspose.Slides
Imports Aspose.Slides.Export

Namespace VisualBasic.Presentations
    Public Class ExportMediaFilestohtml
        Public Shared Sub Run()

            'Loading a presentation
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            Using pres As New Presentation(dataDir + "Media File.pptx")
                Dim path1 As String = dataDir
                Const fileName As String = "ExportMediaFiles.html"
                Const baseUri As String = "http://www.example.com/"

                Dim controller As New VideoPlayerHtmlController(path:=path1, fileName:=fileName, baseUri:=baseUri)

                'Setting HTML options
                Dim htmlOptions As New HtmlOptions(controller)
                Dim svgOptions As New SVGOptions(controller)

                htmlOptions.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(controller)
                htmlOptions.SlideImageFormat = SlideImageFormat.Svg(svgOptions)

                'Saving the file
                pres.Save(Path.Combine(path1, fileName), SaveFormat.Html, htmlOptions)

            End Using
        End Sub
    End Class
End Namespace