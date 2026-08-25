using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projectfile.Pages
{
    [BindProperties]
    public class quizzesModel : PageModel
    {
        public string msgScore;

        public string answerMsg1;
        public string answerMsg2;
        public string answerMsg3;
        public string answerMsg4;
        public string answerMsg5;
        public string answerMsg6;
        public string answerMsg7;
        public string answerMsg8;
        public string answerMsg9;
        public string answerMsg10;
        public string answerMsg11;
        public string answerMsg12;
        public string answerMsg13;
        public string answerMsg14;
        public string answerMsg15;
        public string answerMsg16;
        public string answerMsg17;
        public string answerMsg18;

        public string MsgColor;
        public string Msg1Color;
        public string Msg2Color;
        public string Msg3Color;
        public string Msg4Color;
        public string Msg5Color;
        public string Msg6Color;
        public string Msg7Color;
        public string Msg8Color;
        public string Msg9Color;
        public string Msg10Color;
        public string Msg11Color;
        public string Msg12Color;
        public string Msg13Color;
        public string Msg14Color;
        public string Msg15Color;
        public string Msg16Color;
        public string Msg17Color;
        public string Msg18Color;


        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        public string question4 { get; set; }
        public string question5 { get; set; }
        public string question6 { get; set; }
        public string question7 { get; set; }
        public string question8 { get; set; }
        public string question9 { get; set; }
        public string question10 { get; set; }
        public string question11 { get; set; }
        public string question12 { get; set; }
        public string question13 { get; set; }
        public string question14 { get; set; }
        public string question15 { get; set; }
        public string question16 { get; set; }
        public string question17 { get; set; }
        public string question18 { get; set; }



        public int score;


        public void OnPostSubmit()
        {
            score = 0;

            //question one code
            if (question1 == "7m")
            {
                answerMsg1 = "Correct";
                Msg1Color = "green";
                score = score + 1;

            }
            else if (question1 == "4m")
            {
                answerMsg1 = "Incorrect";
                Msg1Color = "red";
            }

            // else if(question1 == "10m")
            else
            {
                answerMsg1 = "Incorrect";
                Msg1Color = "red";
            }

            // question two code
            if (question2 == "5-7 tones")
            {
                answerMsg2 = "Correct";
                Msg2Color = "green";
                score = score + 1;
            }
            else if (question2 == "5-4 tones")
            {
                answerMsg2 = "Incorrect";
                Msg2Color = "red";

            }
            //else if (question2 == "4-8 tones")
            else
            {
                answerMsg2 = "Incorrect";
                Msg2Color = "red";

            }
            // question three
            if (question3 == "True")
            {
                Msg3Color = "green";
                answerMsg3 = "Correct";
                score = score + 1;


            }
            else
            {
                answerMsg3 = "Incorrect";
                Msg3Color = "red";
            }


            //question four
            if (question4 == "Strong")
            {
                answerMsg4 = "Incorrect";
                Msg4Color = "red";


            }
            else if (question4 == "Double")
            {
              
                answerMsg4 = "Correct";
                Msg4Color = "green";
                score = score + 1;
            }

          
            else
            {
                answerMsg4 = "Incorrect";
                Msg4Color = "red";
            }

           
            //  question five
            if (question5 == "5m")
            {
                answerMsg5 = "Incorrect";
                Msg5Color = "red";


            }
            else if (question5 == "14m")
            {
                answerMsg5 = "Incorrect";
                Msg5Color = "red";

               
            }

            else
            {
                answerMsg5 = "Correct";
                Msg5Color = "green";
                score = score + 1;
            }

            //question six
            if (question6 == "Greek")
            {
                Msg6Color = "green";
                answerMsg6 = "Correct";
                score = score + 1;

            }
            else if (question6 == "English")
            {
                answerMsg6 = "Incorrect";
                Msg6Color = "red";
            }
            else
            {
                answerMsg6 = "Incorrect";
                Msg6Color = "red"; 
            }
   //question 7
   if (question7 == "long neck, small head, and whip-like tail")
   {
       answerMsg7 = "Correct";
       Msg7Color = "green";
       score = score + 1;

   }
   else if (question7== "long neck")
   {
       answerMsg7 = "Incorrect";
       Msg7Color = "red";
   }

   // else if(question7 == "small head")
   else
   {
       answerMsg7 = "Incorrect";
       Msg7Color = "red";
   }

   // question 8
   if (question8 == "Herbivore")
   {
       answerMsg8 = "Correct";
       Msg8Color = "green";
       score = score + 1;
   }
   else if (question8 == "Carnivore")
   {
       answerMsg8 = "Incorrect";
       Msg8Color = "red";

   }
   //else if (question8 == "Omnivore")
   else
   {
       answerMsg8 = "Incorrect";
       Msg8Color = "red";

   }
   // question 9
   if (question9 == "True")
   {
       Msg9Color = "green";
       answerMsg9 = "Correct";
       score = score + 1;


   }
   // else if (question9 == "False") { }
   else
   {
       answerMsg9 = "Incorrect";
       Msg9Color = "red";
   }

   //question 10
   if (question10 == "riverine and coastal regions")
   {
       answerMsg10 = "Correct";
       Msg10Color = "green";
       score = score + 1;

   }
   else if (question10 == "mountains regions")
   {
       answerMsg10 = "Incorrect";
       Msg10Color = "red";
   }

   // else if(question10 == "coastal regions")
   else
   {
       answerMsg10 = "Incorrect";
       Msg10Color = "red";
   }

   // question 11
   if (question11 == "semi aquatic habitats")
   {
       answerMsg11 = "Correct";
       Msg11Color = "green";
       score = score + 1;
   }
   else if (question11 == "forest habitats")
   {
       answerMsg11 = "Incorrect";
       Msg11Color = "red";

   }
   //else if (question 11 == "desert habitats")
   else
   {
       answerMsg11 = "Incorrect";
       Msg11Color = "red";

   }
   // question 12
   if (question12 == "True")
   {
       Msg12Color = "green";
       answerMsg12 = "Correct";
       score = score + 1;


   }
   // else if (question12 == "False") { }
   else
   {
       answerMsg12 = "Incorrect";
       Msg12Color = "red";
   }

            //  question 13
            if (question13 == "byron")
            {
                answerMsg13 = "Incorrect";
                Msg13Color = "red";


            }
            else if (question13 == "jaffe")
            {
                answerMsg13 = "Incorrect";
                Msg13Color = "red";
            }

            else
            {
                answerMsg13 = "Correct";
                Msg13Color = "green";
                score = score + 1;
            }

            //  question 14
            if (question14 == "straight")
            {
                answerMsg14 = "Incorrect";
                Msg14Color = "red";


            }
            else if (question14 == "sharp")
            {
                answerMsg14 = "Incorrect";
                Msg14Color = "red";
            }

            else
            {
                answerMsg14 = "Correct";
                Msg14Color = "green";
                score = score + 1;
            }

            // question 15
            if (question15 == "True")
            {
                Msg15Color = "green";
                answerMsg15 = "Correct";
                score = score + 1;
            }
            else
            {
                answerMsg15 = "Incorrect";
                Msg15Color = "red";
            }

            //  question 16
            if (question16 == "plant")
            {
                answerMsg16 = "Incorrect";
                Msg16Color = "red";


            }
            else if (question16 == "vegan")
            {
                answerMsg16 = "Incorrect";
                Msg16Color = "red";
            }

            else
            {
                answerMsg16 = "Correct";
                Msg16Color = "green";
                score = score + 1;
            }

            //  question 17
            if (question17 == "27 km/h")
            {
                answerMsg17 = "Incorrect";
                Msg17Color = "red";


            }
            else if (question17 == "63 km/h")
            {
                answerMsg17 = "Incorrect";
                Msg17Color = "red";
            }

            else
            {
                answerMsg17 = "Correct";
                Msg17Color = "green";
                score = score + 1;
            }

            //  question 18
            if (question18 == "700kg")
            {
                answerMsg18 = "Incorrect";
                Msg18Color = "red";


            }
            else if (question18 == "7kg")
            {
                answerMsg18 = "Incorrect";
                Msg18Color = "red";
            }

            else
            {
                answerMsg18 = "Correct";
                Msg18Color = "green";
                score = score + 1;
            }

            if (score == 18)
            {
                msgScore = "Great Job! You got " + score + "/18";
                MsgColor = "green";
            }
            else
            {
                msgScore = "You got " + score + " out of 18 ";

            }
        }
      
    }
}
