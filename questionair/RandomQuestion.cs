

namespace questionair
{
    public class RandomQuestion
    {

        public void RandomQuestionair()
        {
            List<QuestionairItem> questionairItems = new List<QuestionairItem>(){
                new QuestionairItem(
                    new List<String> { "Berlin", "English", "Battambang", "New York" },
                    "What is the capital of Germany?",
                    "Berlin"

                ),

                new QuestionairItem(
                    new List<String> { "Kulen Mountain", "Banon Moutain", "Pnom Sompov", "Kompot" },
                    "Where is Prom?",
                    "Kulen Mountain"
                ),
                };
            QuestionairItem item = GetRandomQuestionairItem(questionairItems);
            Console.WriteLine(item.question);
            foreach (String option in item.options.Select((value, index) => $"{index + 1}. {value}"))
            {
                Console.WriteLine(option);
            }
            UserSelection(item);


        }
        public void UserSelection(QuestionairItem item)
        {
            Console.WriteLine("Please select your answer");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice > item.options.Count)
            {
                Console.WriteLine("Please try again");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                String pickedOption = item.options[choice - 1];
                if (pickedOption == item.answer)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
                ContinueQuestion();
                

            }

        }
        QuestionairItem GetRandomQuestionairItem(List<QuestionairItem> questionairItems)
        {
            Random random = new Random(

            );
            int index = random.Next(questionairItems.Count);
            return questionairItems[index];
        }

        public void ContinueQuestion() {
            Console.WriteLine("Do you want to continue? (y/n)");
            string? answer = Console.ReadLine();
            if (answer == "y")
            {
                RandomQuestionair();
            }
            else
            {
                Console.WriteLine("Thank you for playing");
            }
        }
    }
}