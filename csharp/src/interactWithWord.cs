// this program demostrate how to interact with word using office tools
// to compile this write below syntax or see readme file
// path\to\css interactWithWord.cs /r:path\to\Microsoft.Office.Interop.Word.dll

using System;
using Microsoft.Office.Interop.Word;

namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
        Application ap = new Application();
		ap.Application.Visible = true;

		try
		{

			Document doc = ap.Documents.Open( @"C:\Users\electron\Desktop\hello.docx", ReadOnly: false, Visible: true );
			doc.Activate();

			Selection sel =  ap.Selection;

			if ( sel != null )
			{
				switch ( sel.Type )
				{
					case WdSelectionType.wdSelectionIP:

						sel.Paste();
						sel.TypeText("");
						sel.TypeParagraph();
						sel.TypeText("");
						sel.TypeParagraph();
						sel.Paste();
						sel.TypeText("");
						sel.TypeParagraph();
						break;

					default:
						Console.WriteLine( "Selection type not handled; no writing done" );
						break;

				}

				ap.Documents.Save( NoPrompt: true, OriginalFormat: true );

			}
			else
			{
				Console.WriteLine( "Unable to acquire Selection...no writing to document done.." );
			}

			Console.Read();

			ap.Documents.Close( SaveChanges: false, OriginalFormat: false, RouteDocument: false );

		}
		catch ( Exception ex )
		{
			Console.WriteLine( "Exception Caught: " + ex.Message ); // Could be that the document is already open (/) or Word is in Memory(?)
		}
		finally
		{
			// Ambiguity between method 'Microsoft.Office.Interop.Word._Application.Quit(ref object, ref object, ref object)' and non-method 'Microsoft.Office.Interop.Word.ApplicationEvents4_Event.Quit'. Using method group.
			// ap.Quit( SaveChanges: false, OriginalFormat: false, RouteDocument: false );
			( (_Application)ap ).Quit( SaveChanges: false, OriginalFormat: false, RouteDocument: false );

			System.Runtime.InteropServices.Marshal.ReleaseComObject( ap );
		}
      }
   }
}
