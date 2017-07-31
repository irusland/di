using System.IO;
using JetBrains.Annotations;

namespace FractalPainting.Solved.Step11.Infrastructure
{
	public class FileBlobStorage : IBlobStorage
	{
		[CanBeNull]
		public byte[] Get(string name)
		{
			return File.Exists(name) ? File.ReadAllBytes(name) : null;
		}

		public void Set(string name, byte[] content)
		{
			File.WriteAllBytes(name, content);
		}
	}
}