﻿namespace WebappAPI;

public class Region : Entity
{
    // public Guid Id { get; set; }
    public string Name { get; private set; }
    public string Code { get; set; }
    public string? RegionImageUrl { get; set; }
    public Region()
    {
        Id = Guid.NewGuid();
    }

    public Region(Guid id)
    {
        Id = id;
    }


    public void ChangeInfo(string name, string? code = null)
    {
        Name = name;
        Code = code ?? Code;
    }
}


public abstract class Entity
{
    public Guid Id { get; set; }
}

public class Generic
{
    public void S()
    {

        Region a = new();
        a.ChangeInfo("s");
    }
}

/* Concepts:
 * 
 * 1)
    -   Polymorphism, 
    -   Inheritance,
    -   Abstract class

    2)
    -   Public, private,... keywords

    3)
    - Document Swagger api writing a comment that shows in the front-end
*/