﻿public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init() =>
        VerifyQuestPdf.Initialize();
}