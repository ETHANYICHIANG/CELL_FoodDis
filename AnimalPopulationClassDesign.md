# AnimalPopulation API requirements

## This documents what api from other class/system is needed to for the food distrubution system

```C#
class Specie
{

}


class AnimalPopulation
{
    Specie spec;

    
}
```

### AnimalPopulation.cs
* IsEdible(FoodSource) -> return true if is edible
* PopulationDominance() -> return total domiance of a population
* GetNeed(FoodSource.Type) -> return need value