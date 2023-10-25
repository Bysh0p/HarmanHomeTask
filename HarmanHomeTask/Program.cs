using HarmanHomeTask.DataAccess;

namespace HarmanHomeTask
{
    public class Program
    {
        static readonly string BasePath = Directory.GetCurrentDirectory();
        static readonly string ConfigXMLPath = Path.Combine(BasePath, @"fileimport\FileImport.xml");
        static readonly string FileInputPath = Path.Combine(BasePath, @"fileimport\input");
        static readonly string FileDonePath = Path.Combine(BasePath, @"fileimport\done");

        static void Main(string[] args)
        {
            List<HMIXMLFILEGENERATIONPROTOCOLPACKETFILE> IntputFiles = ReadConfigFromXML();
            List<string> FilesToUpload = FilterFiles(IntputFiles);
            ProcessFiles(FilesToUpload);
        }

        private static List<HMIXMLFILEGENERATIONPROTOCOLPACKETFILE> ReadConfigFromXML()
        {
            string xml = File.ReadAllText(ConfigXMLPath);
            var catalog = xml.ParseXML<HMIXMLFILEGENERATIONPROTOCOL>();
            List<HMIXMLFILEGENERATIONPROTOCOLPACKETFILE> FileList = (catalog == null ? new List<HMIXMLFILEGENERATIONPROTOCOLPACKETFILE>() : catalog.Items[0].FILE.ToList());
            return FileList;
        }

        private static List<string> FilterFiles(List<HMIXMLFILEGENERATIONPROTOCOLPACKETFILE> IntputFiles)
        {
            List<string> Result = new();

            foreach (var FileData in IntputFiles)
            {
                string FileName = Path.Combine(FileInputPath, FileData.FILENAME);

                if (FileDataValidator.IsValid(FileName, FileData.CHECKSUM, int.Parse(FileData.BYTESIZE)))
                {
                    Result.Add(FileName);
                }
            }
            return Result;
        }

        private static void ProcessFiles(List<string> Files)
        {
            foreach (string FileName in Files)
            {
                if (File.Exists(FileName))
                {
                    try
                    {
                        string Data = File.ReadAllText(FileName);
                    }
                    catch { throw; }

                    bool Success = RestSharpFacade.UploadFile(FileName);

                    if (Success)
                    {
                        Console.WriteLine("Moving:" + FileName);
                        File.Move(FileName, Path.Combine(FileDonePath, Path.GetFileName(FileName)), overwrite: true);
                    }
                }
            }
        }
    }
}