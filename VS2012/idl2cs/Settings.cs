using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace idl2cs
{
    [Serializable]
    public sealed class Settings
    {
        [Serializable]
        public struct Type
        {
            [XmlAttribute]
            public string Name
            {
                get;
                set;
            }
        }

        [Serializable]
        public struct Namespace
        {
            [XmlAttribute]
            public string Name
            {
                get;
                set;
            }
        }

        [XmlAttribute]
        public bool Internal;
        public List<Type> SuppressedTypes = new List<Type>();
        public List<Namespace> Namespaces = new List<Namespace>();

        public static Settings LoadConfiguration(string configurationFile)
        {
            Settings configuration;

            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            byte[] data = File.ReadAllBytes(configurationFile);

            using (MemoryStream stream = new MemoryStream(data))
            {
                configuration = (Settings)serializer.Deserialize(stream);
            }
            return configuration;
        }

        public static void CreateSampleConfiguration()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));

            using (MemoryStream stream = new MemoryStream())
            {
                Settings empty = new Settings();
                empty.Namespaces.Add(new Settings.Namespace { Name = "Test" });
                empty.SuppressedTypes.Add(new Settings.Type { Name = "Test" });
                serializer.Serialize(stream, empty);
                File.WriteAllBytes("sample.cfg", stream.ToArray());
            }
        }

        public static Settings ParseEmbeddedSettings(string definitionFile)
        {
            if (string.IsNullOrEmpty(definitionFile))
                return null;

            string[] lines = File.ReadAllLines(definitionFile);
            
            string excludedTypesPrefix = "SuppressedTypes:";
            string namespacesPrefix = "Namespaces:";
            string mappingPrefix = "TypeMappings:";
            string internalOption = "Internal";

            List<string> excludedTypesLines = new List<string>();
            List<string> namespacesLines = new List<string>();
            List<string> mappingLines = new List<string>();
            List<string> internalLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (!line.StartsWith("//"))
                    break;
                line = line.Substring(2).Trim();

                if (line.StartsWith(excludedTypesPrefix))
                    excludedTypesLines.Add(line.Substring(excludedTypesPrefix.Length).Trim());

                if (line.StartsWith(namespacesPrefix))
                    namespacesLines.Add(line.Substring(namespacesPrefix.Length).Trim());

                if (line.StartsWith(mappingPrefix))
                    mappingLines.Add(line.Substring(mappingPrefix.Length).Trim());

                if (line == internalOption)
                    internalLines.Add(line);
            }

            if (!excludedTypesLines.Any() && !namespacesLines.Any() && !mappingLines.Any() && !internalLines.Any())
                return null;

            Settings result = new Settings
            {
                Namespaces = new List<Namespace>(),
                SuppressedTypes = new List<Type>()
            };

            foreach (var excludedTypesLine in excludedTypesLines)
                result.SuppressedTypes.AddRange(excludedTypesLine.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => new Type { Name = x.Trim() }));

            foreach (var namespacesLine in namespacesLines)
                result.Namespaces.AddRange(namespacesLine.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => new Namespace { Name = x.Trim() }));
            
            if (internalLines.Any())
                result.Internal = true;

            return result;
        }
    }
}
