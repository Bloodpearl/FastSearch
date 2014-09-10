using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;

namespace FastSearch.Common
{
    public class AppSettings
    {
        #region internal
        private static double version = 0.2;
        private static string phrase = "Alfa";
        private static string name = "Fast Search";
        private static string fullName = null;
        internal static bool blockOnError = false;
        internal static string appConfFile = "FastSearch.ini";
        #endregion

        #region fields
        public static string FullName
        {
            get
            {
                if (fullName == null)
                {
                    string[] text = { name, "-", version.ToString(), phrase };
                    fullName = string.Join(" ", text);
                }
                return fullName;
            }
        }
        private static string[] fieldsToSkipSave = {
            "fieldsToSkipSave","xmlStoredFields","AlfaSwitch","FullName","version","phrase","name","fullName","blockOnError","appConfFile","defaultApplication","defaultArgs"
        };

        #region ini stored fields
        public static bool DefaultAlfaSwitch = true;
        public static bool AlfaSwitch = true;
        public static double OpacityMax = 1;
        public static double OpacityMin = 0.4;
        #endregion

        #region xml stored properties
        private static string[] xmlStoredFields = {
            "Args","DefaultArgs","Applications","DefaultApplication"
        };
        public static Dictionary<string, string> Applications = new Dictionary<string, string>();
        public static Dictionary<string, AplicationArgsData> Args = new Dictionary<string, AplicationArgsData>();

        private static string defaultApplication;
        public static string DefaultApplication
        {
            get
            {
                if (AppSettings.defaultApplication == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej przeglądarki");
                }
                return AppSettings.defaultApplication;
            }
            set { AppSettings.defaultApplication = value; }
        }

        private static AplicationArgsData defaultArgs;
        public static AplicationArgsData DefaultArgs
        {
            get
            {
                if (AppSettings.defaultArgs == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej aplikacji");
                }
                return AppSettings.defaultArgs; 
            }
            set { AppSettings.defaultArgs = value; }
        }
        #endregion
        #endregion

        #region functions
        public bool SaveSettings()
        {
            using (StreamWriter writer = new StreamWriter(appConfFile))
            {
                MemberInfo[] list = GetSettingsList();
                foreach (MemberInfo member in list)
                {
                    if (Array.IndexOf(xmlStoredFields, member.Name) != -1 ||
                        Array.IndexOf(fieldsToSkipSave, member.Name) != -1)
                        continue;
                    if (member.MemberType == MemberTypes.Field)
                    {
                        FieldInfo field = (FieldInfo)member;
                        writer.WriteLine(field.Name + "=" + field.GetValue(this));
                    }
                    else
                    {
                        PropertyInfo property = (PropertyInfo)member;
                        if (!property.CanWrite)
                            continue;
                        writer.WriteLine(property.Name + "=" + property.GetValue(this));
                    }
                }
            }
            return true;
        }
        public bool LoadSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            char[] iniSplitter = {'='};
            using (StreamReader reader = new StreamReader(appConfFile))
            {
                string line;
                string[] parts;
                while ((line = reader.ReadLine()) != null)
                {
                    parts = line.Split(iniSplitter);
                    settings.Add(parts[0], parts[1]);
                }
            }
            MemberInfo[] list = GetSettingsList();
            foreach (MemberInfo member in list)
            {
                if (Array.IndexOf(xmlStoredFields, member.Name) != -1 ||
                    Array.IndexOf(fieldsToSkipSave, member.Name) != -1 ||
                    !settings.ContainsKey(member.Name))
                    continue;
                if (member.MemberType == MemberTypes.Field)
                {
                    FieldInfo field = (FieldInfo)member;
                    field.SetValue(this, Convert.ChangeType(settings[field.Name],field.FieldType));
                }
                else
                {
                    PropertyInfo property = (PropertyInfo)member;
                    if (!property.CanWrite)
                        continue;
                    property.SetValue(this, Convert.ChangeType(settings[property.Name], property.PropertyType));
                }
            }

            return true;
        }
        public string GetSettingsInfo()
        {
            StringBuilder info = new StringBuilder();
            MemberInfo[] list = GetSettingsList();
            foreach (MemberInfo member in list)
            {
                if (member.MemberType == MemberTypes.Field)
                {
                    FieldInfo field = (FieldInfo)member;
                    info.AppendLine(field.Name + "=" + field.GetValue(this));
                }
                else
                {
                    PropertyInfo property = (PropertyInfo)member;
                    if (!property.CanWrite)
                        continue;
                    info.AppendLine(property.Name + "=" + property.GetValue(this));
                }
            }
            return info.ToString();
        }
        private static MemberInfo[] GetSettingsList()
        {
            List<MemberInfo> list = new List<MemberInfo>();
            FieldInfo[] fields = typeof(AppSettings).GetFields();
            PropertyInfo[] properties = typeof(AppSettings).GetProperties();
            list.AddRange(fields);
            list.AddRange(properties);

            return list.ToArray();
        }
        #endregion

    }
}
