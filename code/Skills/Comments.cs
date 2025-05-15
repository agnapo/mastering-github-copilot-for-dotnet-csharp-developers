using System;

namespace Skills;

public class Comments
{
    // Generates a comment for a given skill name.
    public string GenerateComment(string skill)
    {
        if (string.IsNullOrWhiteSpace(skill))
            return "No skill provided.";

        return $"Great job developing your {skill} skills! Keep it up.";
    }
  
}
