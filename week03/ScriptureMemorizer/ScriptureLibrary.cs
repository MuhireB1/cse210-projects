using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        InitializeLibrary();
    }

    private void InitializeLibrary()
    {
        // Add scriptures to the library
        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        ));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten son that whosoever believeth in him should not perish but have everlasting life"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 8),
            "Finally brethren whatsoever things are true whatsoever things are honest whatsoever things are just whatsoever things are pure whatsoever things are lovely whatsoever things are of good report think on these things"
        ));

        _scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "And I said I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Doctrine and Covenants", 39, 23),
            "Learn of me and listen to my words walk in the meekness of my spirit and you shall have peace in me"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Matthew", 5, 14, 16),
            "Ye are the light of the world a city that is set on an hill cannot be hid neither do men light a candle and put it under a bushel but on a candlestick and it giveth light unto all that are in the house let your light so shine before men that they may see your good works and glorify your Father which is in heaven"
        ));
    }

    public Scripture GetRandomScripture()
    {
        int randomIndex = _random.Next(_scriptures.Count);
        return _scriptures[randomIndex];
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public int GetScriptureCount()
    {
        return _scriptures.Count;
    }
}
