using Microsoft.JSInterop;

namespace ContractGenerator.Utilities
{
    public static class FileUtil
    {
        public static void SaveAs(this IJSRuntime js, string filename, MemoryStream data)
        {
            var rt = js as IJSUnmarshalledRuntime;
            var dataArray = data.ToArray();
            rt.InvokeUnmarshalled<string, byte[], object>(
                "saveAsFile",
                filename,
                dataArray);
        }

        public static string GetBlobUrl(this IJSRuntime js, MemoryStream data)
        {
            var rt = js as IJSUnmarshalledRuntime;
            var dataArray = data.ToArray();
            return rt.InvokeUnmarshalled<byte[], string>(
                "getBlobUrl",
                dataArray);
        }
    }
}