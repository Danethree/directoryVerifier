using System;
using System.Reflection.Emit;
using NUnit.Framework;
using testingfiles;

namespace testingFilesTest
{
    
    public class FileProcessTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FileNameDoesExists()
        {
            //AAA Method
            FileProcess fp = new FileProcess();//Arrange
            bool fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");//Act
            Assert.IsTrue(fromCall);//Assert

        }
        
        [Test]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall = fp.FileExists(@"C:\Regedit.exe");
            Assert.IsFalse(fromCall);
        }

        [Test]
     
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {
                return;
            }
            Assert.Fail("Fail expected");
            
        }
    }
}