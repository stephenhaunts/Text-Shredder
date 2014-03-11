/**
* Text Shredder : A personal message encryption tool.
* 
* Copyright (C) 2014 Stephen Haunts
* http://www.stephenhaunts.com
* 
* This file is part of Text Shredder.
* 
* Text Shredder is free software: you can redistribute it and/or modify it under the terms of the
* GNU General Public License as published by the Free Software Foundation, either version 2 of the
* License, or (at your option) any later version.
* 
* Text Shredder is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* 
* See the GNU General Public License for more details <http://www.gnu.org/licenses/>.
* 
* Authors: Stephen Haunts
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace HauntedHouseSoftware.TextShredder.ClientLibrary
{
    public sealed class SettingsWriter
    {
        private SettingsWriter()
        {
        }
        public static string AssemblyDirectory
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public static void WriteSettingsFile(ApplicationSettings settings)
        {
            if (settings == null)
            {
                return;
            }

            try
            {
                var path = Path.GetFullPath(AssemblyDirectory + "settings.xml");

                var serializer = new XmlSerializer(settings.GetType());
                using (var writer = XmlWriter.Create(path))
                {
                    serializer.Serialize(writer, settings);
                }
            }
            catch
            {
                return;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public static ApplicationSettings ReadSettingsFile()
        {
            try
            {
                var path = Path.GetFullPath(AssemblyDirectory + "settings.xml");

                if (File.Exists(path))
                {
                    var serializer = new XmlSerializer(typeof(ApplicationSettings));
                    using (var reader = XmlReader.Create(path))
                    {
                        var settings = (ApplicationSettings)serializer.Deserialize(reader);
                        return settings;
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
