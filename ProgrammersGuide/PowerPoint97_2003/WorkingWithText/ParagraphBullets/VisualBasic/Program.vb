'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports System.Drawing
Imports System

Namespace ParagraphBullets
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Presentation object that represents a PPT file
			Dim pres As New Presentation(dataDir & "demo.ppt")


			'Accessing a slide using its slide position
			Dim slide As Slide = pres.GetSlideByPosition(1)


			'Accessing the first placeholder in the slide and typecasting it as a text holder
			Dim th As TextHolder = CType(slide.Placeholders(0), TextHolder)


			'Getting the first paragraph of the text holder
			Dim para As Paragraph = th.Paragraphs(0)


			'True means, it has bullets
			para.HasBullet = True


			'Setting the bullets color
			para.BulletColor = Color.Blue


			'Setting the bullet height
			para.BulletHeight = 125


			'Setting the bullet character using the ASCII code of a symbol
			para.BulletCharacter = Convert.ToChar("?")


			'Writing the presentation as a PPT file
			pres.Write(dataDir & "modified.ppt")


		End Sub
	End Class
End Namespace