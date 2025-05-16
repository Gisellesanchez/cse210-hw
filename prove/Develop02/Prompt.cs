using System;
using System.Collections.Generic;


public class Prompt
{
    private List<string> prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What was something that did not go as planned today?",
        "What are you grateful for?",
        "What made you smile :) today?",
        "Who made your day better?",
        "What is something you are craving to eat right now?",
        "What is something you are looking forward to tomorrow?",
        
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}