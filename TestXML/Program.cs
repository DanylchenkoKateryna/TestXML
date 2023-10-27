// See https://aka.ms/new-console-template for more information

using TestXML;

XDictionaryService xmlSerializer = new XDictionaryService();

List<XDictionary> dictionaryList = new List<XDictionary>();

var str = xmlSerializer.ParseXDictionaryFromXml("input.xml");
dictionaryList.Add(str);

xmlSerializer.SerializeObjectToXml(dictionaryList,"output.xml");
