'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.SmartArt
Imports System

Namespace VisualBasic.SmartArts
    Public Class AccessChildNodeSpecificPosition
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_SmartArts()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate the presentation
            Dim pres As New Presentation()

            'Accessing the first slide
            Dim slide As ISlide = pres.Slides(0)

            'Adding the SmartArt shape in first slide
            Dim smart As ISmartArt = slide.Shapes.AddSmartArt(0, 0, 400, 400, SmartArtLayoutType.StackedList)

            'Accessing the SmartArt  node at index 0
            Dim node As ISmartArtNode = smart.AllNodes(0)

            'Accessing the child node at position 1 in parent node
            Dim position As Integer = 1
            Dim chNode As SmartArtNode = CType((CType(node.ChildNodes, SmartArtNodeCollection)).Item(position), SmartArtNode)

            'Printing the SmartArt child node parameters
            Dim outString As String = String.Format("j = {0}, Text = {1},  Level = {2}, Position = {3}", position, chNode.TextFrame.Text, chNode.Level, chNode.Position)
            Console.WriteLine(outString)

        End Sub
    End Class
End Namespace