using System.Collections.Generic;
using Tests.View;
using Tests.ViewModel;

namespace Tests.Model
{
    class Questions
    {
        public List<List<Item>> Themes { get; set; }

        public Questions()
        {
            Themes = new List<List<Item>>
            {
                GetMathQuestions(),
                GetEnglishQuestions(),
                GetGeographyQuestions()
            };
        }

        public List<Item> GetMathQuestions()
        {
            return new List<Item>
            {
                new Item
                {
                    Header = "1",
                    Question = "What result of 2 + 2 * 2?",
                    Answers = new List<string> { "8", "42", "=)", "6" },
                    AnswersCorrectness = new List<bool> { false, true, false, true },
                    Control = new CheckBoxes()
                },

                new Item
                {
                    Header = "2",
                    Question = "What sign is used for numbers greater than zero and less than 10",
                    Answers = new List<string> { "+", "-", "*", "/" },
                    AnswersCorrectness = new List<bool> { true, false, false, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "3",
                    Question = "What number results from multiplying 5 by 3?",
                    Answers = new List<string> { "12", "15", "8", "20" },
                    AnswersCorrectness = new List<bool> { false, true, false, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "4",
                    Question = "Solve the equation: 2x + 5 = 15",
                    Answers = new List<string> { "10", "8", "5", "7" },
                    AnswersCorrectness = new List<bool> { false, false, true, false },
                    Control = new RadioBoxes()
                }
            };
        }

        public List<Item> GetEnglishQuestions()
        {
            return new List<Item>
            {
                new Item
                {
                    Header = "1",
                    Question = "Question: How do you say apple in Ukrainian?",
                    Answers = new List<string> { "груша", "яблука", "вишня", "полуниця" },
                    AnswersCorrectness = new List<bool> { false, true, false, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "2",
                    Question = "What word is the opposite of happy?",
                    Answers = new List<string> { "sad", "angry", "excited", "funny" },
                    AnswersCorrectness = new List<bool> { true, false, false, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "3",
                    Question = "How do you correctly write the past tense of the verb go?",
                    Answers = new List<string> { "goed", "goeded", "went", "gone" },
                    AnswersCorrectness = new List<bool> { false, false, true, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "4",
                    Question = "Which words are pronouns in English?",
                    Answers = new List<string> { "book, table", "happy, sad", "he, she", "they, it" },
                    AnswersCorrectness = new List<bool> { false, false, true, true },
                    Control = new CheckBoxes()
                }
            };
        }

        public List<Item> GetGeographyQuestions()
        {
            return new List<Item>
            {
                new Item
                {
                    Header = "1",
                    Question = "Which of the continents is the largest by area?",
                    Answers = new List<string> { "Africa", "North America", "Australia", "Eurasia" },
                    AnswersCorrectness = new List<bool> { false, false, false, true },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "2",
                    Question = "Which sea is located between Europe and Africa?",
                    Answers = new List<string> { "Caribbean Sea", "Mediterranean Sea", "Black Sea", "Beaufort Sea" },
                    AnswersCorrectness = new List<bool> { false, true, false, false },
                    Control = new RadioBoxes()
                },

                new Item
                {
                    Header = "3",
                    Question = "Which river is the longest in the world",
                    Answers = new List<string> { "Amazon River", "Dnieper River", "Nile River", "Yangtze River" },
                    AnswersCorrectness = new List<bool> { false, false, true, false },
                    Control = new RadioBoxes()
                }
            };
        }
    }
}