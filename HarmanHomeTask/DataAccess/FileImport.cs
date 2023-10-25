using System.Xml.Serialization;
using System.Xml;

namespace HarmanHomeTask.DataAccess
{
    public static class FileImport
    {
        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static T? ParseXML<T>(this string @this) where T : class
        {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        public static T? ParseJSON<T>(this string @this) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
