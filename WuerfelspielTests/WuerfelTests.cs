using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {  
        [TestMethod]
        public void Wurfel_Erstellt()
        {
            //act
            Wuerfel x = new Wuerfel();
        } 

        [TestMethod]
        public void Wurfel_EmptyConstructor()
        {
            //arrange          
            Wuerfel x = new Wuerfel();

            //act
            Wuerfel y = new Wuerfel();

            //assert
            Assert.AreEqual(y.AnzahlSeiten,x.AnzahlSeiten);
        }
        
        [TestMethod]
        public void Wurfel_ConstructorIsUsed()
        {
            //arrange          
            Wuerfel x = new Wuerfel(8);

            //act
            Wuerfel y = new Wuerfel(10);

            //assert
            Assert.AreEqual(8,x.AnzahlSeiten);
            Assert.AreEqual(10,y.AnzahlSeiten);
        }
        
        [TestMethod]
        public void Wurfel_GesichertAufTrue()
        {
            //arrange    
            bool gesichert = false;
            Wuerfel x = new Wuerfel();

            //act
            x.SicherungUmschalten();

            //assert
            Assert.IsTrue(gesichert = true);
        }
        
        [TestMethod]
        public void Wurfel_GesichertAufFalse()
        {
            //arrange    
            bool gesichert = true;
            Wuerfel x = new Wuerfel();

            //act
            x.SicherungUmschalten();

            //assert
            Assert.AreNotEqual(gesichert, x.Gesichert);
        }
        
        [TestMethod]
        public void Wurfeln_Passt()
        {
            //arrange    
            Random rnd = new Random();
            Wuerfel x = new Wuerfel();

            //act
            x.Wurfeln();

            //assert
            Assert.IsNotNull(x.LetztesErgebniss);
        }      
    }
}
