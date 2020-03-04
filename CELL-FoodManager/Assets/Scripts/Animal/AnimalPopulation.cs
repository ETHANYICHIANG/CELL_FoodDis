﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Animal populations are holders of animals that also contain information about the animals.
abstract public class AnimalPopulation
{
    private float animalDominance { get; }

    private int populationSize { get; }
    public int PopulationSize { get; }

    private float populationDominace;
    public float PopulationDominace { get => animalDominance * populationSize; }

    public float GrowthTimer;

  


    /// <summary>
    /// Adds a new animal to the list of animals.
    /// </summary>
    /// <param name="animal"></param>
    public abstract void AddAnimalFromGameObject(GameObject animal);

    /// <summary>
    /// Removes a random animal from the list of animals and returns the animal. If there are no animals to remove, there is no effect and null is returned.
    /// </summary>
    public abstract Animal RemoveRandomAnimal();

    public bool IsEdible(FoodSource foodSource)
    {
        foreach (Need need in needs)
        {
            if (need.getFoodType() == foodSource.getFoodType())
            {
                return true;
            }
        }
        return false;
    }

    //public static AnimalPopulation BuildAnimalPopulation(string animalName)
    //{
    //    if (animalName == "Madle")
    //    {
    //        return new MadlePopulation();
    //    }
    //    else if (animalName == "Strot")
    //    {
    //        return new StrotPopulation();
    //    }
    //    else
    //    {
    //        throw new NotSupportedException(animalName + " species is not supported");
    //    }
    //}

    /// <summary>
    /// Returns the need of the NeedType provided or null if it doesn't exist.
    /// </summary>
    /// <param name="needType">The type of need to be searched for.</param>
    //public Need GetNeed(NeedType needType)
    //{
    //    foreach (Need need in Needs)
    //    {
    //        if (need.Type == needType)
    //        {
    //            return need;
    //        }
    //    }
    //    return null;
    //}

    ///// <summary>
    ///// Updates the value of a need to the provided value T returning true if successful and false if unsuccessful.
    ///// </summary>
    ///// <param name="needType">The type of the need to be searched for</param>
    ///// <param name="value">The new value the need will have</param>
    //public bool UpdateNeed<T>(NeedType needType, T value)
    //{
    //    Need<T> need = (Need<T>)GetNeed(needType);
    //    if (need != null)
    //    {
    //        need.CurrentValue = value;
    //        return true;
    //    }
    //    else return false;
    //}
}
