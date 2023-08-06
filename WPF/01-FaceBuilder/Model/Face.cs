using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FaceBuilder.Model
{
    [Serializable]
    public class Face
    {
        private List<string> _faceParts;
        public List<string> FaceParts { get => _faceParts; set => _faceParts = value; }

        public Face()
        {
            _faceParts = new List<string>();
        }

        public override string ToString()
        {
            return _faceParts[0];
        }
    }

    [Serializable]
    public class FacesManager
    {
        public string FileName { get; private set; }
        private List<Face> _facesArray;
        public List<Face> FacesArray { get => _facesArray; set => _facesArray = value; }

        public FacesManager()
        {
            _facesArray = new List<Face>();
            FileName = "Faces.dat";
        }

        public void Save()
        {
            using (var fileStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                new BinaryFormatter().Serialize(fileStream, _facesArray);
        }

        public void Load()
        {
            using (var fileStream = new FileStream(FileName, FileMode.Open))
                _facesArray = (List<Face>)new BinaryFormatter().Deserialize(fileStream);
        }
    }
}