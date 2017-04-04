using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace lab_4
{
    // class to conrol our vocab, like adapter
    public class DictController
    {
        Dictionary<string, Card> dictModel;
        XmlSerializer xmlSerializer;
        string path;
        
        public DictController()
        {
            xmlSerializer = new XmlSerializer(typeof(SerializableDictionary<string, Card>));
            dictModel = new SerializableDictionary<string, Card>();
        }

        // =================== << PROPERTIES >> ======================
        // vocab path
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        // index
        public Card this[int i]
        {
            get { return dictModel.ElementAt(i).Value; }
        }
        
        // ----- Count-properties -----
        public int Nouns
        {
            get
            {
                return dictModel.Count(card => card.Value.isNoun);
            }
        }
        public int Pronouns
        {
            get
            {
                return dictModel.Count(card => card.Value.isPronoun);
            }
        }
        public int Adjectives
        {
            get
            {
                return dictModel.Count(card => card.Value.isAdjective);
            }
        }
        public int Verbs
        {
            get
            {
                return dictModel.Count(card => card.Value.isVerb);
            }
        }
        public int Adverbs
        {
            get
            {
                return dictModel.Count(card => card.Value.isAdverb);
            }
        }
        public int Prepositions
        {
            get
            {
                return dictModel.Count(card => card.Value.isPreposition);
            }
        }
        public int Conjunctions
        {
            get
            {
                return dictModel.Count(card => card.Value.isConjunction);
            }
        }
        public int Interjections
        {
            get
            {
                return dictModel.Count(card => card.Value.isInterjection);
            }
        }
        public int Articles
        {
            get
            {
                return dictModel.Count(card => card.Value.isArticle);
            }
        }
        public int Phrases
        {
            get
            {
                return dictModel.Count(card => card.Value.isPhrase);
            }
        }

        // words count
        public int Count
        {
            get
            {
                return dictModel.Count;
            }
        }

        // avg length of words
        public int AvgWordLength
        {
            get
            {
                return dictModel.Count > 0 ? (int)dictModel.Select(item => item.Key.Length).Average() : 0;
            }
        }

        // max length of words
        public int MaxWordLength
        {
            get
            {
                return dictModel.Count > 0 ? dictModel.Select(item => item.Key.Length).Max() : 0;
            }
        }

        // word with max count of translation
        public int MaxTranslLength
        {
            get
            {
                return dictModel.Count > 0 ? dictModel.Select(item => item.Value.Translations).Max() : 0;
            }
        }

        // =================== << METHODS >> ======================
        // add Card to vocab
        public void addCard(string word, string transl, partOfSpeech pos)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            if (!word.Contains(' ') || pos == partOfSpeech.PHRASE)
            {
                transl = Regex.Replace(transl.ToLower().Trim(), "\\s+", " ");
                if (dictModel.ContainsKey(word))
                {
                    dictModel[word].addTranslation(transl, pos);
                }
                else
                {
                    dictModel.Add(word, new Card(word, transl, pos));
                }
            }
        }

        // remove Card from vocab
        public void removeCard(string word)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            dictModel.Remove(word);
        }

        // remove translation from vocab
        public void removeTranslation(string word, string transl)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            if (dictModel.ContainsKey(word))
            {
                transl = Regex.Replace(transl.ToLower().Trim(), "\\s+", " ");
                dictModel[word].removeTranslation(transl);
            }
            if (dictModel[word].Translation.Count < 1)
            {
                removeCard(word);
            }
        }

        // remove translation from vocab with PoS
        public void removeTranslation(string word, string transl, partOfSpeech pos)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            if (dictModel.ContainsKey(word))
            {
                transl = Regex.Replace(transl.ToLower().Trim(), "\\s+", " ");
                dictModel[word].removeTranslation(transl, pos);
            }
            if (dictModel[word].Translation.Count < 1)
            {
                removeCard(word);
            }
        }
        
        // string of translations
        public string getTranlationString(string word, partOfSpeech pos)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            string str = null;
            if (dictModel.ContainsKey(word))
            {
                if (dictModel[word].Translation.ContainsKey(pos))
                {
                    str = string.Join(", ", dictModel[word].Translation[pos]);
                }
            }
            return str;
        }

        // get a Card
        public Card getCard(string word)
        {
            word = Regex.Replace(word.ToLower().Trim(), "\\s+", " ");
            if (dictModel.ContainsKey(word))
            {
                return dictModel[word];
            }
            return null;
        }

        // =================== << SAVE AND LOAD >> ======================
        // Save vocab into xml-file
        public void save()
        {
            if (path != null)
            {
                Stream writer = new FileStream(path, FileMode.OpenOrCreate);
                xmlSerializer.Serialize(writer, dictModel);
                writer.Close();
            }
        }

        // Save vocab AS into xml-file
        public void saveAs(string path)
        {
            this.path = path;
            Stream writer = new FileStream(path, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(writer, dictModel);
            writer.Close();
        }

        // Load vocab from xml-file
        public void load(string path)
        {
            try
            {
                Stream reader = new FileStream(path, FileMode.Open);
                dictModel = (SerializableDictionary<string, Card>)xmlSerializer.Deserialize(reader);
                reader.Close();
                this.path = path;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
