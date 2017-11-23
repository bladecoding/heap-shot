// /home/lluis/work/heap-shot/HeapShot.Reader/IProgressListener.cs created with MonoDevelop
// User: lluis at 12:19 14/06/2007
//

using System;
using System.Threading;

namespace HeapShot.Reader
{
	public interface IProgressListener
	{
		void ReportProgress (string message, double progress);
		CancellationToken CancellationToken { get; }
	}
}
