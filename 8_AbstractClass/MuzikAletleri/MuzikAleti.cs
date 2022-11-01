using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.MuzikAletleri
{

    //abstract classlar sadece kalitim vermek için tasarlanmıştır. Instance alinamazlar.
   //yani new'lenemezler.
    
    internal abstract class MuzikAleti
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }


      //Abstarct classların en büyük ozelligi de icerisnde Abstarct olan yada olmayan metodlari barindirabilirler.
        //Abstract metodlar kalitim alinan yerde implimente edilmek zorundadir.
        //yani metodun govdesi kalitim alinan yerde yazilacaktir.Interfacedeki gibi metod imzasi yeterlidir.
        public abstract string Cal();
       // public abstract string Cal(string ses);

        public virtual string AkortEt()
        {
            return Marka + "Akor Edildi";
        }

        /*
        * Abstract Metodlari tanimlarken dikkat edilmesi gerekenler
        
         * 1-Abstract metodlar private olarak isaretlenemezler
         * 2-abstarct metodlar sadece abstract classlarda tanimlanabilir
         * 3-Abstract metodlar static olarak tanimlanamazlar.Static kavrami class ozelligi yada metod ozelligi oldugundan instance cikarmaya gerek yoktur.
             halbuki statik olmayan metodlar instnace metodlar
           4-Abstarct metodlarin govdesi olmaz. 
           5-ABSTARCT METODLAR VİRTUAL OLARAK TANİMLANAMAZLAR.
             abastarct metodlar metod imzası ile calisir.Govdesi yoktur.
             virtual metodlarin govdesi vardir.
           6-virtual metodlar inherit verdiği yerlerde ovveride edilebilirler. Yani govdesi yeniiden tanimlanabilir.

        */

    }
}
