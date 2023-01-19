﻿using App.Common.Dtos;
using App.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Helper
{

    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return value.ToString();
        }

        public static Dictionary<T, string> EnumToDictionary<T>()
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
                throw new ArgumentException("T must be of type System.Enum");
          foreach(var item in Enum.GetValues(enumType))
            {
              var e = GetDescription(item as Enum);
              var g =  GetDisplayValue(item);
            }
            return Enum.GetValues(enumType)
                       .Cast<T>()
                       .ToDictionary(k => k, v => (v as Enum).GetDescription());
        }
        public static List<ActionType> EnumToObj<T>()
        {
            var result =new  List<ActionType>();
            var enumType = typeof(T);

            if (!enumType.IsEnum)
                throw new ArgumentException("T must be of type System.Enum");
            foreach (var item in Enum.GetValues(enumType))
            {
                var e = GetDescription(item as Enum);
                var g = GetDisplayValue(item);
                result.Add(new ActionType
                {
                    name = g,
                    value = e
                }


                    );  
            }
            return result;
          
        }
        public static string GetDisplayValue<T>(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes[0].ResourceType != null)
                return lookupResource(descriptionAttributes[0].ResourceType, descriptionAttributes[0].Name);

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }

        private static string lookupResource(Type resourceManagerProvider, string resourceKey)
        {
            foreach (PropertyInfo staticProperty in resourceManagerProvider.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (staticProperty.PropertyType == typeof(System.Resources.ResourceManager))
                {
                    System.Resources.ResourceManager resourceManager = (System.Resources.ResourceManager)staticProperty.GetValue(null, null);
                    return resourceManager.GetString(resourceKey);
                }
            }

            return resourceKey; // Fallback with the key name
        }
    }
}
