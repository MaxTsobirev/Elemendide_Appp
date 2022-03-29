using System;

namespace Elemendide_App
{
    internal class MediaPlayer
    {
        public MediaPlayer()
        {
        }

        public System.Action<object, object> Prepared { get; internal set; }

        internal void SetDataSource(object fileDescriptor, object startOffset, object length)
        {
            throw new NotImplementedException();
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }

        internal void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}