using System;
using Gtk;
using GtkSharp;

/// <summary>
/// Main window.
/// </summary>
public partial class MainWindow: Gtk.Window
{	
	/// <summary>
	/// Initializes a new instance of the <see cref="MainWindow"/> class.
	/// </summary>
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Console.WriteLine( "Window Built\n" );
	}

	/// <summary>
	/// Raises the delete event event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='a'>
	/// The alpha component.
	/// </param>
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	/// <summary>
	/// Raises the file menu quit actived event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected virtual void OnFileMenuQuitActived (object sender, System.EventArgs e)
	{
		Application.Quit ();
	}

	/// <summary>
	/// Raises the login button clicked event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void OnLoginButtonClicked (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (this, 
		                                      DialogFlags.DestroyWithParent,
		                                      MessageType.Error, 
		                                      ButtonsType.Close, "Error loading file");
		
		md.Run ();
		md.Destroy();

	}

}