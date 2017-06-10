/*
 * MIT License
 *
 * Copyright (c) 2017 Steve Bjorg
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System.Collections.Generic;

namespace AdventureBot {

    public enum GameCommandType {
        Option1 = 1,
        Option2,
        Option3,
        Option4,
        Option5,
        Option6,
        Option7,
        Option8,
        Option9,
        Yes = 100,
        No,
        Help = 200,
        Restart,
        Quit
    }

    public enum GameActionType {
        Goto = 1,
        Say,
        Delay,
        Play
    }

     public class GamePlace {

        //--- Fields ---
        public readonly string Id;
        public readonly string Description;

        public readonly Dictionary<GameCommandType, IEnumerable<KeyValuePair<GameActionType, string>>> Choices;

        //--- Constructors ---
        public GamePlace(string id, string description, Dictionary<GameCommandType, IEnumerable<KeyValuePair<GameActionType, string>>> choices) {
            Id = id;
            Description = description;
            Choices = choices;
        }
    }
}