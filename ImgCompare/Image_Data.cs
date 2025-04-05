namespace ImgCompare
{
	using SixLabors.ImageSharp;
	using SixLabors.ImageSharp.PixelFormats;
	using System.IO;

	public class ImageData
	{
		public readonly string FilePath;
		public readonly string FileName;
		public readonly int Width;
		public readonly int Height;
		public readonly ulong Hash;
		public ImageData(string file)
		{
			FilePath = file;
			FileName = Path.GetFileName(file);
			Image<Rgba32> image = Image.Load<Rgba32>(file);
			Width = image.Width;
			Height = image.Height;
			Hash = PHash.P_Hash(image);
			image.Dispose();
		}
	}
}
