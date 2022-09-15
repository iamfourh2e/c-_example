
namespace questionair
{
    public class QuestionairItem
    {
        public String question;
        public String answer;
        public List<String> options;
        // what is constructor ? 
        // constructor is a method that is called when an object is created from a class
        public QuestionairItem(List<String> options, string question, string answer)
        {
            this.options = options;
            this.question = question;
            this.answer = answer;
        }
    }
}