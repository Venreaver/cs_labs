using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace lab_4
{
    // part of speech = PoS
    public enum partOfSpeech { NOUN, PRONOUN, ADJECTIVE, VERB, ADVERB, PREPOSITION, CONJUNCTION, INTERJECTION, ARTICLE, PHRASE }
    
    // class-card
    public class Card : IXmlSerializable
    {
        string word = "";
        Dictionary<partOfSpeech, HashSet<string>> translation = new SerializableDictionary<partOfSpeech, HashSet<string>>();

        public Card()
        {
        }

        public Card(string wordName, string transl, partOfSpeech partOS)
        {
            word = wordName;
            translation.Add(partOS, new HashSet<string>());
            translation[partOS].Add(transl);
        }

        // =================== << PROPERTIES >> ======================
        public string Word
        {
            get
            {
                return word;
            }
        }

        public Dictionary<partOfSpeech, HashSet<string>> Translation
        {
            get
            {
                return translation;
            }
        }

        // translation count
        public int Translations
        {
            get
            {
                return translation.Select(item => item.Value.Count).Sum();
            }
        }

        public bool isNoun
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.NOUN);
            }
        }
        public bool isPronoun
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.PRONOUN);
            }
        }
        public bool isAdjective
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.ADJECTIVE);
            }
        }
        public bool isVerb
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.VERB);
            }
        }
        public bool isAdverb
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.ADVERB);
            }
        }
        public bool isPreposition
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.PREPOSITION);
            }
        }
        public bool isConjunction
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.CONJUNCTION);
            }
        }
        public bool isInterjection
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.INTERJECTION);
            }
        }
        public bool isArticle
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.ARTICLE);
            }
        }
        public bool isPhrase
        {
            get
            {
                return translation.ContainsKey(partOfSpeech.PHRASE);
            }
        }

        // =================== << METHODS >> ======================
        // add translation to card
        public void addTranslation(string newTranslation, partOfSpeech partOS)
        {
            if (!translation.ContainsKey(partOS))
            {
                translation.Add(partOS, new HashSet<string>());
            }
            translation[partOS].Add(newTranslation);
        }

        // remove translation from a card with PoS
        public void removeTranslation(string translationForDelete, partOfSpeech partOS)
        {
            if (translation.ContainsKey(partOS))
            {
                translation[partOS].Remove(translationForDelete);
            }
            if (translation[partOS].Count < 1)
            {
                translation.Remove(partOS);
            }
        }

        // remove translation from a card without PoS
        public void removeTranslation(string translationForDelete)
        {
            for (int i = 0; i < translation.Count; i++)
            {
                translation.ElementAt(i).Value.Remove(translationForDelete);
                if (translation.ElementAt(i).Value.Count < 1)
                {
                    translation.Remove(translation.ElementAt(i).Key);
                }
            }
        }

        
        // =================== << SERIALIZATION >> ======================
        public XmlSchema GetSchema()
        {
            return null;
        }

        // xmlRead Card
        public void ReadXml(XmlReader reader)
        {
            var wordSerializer = new XmlSerializer(typeof(string));
            var translSerializer = new XmlSerializer(typeof(SerializableDictionary<partOfSpeech, HashSet<string>>));
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();
            if (wasEmpty)
            {
                return;
            }
            reader.ReadStartElement("word");
            word = (string)wordSerializer.Deserialize(reader);
            reader.ReadEndElement();
            reader.ReadStartElement("translation");
            translation = (SerializableDictionary<partOfSpeech, HashSet<string>>)translSerializer.Deserialize(reader);
            reader.ReadEndElement();
            reader.ReadEndElement();
        }

        // xmlWrite Card
        public void WriteXml(XmlWriter writer)
        {
            var wordSerializer = new XmlSerializer(typeof(string));
            var translSerializer = new XmlSerializer(typeof(SerializableDictionary<partOfSpeech, HashSet<string>>));
            writer.WriteStartElement("word");
            wordSerializer.Serialize(writer, word);
            writer.WriteEndElement();
            writer.WriteStartElement("translation");
            translSerializer.Serialize(writer, translation);
            writer.WriteEndElement();
        }
    }
}