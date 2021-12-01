using System;

namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public MaterialType(string name)
        {
            this.Name = name;
        }

        public bool Equals(MaterialType mat)
        {
           if (this.Name==mat.Name){
               return true;
           }else{
               return false;
           }
        }
    }
}