﻿// FFXIVAPP.Plugin.Event
// German.cs
// 
// © 2013 ZAM Network LLC

#region Usings

using System.Windows;

#endregion

namespace FFXIVAPP.Plugin.Event.Localization
{
    public abstract class German
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("event_PLACEHOLDER", "*PH*");
            Dictionary.Add("event_AddUpdateEventButtonText", "Ereignis hinzufügen oder updaten");
            Dictionary.Add("event_RegExHeader", "RegEx");
            Dictionary.Add("event_RegExLabel", "RegEx:");
            Dictionary.Add("event_CategoryHeader", "Category");
            Dictionary.Add("event_CategoryLabel", "Category:");
            Dictionary.Add("event_SampleText", "The scout vulture readies Wing Cutter.");
            Dictionary.Add("event_SoundHeader", "Klang");
            Dictionary.Add("event_SoundLabel", "Klang:");
            Dictionary.Add("event_DelayHeader", "Verzögerung (secs)");
            Dictionary.Add("event_DelayLabel", "Verzögerung (secs):");
            return Dictionary;
        }
    }
}
