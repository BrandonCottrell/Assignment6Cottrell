using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Assignment6Cottrell.Context;
using Assignment6Cottrell.Models;
using Assignment6Cottrell.Services;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{

    public MainService()
    {
    }

    public void Invoke() // consider this your Program.cs Main
    {
        MediaContext context = new MediaContext();
        //Wrapper wrapper (hold onto context)
        //wrapper => execute methods to Search

        List<Media> media = new List<Media>();
        media.AddRange(context.Movies);
        media.AddRange(context.Videos);
        media.AddRange(context.Shows);


        Console.WriteLine("What would you like to view?");
        Console.WriteLine("1. Movies");
        Console.WriteLine("2. Shows");
        Console.WriteLine("3. Videos");

        string option = Console.ReadLine();

        if (option == "1")
        {
            Movie mve = new Movie();
            mve.Display();

        }
        else if (option == "2")
        {
            Show sh = new Show();
            sh.Display();
        }
        else if (option == "3")
        {
            Video vdo = new Video();
            vdo.Display();
        }
        else
        {
            Console.WriteLine("Please enter valid option");
        }



        //Console.WriteLine("Which media would you like to display?");
        //var userInput = Console.ReadLine();

        //var result = media.FirstOrDefault(x => x.Title.Contains(userInput));

        //Console.WriteLine($"Your result: {result.Title}");

        //foreach (var m in context.Movies) // movies
        //{
        //    m.Display(); ;
        //}

        //foreach (var m in context.Shows) // shows
        //{
        //    m.Display(); ;
        //}

        //foreach (var m in context.Videos) // videos
        //{
        //    m.Display(); ;
        //}
    }
}