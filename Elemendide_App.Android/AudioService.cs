﻿using System;
using Xamarin.Forms;
using Android.Media;
using Android.Content.Res;
using AudioPlayEx;
using Elemendide_App.Droid;

[assembly: Dependency(typeof(AudioService))]
namespace Elemendide_App.Droid
{
	public class AudioService : IAudio
	{
		public AudioService()
		{
		}

		public void PlayAudioFile(string fileName)
		{
			var player = new MediaPlayer();
			var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
			player.Prepared += (s, e) =>
			{
				player.Start();
			};
			player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
			player.Prepare();
		}
	}
}