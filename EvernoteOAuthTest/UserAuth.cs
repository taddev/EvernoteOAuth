using System;
using Thrift;
using Thrift.Protocol;
using Thrift.Transport;
using Evernote.EDAM.Type;
using Evernote.EDAM.UserStore;
using Evernote.EDAM.NoteStore;
using Evernote.EDAM.Error;

namespace EvernoteOAuthTest
{
	public class UserAuth
	{
		public UserAuth ()
		{
			String evernoteHost = "sandbox.evernote.com";
			
			Uri userStoreUrl = new Uri("https://" + evernoteHost + "/edam/user");
			TTransport userStoreTransport = new THttpClient(userStoreUrl);
			TProtocol userStoreProtocol = new TBinaryProtocol(userStoreTransport);
			UserStore.Client userStore = new UserStore.Client(userStoreProtocol);
			
			bool versionOK = userStore.checkVersion("Evernote OAuth Test",
				                       Evernote.EDAM.UserStore.Constants.EDAM_VERSION_MAJOR,
				                       Evernote.EDAM.UserStore.Constants.EDAM_VERSION_MINOR);
			Console.WriteLine("Is my Evernote API version up to date? " + versionOK);

			if (!versionOK) {
				return;
			}
		}
	}
}

