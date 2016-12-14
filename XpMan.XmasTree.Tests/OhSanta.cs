using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XpMan.XmasTree.Tests
{
    [TestClass]
    public class OhSanta
    {
        [TestMethod]
        public void KnownGoodOutputTest()
        {
            XpMan.XmasTree.Program.Main();
            StringBuilder goldenMasterBuilder = new StringBuilder();
            goldenMasterBuilder.AppendLine("A Wooden toy toy has been made for Susan by Green Wooden Toy Making Elf");
            goldenMasterBuilder.AppendLine("A Wooden toy toy has been made for John by Wooden Toy Making Elf");
            goldenMasterBuilder.AppendLine("A Train toy has been made for Sarah by Toy Making Elf");
            goldenMasterBuilder.AppendLine("A Plastic Spaceship toy has been made for Sarah by Plastic Toy Making Elf");
            goldenMasterBuilder.AppendLine("A Wooden toy toy has been made for Good Tom by Wooden Toy Making Elf");
            goldenMasterBuilder.AppendLine("Santa's got Susan a Green wooden toy");
            goldenMasterBuilder.AppendLine("Santa's got Bad Tom a Coal");
            goldenMasterBuilder.AppendLine("Santa's got John a Wooden toy");
            goldenMasterBuilder.AppendLine("Santa's got Sarah a Train");
            goldenMasterBuilder.AppendLine("Santa's got Andy a Plastic Spaceship");
            goldenMasterBuilder.AppendLine("Santa's got Good Tom a Red wooden toy");
            var goldenMaster = goldenMasterBuilder.ToString();
            var actualSantaOutput = Console.PresentsOutput.ToString();

            Assert.AreEqual(goldenMaster,actualSantaOutput);
            
        }
        
    }
}
