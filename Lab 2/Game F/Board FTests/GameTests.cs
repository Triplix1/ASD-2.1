﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Board_F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_F.Tests
{
    [TestClass()]
    public class GameTests
    {
        
        
        [TestMethod()]
        public void StartTest()
        {
            Game game = new Game(4);
            game.Start();
            Assert.AreEqual(1, game.GetDigitAt(0, 0));
            Assert.AreEqual(2, game.GetDigitAt(1, 0));
            Assert.AreEqual(5, game.GetDigitAt(0, 1));
            Assert.AreEqual(15, game.GetDigitAt(2, 3));

        }

        [TestMethod()]
        public void PressAtTest()
        {
            Game game = new Game(4);
            game.Start();
            game.PressAt(2, 3);
            Assert.AreEqual(15, game.GetDigitAt(3, 3));
            game.PressAt(3, 3);
            Assert.AreEqual(15, game.GetDigitAt(2, 3));
        }

        [TestMethod()]
        public void GetDigitAtTest()
        {
            Game game = new Game(4);
            game.Start();
            Assert.AreEqual(0, game.GetDigitAt(-5, 2));
            Assert.AreEqual(0, game.GetDigitAt(15, 3));
        }

        [TestMethod()]
        public void SolvedTest()
        {
            Game game = new Game(4);
            game.Start();
            Assert.IsTrue(game.Solved());
            game.PressAt(2, 3);
            Assert.IsFalse(game.Solved());
        }
    }
}