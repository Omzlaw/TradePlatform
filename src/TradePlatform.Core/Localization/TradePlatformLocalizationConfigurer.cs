using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TradePlatform.Localization
{
    public static class TradePlatformLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TradePlatformConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TradePlatformLocalizationConfigurer).GetAssembly(),
                        "TradePlatform.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
