﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    class School
    {
        public LearningStream[] LearnStreams { get; set;}

        public School()
        {
            Console.WriteLine("Enter number of streams");
            int CountOfStreams = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of classes on stream");
            int CountClassesOnStream = int.Parse(Console.ReadLine());
            LearnStreamsInit(CountOfStreams, CountClassesOnStream);
            TeachersInit(CountOfStreams * CountClassesOnStream);
        }

        private void LearnStreamsInit(int CountOfStreams, int CountClassesOnStream)
        {
            LearnStreams = new LearningStream[CountOfStreams];
            for (int i = 0; i < this.LearnStreams.Length; i++)
            {
                var learnStream = new LearningStream(CountClassesOnStream);
                for (int j = 0; j < learnStream.Classes.Length; j++)
                {
                    learnStream.Classes[j] = new StudyClass($"{i + 1}-{Char.ConvertFromUtf32(65 + j)}");
                }
                LearnStreams[i] = learnStream;
            }
        }
        private void TeachersInit(int NumberOfTeachers)
        { 

        }
    }
}