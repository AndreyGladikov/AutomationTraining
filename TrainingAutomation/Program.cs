using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation
{




    class Program
    {
        static void Main(string[] args)
        {
            TrainingData trainingData = new TrainingData();
            trainingData.GenerateGuid();
            trainingData.Description = "123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgdfgdfgdf345345dfg123sdfsdf345gfdfgAAAAA";

            TextLesson textLesson = new TextLesson();
            textLesson.GenerateGuid();
            textLesson.Text = "TEST FOR TASK";
            textLesson.Description = "Description of text lesson";

            VideoLesson videoLesson = new VideoLesson();
            videoLesson.GenerateGuid();
            videoLesson.UriVideo = "www.video.com";
            videoLesson.Description = "Description of video lesson";

            LinkOnResource link = new LinkOnResource();
            link.UriContent = "www.content.con";

            

            


            

            
            TrainingData[] trDataArry = new TrainingData[] { textLesson, videoLesson, link };
            

            Console.WriteLine(textLesson.Id.ToString());
            Console.WriteLine(textLesson.Text);
            //Console.WriteLine(trainingData.Id.ToString());
           //Console.WriteLine(trainingData.Description);

            
        }


    }
}
