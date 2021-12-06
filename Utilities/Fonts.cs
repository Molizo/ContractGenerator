using Aspose.Words.Fonts;

namespace ContractGenerator.Utilities
{
    public class Fonts
    {
        public class StreamFontTimesNewRoman : StreamFontSource
        {
            public override Stream OpenFontDataStream()
            {
                var assemName = "ContractGenerator";
                var assembly = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .First(a => a.GetName().Name == assemName);

                return assembly.GetManifestResourceStream($"{assemName}.Fonts.Times New Roman.ttf");
            }
        }

        public class StreamFontTimesNewRomanBold : StreamFontSource
        {
            public override Stream OpenFontDataStream()
            {
                var assemName = "ContractGenerator";
                var assembly = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .First(a => a.GetName().Name == assemName);

                return assembly.GetManifestResourceStream($"{assemName}.Fonts.Times New Roman Bold.ttf");
            }
        }

        public class StreamFontTimesNewRomanItalic : StreamFontSource
        {
            public override Stream OpenFontDataStream()
            {
                var assemName = "ContractGenerator";
                var assembly = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .First(a => a.GetName().Name == assemName);

                return assembly.GetManifestResourceStream($"{assemName}.Fonts.Times New Roman Italic.ttf");
            }
        }

        public class StreamFontTimesNewRomanBoldItalic : StreamFontSource
        {
            public override Stream OpenFontDataStream()
            {
                var assemName = "ContractGenerator";
                var assembly = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .First(a => a.GetName().Name == assemName);

                return assembly.GetManifestResourceStream($"{assemName}.Fonts.Times New Roman Bold Italic.ttf");
            }
        }
    }
}