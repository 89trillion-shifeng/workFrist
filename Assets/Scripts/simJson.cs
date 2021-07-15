using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using SimpleJSON;
using UnityEngine;

namespace DefaultNamespace
{
    public class simJson
    {
        public static List<JSONNode> JsonToData()
        {
            List<JSONNode> jsonLi = new List<JSONNode>();
            StreamReader streamReader = new StreamReader(Application.dataPath + "Config/data.json");
            string str = streamReader.ReadToEnd();
            
            //此处使用simpleJson解析文件
            var jsonDa = JSON.Parse(str);
            for (int i = 0; i < jsonDa["dailyProduct"].Count; i++)
            {
                jsonLi.Add(jsonDa["dailyProduct"][i]);
            }

            return jsonLi;
        }
    }
}